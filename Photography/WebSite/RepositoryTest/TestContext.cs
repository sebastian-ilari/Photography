using Moq;
using AutoMoq;

namespace RepositoryTest
{
    public class TestContext<T> where T : class
    {
        private readonly AutoMoqer mocker;
        private readonly MockRepository repository;
        private readonly T service;

        protected TestContext()
        {
            this.repository = new MockRepository(MockBehavior.Default);
            this.mocker = new AutoMoqer();
            this.service = this.mocker.Create<T>();
        }

        protected T Service
        {
            get { return this.service; }
        }

        protected AutoMoqer Container
        {
            get { return this.mocker; }
        }
    }
}