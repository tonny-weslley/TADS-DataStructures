namespace Sequencia
{


    class Sequencia
    {

        private LinkedList<object> lista;


        public Sequencia()
        {
            lista = new LinkedList<object>();
        }   // Construtor

        //isEmpty
        public bool IsEmpty()
        {
            return lista.Count == 0;
        }
        //size
        public int Size()
        {
            return lista.Count;
        }
        //atRank
        public object AtRank(int rank)
        {
            //verificando se a lista está vazia
            if (IsEmpty())
            {
                throw new SequenciaException("Lista vazia");
            }
            //verificando se a posição é válida
            if (rank < 0 || rank >= Size())
            {
                throw new SequenciaException("Posição inválida");
            }
            //aplicando o algoritmo de busca com base na metade da lista
            LinkedListNode<object> pointer;
            if (rank > Size() / 2)
            {
                pointer = lista.Last;
                for (int i = Size() - 1; i > rank; i--)
                {
                    pointer = pointer.Previous;
                }
            }
            else
            {
                pointer = lista.First;
                for (int i = 0; i < rank; i++)
                {
                    pointer = pointer.Next;
                }
            }
        }
        //rankOf
        public int rankOf(LinkedListNode<object> node){
            int rank = 0;
            LinkedListNode<object> pointer = lista.First;
            while (pointer != node)
            {
                pointer = pointer.Next;
                rank++;
            }
            return rank;
        }



    }


}