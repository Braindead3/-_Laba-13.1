using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_KpIEp_Laba_13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pchel pchel = new Pchel(17, "Влад", "male");
            }
            catch (PchelException ex)
            {

                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
