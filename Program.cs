using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOП6._2
{
    class Stroka
    {
        private static string str;

        public string Str
        {
            get { return str; }
            set
            {
                if (value.Length > 10)
                    str = "Строка слишком длинная";
                else if (value.Length == 0)
                    str = "Пусто";
                else str = value;
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Stroka s = new Stroka();
            Console.WriteLine("Введите строку");
            s.Str = Console.ReadLine();
            Console.WriteLine(s.Str);
            Console.ReadKey();
        }
        
    }
}
