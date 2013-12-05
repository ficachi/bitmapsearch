using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitmapsearch
{
    class Program
    {
        
             static void Main(string[] args)
        {
            Console.WriteLine("Numero de Bits total: ");
            int bits = int.Parse(Console.ReadLine());
            List<Byte> ListaBits = new List<Byte>();

            for (int i = 0; i < bits; i++)
            {
                Console.WriteLine("Que dato contendra el espacio: {0}", i + 1);
                Byte byteo = byte.Parse(Console.ReadLine());
                ListaBits.Add(byteo);
            }

            Console.WriteLine("Dato que deseas encontrar");
            Byte b = byte.Parse(Console.ReadLine());
            Byte[] by = ListaBits.ToArray();
            int contador = 1;
            foreach (var v in by)
            {
                if (v == b)
                {
                    Console.WriteLine("Esta en el espacio : {0}", contador);
                }
                contador++;
            }
            Console.ReadLine();
        
        }
    }
}
