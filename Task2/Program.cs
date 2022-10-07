// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int[] array = new int[6];
FillArray(array);
int result = 0;
Sum (array);
Console.Write($" Сумма нечетных элементов  = {result}");    

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < 6; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
}


 void Sum (int[] array)
{  
    for (int i = 0; i < 6; i++)
    {   Console.Write($"{array[i]}, ");
        if (array[i] % 2 == 1)
        {
            result = result + array[i];
        }
        
    
    }

}
