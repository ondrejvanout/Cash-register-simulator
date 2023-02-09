using System;

namespace CashRegisterSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Round r;
            for (int i = 0; i < 10; i++)
            {
                r = new Round();
                r.PromptRoundToUser();
            }
            
        }
    }
}