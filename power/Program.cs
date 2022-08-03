using System;

namespace power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(print("filan","filankesov","filani"));
            //Console.WriteLine(power(5));
        }
        //static int power(int num1) 
        //{
        //    return num1*num1;
        //}
        static string print(string name)
        {
            return name;

        }
        static string print(string name, string surname)
        {
            return name +" " + surname;
        }
        static string print(string name, string surname, string fname) 
        {
            return name + " " + fname[0] +"."+ surname;
        }
    }
}
