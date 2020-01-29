using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleCollect
{
    public class CustomeListIEnumerator: IEnumerator
    {
        private readonly object Head;

        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            DoubleNode<Notebook> current = (DoubleNode<Notebook>)Head;
            while (current != null)
            {
                if (current.Element.Equals(current.Element))
                    return true;
                current = current.NextElement;
            }
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
