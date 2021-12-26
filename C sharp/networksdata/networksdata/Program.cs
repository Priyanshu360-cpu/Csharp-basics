class addsub
{
    

    public  void Sum(string a , string b) {
        
        Console.WriteLine(Convert.ToInt32(a)+Convert.ToInt32(b));
    }
    public void Sub(string a, string b)
    {
        Console.WriteLine(Convert.ToInt32(a)-Convert.ToInt32(b));
    }
    
}
class Advanced
{
    public void logging(string a,string b)
    {
        Console.WriteLine(Math.Log(Math.E, Convert.ToInt32(a) * Math.Log(Convert.ToInt32(b))));
    }
    public void power(string a,string b)
    {
        Console.WriteLine(Math.Pow(Convert.ToInt32(a), Convert.ToInt32(b)));
    }
}
public class multidiv
{
    public static int div(string a,string b)
    {
        Console.WriteLine(Convert.ToInt32(a)/Convert.ToInt32(b));
        return 0;
    }
    public static int multi(string a,string b)
    {
        Console.WriteLine(Convert.ToInt32(a)*Convert.ToInt32(b));
        return 0;
    }
} 
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("enter first number");
        var b = Console.ReadLine();
        Console.WriteLine("Enter Second number");
        var c = Console.ReadLine();
        repeat:
        Console.WriteLine("-----------\n|Calculator|\n-----------\n|Press 1 to add numbers\t|\n|Press 2 to sub numbers\t|\n|Press 3 to multi numbers|\n|Press 4 to divi numbers|\n|Press 5 for Log\t|\n|Press 6 for Power\t|");
        var a = Console.ReadLine();
        switch (a)
        {

            case "1":
                addsub d = new addsub();
                d.Sum(b, c);
                break;
            case "2":
                addsub f = new addsub();
                f.Sub(b, c);
                break;
            case "3":
                multidiv.multi(b, c);
                break;
            case "4":
                multidiv.div(b, c);
                break;
            case "5":
                Advanced s = new Advanced();
                s.logging(b,c);
                break;
            case "6":
                Advanced fo = new Advanced();
                fo.power(b, c);
                break;
            default:
                Console.WriteLine("Wrong choice");
                goto repeat;
                break;
            
        }
    }
}
