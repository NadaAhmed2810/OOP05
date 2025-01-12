using OOP05._ٍSealed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using total 
namespace OOP05.Partial
{
    internal partial class Employee:Parent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        //Partial Method
        partial void DoSomeThing();
        public void Test()
        {
            DoSomeThing();  
        }
    }
}
