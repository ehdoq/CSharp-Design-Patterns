using _07_Composite.Interfaces;
using System.Collections;

namespace _07_Composite.Classes
{
    public class Worker : IPerson, IEnumerable<IPerson>
    {
        public string? Name { get; set; }

        readonly List<IPerson>? _subWorker = new();

        public IPerson GetSubWorker(int index)
        {
            return _subWorker[index];
        }

        public void AddSubWorker(IPerson person)
        {
            _subWorker.Add(person);
        }

        public void AltCalisanSil(IPerson person)
        {
            _subWorker.Remove(person);
        }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subWorker in _subWorker)
            {
                yield return subWorker;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}