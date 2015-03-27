using Moq;
using AutoMoq;

namespace ControllerTest
{
    public class TestContext<T> where T : class
    {
        private readonly AutoMoqer mocker;
        private readonly MockRepository repository;
        private readonly T controller;

        protected TestContext()
        {
            this.repository = new MockRepository(MockBehavior.Default);
            this.mocker = new AutoMoqer();
            this.controller = this.mocker.Create<T>();
        }

        protected T Controller
        {
            get { return this.controller; }
        }

        protected AutoMoqer Container
        {
            get { return this.mocker; }
        }
    }
}