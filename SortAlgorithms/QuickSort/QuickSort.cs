namespace QuickSort;

public class QuickSort
{
    public int[] List { get; }

    public QuickSort(int[] list)
    {
        List = list;
    }

    public void QuickSortAlgorithm(int low, int high)
    {
        if (low >= high) return;
        var pi = Partition(low, high);
            
        QuickSortAlgorithm(low,pi-1);
        QuickSortAlgorithm(pi+1,high);

    }

    private int Partition(int low, int high)
    {
        var pivot = List[high];
        var i = low - 1;
        int temp;
        for (var j = low; j <= high; j++)
        {
            if (List[j] >= pivot) continue;
            i++;

            temp = List[i];
            List[i] = List[j];
            List[j] = temp;
        }

        temp = List[i + 1];
        List[i+1]= List[high];
        List[high] = temp;
        
        return i+1;
    }

}