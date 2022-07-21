namespace Lista
{
    class ListaArray
    {
        private object[] lista;
        private int t;


        public ListaArray()
        {
            lista = new object[1];
            t = 1;
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
            if (pos >= size() - 1 || pos < 1 || isEmpty())
            {
                throw new listaException("Indice invalido");
            }
            else
            {
                return lista[pos];
            }
        }

        //replaceElement(object element1, object element2) -> done
        public void replaceElement(object element1, object element2)
        {
            //controle de exeção
            if (isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            //verifica se o elemento existe na lista
            if(!lista.Contains(element1))
            {
                throw new listaException("Elemento não encontrado");
            }
            //encontrando a primeira ocorrencia do elemento node
            for (int i = 0; i < size(); i++)
            {
                if (lista[i] == element1)
                {
                    lista[i] = element2;
                    break;
                }
            }
        }

        //swapElements(object element1, object element2) -> done
        public void swapElements(object element1, object element2){
            //controle de exeção
            if (isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            //verifica se o elementos existe na lista
            if (!lista.Contains(element1) || !lista.Contains(element2))
            {
                throw new listaException("Elemento não encontrado");
            }
            //verificando se os elementos são iguais
            if (element1 == element2)
            {
                throw new listaException("Elementos iguais");
            }
            //encontrando a primeira ocorrencia do elemento1
            for (int i = 0; i < size(); i++)
            {
                if (lista[i] == element1)
                {
                    //encontrando a primeira ocorrencia do elemento2
                    for (int j = 0; j < size(); j++)
                    {
                        if (lista[j] == element2)
                        {
                            object aux = lista[i];
                            lista[i] = lista[j];
                            lista[j] = aux;
                            break;
                        }
                    }
                    break;
                }
            }
        }
        
        //insertFirst(object element) -> done
        public void insertFirst(object element){

            if (isEmpty())
            {
                lista = new object[1];
                lista[0] = element;
            }
            else
            {
                //verificar se array está cheio
                if (size() == t)
                {
                    increaseArray();
                }
                //mover todos os elementos para a direita
                for (int i = size() - 1; i >= 0; i--)
                {
                    lista[i + 1] = lista[i];
                }
                lista[0] = element;
            }

        }

        //insertLast(object element) -> todo
        public void insertLast(object element)
        {
            if (isEmpty())
            {
                lista = new object[1];
                lista[0] = element;
            }
            else
            {
                //verificar se array está cheio
                if (size() == t)
                {
                    increaseArray();
                }
                //adiciona o elemento no final
                lista[size()-1] = element;
            }
        }

        public object elemAtRank(int rank){ //Metodo Provisósrio
            return lista[rank];
        }

        public void increaseArray(){
            Array.Resize(ref lista, lista.Length * 2);
            t *= 2;
        }
    }
}
