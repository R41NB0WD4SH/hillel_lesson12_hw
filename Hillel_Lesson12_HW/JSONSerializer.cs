using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Hillel_Lesson12_HW;

public class JSONSerializer
{
    public string Serialize(Dog dog)
    {
        var json = JsonConvert.SerializeObject(dog);
        Console.WriteLine(json);

        return json;
    }

    public Dog Deserialize(string json)
    {
        var deserializedDog = JsonConvert.DeserializeObject<Dog>(json);

        return deserializedDog;
    }
}