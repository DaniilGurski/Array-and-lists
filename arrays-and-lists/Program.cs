internal class Program
{
    private static void Main(string[] args)
    {
        // Assigment 1
        // int[] numbers = new int[5];

        // Console.WriteLine("Enter 5 numbers.");
        
        // for (int i = 1; i <= numbers.Length; i++) {
        //     Console.Write($"Enter {i}: ");
        //     int number = Convert.ToInt32(Console.ReadLine());
        //     numbers[i - 1] = number;
        // }

        // Array.Reverse(numbers);

        // foreach(int number in numbers) {
        //     Console.Write(number + " ");
        // }

        // Assigment 2
        // int[] array1 = {1, 2, 3};
        // int[] array2 = {4, 5, 6, 7};
        // int[] array3 = {8, 2, 10};

        // int res1 = 0;
        // int res2 = 0;
        // int res3 = 0;

        // foreach(int num in array1) {
        //     res1 += num; 
        // }
        // foreach(int num in array2) {
        //     res2 += num; 
        // }
        // foreach(int num in array3) {
        //     res3 += num; 
        // }

        // res1 /= array1.Length;
        // res2 /= array2.Length;
        // res3 /= array3.Length;

        // Console.WriteLine(res1);
        // Console.WriteLine(res2);
        // Console.WriteLine(res3);


        // Assigment 3
        // int[] nums = {1, 2, 3, 4, 5, 6, 7, 8};
        // List<int> even = new List<int>();
        // List<int> odd = new List<int>();


        // for (int index = 0; index < nums.Length; index++) {
        //     int num = nums[index]; 

        //     if (num % 2 == 0) {
        //         even.Add(num);
        //     } else {
        //         odd.Add(num);
        //     }
        // }

        // Console.WriteLine("Even: ");
        // foreach(int num in even) {
        //     Console.WriteLine(num); 
        // }

        // Console.WriteLine("Odd: ");
        // foreach(int num in odd) {
        //     Console.WriteLine(num); 
        // }


        // Assigment 4
        // Console.Write("Multiplication table length: ");
        // int length = Convert.ToInt32(Console.ReadLine());
        // int[,] table = new int[length, length];

        // for (int i = 1; i <= length; i++) {
        //     for (int j = 1; j <= length; j++)
        //     {
        //         table[i - 1, j - 1] = i * j;
        //     }
        // }

        // Console.WriteLine("\nMultiplication table:");
        // for (int i = 0; i < length; i++)
        // {
        //     for (int j = 0; j < length; j++)
        //     {
        //         Console.Write(table[i, j] + "\t");
        //     }
        //     Console.WriteLine();
        // }

        // Console.WriteLine("\n");


        // Assigment 5
        // int[] nums = {1, 2, 3, 4, 5};
        // int nextMax = 0; 
        // int max = 0;

        // // Find the max number
        // foreach (int num in nums) {
        //     if (num > max) {
        //         max = num;
        //     } 
        // }

        // // Find the next biggest number
        // foreach (int num in nums) {
        //     if (num > nextMax && num < max) {
        //         nextMax = num;
        //     }
        // }

        // Console.WriteLine(nextMax);


        // Assigment 6
        int[] nums = {5, 3, 1, 8, 9}; 

        // search scope
        for (int i = 0; i < nums.Length - 1; i++) {
            // index
            for (int j = 0; j < nums.Length - 1 - i; j++) {
                int num1 = nums[j];
                int num2 = nums[j + 1]; 

                if (num1 > num2) {
                    int temp = nums[j];
                    nums[j] = nums[j + 1]; 
                    nums[j + 1] = temp;
                }
            }
        }

        foreach (int num in nums) {
            Console.Write(num + ", ");
        }
    }
}