using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Hillel_Lesson12_HW
{
    class Programm
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Create a dog and a cat");
            Console.WriteLine();

            Dog dog = CreateDog();
            Cat cat = CreateCat();
            
            
            ShowAnimal(dog);
            dog.MakeSound();
            dog.ShowOxygenAlert();

            Console.WriteLine();
            
            ShowAnimal(cat);
            cat.MakeSound();
            cat.ShowOxygenAlert();


            XMLSerializer xmlSerializer = new XMLSerializer();
            var data = xmlSerializer.Serialize(dog);
            var deserialized = xmlSerializer.Deserialize(data);


            var jsonSerializer = new JSONSerializer();
            var json = jsonSerializer.Serialize(dog);
            var deserializedDog = jsonSerializer.Deserialize(json);
            
            
            Console.ReadKey();


        }

        public static void ShowAnimal(Animal animal)
        {
            Console.WriteLine("It's a {0}", animal.TypeOfAnimal);
            Console.WriteLine("Name: {0}", animal.Name);
            Console.WriteLine("Age: {0}", animal.Age);
        }

        public static int ParseNumber(string numberStr)
        {
            int number;
            Int32.TryParse(numberStr, out number);

            return number;
        }

        public static Dog CreateDog()
        {

            Dog dog = new Dog();
            
            
            Console.WriteLine("Enter the dog's name:");
            dog.Name = Console.ReadLine();
            
            Console.WriteLine("Enter the age:");
            dog.Age = ParseNumber(Console.ReadLine());
            
            return dog;
        }
        
        public static Cat CreateCat()
        {
            Cat cat = new Cat();
            
            Console.WriteLine("Enter the cat's name:");
            cat.Name = Console.ReadLine();

            Console.WriteLine("Enter the age:");
            cat.Age = ParseNumber(Console.ReadLine());

            Console.WriteLine("OxygenLevel:");

            return cat;
        }

    }
}
