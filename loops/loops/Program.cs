﻿//check number is positive, negative or neutral
/*
//Console.Write("Enter value of n: ");
//int input = Convert.ToInt32(Console.ReadLine());
//if (input > 0)
//{
//    Console.Write("Number is positive");
//}
//else if (input == 0)
//{
//    Console.WriteLine("Number is neutral");
//}

//else
//{
//    Console.Write("Number is negative");
//}
*/ //Code by @Vishnu

//---------------------------Interesting question---------------------------
/*
//int a = 24;
//if( a > 20) Console.WriteLine("Love");
//else if(a == 24) Console.WriteLine("Happy");
//else
//{
//    Console.WriteLine("Sad");
//}
*/ //Code by @Vishnu

// ----------------------Find if value is lower or upper or numeric -------------------
/*
//string ch = Console.ReadLine();
//int ch1 = int.Parse(ch);
//if( ch1.Equals(ch1) )
//{
//    Console.WriteLine("Numeric");
//}
*/ //Code by @Vishnu

//----------------------- 1 2 3 4
//1 2 3 4
//1 2 3 4
//1 2 3 4
//1 2 3 4
/*
int n = 4, i = 1;
while (i <= n)
{
    int j = 1;
    while (j <= n)
    {
        Console.Write($" " + j);
        j++;
    }
    Console.WriteLine();
    i++;
}
*///Code by @Vishnu

//---------------------- 3 2 1
//3 2 1 
//3 2 1 
//3 2 1 

/*
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= n)
{
    int j = 1;
    while (j <= n)
    {
        Console.Write( n - j + 1 + " ");
        j++;
    }
    Console.WriteLine();
    i++;
}
*/ //Code by @Vishnu

//------------------------ 123
//1 2 3
//4 5 6
//7 8 9
/*
int n = Convert.ToInt32(Console.ReadLine());
int i = 1, count = 1;
while (i <= n)
{
    int j = 1;
    while (j <= n)
    {
        Console.Write(count + " ");
        count++;
        j++;
    }
    Console.WriteLine();
    i++;
}
*/ //Code by @Vishnu

//------------------------ *
//*
//* *
//* * *
//* * * *

/*
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while( i<= n)
{
    int j = 1;
    while(j <= i)
    {
        Console.Write("*" + " ");
        j++;
    }
    Console.WriteLine();
    i++;
}

*/ //Code by @Vishnu

//------------------------ 1
//1
//2 2
//3 3 3
//4 4 4 4
/*
int n = Convert.ToInt32(Console.ReadLine());
int row = 1;
while(row <= n)
{
    int column = 1;
    while(column <= row)
    {
        Console.Write(row + " ");
        column++;
    }
    Console.WriteLine();
    row++;
}
*/ //Code by @Vishnu

//------------------------ 1
//1
//2 3
//4 5 6 7
//8 9 10 11
/*
int n = Convert.ToInt32(Console.ReadLine());    
int row = 1, count = 1;
while(row <= n)
{
    int column = 1;
    while(column <= row)
    {
        Console.Write(count + " ");
        count++;
        column++;
    }
    Console.WriteLine();
    row++;
}
*/ //Code by @Vishnu

//------------------------ 1
//1
//2 3
//3 4 5
//4 5 6 7

int n = Convert.ToInt32(Console.ReadLine());
int row = 1, count = 1;
while(row <= n)
{
    int column = 1;
    while(column <= row)
    {
        Console.Write(count + " ");
        count++;
        column++;
    }
    Console.WriteLine();
    row++;
}

 //Code by @Vishnu