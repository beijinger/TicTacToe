using System;

namespace Ttt.Run
{
    public class WelcomePage
    {
        private const int Krestik = 1;
        private const int Nolik = -1;

        public void Show()
        {  
            
            Console.WriteLine("Hello Yan");
            Console.WriteLine("Choose game:");
            Console.WriteLine("1 for \"two users\"\r\n2 for \"against machine\" ");
            var res1 = Console.ReadLine();
            Console.WriteLine(res1);
            Console.Clear();
            var matrix = new int[3, 3];
            DrawMatrix(matrix);
            Console.WriteLine("Make Your Move:");
            Console.WriteLine("Format: XY. X - row num, Y col num");
            var move = Console.ReadLine();
            Console.WriteLine(move);
            Console.ReadLine();
            int moveRow = int.Parse(move[0].ToString());
            int moveCol = int.Parse(move[1].ToString());
            matrix[moveRow, moveCol] = Krestik;
            Console.Clear();
            DrawMatrix(matrix);


        }
        private void DrawMatrix(int[,] matrix)
        {
            for(var i=0; i<matrix.GetLength(0); i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(".___.___.___.");
                }
                else
                {
                    Console.WriteLine("|___|___|___|");
                }
                for (var j=0; j<matrix.GetLength(1); j++)
                {
                    if(matrix[i,j]==0)
                        {
                        Console.Write("|   ");
                    }
                    else if(matrix[i,j]==Krestik)
                    {                      
                        Console.Write("| X ");                      
                    }
                    else
                    {
                        Console.Write("| 0 ");
                    }
                    
                }
                Console.Write("|");
                Console.WriteLine();           
            }
            Console.WriteLine("|___|___|___|");
        }
    }
}
