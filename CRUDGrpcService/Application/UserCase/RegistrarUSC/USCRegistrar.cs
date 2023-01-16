using CRUDGrpcService.Adapters.MongoDB.Repository;
using CRUDGrpcService.Application.Mapping;

namespace CRUDGrpcService.Application.UserCase.RegistrarUSC
{
    public class USCRegistrar : BaseUsercase, IUSCRegistrar
    {
        public USCRegistrar(IMongoRepository mongoRepository) : base(mongoRepository)
        {
        }

        public async Task<string> RegistrarUSC(RequestUsuario request)
        {
            _mongoRepository.RegistrarUsuarioRepository(MappingUsuario.MappingMongoUsuario(request));

            return "usuario Cadastrado com sucesso";
        }
    }
}
