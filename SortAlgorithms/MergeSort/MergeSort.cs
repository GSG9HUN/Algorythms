namespace MergeSort;

public class MergeSort
{
    private int[] _list;
    public MergeSort(int[] list)
    {
        _list = list;
    }

    public void MergeSortAlgorithm(int leftSideIndex,int rightSideIndex)
    {
      
        if (leftSideIndex >= rightSideIndex) return;
        var mid = leftSideIndex + (rightSideIndex - leftSideIndex) / 2;
        MergeSortAlgorithm(leftSideIndex,mid);
        MergeSortAlgorithm(mid+1,rightSideIndex);
        Merge(leftSideIndex,mid,rightSideIndex);
    }


    private void Merge(int leftSideIndex ,int mid, int rightSideIndex)
    {
        //ez szívás
        throw new NotImplementedException();

    }
    public int[] GetList()
    {
        return _list;
    }
}