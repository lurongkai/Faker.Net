using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker.Net.Autogen
{
    internal class DefaultInstanceService : IInstanceResolver
    {
        public T GetInstance<T>() where T : class
        {
            return Activator.CreateInstance<T>();
        }

        public IEnumerable<T> GetInstances<T>() where T : class
        {
            return Enumerable.Empty<T>();
        }
    }
}
