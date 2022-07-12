using Lista;
// See https://aka.ms/new-console-template for more information


// This is the main entry point of the application.
ListaDLL lista = new ListaDLL();

lista.add(1); //rank0
lista.add(2); //rank1
lista.add(3); //rank2
lista.add(4); //rank3
lista.add(5); //rank4
lista.add(6); //rank5
lista.add(7); //rank6
lista.add(8); //rank7
lista.add(9); //rank8
lista.add(10);//rank9

Console.WriteLine(lista.size());
Console.WriteLine(lista.elemAtRank(2));
lista.replaceElement(2, 5);
Console.WriteLine(lista.elemAtRank(2));
Console.WriteLine(lista.before(5));
Console.WriteLine(lista.after(1));
