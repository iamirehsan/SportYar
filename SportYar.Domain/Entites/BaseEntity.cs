using System.ComponentModel;

namespace SportYar.Domain.Entites
{
    public class BaseEntity
    {
        public string Id { get; set; }

    
        public DateTime CreatedAt => DateTime.Now;
   

        public DateTime? UpdateAt { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
