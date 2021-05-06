using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SteamingContent_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // to call a method from another class, we must new up that class 
            ProgramUI ui = new ProgramUI();
            ui.Run();
        }
    }
}
