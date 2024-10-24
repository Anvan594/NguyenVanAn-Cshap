using DongVat.AnCo;
using static Ex01.AnThit;

namespace DongVat
{
    class Program
    {
        static void Main(string[] args)
        {
            Bo bo = new Bo(1, "Bo", 500);
            Trau trau = new(2, "Trau", 600);
            De de = new(3, "De", 60);

            CaSau caSau = new(4, "CaSau", 100);
            Ho ho = new(5, "Ho", 60);
            SuTu suTu = new(6, "SuTu", 45);
            Console.WriteLine(bo.GetInfo());
            Console.WriteLine(trau.GetInfo());
            Console.WriteLine(de.GetInfo());
            Console.WriteLine(ho.GetInfo());
            Console.WriteLine(suTu.GetInfo());
            Console.WriteLine(caSau.GetInfo());
        }
        
    }
}
