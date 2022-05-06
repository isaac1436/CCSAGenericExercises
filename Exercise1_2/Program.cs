namespace Exercise1_2
{
    public class Exercise1_2
    {
        static int length;
        static void Main()
        {
            GenericMethods.mainProgram<string>();
        }
    }
    public class GenericMethods
    {
        public static void mainProgram<T>()
        {
            Console.Write("How long is your array going to be: ");
            int length = int.Parse(Console.ReadLine());
            T[] list = new T[length];

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"Enter element [{i+1}]: ");
                list[i] = (T)((object)(Console.ReadLine()));
            }

            ReverseArray(list);

            LastElement(list);
        }

        private static void ReverseArray<T>(T[] arr)
        {
            Console.WriteLine("\nThe array in reverse is: ");
            for (int i = arr.Length - 1, j = 0; i >= 0; i--, j++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        private static void LastElement<T>(T[] arr)
        {
            T lastElement = arr[arr.Length - 1];

            Console.WriteLine($"\nThe total count is {arr.Length} and the last element is {lastElement}");
        }

    }
}