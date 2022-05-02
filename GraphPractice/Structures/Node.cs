using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphPractice.Structures
{
    public class Node
    {
        private string _id; 

        public string Id
        {
            get { return _id; }
        }

        public Node()
        {
            _id = Guid.NewGuid().ToString();
        }

        public Node(string id)
        {
            _id = id;   
        }
    }
}
