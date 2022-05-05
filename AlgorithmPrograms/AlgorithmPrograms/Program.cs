using System;
using AlgorithmPrograms;
using AlgorithmPrograms.Utility;

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("welcome to the program");
        bool check=true;
        const string path = @"D:\PracticeProblem\AlgorithmPrograms\AlgorithmPrograms\AlgorithmPrograms\Utility\BinarySearchFile.txt";
        BinarySearch binary = new BinarySearch();
        const string path1 = @"D:\PracticeProblem\AlgorithmPrograms\AlgorithmPrograms\AlgorithmPrograms\Utility\IntegerFile.txt";
        InsertionSort sort = new InsertionSort();
        Console.WriteLine("1.Binary Search\n2.Insertion sort\n3.Bubble Sort");
        while(check)
        {
            Console.WriteLine("Take an option to execute");
            int opt=Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1:
                    string[] input_Array=File.ReadAllLines(path1);
                    Console.WriteLine("Enter a word to search");
                    string word=Console.ReadLine();
                    binary.Search(input_Array,word);
                    break;
                case 2:
                    string[] array = File.ReadAllLines(path1);
                    sort.Sort(array);
                    sort.Display(array);
                    break;
                case 3:
                    string[] arr = File.ReadAllLines(path1);
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.Sort(arr);
                    Console.WriteLine("Sorted array is {0}",arr);
                    break;
            }
        }
    }
}