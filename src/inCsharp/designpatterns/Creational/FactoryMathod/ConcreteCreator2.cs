namespace Creational.FactoryMathod
{
    public class ConcreteCreator2 : ICreator
    {
        public IProduct Create()
        {
            return new ConcreteProduct2();
        }
    }
}
