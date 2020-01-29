using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleCollect
{
    public class CustomeList : IEnumerable<Notebook>
    {
        public DoubleNode<Notebook> Head { get; set; }
        public DoubleNode<Notebook> Tail { get; set; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<Notebook> IEnumerable<Notebook>.GetEnumerator()
        {
            DoubleNode<Notebook> current = Head;
            while (current != null)
            {
                yield return current.Element;
                current = current.NextElement;
            }
        }

        public IEnumerable<Notebook> BackEnumerator()
        {
            DoubleNode<Notebook> current = Tail;
            while (current != null)
            {
                yield return current.Element;
                current = current.PrevElement;
            }
        }
            //public IEnumerator<Notebook> GetEnumerator()
             //{
             //    DoubleNode<Notebook> current = Head;
             //    while (current != null)
             //    {
             //        yield return current.Element;

    //        current = current.NextElement;
    //    }
    //    //return new CustomeListIEnumerator();
    //    //throw new NotImplementedException();
    //}
}
}
