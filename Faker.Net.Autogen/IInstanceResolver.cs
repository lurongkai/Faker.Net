using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker.Net.Autogen
{
    public interface IInstanceResolver
    {
        T GetInstance<T>() where T : class;
        IEnumerable<T> GetInstances<T>() where T : class;
    }
}
