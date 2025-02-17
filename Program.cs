using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a binary string:");
        string binaryString = Console.ReadLine();

        if (IsGoodBinaryString(binaryString))
        {
            Console.WriteLine("The binary string is good.");
        }
        else
        {
            Console.WriteLine("The binary string is not good.");
        }
    }

    static bool IsGoodBinaryString(string binaryString)
    {
        int count0 = 0;
        int count1 = 0;

        foreach (char c in binaryString)
        {
            if (c == '0') count0++;
            else if (c == '1') count1++;
        }

        if (count0 != count1) return false;

        count0 = 0;
        count1 = 0;
        foreach (char c in binaryString)
        {
            if (c == '0') count0++;
            else if (c == '1') count1++;

            if (count1 < count0) return false;
        }

        return true;
    }
}
