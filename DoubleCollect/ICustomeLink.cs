using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleCollect
{
    public interface ICustomeLink
    {
        void Add(Notebook value);
        Notebook this[int index] { get; }
        bool Delete(Notebook value);

    }
}
