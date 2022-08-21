using heap;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ArrayHeap arrayHeap = new ArrayHeap(1);
arrayHeap.add(1);
arrayHeap.add(2);
arrayHeap.add(3);
arrayHeap.add(4);
arrayHeap.add(7);
arrayHeap.add(6);
arrayHeap.print();
Console.WriteLine("========");
Console.WriteLine((int)arrayHeap.remove());
Console.WriteLine("=========");
arrayHeap.print();