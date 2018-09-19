using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace RestAspNETPersonService.Models.Base
{
    //Contrato entre os atributos e a estrutura da tabela
        
    public class BaseEntity
    {
        [Column("id")]
        public long? Id { get; set; }
    }
}
