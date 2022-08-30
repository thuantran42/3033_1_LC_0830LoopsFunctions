// Thuan (Trae) Tran ID: 113437456
// August 30 2022 MIS 3033 001
// Loops and Functions

using System.Net.Security;

Console.WriteLine("Loops review\n"); // /n is new line

// for loop

//for ( 0; 1; 2)
//{
//    3
//}

//0 - 1 - 3 - 2 then 1 - 3 - 2 then 1 - 3 - 2....

int i = 10;
for (; ; i++) // i=i+1
{
    if (i > 20)
    {
        break; // stops the loop
    }

    if (i == 11 || i == 13) // if condition is met, it shall not print 11 and 13
    {
        
        continue; // escape the loop
        
    }
    // continue; //  (escapes the loop)
    Console.WriteLine(i);
    
    // you can also add i++ here if you want
}


// while (){}

Console.WriteLine("while loop results");

int sumOfNums;
sumOfNums = 0;
i = 20; // initialization
int numOfDeposit = 0; // initialized counter
while (i > 8)
{
    numOfDeposit++; // numOfDeposit = numOfDeposit + 1
    sumOfNums = sumOfNums + i;
    // same as sumOfNums += i;
    Console.WriteLine(i);
    i--; // i = i - 1

}
string outStr = string.Format($"The balance is {sumOfNums:C}"); // format specifier currency


Console.WriteLine(outStr);   
Console.WriteLine(numOfDeposit);
Console.WriteLine(sumOfNums*1.0/numOfDeposit);

Console.WriteLine(3/4);



// do {} while()

Console.WriteLine("do while loop results:\n");

i = 20;
do
{
    Console.WriteLine(i);
    i--;
}
while (i > 9);


// Functions method

// function syntax
// datatype1 functio_name(Datatype var1, DataType var2,....)
// {
//
// return datatype1_value;
// }

Console.WriteLine("functions/methods results:\n");
double num1 = 20.6;
double largerOne;

largerOne = _findLargeDouble(num1,3.6);
Console.WriteLine(largerOne);

Console.ReadLine();


double _findLargeDouble(double var1, double var2)
{
    if (var1 > var2) // if var1 is greater than var2
    {
        return var1;
    }
    else // if first condition is false then returns var2
    {
        return var2;
    }

    // return 0;
}