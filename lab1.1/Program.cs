namespace lab1._1
{
    public class Logic()
    {
        public static string ConversionPennyStringToRubles(int number)
        {
            int rub = number / 100;
            int kop = number % 100;
            
            string rubWord;
            string result = "";

            if (rub % 10 == 1 && rub % 100 != 11)
            {
                rubWord = "рубль";
                result += rub + " " + rubWord + " ";
            }
            else if (rub % 10 >= 2 && rub % 10 <= 4)
            {
                rubWord = "рубля";
                result += rub + " " + rubWord + " ";
            }
            else if (rub == 0)
            {
                rubWord = "";
                result += "";
            }

            else
            {
                rubWord = "рублей";
                result += rub + " " + rubWord + "";
            }

            

            if (kop > 0)
            {
                string wordKop;

                if (kop % 10 == 1 && kop % 100 != 11)
                {
                    wordKop = "копейка";
                }

                else if (kop % 10 >= 2 && kop % 10 <= 4)
                {
                    wordKop = "копейки";
                }
                else
                {
                    wordKop = "копеек";
                }

                result += kop + " " + wordKop;
            }
            else
            {
                result += "";
            }

            return result;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            int number;
            string strNumber;


            while (true)
            {
                Console.Write("Введите число от 1 до 9999: ");
                strNumber = Console.ReadLine();

                number = Convert.ToInt32(strNumber);

                if (number >= 1 && number <= 9999)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите корректное число");
                }
            }

            var sum = Logic.ConversionPennyStringToRubles(number);

            Console.WriteLine(sum);
        }
    }
}
