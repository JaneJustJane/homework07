// Найти произведение двух матриц

void FillMatrix (int [,] m1)
{
    for (int i=0; i<m1.GetLength(0); i++)
    {
        for (int j=0; j<m1.GetLength(1); j++)
        {
            m1[i,j]=new Random().Next(0,4);
        }
    }
}

void PrintMatrix (int [,] m2)
{
    for (int i=0; i<m2.GetLength(0); i++)
    {
        for (int j=0; j<m2.GetLength(1); j++)
        {
            Console.Write ($"{m2[i,j]}  ");
        }
    Console.WriteLine ();
    }
}

Console.Write ($"введите кол-во строк 1 матрицы ");
int rows1 = int.Parse(Console.ReadLine () ?? "0");
Console.Write ($"введите кол-во столбцов 1 матрицы ");
int columns1 = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix1 = new int [rows1,columns1];

Console.Write ($"введите кол-во строк 2 матрицы ");
int rows2 = int.Parse(Console.ReadLine () ?? "0");
Console.Write ($"введите кол-во столбцов 2 матрицы ");
int columns2 = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix2 = new int [rows2,columns2];

if (columns1 != rows2)
Console.WriteLine("Матрицы несовместимы, кол-во столбцов 1матрицы должно быть равно кол-ву строк 2 матрицы");

else
{
    FillMatrix (matrix1);
    PrintMatrix (matrix1);
    Console.WriteLine();
    FillMatrix (matrix2);
    PrintMatrix (matrix2);
    
    int [,] matrix3 = new int [columns1,rows2];
    for (int i=0; i<columns1; i++)
    {
        for (int j=0; j<rows2; j++)
        {
            for (int k=0; k<rows2; k++)
            {
                matrix3[i,j]=matrix3[i,j] + matrix1[i,k]*matrix2[k,j];
            }
        }       
    }
    Console.WriteLine();
    PrintMatrix (matrix3);
}
