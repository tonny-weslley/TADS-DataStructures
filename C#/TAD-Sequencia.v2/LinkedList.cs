namespace Sequence
{
    class LinkedList
    {

        private Node first, last;
        private int size;

        //construtor
        public LinkedList()
        {
            size = 0;
        }

        //Mêtodos de acesso e modificação
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Node First
        {
            get { return first; }
            set { first = value; }
        }

        public Node Last
        {
            get { return last; }
            set { last = value; }
        }

    }
}