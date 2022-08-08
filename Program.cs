using System;
using static System.Console;

Clear();

string [] mass = {"hello", "2", "world", ":-"};
//int count = mass.Length;
string [] massresult = CheckString(mass);
PrintArray(massresult);

string [] CheckString(string [] mass)
{
    string [] result = new string [mass.Length];
    int k = 0;
    for(int i=0; i<mass.Length; i++)
        {
            if (mass[i].Length<4)
            {
                result [k] = mass[i];
                k++;
            }
        }
    return result;
}

void PrintArray(string [] mass)
{
    Write("[");
    foreach (var s in mass)
    {
        if (s != null) Write($"{s} ");
    } 
    Write("]");
}


