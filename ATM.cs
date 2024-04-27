public abstract class ATM
{
    public Rupees RupeesInATM { get; set; }
    public UserAccount UserAccount { get; set; }
    public int BranchCode { get; set; }
    public string BankName { get; set; }
    public string ATMname { get; set; }

    int numberOf10Given, numberOf20Given, numberOf50Given, numberOf100Given, numberOf500Given, numberOf1000Given, numberOf5000Given;
    int totalCashGivenFromATM;
    protected ATM(string aTMname, string bankName, int branchCode, Rupees rupeesInATM)
    {

        ATMname = aTMname;
        BranchCode = branchCode;
        BankName = bankName;
        RupeesInATM = rupeesInATM;
    }
    protected ATM(string aTMname, string bankName, int branchcode, int Numberof10, int Numberof20, int Numberof50, int Numberof100, int Numberof500, int Numberof1000, int Numberof5000)
    {

        ATMname = aTMname;
        BranchCode = branchcode;
        BankName = bankName;
        RupeesInATM = new Rupees(Numberof10, Numberof20, Numberof50, Numberof100, Numberof500, Numberof1000, Numberof5000);
    }
    public void WelcomeUser()
    {
        Console.WriteLine($"------------------------(Welcome to {ATMname})------------------------");
    }
    public void CheckBalance(UserAccount useraccount)
    {
        Console.Write("enter your pin : ");
        int pin = int.Parse(Console.ReadLine());


        if (pin > 0 && pin > 999 && pin < 9999)
        {
            Console.WriteLine($"Name : {useraccount.Name}");
            Console.WriteLine($"Balance : {useraccount.Balance}");
            Console.Write("choose option to withdraw \n\t\t\t1-5000rupees 2-10000rupees 3-20000rupees 4-other : \n");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                CashProcess(useraccount, 5000);
            }
            else if (userChoice == 2)
            {
                CashProcess(useraccount, 10000);
            }
            else if (userChoice == 3)
            {
                CashProcess(useraccount, 20000);
            }
            else if (userChoice == 4)
            {
                Console.WriteLine("enter the amount to withdraw : ");
                int amountTowWithdraw = int.Parse(Console.ReadLine());
                CashProcess(useraccount, amountTowWithdraw);
            }
            else
            {
                Console.WriteLine("choose a valid option......");
            }
        }
        else
        {
            Console.WriteLine("enter the valid pin......");
        }
        PrintCash();
        TotalCashGiven();
        FeeCheck(useraccount);

    }
    public void PrintCash()
    {

        Console.WriteLine("___________Cash given___________");
        if (numberOf10Given > 0) Console.WriteLine($"10  x{numberOf10Given}");
        if (numberOf20Given > 0) Console.WriteLine($"20  x{numberOf20Given}");
        if (numberOf50Given > 0) Console.WriteLine($"50 x{numberOf50Given}");
        if (numberOf100Given > 0) Console.WriteLine($"100  x{numberOf100Given}");
        if (numberOf500Given > 0) Console.WriteLine($"500  x{numberOf500Given}");
        if (numberOf1000Given > 0) Console.WriteLine($"1000 x{numberOf1000Given}");
        if (numberOf5000Given > 0) Console.WriteLine($"5000  x{numberOf5000Given}");
    }
    public void TotalCashGiven()
    {

        var total10s = numberOf10Given * 10;
        var total20s = numberOf20Given * 20;
        var total50s = numberOf50Given * 50;
        var total100s = numberOf100Given * 100;
        var total500s = numberOf500Given * 500;
        var total1000s = numberOf1000Given * 1000;
        var total5000s = numberOf5000Given * 5000;

        totalCashGivenFromATM = total10s + total20s + total50s + total100s + total500s + total1000s + total5000s;
        Console.WriteLine($"Totalcashgiven : {totalCashGivenFromATM}");
    }
    public void FeeCheck(UserAccount userAccount)
    {
        if (BankName.ToUpper() != "Meezan Bank".ToUpper())
        {
            Console.WriteLine("transaction fee : 20");
            userAccount.Balance = userAccount.Balance - 20;
        }
        userAccount.Balance = userAccount.Balance - totalCashGivenFromATM;
        Console.WriteLine($"your balance is {userAccount.Balance}");
    }
    public void CashProcess(UserAccount userAccount, int amountTowWithdraw)
    {
        int totalCashGiven = 0;

        if (amountTowWithdraw <= userAccount.Balance)
        {
            int multipleof10 = amountTowWithdraw % 10;
            if (multipleof10 == 0)
            {


                if (amountTowWithdraw <= RupeesInATM.TotalCurrencyValue)
                {
                    while (amountTowWithdraw - totalCashGiven >= 5000 && RupeesInATM.Numberof5000 - numberOf5000Given > 0)

                    {
                        numberOf5000Given += 1;
                        totalCashGiven += 5000;
                    }
                    while (amountTowWithdraw - totalCashGiven >= 1000 && RupeesInATM.Numberof1000 - numberOf1000Given > 0)

                    {
                        numberOf1000Given += 1;
                        totalCashGiven += 1000;
                    }
                    while (amountTowWithdraw - totalCashGiven >= 500 && RupeesInATM.Numberof500 - numberOf500Given > 0)

                    {
                        numberOf500Given += 1;
                        totalCashGiven += 500;
                    }
                    while (amountTowWithdraw - totalCashGiven >= 100 && RupeesInATM.Numberof100 - numberOf100Given > 0)

                    {
                        numberOf100Given += 1;
                        totalCashGiven += 100;
                    }
                    while (amountTowWithdraw - totalCashGiven >= 50 && RupeesInATM.Numberof50 - numberOf50Given > 0)

                    {
                        numberOf50Given += 1;
                        totalCashGiven += 50;
                    }
                    while (amountTowWithdraw - totalCashGiven >= 20 && RupeesInATM.Numberof20 - numberOf20Given > 0)

                    {
                        numberOf20Given += 1;
                        totalCashGiven += 20;
                    }
                    while (amountTowWithdraw - totalCashGiven >= 10 && RupeesInATM.Numberof100 - numberOf10Given > 0)

                    {
                        numberOf10Given += 1;
                        totalCashGiven += 10;
                    }



                }
                else
                {
                    Console.WriteLine("ATM is out of cash.......");
                }
            }
            else
            {
                Console.WriteLine("enter the value multiple of 10");
            }
        }
        else
        {
            Console.WriteLine("enter the valid amount......");
        }
    }
}