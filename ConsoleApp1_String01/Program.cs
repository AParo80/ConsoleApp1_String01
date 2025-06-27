namespace ConsoleApp1_String01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello, World!";
            Console.WriteLine($"Original-Text: {hello}\r\n");




            Console.WriteLine("Ausgabe Array.Reverse: " + StringReverse.ReverseStringArrayReverse(hello));
            Console.WriteLine("Ausgabe ForLoop: " + StringReverse.ReverseStringForLoop(hello));

            // Vokale Zählen
            Console.WriteLine("Ausgabe VokaleZählen: " );
            //VokaleZaehlen.VokaleZaehlen01(hello);

            VokaleZaehlen.VokaleZaehlenDictionary(hello);
        }
    }
}
