using CRUDGrpcService.Adapters.MongoDB.Repository;
using CRUDGrpcService.Application.Mapping;

namespace CRUDGrpcService.Application.UserCase.ConsultarUSC
{
    public class USCConsultar : BaseUsercase,IUSCConsultar
    {
        public USCConsultar(IMongoRepository mongoRepository) : base(mongoRepository)
        {
        }

        public async Task<baseReturn> ConsultarUSC(RequestUsuario request)
        {
            var ret = await _mongoRepository.ConsultarUsuarioRepository(MappingUsuario.MappingMongoUsuario(request));

            return new baseReturn()
            {
                Status = 0,
                Mensagem = $"{ret}"
            };

        }
    }
}
