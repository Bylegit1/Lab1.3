using System.ComponentModel.DataAnnotations;

namespace Lab1._3
{
    public class LetterPercentageLogic
    {
        public static int CountLetters(string proposal) 
        {
            var letterCount = 0;
            for (int i = 0; i < proposal.Length; i++)
            {
                var c = proposal[i];
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я'))
                {
                    letterCount++;
                }
            }
            return letterCount;
        }

        public static int CalcPercentage(int letterCount, int proposalLength)
        {
            return letterCount * 100 / proposalLength;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            var proposal = Console.ReadLine();

            var letterCount = LetterPercentageLogic.CountLetters(proposal);
            var percent = LetterPercentageLogic.CalcPercentage(letterCount, proposal.Length);
            var result = "Доля(в процентах) букв в данном предложении равно: ";

            Console.WriteLine(result + percent);
        }
    }
}
