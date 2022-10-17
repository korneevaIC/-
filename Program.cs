using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Корнеева3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            System.Console.WriteLine("Введите Ваше имя: ");
            name = System.Console.ReadLine();
            string surname;
            System.Console.WriteLine("Введите Вашу фамилию: ");
            surname = System.Console.ReadLine();
            string animal ;
            System.Console.WriteLine("Введите Ваше любимое животное: ");
            animal = System.Console.ReadLine();
            string zodiac;
            System.Console.WriteLine("Введите Ваш знак зодиака: ");
            zodiac = System.Console.ReadLine();
            System.Console.WriteLine("Индивидуальный гороскоп для пользователя - " + name  + surname);
            System.Console.WriteLine("Кем вы были в прошлой жизни - " + animal);   
            System.Console.WriteLine("Ваш знак зодиака - "  + zodiac);
            System.Console.WriteLine("поэтому вы - тонко чувствующая натура");

        }
    }
}
