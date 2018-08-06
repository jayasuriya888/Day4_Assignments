using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2_17_07_2018;
namespace Day4Assignment_19_07_2018_02
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method|AttributeTargets.ReturnValue|AttributeTargets.Constructor,AllowMultiple =true)]
    class MethodInfoAttribute: Attribute
   {
        public string MethodName { get; set; }
        public string ReturnType { get; set; }
        public string Parameter { get; set; }
        public string Message { get; set; }



    }
}
