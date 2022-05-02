using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphPractice.Structures
{
    public class BasicGraphNode : Node
    {
        #region Members

        private List<BasicGraphNode> _edges;

        private int _value = 0;

        #endregion

        #region Properties

        public List<BasicGraphNode> Edges
        {
            get { return _edges; }  
        }
        public int Value
        {
            get { return _value; }  
        }

        #endregion 

        #region Constructors

        public BasicGraphNode() : base()
        {
            _edges = new List<BasicGraphNode>();    
        }

        public BasicGraphNode(string id, int val) : base(id)
        {
            _edges = new List<BasicGraphNode>();
            _value = val;   
        }

        #endregion

        #region Public Methods
        public bool TryAddEdge(BasicGraphNode destination)
        {
            bool isSuccess = false;
            if (!_edges.Contains(destination) && !destination.Edges.Contains(this))
            {
                _edges.Add(destination);
                destination.Edges.Add(this);    
                isSuccess = true;
            }
            return isSuccess;
        }

        public bool TryGetEdgeByID(string id, out BasicGraphNode targetDestination)
        {
            bool isSuccess = false;
            targetDestination = _edges.Find(node => node.Id == id);
            if(targetDestination != null)
            {
                isSuccess = true;
            }
            return isSuccess;
        }

        public string[] ListEdges()
        {
            string[] response = new string[_edges.Count];
            int i = 0;
            foreach (BasicGraphNode destination in _edges)
            {
                response[i++] = $"{destination.Id} : {destination.Value}";
            }
            return response;
        }

        #endregion
    }
}
