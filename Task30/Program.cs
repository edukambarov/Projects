// int [] array = new int[8]; //1 способ
// int [] array1 = new int[8] {2,5,6,5,7,9,9,6}; 
// //                          0,1,2,3,4,5,6,7
// int [] array2 = new int[] {2,5,6,5,7,9,9,6};
// int [] array3 = {2,5,6,5,7,9,9,6};

// var array4 = new int [8];
// var rnd = new Random();
// var res = 45/7 + 34 - 7/13

// array[7] = 7;
// int size = array.Length; //8

// for (int i=0; 1<size; i++)
// {
//     array[i] = i + i;
//     Console.Writeline(array[i] + "");
// }

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8]; // 0 1 2 3 4 5 6 7
FillArray(array);
PrintArray(array);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,2);
    }
}