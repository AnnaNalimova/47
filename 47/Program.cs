// Задайте двухмерный массив размером m*n ,
// заполненный случайными вещественными числами.

double[,] GetArray(int m, int n, int min,int max)
{
    double [,] array = new double[m,n];
    Random rand = new Random();
    for(int i=0;i<array.GetLength(0);i++)
    {
      for(int j=0;j<array.GetLength(1);j++)
      {
         array[i,j]=  Math.Round(rand.Next(min,max) + rand.NextDouble(),3);
      }
    }
return array;
}
void PrintArray(double[,] mass)
{
    for( int i=0;i<mass.GetLength(0);i++)
    {
        for( int j=0;j<mass.GetLength(1);j++)
        {
            Console.Write($"{mass[i, j]}");
        }
    Console.WriteLine();
    }
}
double [,] massive = GetArray(3,4,-2,3);
PrintArray(massive);
