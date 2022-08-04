using Tree;
using System.Collections;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Arvore a1 = new Arvore(1);
a1.addChild(a1.Root(), 2);
a1.addChild(a1.Root(), 3);
NodeTree node = a1.addChild(a1.Root(), 4);
a1.addChild(a1.Root(), 5);
a1.addChild(node, 6);

IEnumerator filhosRoot = a1.children(a1.Root());

IEnumerator filhos4 = a1.children(node);


while (filhosRoot.MoveNext())
{
    NodeTree x = (NodeTree)(filhosRoot.Current);
    int z = (int)x.Value;
    Console.WriteLine(">" + z);
}

Console.WriteLine("filho do 4");

while (filhos4.MoveNext())
{
    NodeTree x = (NodeTree)(filhos4.Current);
    int z = (int)x.Value;
    Console.WriteLine(">" + z);
}

