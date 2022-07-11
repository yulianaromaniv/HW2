using System;

namespace HW2task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string age_str;
            string name_str;
            string mark_str;
            int age;
            Console.WriteLine("input age:");
            age_str = Console.ReadLine();
            Console.WriteLine("input name:");
            name_str = Console.ReadLine();
            Console.WriteLine("input mark:"); 
            mark_str = Console.ReadLine();
            age = Convert.ToInt32(age_str);
            Dog dog;
            dog.name = name_str;
            dog.age = age;
            dog.mark = mark_str;
            Console.WriteLine(dog);
        }
    }
    struct Dog
    {
        public int age;
        public string name;
        public string mark;
        public override string ToString()
        {
            return string.Format("My dog name:{name}, my dog mark:(mark}, my dog age:{age}");
        }
    }
}
