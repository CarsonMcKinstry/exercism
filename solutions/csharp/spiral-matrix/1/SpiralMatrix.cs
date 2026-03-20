
using System.Numerics;

public class SpiralMatrix
{
    
    public static int[,] GetMatrix(int size)
    {
        var matrix = new int[size,size];

        var x = 0;
        var y = 0;
        var max = size - 1;
        var min = 0;
        
        for (var i = 0; i < size * size; i++)
        {
            matrix[y, x] = i + 1;
            if (y == max && x != min)
                x--;
            else if (x == max)
                y++;
            else if (y == min)
                x++;
            else if (x == min && y != min + 1)
                y--;
            else {
                max -= 1;
                min += 1;
                x++;
            }
        }
        
        return matrix;
    }
}
