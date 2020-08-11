using System;

namespace CalcolaLibrary
{
    public class Calcola
    {
        public static double Raddoppia(double num)
        {
            double resp = 0;
            if (num > 0)
            {
                resp = num * 2;
            }
            return resp;
        }

        public static double SommaMonete(double[] monete)
        {
            double resp = 0;
            for (int i = 0; i < monete.Length; i++)
            {
                resp += monete[i];
            }
            return resp;
        }
    }
}
