int[] array = { -1, -3, 8, -4, 3, -8, 3, 5, -2, 9 };

int Length = array.Length;

for (int i = 0; i < Length; i++)
{
    if (array[i] < 0)
    {
        array[i] = -array[i];
    }
    else if (array[i] > 0)
    {
        array[i] = -array[i];
    }
Console.Write(array[i] + " ");
}