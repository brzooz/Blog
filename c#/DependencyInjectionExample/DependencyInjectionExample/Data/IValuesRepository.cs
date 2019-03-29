using System.Collections.Generic;

namespace DependencyInjectionExample.Data
{
    public interface IValuesRepository
    {
        IEnumerable<string> GetValues();
    }
}