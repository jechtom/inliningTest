using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InliningTest.SecondAssembly
{
    public abstract class BaseClass
    {
        public void Execute()
        {
            var name = ExecuteInternal();
            Console.WriteLine(name);
        }

        protected abstract string ExecuteInternal();
    }
}
