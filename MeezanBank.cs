class MeezanBank : ATM
{

    public MeezanBank(string bankName, int branchcode, Rupees rupees) : base("Meezan Bank", bankName, branchcode, rupees)
    {

    }
    public MeezanBank(string bankName, int branchcode, int numberOf10, int numberOf20, int numberOf50, int numberOf100, int numberOf500, int numberOf1000, int numberOf5000)
                    : base("Meezan Bank", bankName, branchcode, numberOf10, numberOf20, numberOf50, numberOf100, numberOf500, numberOf1000, numberOf5000)
    {

    }
}