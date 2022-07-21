namespace Sequence
{
    class Node
    {
        private object element;
        private Node prev, next;


        public Node(object element)
        {
            this.element = element;
            prev = null;
            next = null;
        }

        public Node(object element, Node prev, Node next)
        {
            this.element = element;
            this.prev = prev;
            this.next = next;
        }

        public object Element
        {
            get { return element; }
            set { element = value; }
        }

        public object getElement(){
            return element;
        }

        public Node Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}