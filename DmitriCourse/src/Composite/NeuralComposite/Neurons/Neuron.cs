using System.Collections;
using System.Collections.Generic;

namespace NeuralComposite
{
  public class Neuron : IEnumerable<Neuron>
  {
    public float Value;
    public List<Neuron> In, Out;

    public IEnumerator<Neuron> GetEnumerator()
    {
      yield return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}
