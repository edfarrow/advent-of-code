using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Console.Test.Integration
{
    public static class IntegrationTestConstants
    {
        public static IEnumerable<IntegrationTestSampleData> Input1 = new List<IntegrationTestSampleData>
        {
            new IntegrationTestSampleData("1", 1),
            new IntegrationTestSampleData("1\r\n2", 3),
            new IntegrationTestSampleData("1000\r\n2000\r\n3000\r\n\r\n4000\r\n\r\n5000\r\n6000\r\n\r\n7000\r\n8000\r\n9000\r\n\r\n10000", 24000)
        };
    }
}
