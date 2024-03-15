namespace oszthatoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérlek adj meg egy számot: ");
             double szam = double.Parse(Console.ReadLine());

            if (szam % 3 == 0 & szam % 4 == 0 & szam % 9 == 0){
                Console.WriteLine("A szám osztható 3-mal,4-gyel és 9-cel");
            }
            else if (szam % 3 == 0 & szam % 4 == 0)
            {
                Console.WriteLine("A szám osztható 3-mal és 4-gyel");
            }
            else if (szam % 3 == 0)
            {
                Console.WriteLine("A szám osztható 3-mal");
            }
            else if (szam % 4 == 0 & szam % 9 == 0)
            {
                Console.WriteLine("A szám osztható 4-gyel és 9-cel");
            }
            else if (szam % 9 == 0 & szam % 3 == 0)
            {
                Console.WriteLine("A szám osztható 3-mal és 9-cel");
            }
            else if (szam % 4 == 0)
            {
                Console.WriteLine("A szám osztható 4-gyel");
            }
            else if (szam % 9 == 0)
            {
                Console.WriteLine("A szám osztható 9-cel");
            }
            else
            {
                Console.WriteLine("A szám nem osztható 3-mal, 4-gyel sem 9-cel");
            }
        }
    }
}
