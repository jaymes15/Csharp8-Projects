
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace TRAINING.SYNTAX
{
    public class Arrays
    {
        public void MultiplicationTableOnedimensionalArray()
        {
            WriteLine("Multiplication Table One dimensional Array");
            int[] number = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] number1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int multiplier = 1;

            while (multiplier <= (number1.Length - 1)) { 
            for (int num = 0; num <= 12; num++)
            {
                
                WriteLine(number[num] * number1[multiplier]);

                
            }
            multiplier++;
            }

        }
        public void MultiplicationTableMultidimensionalArray()
        {
            const int rowNumber = 21;
            const int colNumber = 21;
            WriteLine("Multiplication Table Multidimensional Array");
            int[,] array = new int[rowNumber, colNumber];
            int rowIndexing = 0;
            int colIndexing = 0;
            
            for (rowIndexing = 0; rowIndexing < rowNumber; rowIndexing++)
            {

                for (colIndexing = 0; colIndexing < colNumber; colIndexing++)
                {
                  
                    array[rowIndexing, colIndexing] = rowIndexing * colIndexing;
                    
                }

            }

            for (rowIndexing = 1; rowIndexing < rowNumber; rowIndexing++)
            {
                for (colIndexing = 1; colIndexing < colNumber; colIndexing++)
                {
                    Write($"{array[rowIndexing, colIndexing], 5}");
                }
                WriteLine();
            }

        }

    }
}

//pre processor directive
//class instances,class method
//public private static
//heap stack
//sorting linear,random,search
//time table