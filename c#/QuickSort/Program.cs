// yet not working

// load data from file
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Net.WebSockets;

var data = File.ReadAllLines("../../Data/1k.txt");

// convert to int[]
var input = Array.ConvertAll(data, int.Parse);

// Quicksort O(n^2)
// Like Merge Sort, QuickSort is a Divide and Conquer algorithm. 
// It picks an element as pivot and partitions the given array 
// around the picked pivot. There are many different 
// versions of quickSort that pick pivot in different ways. 

// Always pick first element as pivot.
// Always pick last element as pivot
// Pick a random element as pivot.
// Pick median as pivot.
var testInput = input.Take(10).ToArray();

int n = testInput.Length;
quickSort(ref testInput, 0, n - 1);

foreach (var item in testInput) Console.WriteLine(item);

void quickSort(ref int[] arr, int low, int high)
{
    if (low < high)
    {
        var pi = partiion(ref arr, low, high);

        quickSort(ref arr, low, pi - 1);
        quickSort(ref arr, pi + 1, high);
    }
}

int partiion(ref int[] arr, int low, int high)
{
    int pivot = arr[high];

    int i = low - 1;

    for (int j = low; j < high - 1; j++)
    {
        if (arr[j] < pivot)
        {
            i++;
            swap(ref arr, i, j);
        }
    }
    swap(ref arr, i + 1, high);
    return i + 1;
}

void swap(ref int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}