using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BufferEnumerable
{
   public class Iterator<T>:IEnumerable<T>
    {
        ListNode<T> buffer;
        public IEnumerator<T> GetEnumerator()
        {
            if(this.enumerable?.GetType() == this.buffer?.GetType())
            {
                return enumerable.GetEnumerator();
            }
            return Get();
        }
        private IEnumerator<T> Get()
        {
            bool check = false;
            var enumerator = this.enumerable.GetEnumerator();
            try
            {
                while (check = enumerator.MoveNext())
                {
                    var temp = enumerator.Current;
                    buffer.Add(temp);
                    yield return temp;
                }
            }
            finally
            {
                ((IDisposable)enumerator).Dispose();
                if (check==false)
                {
                    this.enumerable = this.buffer;
                }
                else
                {
                    this.buffer = new ListNode<T>();
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();
        }

        IEnumerable<T> enumerable;
        public Iterator(IEnumerable<T> enumerable)
        {
            this.enumerable = enumerable;
            this.buffer = new ListNode<T>();
        }
    }
}
