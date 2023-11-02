class Program
{
    static void Main(string[] args)
    {

        var acc1 = new Bank("Fel");
        var acc2 = new Bank("Fibb", 5000f);
        var acc3 = new Bank(3, "Monica", 10000f);
        acc1.list = new List<Bank>();
        acc1.list.Add(acc1);
        acc1.list.Add(acc2);
        acc1.list.Add(acc3);
        acc1.Print();
        acc2.Out();
    }
}
