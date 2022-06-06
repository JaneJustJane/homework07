// Сформировать трехмерный массив (не повторяющимися) двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента

void FillMatrix (int [,,] m1)
{
    for (int i=0; i<m1.GetLength(0); i++)
    {
        for (int j=0; j<m1.GetLength(1); j++)
        {
            for (int k=0; k<m1.GetLength(2); k++)
            {
                m1[i,j,k]=new Random().Next(9,98);
                
            }
        }       
    }
}

void PrintMatrix (int [,,] m2)
{   
    for (int i=0; i<m2.GetLength(0); i++)
    {
            for (int j=0; j<m2.GetLength(1); j++)
        {
            for (int k=0; k<m2.GetLength(2); k++)
            {
                Console.WriteLine ($"элемент с индексом ({i},{j},{k}) - {m2[i,j,k]}  ");
            }
        Console.WriteLine();
        }
    Console.WriteLine ();
    }
}
int [,,] matrix = new int [3,3,3];
FillMatrix(matrix);
PrintMatrix(matrix);