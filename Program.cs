using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

class Solution
{
    static void Main(string[] args)
    {
        double LONA = Convert.ToDouble(Console.ReadLine().Replace(',','.'));
        double LATA = Convert.ToDouble(Console.ReadLine().Replace(',','.'));
        int N = int.Parse(Console.ReadLine());
        var dico = new Dictionary<double, string>();
        
        for (int i = 0; i < N; i++)
        {
            var DEFIBS = Console.ReadLine()
                .Replace(',','.')
                .Split(';');
            
            double LONB = float.Parse(DEFIBS[4]), LATB = float.Parse(DEFIBS[5]);
            
            double x = (LONB - LONA) * Math.Cos((LATA + LATB) / 2),
                   y = LATB - LATA;
            double dist = Math.Sqrt( Math.Pow(x,2) + Math.Pow(y,2) ) * 6371;

            dico.Add(dist,DEFIBS[1]);
        }

        dico = dico
            .OrderBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        Console.Write(dico.ElementAt(0).Value);
    }
}