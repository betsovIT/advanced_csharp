using System;

namespace MXGP
{
    using Models.Motorcycles;
    using MXGP.Core;
    using System.Linq;
    using System.Reflection;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var engine = new Engine();
            engine.Run();
        }   
    }
}