//int n = 5;
int[] array = { 1, 2, 3, 5, 6 };
int i = 0;
int maxWeight = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxWeight)
        {
            {
                maxWeight = array[i];
            }
        }
    }
    Console.Write(maxWeight);