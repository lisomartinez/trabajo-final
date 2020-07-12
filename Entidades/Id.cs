using System;

namespace Entidades
{
    public class Id : IEquatable<Id>
    {
        private int _value;

        public Id(int value)
        {
            _value = value;
        }

        public static Id Empty => new Id(-1);

        public bool Equals(Id other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is Id other && Equals(other);
        }

        public override int GetHashCode()
        {
            return _value;
        }

        public int AsInt()
        {
            return _value;
        }
    }
}