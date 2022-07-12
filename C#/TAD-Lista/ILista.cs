namespace Lista
{
    public interface ILista
    {
        bool isEmpty();
        int size();
        bool isFirst(object element);
        bool isLast(object element);
        object first();
        object last();
        object before(int pos);
        object after(int pos);
        object elemAtRank(int pos);
        object removeAtRank(int pos);
        object replaceAtRank(int pos, object novo);
        void swapElements(int pos1, int pos2);
        void insertBefore(int pos, object novo);
        void insertAfter(int pos, object novo);
        void replaceElement(int pos, object novo);
        void insertFirst(object novo);
        void insertLast(object novo);
        void remove(int pos);

    }
}