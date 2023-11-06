class Program
{
     static void Main(string[] args)
    {
        while (true)
        {
            
          
            var acc1 = new Bank("Fel");
            var acc2 = new Bank("Fibb", 500f);
            var acc3 = new Bank(3, "Monica", 100f);
            acc1.list = new List<Bank>();

            acc1.list.Add(acc2);
            acc1.list.Add(acc3);
           
            acc1.Print();

            acc2.list = new List<Bank>();
            acc2.list.Add(acc1);
            acc2.list.Add(acc3);
           
            acc2.Print();

            acc3.list = new List<Bank>();
            acc3.list.Add(acc1);
            acc3.list.Add(acc2);
           
            acc3.Print();
        }
    }
}
