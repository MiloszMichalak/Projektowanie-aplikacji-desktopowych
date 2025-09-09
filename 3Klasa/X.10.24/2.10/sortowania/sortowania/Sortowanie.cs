using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowania
{
    internal class Sortowanie
    {
        public static int[] BubbleSort(int[] arr)
        {

        }

        public static int[] HoareSort(int[] nums)
        {

        }using System.Collections.Generic;

namespace sortowania
    {
        internal class Sortowanie
        {
            public static int[] BubbleSort(int[] arr)
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
                return arr;
            }

            public static int[] HoareSort(int[] arr, int low, int high)
            {
                Stack<int[]> stack = new Stack<int[]>();
                stack.Push(new int[] { low, high });

                while (stack.Count != 0)
                {
                    int[] range = stack.Pop();
                    int start = range[0];
                    int end = range[1];

                    if (start >= end) continue;

                    int pivot = arr[start];
                    int left = start - 1;
                    int right = end + 1;

                    while (true)
                    {
                        do
                        {
                            left++;
                        } while (arr[left] < pivot);

                        do
                        {
                            right--;
                        } while (arr[right] > pivot);

                        if (left >= right) break;

                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                    }

                    stack.Push(new int[] { start, right });
                    stack.Push(new int[] { right + 1, end });
                }

                return arr;
            }

            public static int[] LomutoSort(int[] arr, int low, int high)
            {
                Stack<int[]> stack = new Stack<int[]>();
                stack.Push(new int[] { low, high });
                int temp = 0;

                while (stack.Count != 0)
                {
                    int[] range = stack.Pop();
                    int start = range[0];
                    int end = range[1];

                    if (start >= end) continue;

                    int pivot = arr[end];
                    int i = start - 1;

                    for (int j = start; j < end; j++)
                    {
                        if (arr[j] < pivot)
                        {
                            i++;
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }

                    temp = arr[i + 1];
                    arr[i + 1] = arr[end];
                    arr[end] = temp;

                    stack.Push(new int[] { start, i });
                    stack.Push(new int[] { i + 2, end });
                }

                return arr;
            }
        }
    }

    public static int[] LomutoSort(int[] nums)
        {

        }
    }
}
