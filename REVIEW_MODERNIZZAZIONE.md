# TimeOutino — Lista diretta: cosa è vecchio e come aggiornarlo (WinForms ➜ WPF su .NET 10)

Di seguito una lista pratica, senza teoria inutile: **problema attuale**, **perché è vecchio/rischioso**, **come migliorarlo**.

## 1) Stack attuale: .NET Framework 4.8 (legacy)
- **Vecchio oggi:** progetto non SDK e target `.NET Framework 4.8`.
- **Rischio:** toolchain datata, manutenzione più costosa, ecosistema pacchetti meno moderno.
- **Miglioramento:** migrare a **SDK-style** e target `net10.0-windows` (o `net8.0-windows` se volete massima stabilità immediata).

## 2) UI WinForms con logica business nel Form
- **Vecchio oggi:** logica di timer/notifiche dentro il code-behind (`TimeOutino.cs`/`TimeOutinoUtils.cs`).
- **Rischio:** difficile testare, difficile evolvere UI.
- **Miglioramento:** passare a **WPF + MVVM**:
  - `TimeOutino.Wpf` (UI)
  - `TimeOutino.Core` (dominio/use-case)
  - `TimeOutino.Infrastructure` (audio, storage, logging)

## 3) Dipendenza COM `WMPLib`
- **Vecchio oggi:** playback audio via Windows Media Player COM.
- **Rischio:** fragilità di deployment, comportamento non uniforme su ambienti enterprise.
- **Miglioramento:** usare libreria managed (es. `NAudio`) o API moderne Windows.

## 4) Mapping enum con stringhe UI
- **Vecchio oggi:** confronto stringhe (`SelectedValue.ToString()` vs `Description`).
- **Rischio:** bug silenziosi con refactor, typo e localizzazione.
- **Miglioramento:** binding typed (enum come valore reale), converter/display separati.

## 5) Error handling troppo generico
- **Vecchio oggi:** `catch (Exception)` con messaggio generico.
- **Rischio:** debug difficile, scarsa diagnosi in produzione.
- **Miglioramento:** eccezioni specifiche + logging strutturato (Serilog/NLog) + messaggi utente puliti.

## 6) Path hardcoded di sistema
- **Vecchio oggi:** `C:\Windows\Media\Alarm01.wav` hardcoded.
- **Rischio:** file non presente su alcune installazioni, comportamento fragile.
- **Miglioramento:** fallback multipli + risorse app locali + validazione percorso.

## 7) Gestione risorse parziale
- **Vecchio oggi:** oggetti audio/speech non sempre dismessi esplicitamente.
- **Rischio:** leak, handle aperti, stop/play non affidabile dopo molte sessioni.
- **Miglioramento:** implementare `IDisposable` nei componenti runtime e cleanup in shutdown.

## 8) Nessuna persistenza robusta impostazioni
- **Vecchio oggi:** parametri runtime senza storage strutturato.
- **Rischio:** UX povera (utente reimposta tutto).
- **Miglioramento:** settings JSON o `ApplicationData`, con schema versione.

## 9) Copertura test quasi nulla
- **Vecchio oggi:** nessuna suite unit test sul core.
- **Rischio:** regressioni frequenti durante refactor/migrazione.
- **Miglioramento:** test su:
  - countdown engine
  - policy restart/snooze
  - selezione notifica e fallback audio

## 10) Distribuzione/aggiornamento non moderni
- **Vecchio oggi:** packaging non standardizzato moderno.
- **Rischio:** update manuali, rilascio lento.
- **Miglioramento:** MSIX/WiX + pipeline CI/CD + versionamento semantico.

---

## Piano sintetico per migrare da WinForms a WPF su .NET 10

### Fase A — Preparazione (1-2 settimane)
1. Convertire il `.csproj` in SDK-style.
2. Estrarre logica non UI in `TimeOutino.Core`.
3. Introdurre interfacce (`ITimerService`, `INotificationService`, `ISettingsStore`).

### Fase B — Porting UI (2-4 settimane)
4. Nuovo progetto `TimeOutino.Wpf` target `net10.0-windows`.
5. Implementare schermata principale in XAML (timer, stato, pulsanti start/stop/snooze).
6. Implementare ViewModel con `INotifyPropertyChanged` e command.

### Fase C — Hardening (2 settimane)
7. Sostituire COM audio.
8. Logging + error reporting locale.
9. Unit test sul core (>60% sul dominio).

### Fase D — Release (1 settimana)
10. Installer + firma + pipeline build/test/release.
11. Rollout progressivo (beta interna ➜ produzione).

---

## Scelta consigliata (realistica)
- Se volete velocità ma rischio basso: **prima `net8.0-windows` + refactor core**, poi salto a `net10.0-windows`.
- Se volete andare subito “future-facing”: **WPF + `net10.0-windows`** direttamente, ma con più test e beta interna obbligatoria.

