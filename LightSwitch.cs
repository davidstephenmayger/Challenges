using System;
using System.Text.RegularExpressions;

public static class LightSwitch
{
    bool[] lightSwitch;
    public static int numOn(string input)
    {
        //step 1: parse input into num lights + chains
        string[] lines = input.Split('\n');
        int x = int.Parse(lines[0]);
        int size = lines.GetLength(0);
        int numElements = size - 1;
        bool[] lightSwitch = new bool[x];
        for (int i = 0; i < x; i++)
            lightSwitch[i] = false;

        int[] starts = new int[numElements];
        int[] ends = new int[numElements];
        for (int i = 1; i < numElements; i++)
        {
            string[] words = lines[i].Split(' ');
            starts[i - 1] = int.Parse(words[0]);
            ends[i - 1] = int.Parse(words[1]);
        }
        return numOn(x, starts, ends);
    }
    public static int numOn(int number, int[] starts, int[] ends)
    {
       bool[] lightSwitch = new bool[x];
       for (int i = 0; i < x; i++)
           lightSwitch[i] = false;

       for(int i = 0; i < starts.GetLength(0);i++)
           {
               for (int s = starts[i]; s <= ends[i]; s++)
                   lightSwitch[s] = !lightSwitch[s];
           }

        //count number of bulbs on

       int count = 0;
       for (int i = 0; i < x; i++)
           if (lightSwitch[i])
               count++;
       return count;
    }
}
