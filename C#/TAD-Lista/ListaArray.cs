namespace Lista
{
    class ListaArray
    {
        private object[] lista;


        public ListaArray()
        {
            lista = new object[1];
        }
        //isEmpty() -> done
        public bool isEmpty()
        {
            return lista.Length == 0;
        }
        
        //size() -> done
        public int size()
        {
            return lista.Length;
        }
        
        //isFirst(object element) -> done
        public bool isFirst(object element)
        {
            if (isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                return element == lista[0];
            }
        }
        
        //isLast(object element) -> done
        public bool isLast(object element)
        {

            if (isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                return element == lista[size() - 1];
            }

        }
        
        //first() -> done
        public object first()
        {
            if (isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                return lista[0];
            }
        }
        
        //last() -> done
        public object last()
        {
            if (isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                return lista[size() - 1];
            }
        }
        
        //before(int pos) -> done
        public object before(int pos)
        {
            if (pos > size() || pos <= 1 || isEmpty())
            {
                throw new listaException("Indice invalido");
            }
            else
            {
                return lista[pos - 2];
            }
        }
        
        //after(int pos) -> done
        public object after(int pos)
        {
            if (pos >= size()-1 || pos < 1 || isEmpty())
            {
                throw new listaException("Indice invalido");
            }
            else
            {
                return lista[pos];
            }
        }
        
        //elemAtRank(int pos) -> done
        public object elementAtRank(int rank)
        {
            if (rank >= size() || rank < 0 || isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                return lista[rank];
            }
        }
        
        //removeAtRank(int pos) -> done
        public object removeAtRank(int rank)
        {
            if (rank >= size() || rank < 0 || isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                object element = lista[rank];
                for (int i = rank; i < size() - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                lista[size() - 1] = null;
                return element;
            }
        }
        
        //insertBefore(int pos, object novo) -> todo
       
    }

}