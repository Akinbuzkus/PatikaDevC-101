using System;

namespace Degisken{
    class Program{
        static void Main(String[] args){
            Console.WriteLine("Hello, World!");

            String name = "Akin";
            String Surname = "Buzkus";
            int age=27;
            String day=DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(name+" "+Surname+" "+age+" "+day);

            int number1=5;
            int number2=7;

            int Multiple=number1*number2;
            Console.WriteLine(Multiple);

            String newNumber="20";
            int num=20;
            int deger=num + Convert.ToInt32(newNumber);
            Console.WriteLine(deger);

            bool bol=10<2;
            Console.WriteLine(bol);







        }
    }
}
