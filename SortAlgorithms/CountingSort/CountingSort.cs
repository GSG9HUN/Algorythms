namespace CountingSort;

public class CountingSort
{
    private int[] _list;

    public CountingSort(int[] list)
    {
        _list = list;
    }

    public void CountingSortAlgorithm()
    {
        int[] array = CountDifferentElements();
        int j = 0;
        for (int i=0 ; i<array.Length;i++)
        {
            if (array[i] <= 0) continue;
            do
            {
                _list[j] = i;
                j++;
                array[i]--;
            } while (array[i] > 0);
        }
    }

    private int[] CountDifferentElements()
    {
       
        var max =_list.Max();
        int[] array = new int[max+1];
        foreach (var element in _list)
        {
            array[element]++;
        }


        return array;
    }


    public int[] GetList()
    {
        return _list;
    }
}