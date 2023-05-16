
using System.Globalization;

public class Solution
{


    public static void Main()
    {


        int result = BirthdayCandles();
        Console.Write(result);
       
    }

    public static int BirthdayCandles()
    {

        int[] candles = new int [4]{ 2, 4, 4, 1 };

        int result = 0;
        int max = 0;

        for (int i = 0; i < candles.Length; i++)
        {
            int j = 1;
            if (candles[i] >= candles[j])
            {
                max = candles[i];
            }

            j++;
        }

        for (int i = 0; i < candles.Length; i++)
        {
            if (candles[i] >= max)
            {
                result++;
            }
        }



            return result;
    }



}