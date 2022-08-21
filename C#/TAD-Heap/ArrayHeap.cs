using System.ComponentModel;
namespace heap
{
    public class ArrayHeap{

        private object[] heap;
        private int tail;


        public ArrayHeap(int t){
            this.heap = new object[t];
            this.tail = -1;
        }

        public bool isEmpty(){
            return this.tail == -1;
        }

        public int left(int index){
            return 2 * index + 1;
        }

        public int right(int index){
            return 2 * (index + 1);
        }

        public int parent(int index){
            return (index-1)/2;
        }

        public int size(){
            return this.tail + 1;
        }

        public void add(object element){
            // Se o array estiver cheio
            if( tail >= (heap.Length -1)){
                this.resize();
            }

            this.tail ++;
            this.heap[tail] = element;

            int i = tail;
            //caso o objeto inserido for maio que seu pai, devem trocar de lugar
            while(i > 0 && Convert.ToInt32(this.heap[parent(i)]) < Convert.ToInt32(this.heap[i])){
                //variavel que auxilia a troca
                object aux = this.heap[i];
                this.heap[i] = this.heap[parent(i)];
                this.heap[parent(i)] = aux;
                i = parent(i);
            }

        }

        public object remove(){
            if(isEmpty()){
                Console.WriteLine("tá vazio brow");
                return null;
            }

            object element = this.heap[0];// prepara o primeiro elemento do array a ser retornado
            this.heap[0] = this.heap[this.tail];
            this.tail --;

            //heapfy is not working
            this.heapify(0);

            return element;


        }


        private void heapify(int index){
            //verificar se possui filhos, caso não possua não há o que fazer
            //verifica se o indice é valido
            if(isValid(index) || !isLeaf(index)){
                return;
            }

            int max_index = compareMax(index, left(index), right(index));

            if(max_index != index){
                swap(index, max_index);
                heapify(max_index);
            } 
        }

        private int compareMax(int index, int left, int rigth){
            if(Convert.ToInt32(this.heap[index]) > Convert.ToInt32(this.heap[left])){
                if(isValid(rigth)){
                    if(Convert.ToInt32(this.heap[index]) < Convert.ToInt32(this.heap[rigth])){
                        return rigth;
                    }
                }
                return index;
            }else{
                if(isValid(rigth)){
                    if(Convert.ToInt32(this.heap[left]) < Convert.ToInt32(this.heap[rigth])){
                        return rigth;
                    }
                }
                return left;
            }
        }


        private void resize(){
            object[] aux = new object[heap.Length * 2];
            this.heap.CopyTo(aux, 0);
            this.heap = aux;
        }

        private bool isValid(int index){
            return index >= 0 && index <= this.tail;
        }

        private bool isLeaf(int index){
            return index > parent(this.tail) && index <= tail;
        }

        private void swap(int index, int index2){
            object aux = this.heap[index];
            this.heap[index] = this.heap[index2];
            this.heap[index2] = aux;
        }

        public void print(){
            for(int i = 0; i <= this.tail; i++){
                Console.WriteLine(this.heap[i]);
            }
        }

    }
}