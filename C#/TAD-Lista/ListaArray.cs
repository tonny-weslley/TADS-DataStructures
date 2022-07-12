namespace Lista
{
    class ListaArray
    {
        private object[] lista;


        public ListaArray(){
            lista = new object[1];
        }

        public bool isEmpty(){
            return list.Length == 0;
        }

        public int size(){
            return list.Length;
        }

        public bool isFirst(object element){
            if(isEmpty()){
                //exceção
            }else{
                return element == lista[0];
            }
        }

        public bool isLast(object element){

            if(isEmpty()){
                //exceção
            }else{
                return element == lista[size()-1];
            }

        }

        public object first(){
            if(isEmpty()){
                //exceção
            }else{
                return lista[1];
            }
        }

        public object last(){
            if(isEmpty()){
                //exceção
            }else{
                return lista[size()-1];
            }
        }

        public object before(int pos){
            if(pos > size() || pos <= 1 || isEmpty()){
                //exceção
            }else{
                return lista[pos-2];
            }
        }

        public object after(int pos){
             if(pos >= size() || pos < 1 || isEmpty()){
                 //exceção
             }else{
                 return lista[pos];
             }
        }

        public object elementAtRank(int rank){
            if(rank >= size() || rank < 0 || isEmpty()){
                //exceção
            }else{
                return lista[rank];
            } 
        }


        //para implementar
        public object removeAtRank(int rank){
            if(rank >= size() || rank < 0 || isEmpty()){
                //exceção
            }else{
                
            }
        }




    }
}