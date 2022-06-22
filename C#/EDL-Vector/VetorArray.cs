namespace Vetor
{

    class VetorArray : IVetor
    {
        private object[] lista;
        int n;

        //construtor
        public VetorArray()
        {
            lista = new object[1];
            n = 0;
        }



        //isEmpty
        public bool IsEmpty()
        {
            return n == 0;
        }

        //ElemAtRank
        public object ElemAtRank(int pos)
        {
            if(IsEmpty())
            {
                throw new VetorException("Vetor vazio");
            }else{
                return lista[pos];
            }
            
        }

        //RemoveAtRank
        public object RemoveAtRank(int pos)
        {
            if(IsEmpty())
            {
                throw new VetorException("Vetor vazio");
            }else{
                object aux = lista[pos];
                for(int i = pos; i < this.n-1; i++)
                {
                    lista[i] = lista[i+1];
                }
                this.n--;
                this.lista[n] = null;
                return aux;
            }
        }

        //ReplaceAtRank
        public object ReplaceAtRank(int pos, object novo)
        {
            if(IsEmpty())
            {
                throw new VetorException("Vetor vazio");
            }else{
                object aux = lista[pos];
                lista[pos] = novo;
                return aux;
            }
        }

        //InserAtRank
        public void InserAtRank(int pos, object novo)
        {
            if(IsEmpty())
            {
                this.lista[0] = novo;
                this.n++;
            }else{
                if(pos == n)
                {
                    this.lista[n] = novo;
                    this.n++;
                }else{
                    for(int i = n; i > pos; i--)
                    {
                        this.lista[i] = this.lista[i-1];
                    }
                    this.lista[pos] = novo;
                    this.n++;
                }
            }
        }
    }

}