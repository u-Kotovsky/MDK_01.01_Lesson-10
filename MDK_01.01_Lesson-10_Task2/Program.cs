using System.Text;

namespace MDK_01._01_Lesson_10_Task2;

internal class Program
{
    static void Main(string[] args)
    {
        // Ensure RU characters would work.
        Console.OutputEncoding = Encoding.UTF8;

        // Initalize new EnglishTranslator object.
        Translator translator = new EnglishTranslator();

        // Output
        Console.WriteLine(translator.GetLanguage());
    }
}
