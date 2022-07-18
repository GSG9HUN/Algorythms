namespace BinarySearch;

public class Container
{
    public Container(int[] list, int haveToFind)
    {
        List = list;
        HaveToFind = haveToFind;
        Low = 0;
        High = list.Length;
    }

    private int[] List { get; }

    private int HaveToFind { get; }

    private int Low { get; set; }
    private int High { get; set; }


    public int BinarySearch()
    {
        while (Low != High)
        {
            var mid = (Low + High) / 2;

            if (List[mid] == HaveToFind) return mid;

            if (List[mid] < HaveToFind)
                Low = mid+1;
            else
                High = mid;
        }

        return -1;
    }
}