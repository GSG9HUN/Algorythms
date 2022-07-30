// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int[] list = new[] {10,80,30,90,40,50,70 };
QuickSort.QuickSort sort = new QuickSort.QuickSort(list);

sort.QuickSortAlgorithm(0,list.Length-1);


foreach (var element in sort.List)
{
    Console.Write(element+" ");
}