using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleCollect
{
    public class DoubleCustomeList : CustomeList
    {
        public Notebook this[int index]
        {
            get
            {
                DoubleNode<Notebook> currentNode = Head;
                int i = 0;

                while (currentNode != null && i != index)
                {
                    currentNode = currentNode.NextElement;
                    i++;
                }
                return currentNode.Element;
            }
        }
        //=> throw new NotImplementedException();

        public void Add(Notebook value)
        {
            DoubleNode<Notebook> node = new DoubleNode<Notebook>(value);
            if (Head == null)
                Head = node;
            else
                Tail.NextElement = node;
            Tail = node;
            //throw new NotImplementedException();
        }

        public bool Delete(Notebook value)
        {

            DoubleNode<Notebook> predNode = null;
            DoubleNode<Notebook> currentNode = Head;

            while (currentNode != null)
            {
                if (currentNode.Element.Equals(value))
                {
                    if (predNode != null)
                    {
                        predNode.NextElement = currentNode.NextElement;
                        {
                            if (currentNode.NextElement == null)
                            {
                                Tail = predNode;
                            }
                        }
                    }
                    else
                    {
                        Head = Head.NextElement;
                        if (Head == null)
                        {
                            Tail = null;
                        }
                    }
                    return true;
                }
                predNode = currentNode;
                currentNode = currentNode.NextElement;
            }
            return false;
            //throw new NotImplementedException();
        }
    }
}
