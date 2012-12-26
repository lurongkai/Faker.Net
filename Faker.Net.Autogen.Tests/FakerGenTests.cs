using Xunit;

namespace Faker.Net.Autogen.Tests
{
    public class FakerGenTests
    {
        private const int RANDOM_TEST_COUNT = 5;
        [Fact]
        private void TestGenerateInt32()
        {
            RANDOM_TEST_COUNT.Times(() => {
                var int1 = FakerGen.Generate<int>();
                var int2 = FakerGen.Generate<int>();
                Assert.NotEqual(int1, int2);
            });
        }
    }
}
