using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;

namespace Examples.AdvancedCode
{
    public class ExecuteCode
    {
        public ExecuteCode()
        {
            string source =
@"
namespace Foo
{
    public class Bar
    {
        public void SayHello()
        {
            System.Console.WriteLine(""Hello World B"");
        }

        public bool CheckField(string fieldData)
        {
           return !string.IsNullOrWhiteSpace(fieldData);
        }
    }
}
";
            Dictionary<string, string> providerOptions = new Dictionary<string, string>
                {
                    {"CompilerVersion", "v3.5"}
                };

            CompilerParameters compilerParams = new CompilerParameters
            {
                GenerateInMemory = true,
                GenerateExecutable = false,
            };
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add("System.Core.dll");
            compilerParams.ReferencedAssemblies.Add("Microsoft.CSharp.dll");

            CodeDomProvider compiler = CSharpCodeProvider.CreateProvider("CSharp");
            CompilerResults results = compiler.CompileAssemblyFromSource(compilerParams, source);

            if (results.Errors.Count != 0)
                throw new Exception("Mission failed! " + results.Errors[0].ErrorText);

            object o = results.CompiledAssembly.CreateInstance("Foo.Bar");
            MethodInfo mi = o.GetType().GetMethod("SayHello");
            mi.Invoke(o, null);
        }
    }
}
