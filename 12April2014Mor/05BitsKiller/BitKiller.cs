using System;

class BitKiller
{
    static void Main()
    {
        int bytesCount = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        string allBits = "";
        
        for (int i = 0; i < bytesCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
            allBits += Convert.ToString(number, 2).PadLeft(8, '0');

        }
        int allBitsLength = bytesCount * 8;
        for (int i = 1; i < allBitsLength; i+= step)
        {
            allBits = allBits.Remove(i , 1);
            i--;
            allBitsLength--;           
        }
        if(allBits.Length % 8 != 0)
        {
            allBits = allBits.PadRight(((allBits.Length / 8) + 1) * 8 , '0');
        }
        int index = 0;
        while (allBits != "")
        {
            Console.WriteLine(Convert.ToInt32(allBits.Substring(0, 8) , 2));
            allBits = allBits.Remove(0, 8);
            index++;
        }
    }
}