
public static class t
{
    public static void w(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        int width = Console.WindowWidth;
        int padding = (width - text.Length) / 2;
        Console.WriteLine(text.PadLeft(padding + text.Length));
        Console.ResetColor();
    }

    public static void w(string text, ConsoleColor color, ConsoleColor backgroundColor)
    {
        Console.ForegroundColor = color;
        Console.BackgroundColor = backgroundColor;
        int width = Console.WindowWidth;
        int padding = (width - text.Length) / 2;
        Console.WriteLine(text.PadLeft(padding + text.Length));
        Console.ResetColor();
    }

    public static void w(string text)
    {
        w(text, Console.ForegroundColor);
    }

    public static void w(string text, ConsoleColor? color = null, ConsoleColor? backgroundColor = null)
    {
        if (color.HasValue)
        {
            if (backgroundColor.HasValue)
            {
                w(text, color.Value, backgroundColor.Value);
            }
            else
            {
                w(text, color.Value);
            }
        }
        else
        {
            w(text);
        }
    }

    public static void wl(string text, ConsoleColor? color = null, ConsoleColor? backgroundColor = null)
    {
        if (color.HasValue)
        {
            if (backgroundColor.HasValue)
            {
                Console.BackgroundColor = backgroundColor.Value;
                Console.ForegroundColor = color.Value;
            }
            else
            {
                Console.ForegroundColor = color.Value;
            }
        }

        Console.WriteLine();
        Console.WriteLine(text);

        Console.ResetColor();
    }

    public static void wBlack(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.Black, backgroundColor);
    public static void wDarkBlue(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.DarkBlue, backgroundColor);
    public static void wDarkGreen(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.DarkGreen, backgroundColor);
    public static void wDarkCyan(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.DarkCyan, backgroundColor);
    public static void wDarkRed(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.DarkRed, backgroundColor);
    public static void wDarkMagenta(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.DarkMagenta, backgroundColor);
    public static void wDarkYellow(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.DarkYellow, backgroundColor);
    public static void wGray(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.Gray, backgroundColor);
    public static void wDarkGray(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.DarkGray, backgroundColor);
    public static void wBlue(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.Blue, backgroundColor);
    public static void wGreen(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.Green, backgroundColor);
    public static void wCyan(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.Cyan, backgroundColor);
    public static void wRed(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.Red, backgroundColor);
    public static void wMagenta(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.Magenta, backgroundColor);
    public static void wYellow(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.Yellow, backgroundColor);
    public static void wWhite(string text, ConsoleColor? backgroundColor = null) => w(text, ConsoleColor.White, backgroundColor);

    // other methods
    public static void SetConsoleProperties(int width, int height, int fontSize)
    {
        Console.SetWindowSize(width, height);
        Console.SetBufferSize(width, height);
        Console.SetWindowSize(width, (int)(height * 1.5)); // to adjust for font size
        Console.SetBufferSize(width, (int)(height * 1.5)); // to adjust for font size
        Console.SetWindowPosition(0, 0);
        
    }
}
