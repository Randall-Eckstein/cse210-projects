using System;
namespace Develop03;

class Program
{
    static void Main(string[] args)
    {
        ScriptureList scrip = new ScriptureList();
        ConvertTextToList text = new ConvertTextToList();
        Display display = new Display();

        display.DisplayList();
    }
}