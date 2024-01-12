// start----------------------------------------------------------------------------------------------------------------

// Зачача 1 ______________________________________________________________________________________________________________________________________________
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.

Console.WriteLine("Введите размерность масива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
int ind = 0;




while(ind < mas.Length)
{
    Console.Write($"{mas[ind]}\t");
    ind++;
}
Console.WriteLine();




for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"{mas[i]}\t");
}
Console.WriteLine();




foreach (var item in mas)
{
    Console.Write($"{mas[item]}\t");
}
Console.WriteLine();

 


void Print_mas(int[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{mas[item]}\t");
    }
    Console.WriteLine();
}

Print_mas(mas);



int[] Random_mas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1,10);
    }
    return col;
}
int[] new_mas = Random_mas(mas);

Print_mas(new_mas);

Console.WriteLine("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;

foreach (var item in new_mas)
{
    if (item == num)
    {
        count++;
        break;
    } 
}

if (count != 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}




