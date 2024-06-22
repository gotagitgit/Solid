using MainApp.ISP;
using MainApp.LSP;
using MainApp.SRP;

namespace MainApp;

internal class Program
{
    static void Main(string[] args)
    {
        // SRP Demo
        //SRPDemo.NoSRP();
        //SRPDemo.WithSRP();

        // LSP Demo
        //LSPDemo.Run();

        // ISP Demo
        ISPDemo.RunDemo();

        Console.ReadLine();

    }
}
