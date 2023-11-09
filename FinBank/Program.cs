class Program
{
   

    static void Main(string[] args)
    {

        var acc1 = new Bank();
        var acc2 = new Bank();
        var acc3 = new Bank();
        List<Bank> banks = new List<Bank>() { acc1, acc2, acc3 };

        acc1.Info();
        acc2.Info();
        acc3.Info();

        while (true)
        {
           
            Console.WriteLine("\nВведите на какой счет хотите перейти");
            int i = Convert.ToInt32(Console.ReadLine());
            if(i ==acc1.Nomer )
            {
                acc1.Print(banks);
            }
            else if (i == acc2.Nomer)
            {
                acc2.Print(banks);
            }
            else if (i == acc3.Nomer)
            {
                acc3.Print(banks);
            }


           
            
            
            
           
        }
    }
}

