using System;
namespace FoodAppHomework.Domain.Models
{
    public interface IEntity
    {
        public int Id { get; set; }
    }

    public class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
