using System;

class Bubble {
    static void BubbleSort(int[] arr) {
        int n = arr.Length;
        bool swapped;
        
        for (int i = 0; i < n - 1; i++) {
            swapped = false;
            for (int j = 0; j < n - 1 - i; j++) {  // Reduce range as largest element is added to the last
                if (arr[j] > arr[j + 1]) {
                    // Swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            // If no swaps occurred in the entire pass , break early
            if (!swapped) break;
        }
    }

    static void Display(int[] arr) {
        foreach (int num in arr) {
            Console.Write(num + "  ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args) {
        int[] marks = { 45, 23, 98, 67, 44, 90 };
        BubbleSort(marks);
        Display(marks);
    }
}
