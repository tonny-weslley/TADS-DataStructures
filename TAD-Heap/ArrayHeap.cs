namespace heap
{
    public class ArrayHeap{

        private object[] heap;
        private object tail;


        public ArrayHeap(int t){
            this.heap = new object[t];
            this.tail = -1;
        }

        public boolean isEmpty(){
            return this.tail == -1;
        }

        public object left(int index){
            return 2 * index + 1;
        }

        public object right(int index){
            return 2 * (index + 1);
        }

        public object parent(int index){
            return (index-1)/2;
        }

        public void add(object element){
            // Se o array estiver cheio
            if( tail >= (heap.lenth -1)){
                this.resize()
            }

            tail ++;
            this.heap[tail] = element

            int i = tail;
            //caso o objeto inserido for maio que seu pai, devem trocar de lugar
            while(i > 0 && this.heap[parent(i)] < this.heap[i] ){
                //variavel que auxilia a troca
                aux = this.heap[i]
                this.heap[i] = this.heap[parent(i)]
                this.heap[parent(i)] = aux;
                i = parent(i);
            }

        }

        public element remove(){
            if(isEmpty()){
                Console.WriteLine("tá vazio brow");
                return null;
            }

            object element = this.heap[0]// prepara o primeiro elemento do array a ser retornado
            this.heap[0] = this.heap[this.tail]
            this.tail --;

            this.heapify(0);

            return element;


        }


        private void heapify(int index){
            //verificar se possui filhos, caso não possua não há o que fazer
            //verifica se o indice é valido
            if(isValid(index) || !isLeaf(index)){
                return;
            }

            object max_index = compareMax(index, left(index), right(index));

            if(max_index != index){
                swap(index, max_index);
                heapify(max_index);
            } 
        }

        private element compareMax(int index, int left, int rigth){
            if(this.heap[index] > this.heap[left]){
                if(isValid(rigth)){
                    if(this.heap[index] < this.heap[right] ){
                        return right;
                    }
                }
                return index;
            }else{
                if(isValid(rigth)){
                    if(this.heap[left] < this.heap[right] ){
                        return right;
                    }
                }
                return left;
            }
        }


        private void resize(){
            aux = object[heap.lenth * 2];
            this.heap.copyTo(aux, 0);
            this.heap = aux;
        }

        private boolean isValid(int index){
            return index >= 0 && index <= this.tail;
        }

        private boolen isLeaf(int index){
            return index > parent(this.tail) && index <= tail;
        }

        private void swap(int index, int index2){
            aux = this.heap[index]
            this.heap[index] = this.heap[index2]
            this.heap[index2] = aux;
        }

    }
    }