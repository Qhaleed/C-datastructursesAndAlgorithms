



using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }


    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }







    public void introduce()
    {
        Console.WriteLine("Hello my name is " + Name);
        Console.WriteLine("And I am " + Age);
    }

 
}



class Program
{

    //static Person Add(string name, int age)
    //{
    //    Person newPerson = new Person(name, age);
    //    return newPerson;
    //}

    //static void Main()
    //{
    //    Console.WriteLine( "Enter your character name and age");

    //    string newUserName = Console.ReadLine();
    //    int newUserAge = Convert.ToInt32(Console.ReadLine());
    //    Person myCharacter = Add(newUserName, newUserAge);

    //    myCharacter.introduce();

    //}



    static void Main()
    {

        // Arrays in C#
        //int[] numbers = { 1, 2, 3, 4, 5, 6 };

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine((i + 1) + "." + numbers[i]);
        //}

        // Dynamic array in c#
        //List<string> names = new List<string> { "Res", "Shem" };
        //names.Add("bawbaw");
        //foreach (var n in names)
        //    Console.WriteLine(n);


        // Stacks

        //Stack<int> stack = new Stack<int>();

        //stack.Push(1);
        //stack.Push(2);
        //stack.Push(3);

        //foreach (var n in stack)
        //{
        //    Console.WriteLine(n);
        //}

        //Console.WriteLine("Remove the top ");
        //stack.Pop();
        //foreach (var n in stack)
        //{
        //    Console.WriteLine(n);
        //}


        // Sorting Alogrithm using bubble sort

        int[] num = { 54, 1, 2, 342, 5, 67 };


        // Now we need to bubble sort this shi
        foreach (var n in num)
            Console.WriteLine(n);

        for (int i = 0; i < num.Length - 1; i++)
        {
            for (int j = 0; j < num.Length - i - 1; j++)
            {
                if (num[j] > num[j+ 1])
                {
                    int temp = num[j + 1];
                    num[j + 1] = num[j];
                    num[j] = temp;
                }
                
            }
        }
        foreach (var n in num)
            Console.WriteLine(n);


    }
}

