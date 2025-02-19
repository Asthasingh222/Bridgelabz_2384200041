using System;
using System.Diagnostics;

class Program
{
    // Bubble Sort (O(N^2))
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Merge Sort (O(N log N))
    static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1) return;

        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        MergeSort(left);
        MergeSort(right);
        Merge(arr, left, right);
    }

    static void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] < right[j])
                arr[k++] = left[i++];
            else
                arr[k++] = right[j++];
        }

        while (i < left.Length)
            arr[k++] = left[i++];
        while (j < right.Length)
            arr[k++] = right[j++];
    }

    // Quick Sort (O(N log N))
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);

            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int swapTemp = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swapTemp;

        return i + 1;
    }

    static void Main()
    {
        int[] sizes = { 1000, 10000, 100000 };
        Random rand = new Random();

        foreach (var size in sizes)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
                data[i] = rand.Next(1, size);

            Console.WriteLine("Testing with dataset size: " + size);

            // Bubble Sort
            int[] bubbleData = (int[])data.Clone();
            Stopwatch stopwatch = Stopwatch.StartNew();
            BubbleSort(bubbleData);
            stopwatch.Stop();
            Console.WriteLine("Bubble Sort: " + stopwatch.ElapsedMilliseconds + "ms");

            // Merge Sort
            int[] mergeData = (int[])data.Clone();
            stopwatch.Restart();
            MergeSort(mergeData);
            stopwatch.Stop();
            Console.WriteLine("Merge Sort: " + stopwatch.ElapsedMilliseconds + "ms");

            // Quick Sort
            int[] quickData = (int[])data.Clone();
            stopwatch.Restart();
            QuickSort(quickData, 0, quickData.Length - 1);
            stopwatch.Stop();
            Console.WriteLine("Quick Sort: " + stopwatch.ElapsedMilliseconds + "ms");

            Console.WriteLine();
        }
    }
}
