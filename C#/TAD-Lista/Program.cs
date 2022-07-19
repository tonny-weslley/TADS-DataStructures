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


// ListaArray lista2 = new ListaArray();

// lista2.add(1);
// lista2.add(2);
// lista2.add(3);
// lista2.add(4);
// lista2.add(5);
// lista2.add(6);
// lista2.add(7);
// lista2.add(8);
// lista2.add(9);
// lista2.add(10);

// Console.WriteLine(lista2.size());
// Console.WriteLine(lista2.elementAtRank(2));
// foreach (var item in lista2)
// {
//     Console.WriteLine(item);
// }
// //lista2.raplaceElement(2, 5);
// Console.WriteLine(lista2.elementAtRank(2));
// Console.WriteLine(lista2.before(5));
// Console.WriteLine(lista.after(1));
