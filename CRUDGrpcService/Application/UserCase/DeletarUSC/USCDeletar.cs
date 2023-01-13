using CRUDGrpcService.Adapters.MongoDB.Repository;
using CRUDGrpcService.Application.Mapping;

namespace CRUDGrpcService.Application.UserCase.DeletarUSC
{
    public class USCDeletar : BaseUsercase, IUSCDeletar
    {
        public USCDeletar(IMongoRepository mongoRepository) : base(mongoRepository)
        {
        }

        public async Task<baseReturn> DeletarUSC(RequestUsuario request)
        {
              _mongoRepository.DeletarUsuarioRepository(MappingUsuario.MappingMongoUsuario(request));

            return new baseReturn() { Status = 0, Mensagem = $" Usuario Deletado com Sucesso" };
        }
    }
}
