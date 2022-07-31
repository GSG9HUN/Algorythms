namespace SelectionSort;

public class SelectionSort
{
    private int[] _list;

    public SelectionSort(int[] list)
    {
        _list = list;
    }

    public void SelectionSortAlgorithm()
    {
        for (var i = 0; i < _list.Length-1; i++)
        {

            var minIndex = i;
            int j;
            for (j = i+1 ; j < _list.Length; j++)
            {
                if (_list[minIndex] > _list[j])
                {
                    minIndex = j;
                }
            }

            (_list[minIndex],_list[i]) =(_list[i],_list[minIndex]);

        }
    }
    public int[] GetList()
    {
        return _list;
    }
}