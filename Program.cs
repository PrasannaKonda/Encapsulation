//--------------- With out Encapsulation ----------------
//public class BankAccount {
//    public int amount;
//}

//public class Program { 

// static void Main(string[] args)
//{
//        int useramount = Convert.ToInt32(Console.ReadLine());
//    BankAccount account = new BankAccount();
//    account.amount = useramount;
//        Console.WriteLine("Initial Amount:" + account.amount);
//}

//}


//--------------- With Encapsulation ----------------
class BankAccount {
    private int _amount;
    public int Amount {
        get { return _amount; }
        private set {
            if (value > 0)
            {
                _amount = value;
            }
            else {
                Console.WriteLine("Amount must be positive.");
            }
        }
    }
    public void Deposit(int money) {
        if (money > 0)
        {
            _amount += money;
        }
        else {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(int money) {
        if (money > 0 && money <= _amount)
        {
            _amount -= money;
        }
        else {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

}

class Program {
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        Console.WriteLine("Initial Amount: " + account.Amount);
        account.Deposit(500);
        Console.WriteLine("After Deposit: " + account.Amount);
        account.Withdraw(200);
        Console.WriteLine("After Withdrawal: " + account.Amount);
    }
}