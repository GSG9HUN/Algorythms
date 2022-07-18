using BinarySearch;

int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var container = new Container(list, 5);


var result = container.BinarySearch();

Console.WriteLine(result != -1
    ? string.Concat("Az elem a ", result, " indexen található")
    : "Az elem nem található meg a listában");