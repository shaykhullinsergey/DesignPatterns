using System;

namespace SerializationPrototype
{
  [Serializable]
  public class Address
  {
    public string StreetName;
    public int HouseNumber;

    public Address()
    {
    }

    public Address(string streetName, int houseNumber)
    {
      StreetName = streetName;
      HouseNumber = houseNumber;
    }

    public override string ToString()
    {
      return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
    }
  }
}
