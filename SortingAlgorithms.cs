using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms
{
    public static class SortingAlgorithms
    {
        #region Insertion Sort
        public static void insertionSort(this int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            Console.WriteLine("Insertion Sort:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Selection Sort

        public static void selectionSort(this int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine("Selection Sort:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Bubble Sort
        public static void bubbleSort(this int[] arr)
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
            Console.WriteLine("Bubble Sort:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Merge Sort
        public static void mergeSort(this int[] arr)
        {
            if (arr.Length <= 1)
                return;

            int[] left = new int[arr.Length / 2];
            int[] right = new int[arr.Length - left.Length];

            Array.Copy(arr, 0, left, 0, left.Length);
            Array.Copy(arr, left.Length, right, 0, right.Length);

            mergeSort(left);
            mergeSort(right);

            merge(left, right, arr);
        }

        private static void merge(int[] left, int[] right, int[] result)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                result[k++] = left[i++];
            }

            while (j < right.Length)
            {
                result[k++] = right[j++];
            }
            Console.WriteLine("Merge Sort:");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        #endregion

        #region Quick Sort
        public static void quickSort(this int[] arr)
        {
            quickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Quick Sort:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

        private static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }
        #endregion
    }
}
