namespace Vetor
{
    interface IVetor
    {
        public object ElemAtRank(int pos);

        public object RemoveAtRank(int pos);

        public object ReplaceAtRank(int pos, object novo);

        public void InserAtRank(int pos, object novo);

        public bool IsEmpty();
    }
}