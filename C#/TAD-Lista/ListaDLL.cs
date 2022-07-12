namespace Lista{

    using System.Collections.Generic;

    public class ListaDLL {


        private LinkedList<object> lista;

        public ListaDLL(){
            lista = new LinkedList<object>();
        }

        public void add(object element){
            lista.AddLast(element);
        }


        public void remove(object element){
            lista.Remove(element);
        }

        public bool isEmpty(){
            return lista.Count == 0;
        }

        public int size(){
            return lista.Count;
        }

        public bool isFirst(object element){
            return lista.First.Value.Equals(element);
        }

        public bool isLast(object element){
            return lista.Last.Value.Equals(element);
        }

        public object first(){
            return lista.First.Value;
        }
        
        public object last(){
            return lista.Last.Value;
        }

        public object before(int pos){
            if(pos < 0 || pos > lista.Count){
                throw new ArgumentOutOfRangeException();
            }
            if(pos == 0){
                throw new InvalidOperationException();
            }
            //melhorando metodo com estrategia de dividir o array em duas partes

            LinkedListNode<object> element;

            if(pos >= lista.Count/2){
               element = lista.Last;
               for(int i = lista.Count; i > pos-1; i--){
                   element = element.Previous;
               }
            }else{
                element = lista.First;
                for(int i = 0; i < pos-1; i++){
                    element = element.Next;
                }
            }
            return element.Value;
        }

        public object after(int pos){
            if(pos < 0 || pos > lista.Count){
                throw new ArgumentOutOfRangeException();
            }
            if(pos == 0){
                throw new InvalidOperationException();
            }
            //melhorando metodo com estrategia de dividir o array em duas partes

            LinkedListNode<object> element;

            if(pos >= lista.Count/2){
               element = lista.Last;
               for(int i = lista.Count; i > pos+1; i--){
                   element = element.Previous;
               }
            }else{
                element = lista.First;
                for(int i = 0; i < pos; i++){
                    element = element.Next;
                }
            }
            return element.Value;
        }
        
        public object elemAtRank(int pos){
            if(pos < 0 || pos > lista.Count){
                throw new ArgumentOutOfRangeException();
            }
            if(pos == 0){
                throw new InvalidOperationException();
            }
            //melhorando metodo com estrategia de dividir o array em duas partes
            LinkedListNode<object> element;
            if(pos >= lista.Count/2){
               element = lista.Last;
               for(int i = lista.Count; i > pos; i--){
                   element = element.Previous;
               }
            }else{
                element = lista.First;
                for(int i = 0; i < pos; i++){
                    element = element.Next;
                }
            }
            return element.Value;
        }

        //replaceElement(int pos, object novo)
        public object replaceElement(int pos, object novo){
            if(pos < 0 || pos > lista.Count){
                throw new ArgumentOutOfRangeException();
            }
            if(pos == 0){
                throw new InvalidOperationException();
            }
            //melhorando metodo com estrategia de dividir o array em duas partes
            LinkedListNode<object> element;
            if(pos >= lista.Count/2){
               element = lista.Last;
               for(int i = lista.Count; i > pos; i--){
                   element = element.Previous;
               }
            }else{
                element = lista.First;
                for(int i = 0; i < pos; i++){
                    element = element.Next;
                }
            }
            element.Value = novo;
            return element.Value;
        }

        public void insertBefore(int pos, object novo){
            if(pos < 0 || pos > lista.Count){
                throw new ArgumentOutOfRangeException();
            }
            if(pos == 0){
                throw new InvalidOperationException();
            }
            //melhorando metodo com estrategia de dividir o array em duas partes
            LinkedListNode<object> element;
            if(pos >= lista.Count/2){
               element = lista.Last;
               for(int i = lista.Count; i > pos; i--){
                   element = element.Previous;
               }
            }else{
                element = lista.First;
                for(int i = 0; i < pos; i++){
                    element = element.Next;
                }
            }
            lista.AddBefore(element, novo);
        }

        public void insertAfter(int pos, object novo){
            if(pos < 0 || pos > lista.Count){
                throw new ArgumentOutOfRangeException();
            }
            if(pos == 0){
                throw new InvalidOperationException();
            }
            //melhorando metodo com estrategia de dividir o array em duas partes
            LinkedListNode<object> element;
            if(pos >= lista.Count/2){
               element = lista.Last;
               for(int i = lista.Count; i > pos; i--){
                   element = element.Previous;
               }
            }else{
                element = lista.First;
                for(int i = 0; i < pos; i++){
                    element = element.Next;
                }
            }
            lista.AddAfter(element, novo);
        }
        
        public void insertFirst(object novo){
            lista.AddFirst(novo);
        }

        public void insertLast(object novo){
            lista.AddLast(novo);
        }


    }



}