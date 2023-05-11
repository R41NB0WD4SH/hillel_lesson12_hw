using System.Threading.Channels;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Hillel_Lesson12_HW;


[Serializable]
public class Dog : Aerobic
{

    
    public Dog(string name, int age)
    {
        _typeOfAnimal = "Dog";
        
    }

    public Dog()
    {
        _typeOfAnimal = "Dog";
    }

    public override void MakeSound()
    {
        Console.WriteLine("Bark!");
    }

    public override void ShowOxygenAlert()
    {
        Console.WriteLine("I need Oxygen!");
    }
}