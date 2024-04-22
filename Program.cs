namespace Smartphone
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI123", 16);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Play Store");

            Iphone iphone = new Iphone("987654321", "Iphone 15 pro max", "IMEI321", 4);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Apple Store");
        }
    }
}