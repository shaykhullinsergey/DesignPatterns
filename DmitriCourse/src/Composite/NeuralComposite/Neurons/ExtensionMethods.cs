using System.Collections.Generic;

namespace NeuralComposite
{
  public static class ExtensionMethods
  {
    public static void ConnectTo(this IEnumerable<Neuron> source, IEnumerable<Neuron> other)
    {
      if(ReferenceEquals(source, other))
      {
        return;
      }

      foreach (var from in source)
      {
        foreach (var to in other)
        {
          from.Out.Add(to);
          to.In.Add(from);
        }
      }
    }
  }
}
