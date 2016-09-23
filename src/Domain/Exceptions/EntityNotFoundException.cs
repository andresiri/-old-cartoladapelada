using System;
namespace Domain.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public virtual int Id { get; set; }      

        public EntityNotFoundException(int id)
        {
            Id = id;            
        }
    }
}
