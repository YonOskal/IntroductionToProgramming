int[] array = { 7, 5, 4, 7, 8, 1 };
int[] array1 = new int[array.Length / 2];
int FirstNumber = 0;
int LastNumber = array.Length - 1;

while (FirstNumber < LastNumber)
{
    array1[FirstNumber] = array[FirstNumber] * array[LastNumber];
    FirstNumber++;
    LastNumber--;
}
for (int i = 0; i < array1.Length; i++)
{
    Console.Write(array1[i] + " ");
}