using Sequence;
// See https://aka.ms/new-console-template for more information

Console.WriteLine("======Classe de teste para o TAD Sequencia======\n");

Sequencia seq = new Sequencia(); //instanciando sequencia

Console.WriteLine("A lista está inicialmente vazia ? {0}, Com o total de {1} elementos", seq.isEmpty(), seq.size());
//inserindo elementos na sequencia
Console.WriteLine("Adicionando elementos na lista..");
seq.insertLast(1);
seq.insertLast(2);
seq.insertLast(3);
seq.insertLast(4);
seq.insertFirst(0);

Console.WriteLine("A lista está vazia ? {0}", seq.isEmpty());

seq.show();

Console.WriteLine("A lista agora tem {0} elementos\nSeu primeiro elemento é {1} e seu ultimo elemento é {2}", seq.size(), seq.first(), seq.last());

//testando o metodo elementAtRank()
Console.WriteLine("\nO elemento no rank 2 é {0}", seq.elementAtRank(2));

//testando o metodo replaceElementAtRank() e mostrando o resultado
seq.replaceAtRank(2, 5);
Console.WriteLine("\nO elemento no rank 2 é {0}", seq.elementAtRank(2));
seq.show();

//testando o metodo insertAtRank() e mostrando o resultado

Console.WriteLine("\nInserindo 8 no rank 3");
seq.insertAtRank(3, 8);
seq.show();

//testando o metodo removeAtRank() e mostrando o resultado
Console.WriteLine("\nRemovendo elemento no rank 3");
seq.removeAtRank(3);
seq.show();
//testando o metodo before e after e mostrando o resultado
Console.WriteLine("\nO elemento que vem antes de {0} é {1}, e o que vem depois é o {2}", 5, seq.before(5), seq.after(5));
seq.replaceElement(5, 9);
seq.show();

//testando o metodo swapElements() e mostrando o resultado
Console.WriteLine("\nTrocando a posição de {0} e {1}", 0, 3);
seq.swapElements(0, 3);
seq.show();

//testando o metodo insertBefore() e mostrando o resultado
Console.WriteLine("\nInserindo {0} antes de {1}", 80, 0);
seq.insertBefore(0, 80);
seq.show();


//testando o metodo insertAfter() e mostrando o resultado
Console.WriteLine("\nInserindo {0} depois de {1}", 44, 80);
seq.insertAfter(80, 44);
seq.show();


//Adicinando 10 elementos na sequencia
