
Console.Clear();
int[] array = new int[6];
FillArray(array);
Evennumbers(array);

    

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < 6; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
}


void Evennumbers(int[] array)
{ 
    int n = 0; 
    for (int i = 0; i < 6; i++)
    {   Console.Write($"{array[i]}, ");
        if (array[i] % 2 == 0)
        
        {
           n++;
        }
    
    }
Console.Write($" Колличество четных чисел в мвссиве  = {n}");
}