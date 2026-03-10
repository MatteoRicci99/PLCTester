# PLC Tester - Lettore Dati Siemens S7

Applicazione Windows Forms in C# per testare la lettura di dati da PLC Siemens S7.

## Caratteristiche

- Supporto per PLC Siemens S7-200, S7-300, S7-400, S7-1200, S7-1500
- Lettura di diversi tipi di dati:
  - **Bool**: singoli bit
  - **Byte**: 8 bit
  - **Int**: 16 bit (Word)
  - **DInt**: 32 bit (Double Word)
  - **Real**: numeri in virgola mobile (32 bit)
  - **String**: stringhe di testo
- Interfaccia grafica semplice e intuitiva
- Configurazione manuale di IP, Rack e Slot

## Requisiti

- Windows 7 o superiore
- .NET Framework 4.8
- Visual Studio 2017 o superiore (per compilazione)

## Installazione

### Opzione 1: Compilazione con Visual Studio

1. Apri Visual Studio
2. Vai su `File` → `Open` → `Project/Solution`
3. Seleziona il file `PLCTester.csproj`
4. Clicca con il tasto destro sul progetto in Solution Explorer
5. Seleziona `Manage NuGet Packages`
6. Installa il pacchetto **S7netplus** (versione 0.20.0 o superiore)
7. Premi `F5` per compilare ed eseguire

### Opzione 2: Compilazione da riga di comando

```bash
# Ripristina i pacchetti NuGet
nuget restore PLCTester.csproj

# Compila il progetto
msbuild PLCTester.csproj /p:Configuration=Release

# L'eseguibile sarà in: bin\Release\PLCTester.exe
```

## Utilizzo

### 1. Connessione al PLC

1. Seleziona il **Tipo CPU** dal menu a tendina
2. Inserisci l'**Indirizzo IP** del PLC
3. Imposta i valori di **Rack** e **Slot**:
   - Per S7-300/400: solitamente Rack=0, Slot=2
   - Per S7-1200/1500: solitamente Rack=0, Slot=1
4. Clicca su **Connetti**

### 2. Lettura Dati

Una volta connesso:

1. Seleziona il **Tipo Dato** da leggere
2. Inserisci il numero del **DB** (Data Block)
3. Inserisci l'**Offset** (posizione nel DB)
4. Per le stringhe, inserisci anche la **Lunghezza**
5. Clicca su **Leggi**

Il risultato apparirà nella sezione "Risultato" in basso.

### Esempi di Lettura

#### Bool (Bit)
- DB Number: `1`
- Offset: `0`
- Legge: `DB1.DBX0.0`

#### Byte
- DB Number: `1`
- Offset: `2`
- Legge: `DB1.DBB2`

#### Int (16-bit Word)
- DB Number: `1`
- Offset: `4`
- Legge: `DB1.DBW4`

#### DInt (32-bit Double Word)
- DB Number: `1`
- Offset: `6`
- Legge: `DB1.DBD6`

#### Real (Float 32-bit)
- DB Number: `1`
- Offset: `10`
- Legge: `DB1.DBD10`

#### String
- DB Number: `1`
- Offset: `20`
- Lunghezza: `10`
- Legge: `DB1.DBB20` (stringa di max 10 caratteri)

## Formato Indirizzi S7

L'applicazione utilizza il formato standard Siemens:

- **DBX**: Data Block Byte.Bit (Bool)
- **DBB**: Data Block Byte (Byte)
- **DBW**: Data Block Word (Int - 2 byte)
- **DBD**: Data Block Double Word (DInt/Real - 4 byte)

## Note Importanti

1. **Offset**: Gli offset partono da 0
2. **Bool**: Il formato è `DBX[offset].[bit]` - attualmente legge sempre il bit 0
3. **String S7**: Le stringhe Siemens hanno 2 byte di header (max length e current length)
4. **Allineamento**: Rispettare l'allineamento dei dati nel PLC:
   - Bool: allineamento a bit
   - Byte: allineamento a byte
   - Word: allineamento a 2 byte (offset pari)
   - DWord: allineamento a 2 byte (offset pari)

## Espansione Futura

Il progetto è strutturato per essere facilmente espandibile:

- Aggiungere supporto per altri protocolli (Modbus, EtherNet/IP, ecc.)
- Implementare scrittura dati
- Aggiungere monitoraggio continuo
- Salvare configurazioni di test
- Log delle letture su file

## Libreria Utilizzata

Questo progetto utilizza **S7.Net Plus** (https://github.com/S7NetPlus/s7netplus), una libreria .NET open source per comunicare con PLC Siemens S7.

## Troubleshooting

### Errore di connessione

- Verificare che il PLC sia raggiungibile (ping all'IP)
- Controllare Rack e Slot corretti
- Verificare che la comunicazione S7 sia abilitata nel PLC
- Controllare il firewall Windows

### Errore di lettura

- Verificare che il DB esista nel PLC
- Controllare che l'offset sia valido per il DB
- Verificare l'allineamento dei dati (Word su offset pari)
- Assicurarsi che il DB sia accessibile (non ottimizzato)

## Licenza

Progetto di esempio per uso interno e testing.
