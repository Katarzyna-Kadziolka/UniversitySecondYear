using System;


public interface IClient
{
    string GetData();
}

public class RealClient : IClient
{
    public string Data { get; set; }
    //

    public RealClient()
    {
        Console.WriteLine("RealClient: Initialized");
        Data = "WSEI data";
    }

    public string GetData()
    {
        return Data;
    }
}


public class ProxyClient : IClient
{
    RealClient client = null;
    private bool _authenticated = false;
    private string _pass = "dobrehaslo";

    public ProxyClient(string password)
    {
        if (password == _pass)
        {
            _authenticated = true;
            Console.WriteLine("ProxyClient: Initialized");
            client = new RealClient();
        }
        else
        {
            _authenticated = false; // dla pewności :)
        }
    }

    public string GetData()
    {
        if (_authenticated)
        {
            return $"Data from Proxy Client = {client.GetData()}";
        }
        else {
            return "ProxyClient: Access denied";
        }
    }
}


class Program
{
    static void Main(string[] args)
    {

        ProxyClient proxy1 = new ProxyClient("zlehaslo");
        Console.WriteLine(proxy1.GetData());
        Console.WriteLine();

        ProxyClient proxy2 = new ProxyClient("dobrehaslo");
        Console.WriteLine(proxy2.GetData());
        //

    }

    

}