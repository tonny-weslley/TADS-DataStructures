namespace Sequencia{


    bool isEmpty();
    int size();
    object elementAtRank(int rank);
    void replaceElementAtRank(int rank , object element);
    void insertAtRank(int rank, object element);
    void removeAtRank(int rank);
    object first();
    object last();
    object before(LinkedListNode<object> node);
    object after(LinkedListNode<object> node);
    void replaceElement(LinkedListNode<object> node, object novo);
    void swapElements(LinkedListNode<object> node, object element);
    void insertBefore(LinkedListNode<object> node, object element);
    void insertAfter(LinkedListNode<object> node, object element);
    void insertFirst(object element);
    void insertLast(object element);
    void remove(LinkedListNode<object> node);

    void atRank(int rank);
    void rankOf(LinkedListNode<object> node);


}