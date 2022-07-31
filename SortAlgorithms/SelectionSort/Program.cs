// See https://aka.ms/new-console-template for more information

var list = new[] {10,80,30,90,40,50,70,10 };

SelectionSort.SelectionSort selectionSort = new SelectionSort.SelectionSort(list);

selectionSort.SelectionSortAlgorithm();

foreach (var element in selectionSort.GetList())
{
    Console.Write(element + " ");
}