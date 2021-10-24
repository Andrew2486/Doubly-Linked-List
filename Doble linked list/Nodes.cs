using System;
using System.Collections.Generic;
using System.Text;

namespace Doble_linked_list
{
    class Nodes
    {
        public int data;
        public Nodes next;
        public Nodes prev;
        public Nodes(int d)
        {
            data = d;
            next = null;
            prev = null;
        }
    }
}
