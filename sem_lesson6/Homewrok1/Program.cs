// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

{
    char[,] CreateMatrixRndChar(int rows, int columns)
    {
        char[,] matrix = new char[rows, columns];
        Random rnd = new Random();

        int min = 65; // Начало диапазона символов (например, 'A')
        int max = 90; // Конец диапазона символов (например, 'Z')

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = (char)rnd.Next(min, max + 1);
            }
        }

        return matrix;
    }

    void PrintRndMatrix(char[,] RndMatrix)
    {
        for (int i = 0; i < RndMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < RndMatrix.GetLength(1); j++)
            {
                Console.Write(RndMatrix[i, j] + " "); 
            }
            Console.WriteLine(); 
        }
    }

   string[] CreateStringFromMatrixChar(char[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        string[] result = new string[rows];
        for (int i = 0; i < rows; i++)
        {
            char[] row = new char[columns];
            for (int j = 0; j < columns; j++)
            {
                row[j] = matrix[i, j];
            }
            result[i] = new string(row);
        }

        return result;
    }
    

    {
        char[,] matrix = CreateMatrixRndChar(3, 3);
        PrintRndMatrix(matrix);
        string[] result = CreateStringFromMatrixChar(matrix);
        foreach (string s in result)
        {
            Console.Write(s);
        }
    }
}
