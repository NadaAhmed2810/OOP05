using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Partial
{
    internal partial class Employee
    {
        public string? Address {  get; set; }
        partial  void DoSomeThing()
        {
            int x = 10;
            x++;
            Console.WriteLine(x);
        }
    }
}
