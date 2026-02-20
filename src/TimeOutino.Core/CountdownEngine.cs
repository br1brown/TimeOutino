namespace TimeOutino.Core;

public sealed class CountdownEngine
{
    private TimeSpan _remaining = TimeSpan.Zero;
    private TimeSpan _starting = TimeSpan.Zero;

    public TimeSpan Remaining => _remaining;
    public TimeSpan Starting => _starting;

    public bool IsRunning { get; private set; }

    public double Percentage
    {
        get
        {
            if (_starting.TotalSeconds <= 0)
                return 0;

            return (_remaining.TotalSeconds / _starting.TotalSeconds) * 100d;
        }
    }

    public void Start(TimeSpan duration)
    {
        if (duration <= TimeSpan.Zero)
            throw new ArgumentOutOfRangeException(nameof(duration), "Duration must be greater than zero.");

        _starting = duration;
        _remaining = duration;
        IsRunning = true;
    }

    /// <summary>
    /// Decrease remaining time by one tick and return true when finished.
    /// </summary>
    public bool Tick(TimeSpan step)
    {
        if (!IsRunning)
            return false;

        if (step <= TimeSpan.Zero)
            throw new ArgumentOutOfRangeException(nameof(step), "Step must be greater than zero.");

        _remaining = _remaining.Subtract(step);
        if (_remaining <= TimeSpan.Zero)
        {
            _remaining = TimeSpan.Zero;
            IsRunning = false;
            return true;
        }

        return false;
    }

    public void Stop()
    {
        IsRunning = false;
    }
}
