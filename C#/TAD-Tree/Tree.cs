using System.Collections;
namespace Tree
{

    class Arvore
    {

        private NodeTree root;
        private int t;

        public Arvore(object rootValue)
        {
            this.root = new NodeTree(1, null);
            this.t = 1;
        }

        public NodeTree Root()
        {
            return this.root;
        }

        public int size(){
            return this.t;
        }

        public bool isEmpty()
        {
            return this.root == null;
        }

        public bool isInternal(NodeTree node)
        {
            return node.ChildNumber() > 0;
        }

        public bool isExternal(NodeTree node)
        {
            return node.ChildNumber() == 0;
        }

        public bool isRoot(NodeTree node)
        {
            return node == this.root;
        }

        public IEnumerator children(NodeTree node)
        {
            return node.getChildrens();
        }

        public NodeTree parent(NodeTree node)
        {
            return node.Parent;
        }

        public NodeTree addChild(NodeTree node, object element){
            NodeTree novo = new NodeTree(element, node);
            node.addChild(novo);
            this.t++;
            return novo;
        }

        public object removeChild(NodeTree node){
            object value = node.Value;
            node.Parent.removeChild(node);
            this.t--;
            return value;

        }

        public int depth(NodeTree node){
            if(node == this.root)
                return 0;
            else
                return 1 + this.depth(node.Parent);
        }


         public IEnumerator elements()
        {
            IEnumerator nos = nodes();
            ArrayList list = new ArrayList();

            while (nos.MoveNext())
            {
                NodeTree no = new NodeTree(null, null);
                no = (NodeTree)nos.Current;
                list.Add(no.Value);
            }
            return list.GetEnumerator();
        }


        public IEnumerator nodes()
        {
            ArrayList nodes = new();
            return preOrder(this.root, nodes);
        }

        // percorer arvore em ordem
         private IEnumerator preOrder(NodeTree node, ArrayList lista)
        {
            lista.Add(node);
            IEnumerator childrens = node. childrenEnum();
            while (childrens.MoveNext())
            {
                preOrder((NodeTree)childrens.Current, lista);
            }
            return lista.GetEnumerator();
        }


        public void replace(NodeTree node, NodeTree v)
        {
            NodeTree backup = node;
            node = v;
            v = backup;
        }


    }

}



// Metodos Genericos
/*
size - DONE
heigth
isEmpty - DONE
elements - DONE
nos - DONE
*/

// Metodos de Acesso
/*
root - DONE
parent - DONE
children - DONE
*/

// Metodos de Consulta
/*
isInternal - DONE
isExternal - DONE
isRoot - DONE
depth - DONE
*/

// metodos de Atualização 
/*
replace - DONE
*/