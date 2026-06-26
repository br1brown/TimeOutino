using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TimeOutino
{
    public partial class TimeOutino : Form
    {
        // Colori coerenti con la palette dell'interfaccia.
        private static readonly Color AnelloAccento = Color.FromArgb(0, 137, 123);
        private static readonly Color AnelloTraccia = Color.FromArgb(40, 0, 0, 0);
        private static readonly Color PillBackground = Color.FromArgb(190, 38, 50, 56);

        /// <summary>
        /// Disegna sopra l'immagine di stato del bottone, mentre il timer scorre,
        /// un anello di progresso che si svuota e il tempo rimanente in grande.
        /// </summary>
        private void OnBtnConfigPaint(object sender, PaintEventArgs e)
        {
            if (customtimer == null || !customtimer.Running)
                return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle area = btnconfig.ClientRectangle;
            double percentuale = Math.Max(0, Math.Min(100, customtimer.Percentage));

            DisegnaAnello(g, area, percentuale);
            DisegnaTempo(g, area, customtimer.ToString());
        }

        private static void DisegnaAnello(Graphics g, Rectangle area, double percentuale)
        {
            float penW = Math.Max(6f, Math.Min(area.Width, area.Height) * 0.04f);
            int diam = (int)(Math.Min(area.Width, area.Height) - penW - 6);
            if (diam <= 20)
                return;

            var ring = new RectangleF(
                area.X + (area.Width - diam) / 2f,
                area.Y + (area.Height - diam) / 2f,
                diam, diam);

            float sweep = 360f * (float)percentuale / 100f;

            using (var track = new Pen(AnelloTraccia, penW) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            using (var arc = new Pen(AnelloAccento, penW) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            {
                g.DrawArc(track, ring, 0, 360);
                if (sweep > 0)
                    g.DrawArc(arc, ring, -90, sweep);
            }
        }

        private static void DisegnaTempo(Graphics g, Rectangle area, string tempo)
        {
            const float padX = 16f, padY = 6f, margin = 12f;

            using (var font = new Font("Segoe UI", 20F, FontStyle.Bold))
            {
                SizeF ts = g.MeasureString(tempo, font);
                var pill = new RectangleF(
                    area.X + (area.Width - ts.Width) / 2f - padX,
                    area.Bottom - ts.Height - padY * 2 - margin,
                    ts.Width + padX * 2,
                    ts.Height + padY * 2);

                using (var back = new SolidBrush(PillBackground))
                using (var path = RoundedRect(pill, pill.Height / 2f))
                    g.FillPath(back, path);

                using (var text = new SolidBrush(Color.White))
                using (var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                })
                    g.DrawString(tempo, font, text, pill, sf);
            }
        }

        /// <summary>
        /// Attiva il double buffering su un controllo tramite la proprietà protetta
        /// <c>DoubleBuffered</c>, per evitare lo sfarfallio quando il bottone viene
        /// ridisegnato a ogni secondo.
        /// </summary>
        private static void AbilitaDoubleBuffering(Control control)
        {
            var prop = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            prop?.SetValue(control, true, null);
        }

        private static GraphicsPath RoundedRect(RectangleF r, float radius)
        {
            float d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
