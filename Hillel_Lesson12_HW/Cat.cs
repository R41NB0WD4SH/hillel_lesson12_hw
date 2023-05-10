namespace Hillel_Lesson12_HW;

public class Cat : Aerobic
{
    
   
    public Cat(string name, int age)
    {
        _typeOfAnimal = "Cat";
    }

    public Cat()
    {
        _typeOfAnimal = "Cat";
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
    
    public override void ShowOxygenAlert()
    {
        Console.WriteLine("I need Oxygen!");
    }
}