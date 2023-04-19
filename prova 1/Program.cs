using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ex 1

            //int num, valor;

            //Console.WriteLine("insira um valor");

            //num = int.Parse(Console.ReadLine());

            //if (num >= 0)
            //{
            //    valor = num;
            //    valor=int.Parse(Console.ReadLine());
            //}
            //else
            //{
            //    valor = -num;
            //}

            //Console.WriteLine("o valor absoluto é de"+num+valor);

            //ex 2

            //double num;

            //Console.WriteLine("insira o valor");
            //num = int.Parse(Console.ReadLine());

            //if (num%3 == 0 && num% 5 == 0)
            //{

            //    Console.WriteLine("o numero é divisivel por 3 e 5");

            //}

            //else if (num%4==0  && num%7==0)
            //{
            //    Console.WriteLine("o numero é divisivel por 4 e 7");
            //}

            //else if (num % 3 == 0)
            //{
            //    Console.WriteLine("o numero é divisível por 3");
            //}
            //else if (num % 5 == 0)
            //{
            //    Console.WriteLine("o numero é divisível por 5");
            //}
            //else if (num % 4 == 0)
            //{
            //    Console.WriteLine("o numero é divisível por 4");
            //}

            //else if (num % 7 == 0)
            //{
            //    Console.WriteLine("o numero é divisivel por 7");
            //}



            //ex 3

            int a, b, c;

            Console.WriteLine("insira o primeiro valor");
            a=int.Parse(Console.ReadLine());

            Console.WriteLine("insira o segundo valor");
            b=int.Parse(Console.ReadLine());

            Console.WriteLine("insira o terceiro valor");
            c=int.Parse(Console.ReadLine());

            if (a>b && b>c)
            {
                Console.WriteLine(a);
            }

            else if(b>c && b > a)
            {
                Console.WriteLine(b);
            }
            else if(c>a && c > b)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();


        }
    }
}





        


        
    

