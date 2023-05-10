using System.Threading.Channels;

namespace Hillel_Lesson12_HW;

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