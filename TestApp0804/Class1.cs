using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp0804
{
    class Dog
    {
        public Dog(string _type, int _nose, int _ear, int _bark)
        {
            type = _type;
            nose_level = _nose;
            ear_level = _ear;
            bark_level = _bark;
        }
        //public Dog()
        //{

        //}
        public static string type_ = "Default";
        public string type;
        public int nose_level, ear_level, bark_level;
        public void ShowDogInfo()
        {
            Console.WriteLine($"{type}, {nose_level}, {ear_level}, {bark_level}");
        }
    }
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Dog dog = new Dog();
    //        Dog poodle = new Dog("애완견", 1, 1, 1);
    //        Dog shepherd = new Dog("탐색견", 3, 3, 4);
    //        Console.WriteLine($"poodle {poodle.type}, {poodle.nose_level}, {poodle.ear_level}, {poodle.bark_level}");
    //        Console.WriteLine($"shepherd {shepherd.type}, {shepherd.nose_level}, {shepherd.ear_level}, {shepherd.bark_level}");
    //        Console.WriteLine(Dog.type_);
    //        poodle.ShowDogInfo();
    //        //dog.ShowDogInfo();
    //    }
    //}

}
