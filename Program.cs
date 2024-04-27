class Program()
{
    public static void Main()
    {
        var muneebaccount = new UserAccount("muneeb", 1456, 31524324, 500000);


        var atm = new MeezanBank("Alafalah Bank", 12313, new Rupees(100));
        atm.WelcomeUser();
        atm.CheckBalance(muneebaccount);

    }
}


