using Structural.Composite;
using Xunit;

namespace Tests.Structural
{
    public class CompositeTests
    {
        [Fact]
        public void Composite_CompositeWithLeafs_MustBeAbleToAccessLeafs()
        {
            var composite = new Composite("mom");
            var girl = new Leaf("girl");
            var boy = new Leaf("boy");

            composite.Add(girl);
            composite.Add(boy);


            Assert.Contains("boy", composite.ToString());
            Assert.Contains("girl", composite.ToString());
        }

        [Fact]
        public void Composite_Leafs_MustNotBeAbleToAccessComposite()
        {
            var composite = new Composite("mom");
            var boy = new Leaf("boy");

            composite.Add(boy);

            Assert.DoesNotContain("mom", boy.ToString());
        }
    }
}
