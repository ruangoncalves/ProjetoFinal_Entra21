using System;

namespace Domain
{
    public abstract class Entidade
    {
        public Guid Id { get; protected set;} = Guid.NewGuid();
    }
}