using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace InliningTest
{
    public class Implementation : SecondAssembly.BaseClass
    {
        protected override string ExecuteInternal()
        {
            // Remark:  This method is inlined in VS2015 RC in Release mode (in VS2013 it's not)
            //          Inlining will cause that "GetCallingAssembly" in nested "GetContextInfo" 
            //          method will not return current assembly.
            var name = GetContextInfo();
            return name;
        }

        private static string GetContextInfo()
        {
            var sb = new StringBuilder();
            var assembly = Assembly.GetCallingAssembly();
            sb.AppendLine(string.Format("Calling assembly: {0}", assembly.GetName().Name));
            sb.AppendLine();

            sb.AppendLine("Stack trace:");
            StackTrace st = new StackTrace(true);
            for (int i = 0; i < st.FrameCount; i++)
            {
                StackFrame sf = st.GetFrame(i);
                var method = sf.GetMethod();
                sb.AppendLine(string.Concat(Path.GetFileName(sf.GetFileName()), " | ", method));
            }

            return sb.ToString();
        }
    }
}