using CRUDGrpcService.Adapters.MongoDB.Models;

namespace CRUDGrpcService.Adapters.MongoDB.Repository
{
    public interface IMongoRepository
    {
        public void RegistrarUsuarioRepository(ModelsMongoDb request);
        public Task<dynamic> ConsultarUsuarioRepository(ModelsMongoDb request);
        public Task<dynamic> AtualizarUsuarioRepository(ModelsMongoDb request);
        public void DeletarUsuarioRepository(ModelsMongoDb request);
    }
}
