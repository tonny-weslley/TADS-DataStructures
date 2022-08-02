using System.Collections;
namespace Tree
{

    class Arvore
    {

        private NodeTree root;
        private int t;

        public Arvore(NodeTree root)
        {
            this.root = root;
            this.t = 1;
        }

        public NodeTree Root()
        {
            return this.Root();
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

        public void addChild(NodeTree node, object element){
            node.addChild(new NodeTree(element, node));
            this.t++;
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
    }

}



// Metodos Genericos
/*
size
heigth
isEmpty - DONE
elements
nos
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
replace
*/