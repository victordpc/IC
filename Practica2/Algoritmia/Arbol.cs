using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmia
{
    public class Arbol
    {
        public static Tree CreateTreeAndHandleUserOperation(DataTable dato)
        {
            return new Tree
            {
                Root = Tree.Aprender(dato, "")
            };
        }
    }
}
