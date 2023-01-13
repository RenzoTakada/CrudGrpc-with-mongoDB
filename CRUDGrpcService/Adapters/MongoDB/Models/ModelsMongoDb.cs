using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CRUDGrpcService.Adapters.MongoDB.Models
{
    public class ModelsMongoDb
    {
        [BsonId]
        public int Id { get; set; }
        [BsonElement("tipo")]
        public int tipo { get; set; }
        [BsonElement("nome")]
        public string nome { get; set; }
        [BsonElement("idade")]
        public int idade { get; set; }
        [BsonElement("numeroConta")]
        public string numeroConta { get; set; }
        [BsonElement("agencia")]
        public string agencia { get; set; }
        [BsonElement("saldo")]
        public double saldo { get; set; 
        }

    }
}
