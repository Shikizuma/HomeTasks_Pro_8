using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks_Pro_8
{
    [Serializable]
    public class TestClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Age} - {Salary}";
        }
    }
}
