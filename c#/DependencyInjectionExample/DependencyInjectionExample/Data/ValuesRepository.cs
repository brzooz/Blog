using System;
using System.Collections.Generic;

namespace DependencyInjectionExample.Data
{
    public class ValuesRepository : IValuesRepository
    {
        public IEnumerable<string> GetValues()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
