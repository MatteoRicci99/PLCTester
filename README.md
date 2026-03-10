# PLC Tester

PLC Tester is a lightweight Windows Forms application designed to test communication with Siemens S7 PLCs.

The tool allows developers, automation engineers, and technicians to quickly verify connectivity and read values from PLC Data Blocks during development, debugging, or commissioning phases.

The application uses the **S7.Net** library to communicate with Siemens PLCs over Ethernet.

---

## Features

* Connect to Siemens S7 PLCs via IP address
* Support for multiple CPU types:

  * S7-200
  * S7-300
  * S7-400
  * S7-1200
  * S7-1500
* Read different PLC data types from Data Blocks:

  * Bool
  * Byte
  * Int (16-bit)
  * DInt (32-bit)
  * Real (32-bit floating point)
  * String
* Simple and intuitive graphical interface
* Connection status indicator
* Quick diagnostic tool for PLC communication testing

---

## Technologies Used

* C#
* Windows Forms
* .NET
* S7.Net library

---

## How It Works

1. Select the PLC CPU type.
2. Enter the PLC IP address.
3. Configure **Rack** and **Slot** values.
4. Click **Connect** to establish the connection.
5. Enter:

   * Data Block number
   * Offset
   * Data type
6. Click **Read** to retrieve the value from the PLC.

The result will be displayed in the result window.

---

## Example Addressing

Reading a boolean value:

```
DB1.DBX0.0
```

Reading an integer:

```
DB1.DBW2
```

Reading a double integer:

```
DB1.DBD4
```

---

## String Reading

For strings, the application reads the standard **Siemens S7 string structure**:

```
Byte 0 → Maximum string length
Byte 1 → Current string length
Byte 2..N → Characters
```

The tool automatically extracts and displays the string value.

---

## Requirements

* Windows OS
* .NET Runtime (if not published as self-contained)
* Network access to the PLC

---

## Disclaimer

This project was created as a **learning and testing tool** for PLC communication.
It is not intended to replace professional industrial diagnostic software.

---

## License

This project is open source and available for learning and experimentation.
