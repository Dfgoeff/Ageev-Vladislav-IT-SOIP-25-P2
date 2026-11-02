using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            first();
            second();
            third();
        }
        static void first()
        {
            Box<int> number = new Box<int>();
            Box<string> text = new Box<string>();

            number.Put(367);
            text.Put("Zampando&Macerite");
            Console.WriteLine($"Число в коробке: {number.Get()}");
            Console.WriteLine($"Строка в коробке: {text.Get()}");
        }
        static void second()
        {
            int num1 = 306;
            int num2 = 44;

            string word1 = "Zampando";
            string word2 = "Macerie";

            Console.WriteLine($"Числа до подмены: {num1} {num2}");
            Utils.Swap(ref num1,ref num2);
            Console.WriteLine($"Числа после подмены: {num1} {num2}");
            Console.WriteLine($"Слова до подмены: {word1} {word2}");
            Utils.Swap(ref word1,ref word2);
            Console.WriteLine($"Слова после подмены: {word1} {word2}");
        }
        static void third()
        {
            Pair<int,string> pair = new Pair<int,string>(367, "Zampando&Macerie");
            Console.WriteLine(pair.ToString());
        }
    }
}
