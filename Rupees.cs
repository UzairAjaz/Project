public class Rupees
{
    public int Numberof10 { get; set; }
    public int Numberof20 { get; set; }
    public int Numberof50 { get; set; }
    public int Numberof100 { get; set; }
    public int Numberof500 { get; set; }
    public int Numberof1000 { get; set; }
    public int Numberof5000 { get; set; }

    public int TotalCurrencyValue
    {
        get
        {

            var total10s = Numberof10 * 10;
            var total20s = Numberof20 * 20;
            var total50s = Numberof50 * 50;
            var total100s = Numberof100 * 100;
            var total500s = Numberof500 * 500;
            var total1000s = Numberof1000 * 1000;
            var total5000s = Numberof5000 * 5000;

            return total10s + total20s + total50s + total100s + total500s + total1000s + total5000s;
        }
    }

    public Rupees(int currencies)
    {
        Numberof10 = currencies;
        Numberof20 = currencies;
        Numberof50 = currencies;
        Numberof100 = currencies;
        Numberof500 = currencies;
        Numberof1000 = currencies;
        Numberof5000 = currencies;
    }
    public Rupees(int numberof10, int numberof20, int numberof50, int numberof100, int numberof500, int numberof1000, int numberof5000)
    {
        Numberof10 = numberof10;
        Numberof20 = numberof20;
        Numberof50 = numberof50;
        Numberof100 = numberof100;
        Numberof500 = numberof500;
        Numberof1000 = numberof1000;
        Numberof5000 = numberof5000;
    }
}
