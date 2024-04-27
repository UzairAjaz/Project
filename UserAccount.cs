public class UserAccount
{
    public string Name { get; set; }
    public int BranchCode { get; set; }
    public int AccountNumber { get; set; }
    public int Balance { get; set; }

    public UserAccount(string name, int branchcode, int accountNumber, int balance)
    {
        Name = name;
        BranchCode = branchcode;
        AccountNumber = accountNumber;
        Balance = balance;
    }
}

