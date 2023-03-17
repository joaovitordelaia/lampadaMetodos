using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casaTeste
{
    class Program
    {
        static void Main(string[] args)
        {

            Lampada lampi = new Lampada();

            //Console.WriteLine("A lampada está: " + lampi.LerStatus());
            

            Console.Write("Altere a potencia da Lampada: ");
            lampi.AlterarPotencia(Console.ReadLine());
            Console.Write("Altere a Voltagem da Lampada: ");
            lampi.AlterarVoltagem(Console.ReadLine());
            Console.WriteLine("A Voltagem é: " + lampi.MostrarVoltagem());
            Console.WriteLine("A potencia é: " + lampi.MostrarPotencia());
            lampi.Apagar();
            lampi.Ascender();

            Console.WriteLine(lampi.LerStatus());

            Console.ReadKey();

            
            


        }
    }
}
