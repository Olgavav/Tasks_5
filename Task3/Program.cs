//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
int[] array = new int[6];
FillArray(array);
MaxMin (array);    

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < 6; i++)
    {
        array[i] = rand.Next(0, 10000);
    }
}


 void MaxMin (int[] array)
{   int min =array[0];
    int max = 0; 
    for (int i = 0; i < 6; i++)
    {  
        Console.Write($"{array[i]}, ");
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine($"max = {max}, ");
    for (int i = 1; i < 6; i++){
        if (min > array[i]){
            min=array[i];
        }
        
    }
  
   Console.WriteLine($"min = {min}");
   Console.WriteLine($"max - min = {max - min}");
}
