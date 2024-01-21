using System.IO;
using System.Runtime.CompilerServices;

string readText = File.ReadAllText("../../../input.txt");
int up = 0, down = 0, floor = 0;
bool flag = false;
for (int i = 0; i < readText.Length; i++)
{
    if (readText[i] == '(')
    {
        up++;
        floor++;
    }
    else
    {
        down++;
        floor++;
    }
    if (up - down == -1 && flag == false)
    {
        Console.WriteLine("part two = " + floor);
        flag = true;

    }
}
Console.WriteLine("part one = " + (up - down));

