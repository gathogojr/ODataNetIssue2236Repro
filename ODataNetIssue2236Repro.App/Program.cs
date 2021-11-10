using System;
using Default;

namespace ODataNetIssue2236Repro.App
{
    class Program
    {
        private const string ServiceUri = "http://localhost:8775/odata";

        static void Main(string[] args)
        {
            var context = new Container(new Uri(ServiceUri));

            var whoAmI = context.WhoAmI().GetValue();
        }
    }
}
