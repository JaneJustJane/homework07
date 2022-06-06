// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

int [][] myTriangle = new int [11][];
myTriangle[0]=new int [1]{1};
myTriangle[1]=new int [2]{6,1};
myTriangle[2]=new int [2]{5,1};
myTriangle[3]=new int [3]{15,4,1};
myTriangle[4]=new int [3]{10,3,1};
myTriangle[5]=new int [4]{20,6,2,1};
myTriangle[6]=new int [3]{10,3,1};
myTriangle[7]=new int [3]{15,4,1};
myTriangle[8]=new int [2]{5,1};
myTriangle[9]=new int [2]{6,1};
myTriangle[10]=new int [1]{1};

for (int i=0; i<myTriangle.Length; i++)
{  
    for (int j=0; j<myTriangle[i].Length; j++)
    {
        Console.Write(myTriangle[i][j] + " ");
    }
Console.WriteLine();
}