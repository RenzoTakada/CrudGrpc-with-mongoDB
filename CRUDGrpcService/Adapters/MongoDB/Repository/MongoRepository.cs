using CRUDGrpcService.Adapters.MongoDB.Connection;
using CRUDGrpcService.Adapters.MongoDB.Models;
using MongoDB.Driver;

namespace CRUDGrpcService.Adapters.MongoDB.Repository
{
    public class MongoRepository : IMongoRepository
    {
        private IMongoCollection<ModelsMongoDb> mongoConnection;
        public MongoRepository(ConnectionMongo connectionMongo)
        {

            IMongoClient client = new MongoClient(connectionMongo.connections);
            IMongoDatabase database = client.GetDatabase("APIcrudGrpc");
            mongoConnection = database.GetCollection<ModelsMongoDb>("Usuario");
        }


        public async void RegistrarUsuarioRepository(ModelsMongoDb request)
        {
            await mongoConnection.InsertOneAsync(request);

        }
        public async Task<dynamic> ConsultarUsuarioRepository(ModelsMongoDb request)
        {
            var ret = mongoConnection.Find(x => x.Id == request.Id).FirstOrDefault();
            return ret;
        }
        public async Task<dynamic> AtualizarUsuarioRepository(ModelsMongoDb request)
        {
            var ret = mongoConnection.InsertOneAsync(request);
            return ret;
        }
        public async void DeletarUsuarioRepository(ModelsMongoDb request)
        {
            await mongoConnection.DeleteOneAsync(x => x.Id == request.Id);

        }
    }
}
