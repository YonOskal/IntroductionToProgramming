// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int [] array = new int [] {2, 4, 6, 22, 15};
NumberFromLast(array, array.Length - 1);

void NumberFromLast(int [] array,int index)
{
    if (index < 0)
    {
        return;
    }
    Console.WriteLine(array[index]);
   NumberFromLast(array, index - 1);
}
