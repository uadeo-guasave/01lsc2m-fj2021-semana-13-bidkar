using System;

namespace MusicApp
{
    public sealed class Helpers
    {
        public const int LARGO_DE_LINEA = 60;

        public static void printTitle(string title)
        {
            printDoubleLine();
            printCenteredText(title, true);
            printDoubleLine();
        }

        public static void printSubTitle(string subtitle)
        {
            printCenteredText(subtitle, false);
            printSingleLine();
        }

        private static void printCenteredText(string text, bool upper)
        {
            // if (upper) {
            //     Console.WriteLine("{0," + (LARGO_DE_LINEA / 2 + text.Length / 2) + "}", text.ToUpper());
            // } else {
            //     Console.WriteLine("{0," + (LARGO_DE_LINEA / 2 + text.Length / 2) + "}", text);
            // }

            Console.WriteLine("{0," + (LARGO_DE_LINEA / 2 + text.Length / 2) + "}", upper ? text.ToUpper() : text);
        }

        private static void printSingleLine()
        {
            Console.WriteLine("".PadLeft(LARGO_DE_LINEA, '-'));
        }
        private static void printDoubleLine()
        {
            Console.WriteLine("".PadLeft(LARGO_DE_LINEA, '='));
        }
    }
}