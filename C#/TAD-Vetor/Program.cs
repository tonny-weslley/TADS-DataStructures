using Vetor;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

VetorDLL vetor = new VetorDLL();

//testing insert at rank
vetor.InserAtRank(0, "teste");
vetor.InserAtRank(1, "teste2");
vetor.InserAtRank(2, "teste3");
vetor.InserAtRank(3, "teste4");
vetor.InserAtRank(4, "teste5");
vetor.InserAtRank(5, "teste6");
vetor.InserAtRank(6, "teste7");

//testing elem at rank
Console.WriteLine(vetor.ElemAtRank(0));
Console.WriteLine(vetor.ElemAtRank(1));
Console.WriteLine(vetor.ElemAtRank(2));
Console.WriteLine(vetor.ElemAtRank(3));
Console.WriteLine(vetor.ElemAtRank(4));
Console.WriteLine(vetor.ElemAtRank(5));
Console.WriteLine(vetor.ElemAtRank(6));

Console.WriteLine("====Removendo elementos (removeAtRank)====");
//testing remove at rank
Console.WriteLine(vetor.RemoveAtRank(0));
Console.WriteLine(vetor.RemoveAtRank(1));
Console.WriteLine(vetor.RemoveAtRank(2));

//testing replace at rank
vetor.InserAtRank(0, "teste");
vetor.InserAtRank(1, "teste2");
vetor.InserAtRank(2, "teste3");
vetor.InserAtRank(3, "teste4");
Console.WriteLine("====Rearranjando elementos ( replaceAtRank)====");
vetor.ReplaceAtRank(0, "teste5");
vetor.ReplaceAtRank(1, "teste6");
vetor.ReplaceAtRank(2, "teste7");

//showing the vector
Console.WriteLine(vetor.ElemAtRank(0));
Console.WriteLine(vetor.ElemAtRank(1));
Console.WriteLine(vetor.ElemAtRank(2));


Console.WriteLine("\n\n================\nTestando Vetor com Array");

VetorArray vetor2 = new VetorArray();

//testing insert at rank
vetor2.InserAtRank(0, "teste");
vetor2.InserAtRank(1, "teste2");
vetor2.InserAtRank(2, "teste3");
vetor2.InserAtRank(3, "teste4");
vetor2.InserAtRank(4, "teste5");
vetor2.InserAtRank(5, "teste6");
vetor2.InserAtRank(6, "teste7");

//testing elem at rank
Console.WriteLine(vetor2.ElemAtRank(0));
Console.WriteLine(vetor2.ElemAtRank(1));
Console.WriteLine(vetor2.ElemAtRank(2));
Console.WriteLine(vetor2.ElemAtRank(3));
Console.WriteLine(vetor2.ElemAtRank(4));
Console.WriteLine(vetor2.ElemAtRank(5));
Console.WriteLine(vetor2.ElemAtRank(6));

Console.WriteLine("====Removendo elementos (removeAtRank)====");
//testing remove at rank
Console.WriteLine(vetor2.RemoveAtRank(0));
Console.WriteLine(vetor2.RemoveAtRank(1));
Console.WriteLine(vetor2.RemoveAtRank(2));

//testing replace at rank
vetor2.InserAtRank(0, "teste");
vetor2.InserAtRank(1, "teste2");
vetor2.InserAtRank(2, "teste3");
vetor2.InserAtRank(3, "teste4");

Console.WriteLine("====Rearranjando elementos ( replaceAtRank)====");
vetor2.ReplaceAtRank(0, "teste5");
vetor2.ReplaceAtRank(1, "teste6");
vetor2.ReplaceAtRank(2, "teste7");

Console.WriteLine(vetor2.ElemAtRank(0));
Console.WriteLine(vetor2.ElemAtRank(1));
Console.WriteLine(vetor2.ElemAtRank(2));
