class Bank
{
    int nomer;  //Номер счета
    string name; //Имя владельца
    float sum;    // сумма
    
    public int Nomer
    {
        get { return nomer; }
    }
    
    // метод ввода информации
    public void Info ()
    {
        
            nomer = nomer;
            name = name;
            sum = sum;
            Console.WriteLine("\nВведите ваше имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите номер счета");
            nomer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Счет успешно создан!");
        }
    
    // метод вывода информации
     void Out()
    {
        Console.WriteLine($"\nНомер вашего счета: {nomer}\tВаше имя: {name}\t Cумма на счете: {sum}");
    }

    // метод чтоб положить деньги на счет
    
     void dob()
    {
        Console.Write("Сколько рублей хотите внести? ");
        int a = Convert.ToInt32(Console.ReadLine());
        sum += a;
        Console.WriteLine($"Деньги успешно внесены, на балансе {sum} рублей ");
    }

    // метод чтоб снять деньги со счета
     void umen()
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
     void obnul()
    {
        sum = 0;
        Console.WriteLine($"Вы сняли все деньги. На счету {sum}");
    }

    // метод перевода с одного счета на другой 
     void Transaction(List<Bank> banks)
    {
        Console.WriteLine("Укажите на какой счет хотите перевести деньги");
        int i = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Сколько хотите перевести?");
        int r = Convert.ToInt32(Console.ReadLine());
        if(sum > r)
        { sum -= r;
            Searh(i, banks).sum += r;
        }
        else
        {
            Console.WriteLine("Недостаточно средств, пополните баланс");
            Print(banks);
        }
        //sum -= r;                              // вычитается сумма с заданного счета

        //Searh(i, banks).sum += r;               // прибавляется сумма в выбранный счет

    }

    // перебор счетов
    private Bank Searh(int nom, List<Bank> bank)
    {
        foreach (Bank b in bank)
        {
            if (nom == b.nomer)
            {
                Console.WriteLine($"Перевод успешно выполнен! На вешем счету {sum}");
                return b;
            }
        }
        Console.WriteLine("Счет не найден.Повторите действие");
        Print(bank);
        return null;
    }

    // метод для возврата методов, опираясь на выбор клиента
    public void Print(List<Bank> banks)
    {
        
      
        while (true)
        {
            
            Out(); 

             Console.WriteLine($"Выберите операцию для выполнения: \n1 - Внести деньги\t2 - Снять деньги\t3 - Снять всю сумму\t4 - перевести деньги на другой счет\t5 - Выход");
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
                Transaction(banks);
            }
            else if (a == 5)
            {
                return;
            }
            else
            {
                Console.WriteLine("Ошибка выбора");
                Print(banks);
            }
            Console.WriteLine("-------------------------------------------------");
        }
    }
}


