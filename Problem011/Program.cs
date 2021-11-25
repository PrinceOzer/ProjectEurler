using System;

namespace Problem011
{
    public class DiagonalLine
    {
        public static int Right(int product, int[,] array, int x, int y)
        {
            if (array[x, y] == 0 || array[x, y + 1] == 0 || array[x, y + 2] == 0 || array[x, y + 3] == 0)
            {
                return product;
            }
            else if (product < array[x, y] * array[x, y + 1] * array[x, y + 2] * array[x, y + 3])
            {
                return array[x, y] *
                   array[x, y + 1] *
                   array[x, y + 2] *
                   array[x, y + 3];

            }
            else
            {
                return product;
            }

        }
        public static int Left(int product, int[,] array, int x, int y)
        {
            if (array[x, y] == 0 || array[x, y - 1] == 0 || array[x, y - 2] == 0 || array[x, y - 3] == 0)
            {
                return product;
            }
            else if (product < array[x, y] * array[x, y - 1] * array[x, y - 2] * array[x, y - 3])
            {
                return array[x, y] *
                   array[x, y - 1] *
                   array[x, y - 2] *
                   array[x, y - 3];

            }
            else
            {
                return product;
            }
        }
        public static int Up(int product, int[,] array, int x, int y)
        {
            if (array[x, y] == 0 || array[x - 1, y] == 0 || array[x - 2, y] == 0 || array[x - 3, y] == 0)
            {
                return product;
            }
            else if (product < array[x, y] * array[x - 1, y] * array[x - 2, y] * array[x - 3, y])
            {
                return array[x, y] *
                   array[x - 1, y] *
                   array[x - 2, y] *
                   array[x - 3, y];
            }
            else
            {
                return product;
            }

        }
        public static int Down(int product, int[,] array, int x, int y)
        {
            if (array[x, y] == 0 || array[x + 1, y] == 0 || array[x + 2, y] == 0 || array[x + 3, y] == 0)
            {
                return product;
            }
            else if (product < array[x, y] * array[x + 1, y] * array[x + 2, y] * array[x + 3, y])
            {
                return array[x, y] *
                   array[x + 1, y] *
                   array[x + 2, y] *
                   array[x + 3, y];
            }
            else
            {
                return product;
            }
        }
        public static int RightUp(int product, int[,] array, int x, int y)
        {
            if (array[x, y] == 0 || array[x - 1, y + 1] == 0 || array[x - 2, y + 2] == 0 || array[x - 3, y + 3] == 0)
            {
                return product;
            }
            else if (product < array[x, y] * array[x - 1, y + 1] * array[x - 2, y + 2] * array[x - 3, y + 3])
            {
                return array[x, y] *
                   array[x - 1, y + 1] *
                   array[x - 2, y + 2] *
                   array[x - 3, y + 3];
            }
            else
            {
                return product;
            }

        }
        public static int LeftUp(int product, int[,] array, int x, int y)
        {
            if (array[x, y] == 0 || array[x - 1, y - 1] == 0 || array[x - 2, y - 2] == 0 || array[x - 3, y - 3] == 0)
            {
                return product;
            }
            else if (product < array[x, y] * array[x - 1, y - 1] * array[x - 2, y - 2] * array[x - 3, y - 3])
            {
                return array[x, y] *
                   array[x - 1, y - 1] *
                   array[x - 2, y - 2] *
                   array[x - 3, y - 3];
            }
            else
            {
                return product;
            }
        }
        public static int RightDown(int product, int[,] array, int x, int y)
        {
            if (array[x, y] == 0 || array[x + 1, y + 1] == 0 || array[x + 2, y + 2] == 0 || array[x + 3, y + 3] == 0)
            {
                return product;
            }
            else if (product < array[x, y] * array[x + 1, y + 1] * array[x + 2, y + 2] * array[x + 2, y + 3])
            {
                return array[x, y] *
                   array[x + 1, y + 1] *
                   array[x + 2, y + 2] *
                   array[x + 2, y + 3];
            }
            else
            {
                return product;
            }

        }
        public static int LeftDown(int product, int[,] array, int x, int y)
        {
            if (array[x, y] == 0 || array[x + 1, y - 1] == 0 || array[x + 2, y - 2] == 0 || array[x + 3, y - 3] == 0)
            {
                return product;
            }
            else if (product < array[x, y] * array[x + 1, y - 1] * array[x + 2, y - 2] * array[x + 3, y - 3])
            {
                return array[x, y] *
                   array[x + 1, y - 1] *
                   array[x + 2, y - 2] *
                   array[x + 3, y - 3];
            }
            else
            {
                return product;
            }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            string numbers = "08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08" +
                            "49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00" +
                            "81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65" +
                            "52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91" +
                            "22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80" +
                            "24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50" +
                            "32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70" +
                            "67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21" +
                            "24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72" +
                            "21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95" +
                            "78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92" +
                            "16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57" +
                            "86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58" +
                            "19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40" +
                            "04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66" +
                            "88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69" +
                            "04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36" +
                            "20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16" +
                            "20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54" +
                            "01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48";
            numbers = numbers.Replace(" ", "");
            int[,] array = new int[20, 20];
            int arrayindex = 0;
            int product = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    array[i, j] = int.Parse(numbers[arrayindex].ToString() + "" + numbers[arrayindex + 1].ToString());
                    arrayindex += 2;
                }

            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {//123456789
                    if (i < 3 && j < 3)//1 R D RD
                    {
                        product = DiagonalLine.Right(product, array, i, j);
                        product = DiagonalLine.Down(product, array, i, j);
                        product = DiagonalLine.RightDown(product, array, i, j);
                    }
                    else if (i < 3 && j > 2 && j < 17)//2 R L D RD LD
                    {
                        product = DiagonalLine.Right(product, array, i, j);
                        product = DiagonalLine.Left(product, array, i, j);
                        product = DiagonalLine.Down(product, array, i, j);
                        product = DiagonalLine.RightDown(product, array, i, j);
                        product = DiagonalLine.LeftDown(product, array, i, j);

                    }
                    else if (i < 3 && j > 16)//3 L D LD
                    {
                        product = DiagonalLine.Left(product, array, i, j);
                        product = DiagonalLine.Down(product, array, i, j);
                        product = DiagonalLine.LeftDown(product, array, i, j);
                    }
                    else if (i > 2 && i < 17 && j < 3)//4 R U D RU RD
                    {
                        product = DiagonalLine.Right(product, array, i, j);
                        product = DiagonalLine.Up(product, array, i, j);
                        product = DiagonalLine.Down(product, array, i, j);
                        product = DiagonalLine.RightUp(product, array, i, j);
                        product = DiagonalLine.RightDown(product, array, i, j);
                    }
                    else if (i > 2 && i < 17 && j > 2 && j < 17)//5 R L U D RU RD LU LD
                    {
                        product = DiagonalLine.Right(product, array, i, j);
                        product = DiagonalLine.Left(product, array, i, j);
                        product = DiagonalLine.Up(product, array, i, j);
                        product = DiagonalLine.Down(product, array, i, j);
                        product = DiagonalLine.RightUp(product, array, i, j);
                        product = DiagonalLine.RightDown(product, array, i, j);
                        product = DiagonalLine.LeftUp(product, array, i, j);
                        product = DiagonalLine.LeftDown(product, array, i, j);
                    }
                    else if (i > 2 && i < 17 && j > 16)//6 L U D LU LD
                    {
                        product = DiagonalLine.Left(product, array, i, j);
                        product = DiagonalLine.Up(product, array, i, j);
                        product = DiagonalLine.Down(product, array, i, j);
                        product = DiagonalLine.LeftUp(product, array, i, j);
                        product = DiagonalLine.LeftDown(product, array, i, j);
                    }
                    else if (i > 16 && j < 3)//7 R U RU
                    {
                        product = DiagonalLine.Right(product, array, i, j);
                        product = DiagonalLine.Up(product, array, i, j);
                        product = DiagonalLine.RightUp(product, array, i, j);
                    }
                    else if (i > 16 && j > 2 && j < 17)//8 R L U RU LU
                    {
                        product = DiagonalLine.Right(product, array, i, j);
                        product = DiagonalLine.Left(product, array, i, j);
                        product = DiagonalLine.Up(product, array, i, j);
                        product = DiagonalLine.RightUp(product, array, i, j);
                        product = DiagonalLine.LeftUp(product, array, i, j);
                    }
                    else if (i > 16 && j > 16)//9 L U LU
                    {
                        product = DiagonalLine.Left(product, array, i, j);
                        product = DiagonalLine.Up(product, array, i, j);
                        product = DiagonalLine.LeftUp(product, array, i, j);
                    }



                }
            }
            Console.WriteLine(product);
        }
    }
}
