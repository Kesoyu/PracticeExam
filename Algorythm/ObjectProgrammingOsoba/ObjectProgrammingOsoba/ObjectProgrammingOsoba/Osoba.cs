using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProgrammingOsoba
{
    internal class Osoba
    {
        private int id { get; set; }
        private string name { get; set; }
        public static int counter = 0;
        public Osoba(int id, string name)
        {
            this.id = id;
            this.name = name;
            counter++;
        }
        public Osoba()
        {
            id = 0;
            name = string.Empty;
            counter++;
        }
        public Osoba(Osoba copy)
        {
            id = copy.id;
            name = copy.name;
            counter++;
        }

        public void Hi(string name)
        {
            Console.WriteLine("Cześć " + name + ", mam na imię " + this.name);
        }

        public void Hi()
        {
            Console.WriteLine("Brak Danych");
        }

    }
}
