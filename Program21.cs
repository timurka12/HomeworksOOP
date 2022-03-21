using System;

namespace ConsoleApp203
{
    enum AT { Current, Savings }
    class Score
    {
        public Score(string accountNumber, decimal balans, AT type)
        {
            AccountNumber = accountNumber;
            Balans = balans;
            Type = type;
        }
        public string AccountNumber { get; set; }
        public decimal Balans { get; set; }
        public AT Type { get; set; }
        public override string ToString() => $"AccountNumber - {AccountNumber}, Balans - {Balans}, Type - {Type}";

    }
    class Program
    {
        static void Main()
        {
            AT accountType = AT.Current;
            Console.WriteLine(accountType);
            Score score = new Score("08052003NTR", 1_200_000, AT.Savings);
            Console.WriteLine(score);
        }

    }
}
