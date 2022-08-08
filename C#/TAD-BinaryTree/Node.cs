namespace BinaryTree{


    class TreeNode{
        

        private object element;
        private TreeNode left;
        private TreeNode right;
        private TreeNode parent;

        //getters e setters
        public object Element { get => element; set => element = value; }
        public TreeNode Left { get => left; set => left = value; }
        public TreeNode Right { get => right; set => right = value; }
        public TreeNode Parent { get => parent; set => parent = value; }
        
        public TreeNode(object element){
            this.element = element;
            this.left = null;
            this.right = null;
            this.parent = null;
        }

        public TreeNode(object element, TreeNode parent){
            this.element = element;
            this.left = null;
            this.right = null;
            this.parent = parent;
        }
        
        public bool isExternal(){
            return this.left == null && this.right == null;
        }

        public bool isInternal(){
            return this.left != null || this.right != null;
        }

        public bool isRoot(){
            return this.parent == null;
        }

        public bool hasLeft(){
            return this.left != null;
        }

        public bool hasRight(){
            return this.right != null;
        }

    }


}