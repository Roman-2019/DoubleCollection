using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleCollect
{
    public class DoubleNode<Notebook>
    {
        public DoubleNode(Notebook element)
        {
            Element = element;
        }

        public Notebook Element { get; set; }
        public DoubleNode<Notebook> NextElement { get; set; }
        public DoubleNode<Notebook> PrevElement { get; set; }
    }
}
