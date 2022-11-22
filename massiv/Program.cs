/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] array = new int[] { 1, 2, 5, 7, 19};

Console.WriteLine("[{0}]", string.Join(", ", array));
//

int[] myArray = new int[] {6, 1, 33};

Console.WriteLine("[{0}]", string.Join(", ", myArray));