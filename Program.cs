using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {   
                for(int i=0; i < 10; i++) 
                {
                    if((i % 2) == 0)
                     {
                        break;
                    }
                    Console.WriteLine(i);
                }
            //Laços condicionais => execução mediante determinada condição/situação satisfeita
            int hora = 18;
            if (hora <= 15)            
                Console.WriteLine("São menos que 15h00");            
            else if (hora <= 17)
                Console.WriteLine("A hora é menor ou igual a 17!");
            else
            {   
                if(hora == 18)
                    Console.WriteLine("São 18!");
                else
                    Console.WriteLine("Já passou das 18h!");
            }
            // switch.. case
            
            switch(hora )
            {
                case 15:
                    Console.WriteLine("São 15h");
                    break;
                case 18:
                    Console.WriteLine("São 18h");
                    break;
            
            }
                

            FirstSemester month = FirstSemester.May;
            switch(month)
            {
                case FirstSemester.January:
                    Console.WriteLine("January");
                    break;
                case FirstSemester.February:
                    Console.WriteLine("February");
                    break;
                case FirstSemester.March:
                    Console.WriteLine("March");
                    break;
                case FirstSemester.April:
                    Console.WriteLine("April");
                    break;
                case FirstSemester.May:
                    Console.WriteLine("May");
                    break;
                case FirstSemester.June:
                    Console.WriteLine("June");
                    break;
          
                  






            
            }

        
        
        
        }
    }
    public enum FirstSemester
    {
        January, February, March, April, May, June
    }
}