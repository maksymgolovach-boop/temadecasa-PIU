namespace Calculsalariu
{
    class Program
    {
        static void Main(string[] args)
        {
            int ore_lucrate = 0;
            double tarif_ora;
            double salariu;

            Console.Write("Introduceti tariful pe ora [RON]: ");
            tarif_ora = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti numarul de ore lucrate: ");
            ore_lucrate = Convert.ToInt32(Console.ReadLine());

            salariu = tarif_ora * (double)ore_lucrate;

            if (salariu > 3000)
            {
                Console.WriteLine("Salariu mare");
            }
            else
            {
                Console.WriteLine("Ati lucrat prea putine ore pentru a avea un salariu mare!.");
            }
        }
    }
}