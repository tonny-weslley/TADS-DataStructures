using System.Collections;
namespace Tree {


    class NodeTree{

        private object value;
        private NodeTree parent;
        private List<NodeTree> children;

        //construtor
        public NodeTree(object value, NodeTree parent){
            this.value = value;
            this.parent = parent;
            this.children = new List<NodeTree>();
        }

        //getters e setters
        public object Value {
            get { return value; }
            set { this.value = value; }
        }

        public NodeTree Parent {
            get { return parent; }
            set { this.parent = value; }
        }

        public List<NodeTree> Children {
            get { return children; }
            set { this.children = value; }
        }

        public int ChildNumber(){
            return this.children.Count;
        }

        public IEnumerator getChildrens(){
            return this.children.GetEnumerator();
        }

        public void addChild(NodeTree child){
            this.children.Add(child);
        }

        public void removeChild(NodeTree child){
            this.children.Remove(child);
        }


    }

}