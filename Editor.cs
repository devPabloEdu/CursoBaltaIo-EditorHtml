using System;
using System.Text;
using System.IO;
using Microsoft.VisualBasic;

namespace EditorHtml
{
    public static class Editor{
        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-------------");
            Start();
        }

        public static void Start(){
            var file = new StringBuilder();

            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            
            Console.WriteLine("-------------");
            Console.WriteLine("Deseja salvar o arquivo?");
            Console.WriteLine("-------------");
            var optionSave = Console.ReadLine();
            if(optionSave == "sim")  
            {
                SaveFile(file);
                
            }
                else {
                Console.WriteLine("Ok, arquivo não esta salvo!");
            }
        }

        public static void SaveFile(StringBuilder file){
                Console.Clear();
                Console.WriteLine("Qual caminho deseja salvar?");
                var path = Console.ReadLine();
                using (var newSavedFile = new StreamWriter(path))
                {newSavedFile.Write(file);
                }
                Console.WriteLine("Ok, arquivo salvo!");
        }
    }
}