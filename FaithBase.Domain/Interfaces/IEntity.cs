using System;

namespace FaithBase.Domain.Interfaces
{
    public interface IEntity
    {
        long Id { get; set; }
        DateTime Created { get; set; }
        DateTime Updated { get; set; }
    }
}