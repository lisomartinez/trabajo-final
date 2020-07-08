using System;

namespace Entidades
{
    public abstract class Entidad : IEquatable<Entidad>
    {
        public Id Id { get; set; }

        protected Entidad(Id id)
        {
            Id = id;
        }

        public bool Equals(Entidad other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is Entidad other && Equals(other);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }

        public static bool operator ==(Entidad left, Entidad right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Entidad left, Entidad right)
        {
            return !Equals(left, right);
        }
    }
}