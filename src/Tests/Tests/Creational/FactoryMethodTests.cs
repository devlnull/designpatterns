using Creational.FactoryMathod;
using Xunit;

namespace Tests.Creational
{
    public class FactoryMethodTests
    {

        [Fact]
        public void CreateProduct_Creator2_MustCreateProduct2()
        {
            var creator2 = new ConcreteCreator2();
            IProduct product = creator2.Create();

            Assert.True(product is ConcreteProduct2);
        }

    }
}
