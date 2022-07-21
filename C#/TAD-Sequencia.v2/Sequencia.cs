namespace Sequence
{

    class Sequencia
    {
        LinkedList lista = new LinkedList();

        public bool isEmpty()
        {
            return lista.Size == 0;
        }

        public int size()
        {
            return lista.Size;
        }

        public object elementAtRank(int rank)
        {
            Node aux = lista.First;
            for (int i = 0; i < rank; i++)
            {
                aux = aux.Next;
            }
            return aux.Element;
        }

        public void replaceAtRank(int rank, object element)
        {
            Node aux = lista.First;
            for (int i = 0; i < rank; i++)
            {
                aux = aux.Next;
            }
            aux.Element = element;
        }

        public void insertAtRank(int rank, object element)
        {
            //verificar de o rank é 0
            if (rank == 0)
            {
                Node novo = new Node(element, null, lista.First);
            }
            else if (rank == size() - 1)
            {
                Node novo = new Node(element, lista.Last, null);
            }
            else
            {

                Node aux = lista.First;
                for (int i = 0; i < rank; i++)
                {
                    aux = aux.Next;
                }
                Node novo = new Node(element, aux.Prev, aux);
                aux.Prev.Next = novo;
                aux.Prev = novo;
                lista.Size++;
            }

        }

        public void removeAtRank(int rank)
        {
            Node aux = lista.First;
            for (int i = 0; i < rank; i++)
            {
                aux = aux.Next;
            }
            aux.Prev.Next = aux.Next;
            aux.Next.Prev = aux.Prev;
            lista.Size--;
        }

        public object first()
        {

            //Verificar se a lista está vazia
            if (isEmpty())
            {
                throw new SequenciaException("A Sequencia está vazia");
            }
            else
            {
                return lista.First.Element;
            }
        }

        public object last()
        {
            //Verificar se a lista está vazia
            if (isEmpty())
            {
                throw new SequenciaException("A Sequencia está vazia");
            }
            else
            {
                return lista.Last.Element;
            }
        }

        public object before(object element)
        {
            //Verificar se a lista está vazia
            if (isEmpty())
            {
                throw new SequenciaException("A Sequencia está vazia");
            }
            //verificar se o element é o primeiro elemento da sequencia
            else if (element.Equals(lista.First.Element))
            {
                throw new SequenciaException("Posição inválida");
            }
            else
            {

                Node aux = lista.Last;
                bool find = false;
                while (aux.Prev != null)
                {
                    if (aux.Element.Equals(element))
                    {
                        find = true;
                        break;
                    }
                    aux = aux.Prev;
                }
                //verificar se o elemento foi encontrado
                if (!find)
                {
                    throw new SequenciaException("Elemento não encontrado");
                }
                else
                {
                    return aux.Prev.Element;
                }
            }

        }

        public object after(object element)
        {
            //Verificar se a lista está vazia
            if (isEmpty())
            {
                throw new SequenciaException("A Sequencia está vazia");
            }
            //verificar se o element é o ultimo elemento da sequencia
            else if (element.Equals(lista.Last.Element))
            {
                throw new SequenciaException("Posição inválida");
            }
            else
            {

                Node aux = lista.First;
                bool find = false;
                while (aux.Next != null)
                {
                    if (aux.Element.Equals(element))
                    {
                        find = true;
                        break;
                    }
                    aux = aux.Next;
                }
                //verificar se o elemento foi encontrado
                if (!find)
                {
                    throw new SequenciaException("Elemento não encontrado");
                }
                else
                {
                    return aux.Next.Element;
                }
            }
        }

        public void insertFirst(object element)
        {
            //Verificar se a lista está vazia
            if (isEmpty())
            {
                throw new SequenciaException("A Sequencia está vazia");
            }
            else
            {
                Node novo = new Node(element, null, lista.First);
                lista.First.Prev = novo;
                lista.First = novo;
                lista.Size++;
            }
        }

        public void insertLast(object element)
        {
            //Verificar se a lista está vazia
            if (isEmpty())
            {
                lista.First = new Node(element);
                lista.Last = lista.First;
            }
            else
            {
                lista.Last.Next = new Node(element, lista.Last, null);
                lista.Last = lista.Last.Next;
            }
            lista.Size++;
        }


        public void replaceElement(object element, object novo)
        {
            // verificar se a sequencia está vazia
            if (isEmpty())
            {
                throw new SequenciaException("A sequencia está vazia");
            }
            // verificar se o elemento é o primeiro elemento
            if (element.Equals(first()))
            {
                lista.First.Element = novo;
            }
            //verificar se é o ultimo elemento
            else if (element.Equals(last()))
            {
                lista.Last.Element = novo;
            }
            else
            {
                Node aux = lista.First;
                bool find = false;
                while (aux != null)
                {
                    if (aux.Element.Equals(element))
                    {
                        aux.Element = novo;
                        find = true;
                        break;
                    }
                    aux = aux.Next;
                }
                if (!find)
                {
                    throw new SequenciaException("Elemento não encontrado");
                }

            }
        }

        public void swapElements(object element1, object element2)
        {
            // verificar se a sequencia está vazia
            if (isEmpty())
            {
                throw new SequenciaException("A sequencia está vazia");
            }
            //verificar se o element1 existe na lista
            Node aux = lista.First;
            Node el1 = null;
            Node el2 = null;
            bool find1 = false;
            bool find2 = false;
            while (aux != null)
            {
                if (aux.Element.Equals(element1))
                {
                    el1 = aux;
                    find1 = true;
                }
                if (aux.Element.Equals(element2))
                {
                    el2 = aux;
                    find2 = true;
                }
                if (find1 && find2)
                {
                    break;
                }
                aux = aux.Next;
            }
            if (!find1)
            {
                throw new SequenciaException("Elemento não encontrado");
            }
            if (!find2)
            {
                throw new SequenciaException("Elemento não encontrado");
            }
            el1.Element = element2;
            el2.Element = element1;
        }


        public void insertBefore(object element, object novo)
        {
            // verificar se a sequencia está vazia
            if (isEmpty())
            {
                throw new SequenciaException("A sequencia está vazia");
            }
            //verificar se o element1 existe na lista
            Node aux = lista.First;
            Node el1 = null;
            bool find1 = false;
            while (aux != null)
            {
                if (aux.Element.Equals(element))
                {
                    el1 = aux;
                    find1 = true;
                    break;
                }
                aux = aux.Next;
            }
            if (!find1)
            {
                throw new SequenciaException("Elemento não encontrado");
            }
            Node novoNodo = new Node(novo, el1.Prev, el1);
            if (el1.Prev != null)
            {
                el1.Prev.Next = novoNodo;
            }
            else
            {
                lista.First = novoNodo;
            }
            el1.Prev = novoNodo;
            lista.Size++;
        }

        public void insertAfter(object element, object novo)
        {
            // verificar se a sequencia está vazia
            if (isEmpty())
            {
                throw new SequenciaException("A sequencia está vazia");
            }
            //verificar se o element1 existe na lista
            Node aux = lista.First;
            Node el1 = null;
            bool find1 = false;
            while (aux != null)
            {
                if (aux.Element.Equals(element))
                {
                    el1 = aux;
                    find1 = true;
                    break;
                }
                aux = aux.Next;
            }
            if (!find1)
            {
                throw new SequenciaException("Elemento não encontrado");
            }
            Node novoNodo = new Node(novo, el1, el1.Next);
            if (el1.Next != null)
            {
                el1.Next.Prev = novoNodo;
            }
            else
            {
                lista.Last = novoNodo;
            }
            el1.Next = novoNodo;
            lista.Size++;
        }

        public object remove(object element)
        {
            // verificar se a sequencia está vazia
            if (isEmpty())
            {
                throw new SequenciaException("A sequencia está vazia");
            }
            //verificar se o element é o primeiro elemento
            if (element.Equals(first()))
            {
                Node aux = lista.First;
                lista.First = lista.First.Next;
                lista.First.Prev = null;
                lista.Size--;
                return aux.Element;
            }
            //verificar se é o ultimo elemento
            else if (element.Equals(last()))
            {
                Node aux = lista.Last;
                lista.Last = lista.Last.Prev;
                lista.Last.Next = null;
                lista.Size--;
                return aux.Element;
            }
            else
            {
                Node aux = lista.First;
                bool find = false;
                while (aux.Next != null)
                {
                    if (aux.Element.Equals(element))
                    {
                        find = true;
                        break;
                    }
                    aux = aux.Next;
                }
                //verificar se o elemento foi encontrado
                if (!find)
                {
                    throw new SequenciaException("Elemento não encontrado");
                }
                else
                {
                    aux.Prev.Next = aux.Next;
                    aux.Next.Prev = aux.Prev;
                    lista.Size--;
                    return aux.Element;
                }
            }
        }


        public object atRank(int rank)
        {
            // verificar se a sequencia está vazia
            if (isEmpty())
            {
                throw new SequenciaException("A sequencia está vazia");
            }
            //verificar se o rank é menor que 0
            if (rank < 0 || rank >= lista.Size)
            {
                throw new SequenciaException("Posição inválida");
            }
            else
            {
                Node aux = lista.First;
                int i = 0;
                while (i < rank)
                {
                    aux = aux.Next;
                    i++;
                }
                return aux.Element;
            }
        }

        public int rankOf(object element)
        {
            // verificar se a sequencia está vazia
            if (isEmpty())
            {
                throw new SequenciaException("A sequencia está vazia");
            }
            //verificar se o elemento existe na lista
            Node aux = lista.First;
            int i = 0;
            bool find = false;
            while (aux != null)
            {
                if (aux.Element.Equals(element))
                {
                    find = true;
                    break;
                }
                aux = aux.Next;
                i++;
            }
            if (!find)
            {
                throw new SequenciaException("Elemento não encontrado");
            }
            return i;
        }
        public void show()
        {
            Node aux = lista.First;
            while (aux != null)
            {
                Console.Write(aux.Element + " | ");
                aux = aux.Next;
            }
            Console.WriteLine();
        }

    }




}