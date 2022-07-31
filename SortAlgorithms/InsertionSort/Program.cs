// See https://aka.ms/new-console-template for more information

var list = new[] {10,80,30,90,40,50,70,10 };

InsertionSort.InsertionSort insertionSort = new InsertionSort.InsertionSort(list);

insertionSort.InsertionSortAlgorithm();

foreach (var element in insertionSort.GetList())
{
    Console.Write(element + " ");
}