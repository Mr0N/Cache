using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufferTest
{
    class TestIterator
    {
        public IEnumerable<int> GetIterator()
        {
            for (int i = 0; i < 1000; i++)
            {
                yield return i;
            }
        }
    }
}
