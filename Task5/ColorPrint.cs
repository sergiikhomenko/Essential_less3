namespace Task5;

public class ColorPrint : Printer
{
    private ConsoleColor[]  _colors = {
        ConsoleColor.Red,ConsoleColor.Cyan,ConsoleColor.Magenta
    };

    private int _colorIndex=0;
    public override void Print(string value)
    {
        Console.ForegroundColor = _colors[_colorIndex];
        base.Print(value);
        Console.ResetColor();
        _colorIndex = (_colorIndex  + 1)% _colors.Length;
    }
}