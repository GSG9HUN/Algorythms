// See https://aka.ms/new-console-template for more information



var list = new[] {10,80,30,90,40,50,70 };
MergeSort.MergeSort mergeSort = new MergeSort.MergeSort(list);

mergeSort.MergeSortAlgorithm(0,list.Length-1);


foreach (var element in mergeSort.GetList())
{
    Console.Write(element+" ");
}