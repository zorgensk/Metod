// Метод поиска максимального значения в массиве по индексу
void FindMaxInd(int []arr )
{
int max =  arr[0];
int ind = 0;
for(int i = 0; i < arr.Length; i++)
{
   if(arr[i] > max)
    {
     max = arr[i];
     ind = i;
    }
}
Console.WriteLine($"максимальное значение в массиве {max}, находится под индексом [{ind}]");
 
}


//метод заполнения массива
 void RandomArray(int []arr)
{

// int index = new Random().Next(5, 10);   
// int []arr = new int[index];

for(int i = 0; i < arr.Length; i++)
{

arr[i] = new Random().Next(-10, 11);   
 

//  Console.Write($"{i } {arr[i] = new Random().Next(-10, 11)}  ");
//  Console.WriteLine("");
}

}


// Метод вывода массива в терминал
 void PrintArray(int []arr )
 {
for(int i =0; i < arr.Length; i++)
{
    Console.WriteLine($"[{i}] = {arr[i]}" );
}

 }
 
 
int index = new Random().Next(5, 10);   
int []arr = new int[index];
 
 RandomArray(arr);
 PrintArray(arr);
 FindMaxInd(arr);


