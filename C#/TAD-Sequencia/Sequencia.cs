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
        public bool isEmpty()
        {
            return lista.Count == 0;
        }
        //size
        public int Size()
        {
            return lista.Count;
        }
        //atRank
        public object atRank(int rank)
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
        public int rankOf(LinkedListNode<object> node)
        {
            int rank = 0;
            LinkedListNode<object> pointer = lista.First;
            while (pointer != node)
            {
                pointer = pointer.Next;
                rank++;
            }
            return rank;
        }

        //elementAtRank
        public object elementAtRank(int rank)
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
            return pointer.Value;
        }
        //replaceElementAtRank
        public void replaceElementAtRank(int rank, object element)
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
            pointer.Value = element;
        }
        //insertAtRank
        public void insertAtRank(int rank, object element)
        {
            //verificando se a lista está vazia
            if (IsEmpty())
            {
                throw new SequenciaException("Lista vazia");
            }
            //verificando se a posição é válida
            if (rank < 0 || rank > Size())
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
            lista.AddAfter(pointer, element);
        }
        //removeAtRank
        public void removeAtRank(int rank)
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
            if (rank > size() / 2)
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
            lista.Remove(pointer);
        }
        //first
        public object first()
        {
            //verificando se a lista está vazia
            if (IsEmpty())
            {
                throw new SequenciaException("Lista vazia");
            }
            return lista.First.Value;
        }
        //last
        public object last()
        {
            //verificando se a lista está vazia
            if (IsEmpty())
            {
                throw new SequenciaException("Lista vazia");
            }
            return lista.Last.Value;
        }
        //before
        public object before(LinkedListNode<object> node)
        {
            //verificando se a lista está vazia
            if (IsEmpty())
            {
                throw new SequenciaException("Lista vazia");
            }
            //verificando se o nó é válido
            if (node == null)
            {
                throw new SequenciaException("Nó inválido");
            }
            //verificando se o nó é o primeiro
            if (node == lista.First)
            {
                throw new SequenciaException("Nó inválido");
            }
            LinkedListNode<object> pointer = lista.Last;
            while (pointer != node)
            {
                pointer = pointer.Previous;
            }
            return pointer.Previous.Value;
        }
        //after
        public object after(LinkedListNode<object> node)
        {
            //verificando se a lista está vazia
            if (IsEmpty())
            {
                throw new SequenciaException("Lista vazia");
            }
            //verificando se o nó é válido
            if (node == null)
            {
                throw new SequenciaException("Nó inválido");
            }
            LinkedListNode<object> pointer = lista.First;
            while (pointer != node)
            {
                pointer = pointer.Next;
            }
            return pointer.Next.Value;
        }
        //replace element
        public void replaceElement(LinkedListNode<object> node, object element)
        {
            //verificando se a lista está vazia
            if (IsEmpty())
            {
                throw new SequenciaException("Lista vazia");
            }
            //verificando se o nó é válido
            if (node == null)
            {
                throw new SequenciaException("Nó inválido");
            }
            //verificar se é o primro nó
            if (node == lista.First)
            {
                lista.First.Value = element;
            }
            //verificar se é o último nó
            else if (node == lista.Last)
            {
                lista.Last.Value = element;
            }
            else
            {
                LinkedListNode<object> pointer = lista.First;
                while (pointer != node)
                {
                    pointer = pointer.Next;
                }
                pointer.Value = element;
            }
        }

        public void insertBefore(LinkedListNode<object> node, object element){
            //verificando se a lista está vazia
            if (IsEmpty())
            {
                throw new SequenciaException("Lista vazia");
            }
            //verificando se o nó é válido
            if (node == null)
            {
                throw new SequenciaException("Nó inválido");
            }
            //verificar se é o primro nó
            if (node == lista.First)
            {
                lista.AddFirst(element);
            }
            //verificar se é o último nó
            else if (node == lista.Last)
            {
                LinkedListNode<object> novo = new LinkedListNode<object>(element); //instancia de novo nó
                novo.Next = list.Last;                                             //novo nó aponta para o último nó da lista
                novo.Previous = list.Last.Previous;                                //anterior do novo nó aponta para o nó anterior ao último nó da lista
                lista.Previous.Next = novo;
                lista.Last.Previous = novo;
            }
            else
            {
                LinkedListNode<object> pointer = lista.First;
                while (pointer != node)
                {
                    pointer = pointer.Next;
                }
                LinkedListNode<object> novo = new LinkedListNode<object>(element);  //instancia de novo nó
                novo.Next = pointer;                                                //novo nó aponta para o nó após o nó a ser inserido
                novo.Previous = pointer.Previous;                                   //anterior do novo nó aponta para o nó anterior ao nó a ser inserido
                pointer.Previous.Next = novo;
                pointer.Previous = novo;
            }
        }
        public void insertAfter(LinkedListNode<object> node, object element){

        }

    }


}