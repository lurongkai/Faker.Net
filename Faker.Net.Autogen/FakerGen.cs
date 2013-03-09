using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker.Net.Autogen
{
    public class FakerGen
    {
        private readonly static Random _random = new Random();

        public static T Generate<T>() {
            if (typeof(T) == typeof(int)) {
                return (T)(object)_random.Next();
            }

            return default(T);
        }

        public static IEnumerable<T> GenerateList<T>() {
            throw new NotImplementedException();
        }

        public static T RecoverySnapshot<T>()
        {
            throw new NotImplementedException();
        }
    }
}
