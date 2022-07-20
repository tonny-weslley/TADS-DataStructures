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
        void replaceElement(object node, object element);
        void swapElements(int pos1, int pos2);
        void insertBefore(int pos, object novo);
        void insertAfter(int pos, object novo);
        void insertFirst(object novo);
        void insertLast(object novo);
        void remove(int pos);

    }
}

/*

Mêtodos:
    Inscerção:
        insertBefore(int pos, object novo)
            Insere novo antes da posição pos
        insertAfter(int pos, object novo)
            Insere novo depois da posição pos
        insertFirst(object novo)
            Insere novo no início da lista
        insertLast(object novo)
            Insere novo no final da lista
    Remoção:
        remove(int pos)
            Remove o elemento da posição pos
    Substituição:
        replaceElement(int pos, object novo)
            Substitui o elemento da posição pos pelo novo
    Troca:
        swapElements(int pos1, int pos2)
            Troca os elementos da posição pos1 com a posição pos2
    Consulta:
        isEmpty()
            Retorna true se a lista estiver vazia
        size()
            Retorna o tamanho da lista
        isFirst(object element)
            Retorna true se o elemento estiver no início da lista
        isLast(object element)
            Retorna true se o elemento estiver no final da lista
        first()
            Retorna o primeiro elemento da lista
        last()
            Retorna o último elemento da lista
        before(int pos)
            Retorna o elemento anterior à posição pos
        after(int pos)
            Retorna o elemento posterior à posição pos
        elemAtRank(int pos)
            Retorna o elemento da posição pos
*/