﻿class Bank
{
    private int nom;
    private string name;
    private float sum;
    public List<Bank> list;
    public Bank(string n) { nom = 1; name = n; sum = 10000f; }
    public Bank(string n, float s) { nom = 2; name = n; sum = s; }
    public Bank(int id, string n, float s) { nom = id; name = n; sum = s; }

    //открытие счета
    public void Out()
    {
        Console.WriteLine($"Номер вашего счета: {nom}\tВаше имя: {name}\t Cумма на счете: {sum}");
    }
    // метод чтоб положить деньги на счет
    public void dob()
    {
        Console.Write("Сколько рублей хотите внести? ");
        int a = Convert.ToInt32(Console.ReadLine());
        sum += a;
        Console.WriteLine($"Деньги успешно внесены, на балансе {sum} рублей ");
    }
    // метод чтоб снять деньги со счета
    public void umen()
    {
       Console.Write("Сколько рублей хотите снять?");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a <= sum)
        {
            sum -= a;
            Console.WriteLine($"Снято {a} рублей.На балансе {sum} рублей");
        }
        else if (a > sum)
        {
            Console.WriteLine("Недостаточно средств. Повторите действие!");
            umen();
        }
    }

    // метод чтоб снять все деньги со счета 
    public void obnul()
    {
        sum = 0;
        Console.WriteLine($"Вы сняли все деньги. На счету {sum}");
    }

    // метод перевода с одного счета на другой 
    public void Transaction()
    {
        Console.WriteLine("Укажите на какой счет хотите перевести деньги?");
        int i = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Сколько хотите перевести?");
        int r = Convert.ToInt32(Console.ReadLine());
        sum -= r;
        Searh(i, list).sum += r;
    }

    private Bank Searh(int nom, List<Bank> bank)
    {

        foreach (Bank b in bank)
        {
            if (nom == b.nom)
            {
                return b;
            }

        }
        Console.WriteLine("Счет не найден");
        return null;
    }
    public void Print()
    {
        while (true)
        {
            Out();
            Console.WriteLine("Выберите операцию для выполнения:\n1 - Внести деньги\t2 - Снять деньги\t3 - Снять всю сумму\t4 - перевести деньги на другой счет\t5 - Выход");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                dob();
            }
            else if (a == 2)
            {
                umen();
            }
            else if (a == 3)
            {
                obnul();
            }
            else if (a == 4)
            {
                Transaction();
            }
            else if (a == 5)
            {
                return;
            }
            else
            {
                Console.WriteLine("Ошибка выбора");
            }

            Console.WriteLine("-----------------------------Следующий---------------------");
        }
    }
}

