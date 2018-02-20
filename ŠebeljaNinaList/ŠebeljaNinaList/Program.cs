using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŠebeljaNinaList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            while(true)
            {
                Console.Write("Upisite ime: (ako želite prekinuti upišite 'ne' . )");
                string ime = Console.ReadLine();
                if(ime == "ne")
                {
                    break;
                }
                lista.Add(ime);
            }
            lista.Sort();
            lista.Reverse();

            Console.WriteLine("Unesena imena obrnutim redoslijedom");
            lista.Reverse();
            foreach (string ime in lista)
            {
                Console.Write("{0}, \n", ime);

            }
            for(int i=0;i<lista.Count;i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadKey();
        }
        
    }
}
