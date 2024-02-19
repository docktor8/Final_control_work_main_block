using System;

Console.Write("Введите размер массива: ");
int lenght_array = int.Parse(Console.ReadLine());
string[] array = new string[lenght_array];
for(int i =0; i < lenght_array; i++)
{
    Console.Write($"Введите {i} элемент массива: ");
    array[i] = Console.ReadLine();
}
int str_length_limit =3;
int lenght_new_array =0;
for(int i =0; i < lenght_array; i++)
{
    if(array[i].Length<=str_length_limit)
    {
        lenght_new_array++;
    }
}
string[] new_array = new string[lenght_new_array];
int count_new_array =0;
for(int i =0; i < lenght_array; i++)
{
    if(array[i].Length<=str_length_limit)
    {
        new_array[count_new_array]=array[i];
        Console.Write($"{new_array[count_new_array]} ");
        count_new_array++; 
    }    
}
