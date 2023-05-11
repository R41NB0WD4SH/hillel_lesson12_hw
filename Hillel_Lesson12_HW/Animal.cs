namespace Hillel_Lesson12_HW;


[Serializable]
public class Animal
{

    protected string _typeOfAnimal;
    protected string _name;
    protected int _age;

    internal string TypeOfAnimal
    {
        get
        {
            return _typeOfAnimal;
        }
        
    }
    internal string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    

    internal int Age
    {
        get { return _age; }
        set
        {
            if (value >= 0)
            {
                _age = value;
            }
            else
            {
                _age = 0;
            }
        }
    }


    public Animal(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public Animal()
    {
        
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("");
    }
    
}