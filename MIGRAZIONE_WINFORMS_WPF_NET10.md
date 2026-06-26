# Migrazione incrementale: WinForms -> WPF su .NET 10

Questa è la strada consigliata per migrare senza bloccare il prodotto.

## Cosa è già stato fatto in questo step
- Creato un nuovo progetto `src/TimeOutino.Core` target `net10.0`.
- Estratto un `CountdownEngine` indipendente dalla UI.
- Definiti contratti base (`NotificationMode`, `RestartPolicy`, `NotificationRequest`) per disaccoppiare UI e logica.

## Prossimi step (ordine consigliato)
1. **Integrare il Core nel WinForms attuale**
   - sostituire gradualmente `CustomTimer` con `CountdownEngine`.
   - mantenere la UI attuale invariata, cambiare solo orchestrazione interna.

2. **Creare progetto WPF**
   - nuovo `TimeOutino.Wpf` su `net10.0-windows`.
   - MVVM minimale: MainViewModel con comandi Start/Stop/Snooze.

3. **Portare notifiche dietro interfacce**
   - `INotificationService` in Core.
   - implementazioni concrete in Infrastructure (audio locale, speech, beep di sistema).

4. **Deprecare WinForms**
   - una volta allineate feature e test smoke, rimuovere UI legacy.

## Perché così
- riduci rischio di regressioni;
- rilasci value in piccoli blocchi;
- prepari una base pulita per WPF senza riscrittura "big bang".
