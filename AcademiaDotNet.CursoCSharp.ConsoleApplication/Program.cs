using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCSharp.ConsoleApplication
{
    class Program
    {
        enum DiasUteisDaSemana
        {
            Sunday,
            Monday, 
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        };
        static void Main(string[] args)
        {
            var diaDaSemana = DiasUteisDaSemana.Wednesday;

            if(diaDaSemana == DiasUteisDaSemana.Monday)
            {
                Console.WriteLine("Estamos na Segunda Feira");

            } else if(diaDaSemana == DiasUteisDaSemana.Tuesday)
            {
                Console.WriteLine("Estamos na Terça Feira");

            } else if(diaDaSemana == DiasUteisDaSemana.Wednesday)
            {
                Console.WriteLine("Estamos na Quarta Feira");

            } else if(diaDaSemana == DiasUteisDaSemana.Thursday)
            {
                Console.WriteLine("Estamos na Quinta Feira");

            }else if(diaDaSemana == DiasUteisDaSemana.Friday)
            {
                Console.WriteLine("Estamos na Sexta Feira");

            }else if(diaDaSemana == DiasUteisDaSemana.Saturday)
            {
                Console.WriteLine("Fim de semana - Sábado");

            }else if(diaDaSemana == DiasUteisDaSemana.Sunday)
            {
                Console.WriteLine("Fim de semana - Domingo");
            }
            
            Console.Read();
        }
    }
}
