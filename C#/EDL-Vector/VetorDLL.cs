namespace Vetor
{

    using System.Collections.Generic;
    class VetorDLL : IVetor
    {

        private LinkedList<object> lista;

        public VetorDLL()
        {
            lista = new LinkedList<object>();
        }   // Construtor

        //isEmpty
        public bool IsEmpty()
        {
            return lista.Count == 0;
        }

        //ElemAtRank
        public object ElemAtRank(int pos)
        {
            this.checkPos(pos);
            return lista.ElementAt(pos);
        }


        //RemoveAtRank
        public object RemoveAtRank(int pos)
        {
            this.checkPos(pos);

            LinkedListNode<object> node = this.GetNode(pos);
            object aux = node.Value;
            lista.Remove(node);
            return aux;
        }

        //ReplaceAtRank
        public object ReplaceAtRank(int pos, object novo)
        {
            this.checkPos(pos);
            LinkedListNode<object> node = this.GetNode(pos);
            object aux = node.Value;
            node.Value = novo;
            return aux;
        }

        //InserAtRank
        public void InserAtRank(int pos, object novo)
        {
            this.checkPos(pos);
            LinkedListNode<object> node = new(novo);
            

            if(this.IsEmpty()){
                lista.AddFirst(node);
            }else if (pos == lista.Count){
                lista.AddLast(node);
            }else{
                LinkedListNode<object> aux = this.GetNode(pos);
                lista.AddBefore(aux, node);
            }

        }



        private void checkPos(int pos){
            if (pos < 0 || pos > lista.Count)
            {
                throw new VetorException("Posição inválida");
            }
        }

        //return a node from the list
        private LinkedListNode<object> GetNode(int pos)
        {
            this.checkPos(pos);

            if(pos < lista.Count / 2)
            {
                LinkedListNode<object> node = lista.First;
                for (int i = 0; i < pos; i++)
                {
                    node = node.Next;
                }
                return node;

            }
            else
            {
                LinkedListNode<object> node = lista.Last;
                for (int i = lista.Count - 1; i > pos; i--)
                {
                    node = node.Previous;
                }
                return node;
            }
        }



    }



}