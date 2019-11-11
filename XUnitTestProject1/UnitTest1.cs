using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TrueDoer()
        {
            DoThingService doThingService = new DoThingService(new TrueDoer());
            bool somethingDone = doThingService.Do();
            Assert.True(somethingDone);
        }

        [Fact]
        public void FalseDoer()
        {
            DoThingService doThingService = new DoThingService(new FalseDoer());
            bool somethingDone = doThingService.Do();
            Assert.False(somethingDone);
        }
    }

    public interface IDoThings
    {
        bool Do();
    }

    public class FalseDoer : IDoThings
    {
        public bool Do()
        {
            return false;
        }
    }

    public class TrueDoer : IDoThings
    {
        public bool Do()
        {
            return true;
        }
    }

    public class DoThingService
    {
        private readonly IDoThings _doer;


        public DoThingService(IDoThings doer)
        {
            _doer = doer;
        }

        public bool Do()
        {
            return _doer.Do();
        }
    }
}
