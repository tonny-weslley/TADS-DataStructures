using System.Collections;
namespace BinaryTree
{

    class BST
    {
        private TreeNode root;
        private int size;
        public BST(object element)
        {
            this.root = new TreeNode(element);
            this.size = 0;
        }

        // retornta a quantidade de nos da arvore
        public int Size()
        {
            return this.size;
        }

        // retorna a altura da arvore
        public int Heigth()
        {
            return this.getHeigth(this.root);
        }
        // metodo privado para retornar a altura da arvore
        private int getHeigth(TreeNode node)
        {
            if (node == null || node.isExternal())
            {
                return 0;
            }
            return 1 + Math.Max(getHeigth(node.Left), getHeigth(node.Right));
        }

        //metodos de consulta
        public bool isRoot(TreeNode node)
        {
            return node == this.root;
        }
        public bool isExternal(TreeNode node)
        {
            return node.isExternal();
        }
        public bool isInternal(TreeNode node)
        {
            return !node.isExternal();
        }

        //metodo para procurar um no na arvore
        public object Search(object element)
        {
            return this.search(this.root, element).Element;
        }

        private TreeNode search(TreeNode node, object element)
        {
            if (node == null)
            {
                return null;
            }

            switch (Comparer.Compare(node.Element, element))
            {
                case -1:
                    return search(node.Right, element);
                case 1:
                    return search(node.Left, element);
                case 0:
                    return node; 
                default:
                    return null;
            }

        }

        //metodo para inserir um no na arvore
        public void Insert(object element){
            TreeNode node = new TreeNode(element);
            TreeNode aux = this.root;

            while (aux != null)
            {
                switch (Comparer.Compare(aux.Element, element))
                {
                    case -1:
                        if (aux.Right == null)
                        {
                            aux.Right = node;
                            node.Parent = aux;
                            this.size++;
                            return;
                        }
                        else
                        {
                            aux = aux.Right;
                        }
                        break;
                    case 1:
                        if (aux.Left == null)
                        {
                            aux.Left = node;
                            node.Parent = aux;
                            this.size++;
                            return;
                        }
                        else
                        {
                            aux = aux.Left;
                        }
                        break;
                    case 0:
                        return;
                    default:
                        return;
                }
            }
        }

        //metodo para remover um no da arvore
        public object Remove(object element){
            return this.remove(this.root, element).Element;
        }

        private TreeNode remove(TreeNode node, object element){ 
            
            TreeNode aux = search(node, element);

            //caso não possua filho algum
            if(aux.isExternal()){
                switch (Comparer.Compare(aux.Element, element))
                {
                    case -1:
                        aux.Parent.Right = null;
                        break;
                    case 1:
                        aux.Parent.Left = null;
                        break;
                    case 0:
                        aux.Parent = null;
                        break;
                    default:
                        break;
                }
                return aux;
            }
            //caso não possua filho a direita
            else if(!aux.hasRight()){
                aux.Parent.Left = aux.Left;
                aux.Left.Parent = aux.Parent;
                this.size--;
                return aux;
            //caso não possua filho a esquerda
            }else if(!aux.hasLeft()){
                aux.Parent.Right = aux.Right;
                aux.Right.Parent = aux.Parent;
                this.size--;
                return aux;
            //caso possua filho a direita e a esquerda
            }else{
                TreeNode aux2 = aux.Right;
                aux2 = min(aux2);
                // verificar se possui filhos a direita
                // caso possua, realocar o no pai
                if(aux2.hasRight()){
                    aux2.Right.Parent = aux2.Parent;
                    aux2.Parent.Left = aux2.Right;
                }
                //procedimentos de remoção
                //1 - vincular os filhos do no a a ser removido ao substituto
                aux.Left.Parent = aux2;
                aux.Right.Parent = aux2;
                aux2.Left = aux.Left;
                aux2.Right = aux.Right;
                //2 - vincular o pai do antigo node ao novo
                //verifica se o no a ser removido é o root
                if(isRoot(aux)){
                    aux2.Parent = null;
                    this.root = aux2;
                }else{
                    aux2.Parent = aux.Parent;
                    switch (Comparer.Compare(aux.Element, aux.Parent.Element))
                    {
                        case -1:
                            aux.Parent.Right = aux2;
                            break;
                        case 1:
                            aux.Parent.Left = aux2;
                            break;
                        default:
                            break;
                    }
                }
                return aux;
            }

           
        }

        //retorna o menor filho
        private TreeNode min(TreeNode node){
            while (node.hasLeft())
            {
                node = node.Left;
            }
            return node;
        }

        //percorre o array em nivel
        public void level_order(){
            Queue level = new Queue();

            level.Enqueue(this.root);

            while (level.Count != 0){
                TreeNode actualNode = (TreeNode)level.Dequeue();
                Console.WriteLine(actualNode.Element);
                if(actualNode.hasLeft()){
                    level.Enqueue(actualNode.Left);
                }
                if(actualNode.hasRight()){
                    level.Enqueue(actualNode.Right);
                }
            }

        }
        
    }

}
