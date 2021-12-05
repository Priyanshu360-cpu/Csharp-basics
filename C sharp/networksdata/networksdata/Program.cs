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
        Console.WriteLine("Calculator\nPress 1 to add numbers\nPress 2 to sub numbers\n Press 3 to multi numbers\nPress 4 to divi numbers");
        var a = Console.ReadLine();
        Console.WriteLine("enter first number");
        var b = Console.ReadLine();
        Console.WriteLine("Enter Second number");
        var c = Console.ReadLine();
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
        }
    }
}