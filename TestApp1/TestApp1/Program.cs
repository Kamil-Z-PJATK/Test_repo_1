﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
int x=15;
int y = 44;
Console.WriteLine(x);
Console.WriteLine(x+y);
Main([]);
 static void Main(string[] args)
{
    
    List<int> l1 = new List<int>{1,2,3,4,5,6,7,8,9,10};
   Console.WriteLine(avg(l1)) ;
   Console.WriteLine(max(l1));

}

static double avg(List<int> l1)
{
    double sum1 = 0;
    for (int i = 0; i < l1.Count; i++)
    {
       
        sum1 += l1[i];
    }
    return sum1/l1.Count;
}

static int max(List<int> l1)
{
    return l1.Max();
}

static void crazy_fun()
{
    Console.WriteLine("Wanna know how I got these scars?");
}
