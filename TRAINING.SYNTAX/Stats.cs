using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TRAINING.SYNTAX
{
    public class Stats
    {
        // initailizing Data Array
        int[] listOfNumbers;


        #region Number Generator
        public void numberGenerator()
        {
            int arraySize = 8;
            int minNumber = 1;
            int maxNumber = 10;
            listOfNumbers = new int[arraySize];

            Write("Data :");

            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                Random random = new Random();
                listOfNumbers[i] = random.Next(minNumber, maxNumber);
            }

            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                Write($"{listOfNumbers[i],5}");

            }

            /*   meanCalculator(listOfNumbers);

               meadianCalculator(listOfNumbers);
                */
            modeCalculator(listOfNumbers);




        }
        #endregion

        #region Mean Calculator
        private void meanCalculator(int[] listofNumbers)
        {
            decimal dataSum = 0M;
            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                dataSum += listOfNumbers[i];

            }
            decimal mean = dataSum / listofNumbers.Length;
            WriteLine();
            WriteLine($"Mean = {mean}");
        }
        #endregion

        #region Median Calculator
        private void meadianCalculator(int[] listOfNumbers)
        {
            decimal median;

            if (listOfNumbers.Length % 2 == 0)
            {
                int indexOfFirstMiddleNumber = (listOfNumbers.Length / 2);
                int indexOfSecondMiddleNumber = indexOfFirstMiddleNumber - 1;
                decimal sum = (listOfNumbers[indexOfFirstMiddleNumber] + listOfNumbers[indexOfSecondMiddleNumber]);
                median = sum / 2;
                WriteLine($"Median = {median}");

            }
            else
            {

                decimal middleNumber = (((decimal)listOfNumbers.Length) / 2);
                var roundOffMiddleNumber = Math.Round(middleNumber, 0);
                int indexOfMiddleNumber = ((int)roundOffMiddleNumber) - 1;
                median = listOfNumbers[indexOfMiddleNumber];
                WriteLine($"Median = {median}");
            }


        }
        #endregion

        #region Mode Calcualtor
        private void modeCalculator(int[] listOfNumbers)
        {
            int counter = 0;
            //int[] dataSpace = new int[10];
            int y , i;
            

            for ( i = 0; i < listOfNumbers.Length; i++)
            {
                for (y = 0; y < listOfNumbers.Length; y++)
                {
                   
                    if (listOfNumbers[y] == listOfNumbers[i])
                    {
                        counter++;
                          
                    }
                    if (y == (listOfNumbers.Length - 1))
                    {
                        WriteLine();
                        Write($"{listOfNumbers[i],8}");
                        Write($"{counter,8}");
                    }
                    //WriteLine();
                    //WriteLine($"{counter}");
                }
                counter = 0;
                y = 0;




                //dataSpace[listOfNumbers[i]] += 1;
            }
            i = 0;
           






            #endregion

        }
    }
}
