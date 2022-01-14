using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example.methods
{
    public class Go
    {
        public void HereketeBasla(decimal benzin)
        {
            Console.WriteLine("Nece km yol gedeceksiniz?");

            string yol = Console.ReadLine();

            decimal netice = (Convert.ToDecimal(yol) * 10) / 100;

            decimal qalanBenzin = benzin - netice;

            if (qalanBenzin < 0)
            {
                Console.WriteLine( " Kiyafet qeder benzin yoxdur. " );
            }

            else
            {
                Console.WriteLine("Sizin " + " " + qalanBenzin + " litr benzininiz qaldi");

            }



        }

        public void Benzindoldur(decimal benzin)
        {
            Console.WriteLine("Nece litr benzin doldurmaq isteyirsiniz?");
            string Benzin = Console.ReadLine();


            Console.WriteLine(Benzindoldur + " litr benzin doldurdunuz");

        }
    }
}
