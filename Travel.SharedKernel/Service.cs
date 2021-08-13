using Travel.SharedKernel.Interfaces;

namespace Travel.SharedKernel
{
    public abstract class Service
    {
        protected IRepository Repository { get; }

        protected Service(IRepository repository)
        {
            Repository = repository;
        }
    }
}
