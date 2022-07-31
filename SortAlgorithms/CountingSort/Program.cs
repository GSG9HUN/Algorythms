// See https://aka.ms/new-console-template for more information

var list = new[] {10,80,30,90,40,50,70,10 };

CountingSort.CountingSort countingSort = new CountingSort.CountingSort(list);

countingSort.CountingSortAlgorithm();

foreach (var element in countingSort.GetList())
{
    Console.Write(element+" ");
}