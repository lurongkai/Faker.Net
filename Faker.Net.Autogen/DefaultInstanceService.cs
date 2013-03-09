using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker.Net.Autogen
{
    internal class DefaultInstanceService : IInstanceService
    {
        public T GetInstance<T>() where T : class {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetInstances<T>() where T : class {
            throw new NotImplementedException();
        }
    }
}
