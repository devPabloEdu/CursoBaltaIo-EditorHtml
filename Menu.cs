using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;


        }

        public static void DrawScreen(){
            Console.Write("+");
            for(int i = 0; i <= 30; i++){
                Console.Write("+");
            }
        }


    }
}