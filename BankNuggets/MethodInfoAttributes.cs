using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankNuggets
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class MethodInfoAttribute : Attribute
    {
        public string Description { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public MethodInfoAttribute(string description)
        {
            Description = description;
        }
        public MethodInfoAttribute(string description, string input, string output)
        {
            Description = description;
            Input = input;
            Output = output;
        }
    }
}
