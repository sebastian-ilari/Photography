using Moq;
using AutoMoq;

namespace Common
{
    public class TestContext<T> where T : class
    {
        private readonly AutoMoqer mocker;
        private readonly MockRepository repository;
        private readonly T entity;

        protected TestContext()
        {
            this.repository = new MockRepository(MockBehavior.Loose);
            
            this.mocker = new AutoMoqer();
            this.entity = this.mocker.Create<T>();
        }

        protected T Entity
        {
            get { return this.entity; }
        }

        protected AutoMoqer Container
        {
            get { return this.mocker; }
        }
    }
}