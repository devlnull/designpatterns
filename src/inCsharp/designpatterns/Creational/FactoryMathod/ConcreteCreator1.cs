namespace Creational.FactoryMathod
{
    public class ConcreteCreator1 : ICreator
    {
        public IProduct Create()
        {
            return new ConcreteProduct1();
        }
    }
}
