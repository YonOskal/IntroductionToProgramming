// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


char[,] CreateMatrixRndChar(int rows, int colums)
{
    char[,] matrix = new char[rows, colums];
    Random rnd = new Random();

    int min = 65; // Начало диапазона символов (например, 'A')
    int max = 90; // Конец диапазона символов (например, 'Z')

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (char)rnd.Next(min,max + 1);
        }

    }

    return matrix;
}

string[] CreateStringFromMatrixChar(char[,] mat)
{
    string[] str = new string[mat.GetLength(0)];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        str[i] = string.Empty;
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            str[i] += mat[i, j];
        }
    }
    return str;
}

char[,] matrix = CreateMatrixRndChar(3, 3);
string[] result = CreateStringFromMatrixChar(matrix);
foreach (string s in result)
{
    Console.Write(s);
}

