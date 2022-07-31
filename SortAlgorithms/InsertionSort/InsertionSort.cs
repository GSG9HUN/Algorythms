namespace InsertionSort;

public class InsertionSort
{
    private int[] _list;


    public InsertionSort(int[] list)
    {
        _list = list;
    }

    public void InsertionSortAlgorithm()
    {
        for (var i = 1; i < _list.Length; i++)
        {
            var k = i;
            for (var j = i-1; j > 0; j--)
            {
                if (_list[j] > _list[k])
                {
                    (_list[k], _list[j]) = (_list[j], _list[k]);
                    k--;
                }
            }
        }
    }
    

    public int[] GetList()
    {
        return _list;
    }
}