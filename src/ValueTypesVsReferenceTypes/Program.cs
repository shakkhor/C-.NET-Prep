﻿class Program
{
    static void Main(string[] args)
    {
        //int is a value type
        int a = 5;
        Console.WriteLine($"Number is {a}");
        AddOne(a);
        Console.WriteLine($"Now number is {a}\n");

        //List<int> is a reference type
        var list = new List<int>();
        Console.WriteLine($"List contains {list.Count} elements");
        AddOneToList(list);
        Console.WriteLine($"Now list contains {list.Count} elements\n");

        //base types for value types and reference types
        Console.WriteLine($"int's base type is {typeof(int).BaseType}");
        Console.WriteLine($"List<int>'s base type is {typeof(List<int>).BaseType}\n");

        //for value types, a copy is created on assignment
        int b = 10;
        int c = b;
        ++c;
        Console.WriteLine($"Number 'b' is {b}");
        Console.WriteLine($"Number 'c' is {c}\n");

        //for reference types, only the reference is copied
        //The variable points to the same object
        List<int> listB = new List<int> { 1, 2, 3 };
        List<int> listC = listB;
        listC.Add(4);
        Console.WriteLine($"listB contains {listB.Count} elements");
        Console.WriteLine($"listC contains {listC.Count} elements\n");

        Console.ReadKey();
    }

    private static void AddOne(int a)
    {
        a++;
    }
    private static void AddOneToList(List<int> list)
    {
        list.Add(1);
    }
}