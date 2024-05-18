// int[] array1 = new int[5];
// int[] array2 = new int[5] { 3, 6, 8, 3, 9 };
// int[] array3 = new int[] { 3, 6, 8, 3, 9 };

int[] array = {1, 3, 8, 19, 3, 8};
int num = 8;

bool isExistNum = false;

for (int i = 0; i < array.Length; i++)
{
if(array[i] == num)
{
isExistNum = true;
break;
}
}

// int number = 45;

// if(number > num) Console.WriteLine("Ура!");
// if(!(number < num)) Console.WriteLine("Ура!");

//string result = isExistNum ? "Да" : "Нет";
Console.WriteLine(isExistNum ? "Да" : "Нет");