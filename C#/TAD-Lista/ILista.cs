namespace Lista
{
    public interface ILista
    {
        bool isEmpty();
        int size();
        object elemAtRank(int pos);
        object removeAtRank(int pos);
        object replaceAtRank(int pos, object novo);
        bool isFirst();
        bool isLast();
        object first();
        object last();
        object before(int pos);
        object after(int pos);
        void insertBefore(int pos, object novo);
        void insertAfter(int pos, object novo);
        void replaceElement(int pos, object novo);
        void swapElements(int pos1, int pos2);
        void insertFirst(object novo);
        void insertLast(object novo);
        void remove(int pos);
        
    }
}