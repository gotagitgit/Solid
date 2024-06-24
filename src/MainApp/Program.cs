using MainApp.DIP;
using MainApp.ISP;
using MainApp.LSP;
using MainApp.OCP;
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
        //ISPDemo.RunDemo();

        // DIP Demo
        //DIPDemo.RunDemo();

        // OCP Demo
        OCPDemo.RunDemo();

        Console.ReadLine();

    }
}
