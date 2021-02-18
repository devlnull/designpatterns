using Behavioral.Observer;
using Xunit;

namespace Tests.Behaviorals
{
    public class ObserverTests
    {
        [Fact]
        public void SendSignal_WithSomeClient_MustUpdateAll()
        {
            var testSubject = new ConcreteSubject() { SubjectState = "signal1" };
            var observer1 = new ConcreteObserver(testSubject, "observer1");
            var observer2 = new ConcreteObserver(testSubject, "observer2");
            var observer3 = new ConcreteObserver(testSubject, "observer3");

            testSubject.Attach(observer1);
            testSubject.Attach(observer2);
            testSubject.Attach(observer3);

            testSubject.Notify();

            Assert.Equal("signal1", observer1.GetState());
            Assert.Equal("signal1", observer2.GetState());
            Assert.Equal("signal1", observer2.GetState());
        }

        [Fact]
        public void Send2Signals_WithSomeClient_MustBeUpdateAtSecondSignal()
        {
            var testSubject = new ConcreteSubject() { SubjectState = "signal1" };
            var observer1 = new ConcreteObserver(testSubject, "observer1");
            var observer2 = new ConcreteObserver(testSubject, "observer2");
            var observer3 = new ConcreteObserver(testSubject, "observer3");

            testSubject.Attach(observer1);
            testSubject.Attach(observer2);
            testSubject.Attach(observer3);

            testSubject.Notify();
            Assert.Equal("signal1", observer1.GetState());
            Assert.Equal("signal1", observer2.GetState());
            Assert.Equal("signal1", observer2.GetState());

            testSubject.SubjectState = "signal2";
            testSubject.Notify();

            Assert.Equal("signal2", observer1.GetState());
            Assert.Equal("signal2", observer2.GetState());
            Assert.Equal("signal2", observer2.GetState());
        }
    }
}
