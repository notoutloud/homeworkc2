namespace exercises;

class Program
{
    static void Main(string[] args)
    {
        /* 10zd
            int Input (string text) {
                Console.Write (text);
                return Convert.ToInt32(Console.ReadLine());
            }
            int first = Input("Введите трехзначное число: ");
            int sin = first/10;
            int enty = sin % 10;
            Console.WriteLine($"ответ: {enty}");
            */

            //zd 13
            /*
            int Input (string text) {
                Console.Write (text);
                return Convert.ToInt32(Console.ReadLine());
            }
            int first = Input("Введите число: ");
            if(first > 1000) {
                while (first >= 1000) {
                    first = first / 10;
                } 
                int sin = first % 10;
                Console.WriteLine($"ответ: {sin}"); 
            }
            if (first < 100) {
                Console.WriteLine("третьей цифры нет");
            }
            */

            //zd15
            int Input (string text) {
                Console.Write (text);
                return Convert.ToInt32(Console.ReadLine());
            }
            int first = Input("Введите цифру, обозначающую день недели: ");
            if (first > 7)  {
                Console.WriteLine ("Такого дня недели не существует");
            }
            if (first == 6 || first == 7) {
                Console.WriteLine ("Да, выходной");
            }
            if (first < 6) {
                Console.WriteLine ("нет, не выходной");
            }
    }
}
