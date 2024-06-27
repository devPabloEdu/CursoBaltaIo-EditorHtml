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
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen(){
            DrawTopLineAndBottomLine();
            DrawCollum();
            DrawTopLineAndBottomLine();
        }

        public static void DrawTopLineAndBottomLine(){
            Console.Write("+");
            for(int i = 0; i <= 30; i++){
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void DrawCollum(){
            for(int lines = 0; lines <= 10; lines++){
                Console.Write("|");
                 for(int i = 0; i <= 30; i++){
                 Console.Write(" ");
                 }
                Console.Write("|");
                Console.Write("\n");               
            }
        }

        public static void WriteOptions(){
            Console.SetCursorPosition(3,2); //coluna 3, linha 2
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3); //coluna 3, linha 3
            Console.WriteLine("==============");
            Console.SetCursorPosition(3,4); //coluna 3, linha 4
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,6); //coluna 3, linha 6
            Console.WriteLine("1 - NOVO ARQUIVO");
            Console.SetCursorPosition(3,7); //coluna 3, linha 7
            Console.WriteLine("2 - ABRIR");
            Console.SetCursorPosition(3,9); //coluna 3, linha 9
            Console.WriteLine("0 - SAIR");
            Console.SetCursorPosition(3,10); //coluna 3, linha 10
            Console.Write("OPÇÃO");
        }

        public static void HandleMenuOption(short option){
            switch(option) {
                case 1 : Console.WriteLine("EDITOR");
                break;
                case 2 : Console.WriteLine("View");
                break;
                case 0 : {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show();
                break;
            }
        }
    }
}