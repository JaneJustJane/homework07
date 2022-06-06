// В двумерном массиве целых чисел. Удалить строку и столбец,
//       на пересечении которых расположен наименьший элемент.

void FillMatrix (int [,] m1)
{
    for (int i=0; i<m1.GetLength(0); i++)
    {
        for (int j=0; j<m1.GetLength(1); j++)
        {
            m1[i,j]=new Random().Next(0,16);
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

Console.Write ($"введите кол-во строк матрицы ");
int rows1 = int.Parse(Console.ReadLine () ?? "0");
Console.Write ($"введите кол-во столбцов матрицы ");
int columns1 = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix1 = new int [rows1,columns1];
FillMatrix(matrix1);
PrintMatrix(matrix1);
int min = int.MaxValue;
int minrow = 0;
int mincolumn = 0;
for (int i=0; i<rows1; i++)
    for (int j=0; j<columns1; j++)
        {
            if (matrix1[i,j]<min) 
            {
                min=matrix1[i,j];
                minrow = i;
                mincolumn = j;
            }
        }
Console.WriteLine(min);
Console.WriteLine(minrow);
Console.WriteLine(mincolumn);

int [,] matrix2 = new int [rows1-1, columns1-1];


for (int i=0; i<matrix2.GetLength(0); i++)
{

    int a = i;
    if (i >= minrow)
    a=a+1;
    for (int j=0; j<matrix2.GetLength(1); j++)
    {
        int b = j;
        if (j>=mincolumn)
        b=b+1;
        matrix2[i,j]=matrix1[a,b];
    }
        
}
Console.WriteLine();   
PrintMatrix(matrix2);