using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Hillel_Lesson12_HW;

public class XMLSerializer
{
    private XmlSerializer _xmlSerializer = new XmlSerializer(typeof(Dog));


    public string Serialize(Dog dog)
    {
        StringWriter writer = new StringWriter();
        
        _xmlSerializer.Serialize(writer, dog);

        string xmlString = writer.ToString();

        Console.WriteLine(xmlString);

        return xmlString;
    }

    public Dog Deserialize(string data)
    {
        StringReader reader = new StringReader(data);

        Dog deserializedDog = (Dog)_xmlSerializer.Deserialize(reader);

        return deserializedDog;
    }
}