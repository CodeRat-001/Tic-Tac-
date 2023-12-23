using System;
using System.Data;
namespace TicTacToe
{
    class Game
    {
        public static char[,] PlaceHolder = new char[9, 9];
        public static char p1, p2;
        public static void Main(String[] args)
        {
            char a = '1';
            char b = '2';
            char c = '3';
            char d = '4';
            char e = '5';
            char f = '6';
            char g = '7';
            char h = '8';
            char i = '9';

            //initialize the array of place
            PlaceHolder[0, 0] = a;
            PlaceHolder[0, 1] = b;
            PlaceHolder[0, 2 ] = c;
            PlaceHolder[1, 0] = d;
            PlaceHolder[1, 1] = e;
            PlaceHolder[1, 2] = f;
            PlaceHolder[2, 0] = g;
            PlaceHolder[2, 1] = h;
            PlaceHolder[2, 2] = i;



            //Display the grid
            do
            {
                Console.WriteLine(" ");
                for (int iy = 0; iy < 3; iy++)
                {

                    for (int j = 0; j < 3; j++)
                    { Console.Write(PlaceHolder[iy, j] + "  | "); }

                    Console.Write("\n-------------\n");
                }

                Console.WriteLine("Player 1 is always X and Player 2 is always O");
                Console.WriteLine("Type the numer where you would like to place your mark to play");

                int z = 0;
                for (; z < 9; z++)
                {
                    if (z % 2 == 0)
                    {
                        Console.WriteLine("Player 1  \n");
                        try
                        {
                            p1 = Console.ReadKey().KeyChar;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong format!! Enter a number as displayed");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPlayer 2 \n");

                        try
                        {
                            p2 = Console.ReadKey().KeyChar;
                            break;
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Wrong format!! Enter a number as displayed");
                        }
                    }
                }
                switch (p1)     //X
                {
                    case '1': PlaceHolder[0, 0] = 'X'; break;
                    case '2': PlaceHolder[0, 1] = 'X'; break;
                    case '3': PlaceHolder[0, 2] = 'X'; break;
                    case '4': PlaceHolder[1, 0] = 'X'; break;
                    case '5': PlaceHolder[1, 1] = 'X'; break;
                    case '6': PlaceHolder[1, 2] = 'X'; break;
                    case '7': PlaceHolder[2, 0] = 'X'; break;
                    case '8': PlaceHolder[2, 1] = 'X'; break;
                    case '9': PlaceHolder[2, 2] = 'X'; break;
                }
                switch (p2)     //O
                {
                    case '1': PlaceHolder[0, 0] = 'O'; break;
                    case '2': PlaceHolder[0, 1] = 'O'; break;
                    case '3': PlaceHolder[0, 2] = 'O'; break;
                    case '4': PlaceHolder[1, 0] = 'O'; break;
                    case '5': PlaceHolder[1, 1] = 'O'; break;
                    case '6': PlaceHolder[1, 2] = 'O'; break;
                    case '7': PlaceHolder[2, 0] = 'O'; break;
                    case '8': PlaceHolder[2, 1] = 'O'; break;
                    case '9': PlaceHolder[2, 2] = 'O'; break;
                }

            }
            while (true);
  }} } 


