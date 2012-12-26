using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker.Net.Autogen.Tests
{
    internal static class TestHelper
    {
        public static void Times(this int num, Action action) {
            for (int i = 0; i < num; i++) {
                action();
            }
        }
    }
}
