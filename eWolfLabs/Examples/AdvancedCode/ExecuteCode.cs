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
            System.Console.WriteLine(""Hello World"");
        }
    }
}
            ";

            Dictionary<string, string> providerOptions = new Dictionary<string, string>
                {
                    {"CompilerVersion", "v3.5"}
                };
            CSharpCodeProvider provider = new CSharpCodeProvider(providerOptions);

            CompilerParameters compilerParams = new CompilerParameters
            {
                GenerateInMemory = true,
                GenerateExecutable = false
            };

            CompilerResults results = provider.CompileAssemblyFromSource(compilerParams, source);

            if (results.Errors.Count != 0)
                throw new Exception("Mission failed!");

            object o = results.CompiledAssembly.CreateInstance("Foo.Bar");
            MethodInfo mi = o.GetType().GetMethod("SayHello");
            mi.Invoke(o, null);
        }
    }
}
