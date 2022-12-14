// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];

Console.WriteLine(" Inpur a number ");
   
   for (int i = 0; i < array.Length; i++)
    
     {
       
       int a = Convert.ToInt32(Console.ReadLine());
       array[i] = a;
     }
   
    for (int i = 0; i < array.Length; i++)

       

Console.Write( "{0} ", array[i]);
