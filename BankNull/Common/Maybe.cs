using System.Collections;
using System.Collections.Generic;

namespace BankNull.Common
{
    public class Maybe<T> : IEnumerable<T>
    {
        private readonly IEnumerable<T> _values;
        
        public Maybe(T value)
        {
            _values = new [] {value};
        }

        public Maybe()
        {
            _values = new T[0];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}