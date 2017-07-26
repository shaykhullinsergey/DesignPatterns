using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializationPrototype
{
  public static class ExtentionMethods
  {
    public static T DeepCopy<T>(this T self)
    {
      using (var stream = new MemoryStream())
      {
        var formatter = new BinaryFormatter();
        formatter.Serialize(stream, self);
        stream.Seek(0, SeekOrigin.Begin);

        return (T)formatter.Deserialize(stream); 
      }
    }

    public static T DeepCopyXml<T>(this T self)
    {
      using (var stream = new MemoryStream())
      {
        var x = new XmlSerializer(typeof(T));
        x.Serialize(stream, self);
        stream.Position = 0;

        return (T)x.Deserialize(stream);
      }
    }
  }
}
