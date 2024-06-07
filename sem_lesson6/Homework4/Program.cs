﻿// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.


static string ReverseWord(string strNew)
{
    string[] strNewSplit = strNew.Split(); // ["Hello", "my", "world"]

    string res = "";

    for (int i = strNewSplit.Length - 1; i >= 0; i--)
    {
        res += strNewSplit[i] + " ";
    }

    return res;
}

string strNew = "Hello my world";
string res = ReverseWord(strNew);
Console.WriteLine(res);