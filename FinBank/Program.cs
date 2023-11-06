class Program
{
    
    static void Main(string[] args)
    {
        var acc1 = new Bank(1, "Fel", 1000f);
        var acc2 = new Bank(2, "Fibb", 500f);
        var acc3 = new Bank(3, "Monica", 100f);
        List<Bank> banks = new List<Bank>() { acc1, acc2, acc3 };
        while (true)
        {
            acc1.Print(banks);
            acc2.Print(banks);
            acc3.Print(banks);
        }
    }
}
