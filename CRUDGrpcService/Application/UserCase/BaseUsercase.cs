using CRUDGrpcService.Adapters.MongoDB.Repository;

namespace CRUDGrpcService.Application.UserCase
{
    public abstract class BaseUsercase
    {
        protected IMongoRepository _mongoRepository;
        public BaseUsercase(IMongoRepository mongoRepository)
        {
            _mongoRepository = mongoRepository;
        }
    }
}
