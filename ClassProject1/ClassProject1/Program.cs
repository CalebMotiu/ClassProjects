namespace ClassProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadNumber("No. of elements=", 3);
            int[] array = new int[n];
            for (int i = 0; i < n; i++) 
            {
                array[i] = ReadNumber($"Element at index {i}=", 1);
            }

         string elements = string.Join(",", array);
            Console.WriteLine("Arrays=" + elements);
            int min = Min(array);
            Console.WriteLine($"Min element={min}");

            int[] sortedArray = SelectionSort(array);
            string sortedElements = string.Join(",", array);
            Console.WriteLine("Sorted Array=" + sortedElements);
        }


        static int ReadNumber(string label, int maxAttempts)
        {
            int attempts = 1;
            do
            {
                Console.Write(label);
                string input = Console.ReadLine();
                bool isValidNumber = (int.TryParse(input, out int result));

                if (isValidNumber)
                {
                    return result;
                }

                if (attempts < maxAttempts)
                {
                    Console.WriteLine($"Value '{input}' is not valid number, please try again.");
                }
                 attempts++;
            } while (attempts <= maxAttempts);

            Console.WriteLine($"no valid numeric input, number = 0");
            return 0;
            
        }

        static int Min(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array),
                    "Cannot calculate min vlaue of null array");
            }

            if (array.Length == 0)
            {
                throw  new ArgumentException(nameof(array),
                    "Cannot calculate min value of an empty array");
            }

            int min = array[0];
            for (int i=0; i < array.Length; i++) 
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
            
        public static int[] SelectionSort(int[] array)
        {
            if (array is null)
            { 
                throw new ArgumentNullException(nameof(array),
                    "Cannot sort a null array.");            
            }

            if (array.Length == 0)
            {
                throw new ArgumentException ("Cannot sort an empty array",nameof(array));
            }

            for (int i = 0; i < array.Length -1;i++ )
            {
                for (int j = i+1;j < array.Length;j++) 
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }

}