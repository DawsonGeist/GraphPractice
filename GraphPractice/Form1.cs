using GraphPractice.Structures;
using System.Diagnostics;

namespace GraphPractice
{
    public partial class Form1 : Form
    {
        private List<BasicGraphNode> _nodes = new List<BasicGraphNode>(); 
        
        private BasicGraphNode currentNode = null;
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            Debug.Print("Creating nodes A, B, C");
            BasicGraphNode nodeA = new BasicGraphNode();
            BasicGraphNode nodeB = new BasicGraphNode();    
            BasicGraphNode nodeC = new BasicGraphNode();

            Debug.Print("Connecting nodes A, B");
            Debug.Assert(nodeA.TryAddEdge(nodeB));
            Debug.Print("Connecting nodes B, C");
            Debug.Assert(nodeB.TryAddEdge(nodeC));

            currentNode = nodeA;
            UpdateFormOnTravel();
        }

        private void UpdateFormOnTravel()
        {
            lblCurrentNode.Text = $"Current Node: {currentNode.Id}";
            tbCurrentEdges.Lines = currentNode.ListEdges();

            cbDestination.Items.Clear();
            foreach (BasicGraphNode x in currentNode.Edges)
            {
                cbDestination.Items.Add(x.Id);
            }

            cbDestination.SelectedIndex = 0;
        }

        private void btnTravelOnEdge_Click(object sender, EventArgs e)
        {
            BasicGraphNode x;
            string destId = cbDestination.Items[cbDestination.SelectedIndex]?.ToString() ?? string.Empty;
            if (currentNode.TryGetEdgeByID(destId, out x))
            {
                currentNode = x;
                UpdateFormOnTravel();
            }
            Refresh();
        }
    }
}