using System;
using FaithBase.Domain.Interfaces;

namespace FaithBase.Domain
{
    public class Entity : IEntity
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}