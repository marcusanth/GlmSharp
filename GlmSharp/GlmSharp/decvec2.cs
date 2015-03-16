using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct decvec2 : IReadOnlyList<decimal>, IEquatable<decvec2>
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        public decimal x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public decimal y;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_decvec2 swizzle => new swizzle_decvec2(x, y);
        
        /// <summary>
        /// Predefined all-zero vector (DO NOT MODIFY)
        /// </summary>
        public static readonly decvec2 Zero = new decvec2(default(decimal), default(decimal));
        
        /// <summary>
        /// Predefined all-ones vector (DO NOT MODIFY)
        /// </summary>
        public static readonly decvec2 Ones = new decvec2(1m, 1m);
        
        /// <summary>
        /// Predefined unit-X vector (DO NOT MODIFY)
        /// </summary>
        public static readonly decvec2 UnitX = new decvec2(1m, default(decimal));
        
        /// <summary>
        /// Predefined unit-Y vector (DO NOT MODIFY)
        /// </summary>
        public static readonly decvec2 UnitY = new decvec2(default(decimal), 1m);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public decimal[] Values => new[] { x, y };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public decvec2(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public decvec2(decimal v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public decvec2(decvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public decvec2(decvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public decvec2(decvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(decvec2 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec3(decvec2 v) => new ivec3((int)v.x, (int)v.y, default(int));
        
        /// <summary>
        /// Explicitly converts this to a ivec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec4(decvec2 v) => new ivec4((int)v.x, (int)v.y, default(int), default(int));
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(decvec2 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec3(decvec2 v) => new uvec3((uint)v.x, (uint)v.y, default(uint));
        
        /// <summary>
        /// Explicitly converts this to a uvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec4(decvec2 v) => new uvec4((uint)v.x, (uint)v.y, default(uint), default(uint));
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(decvec2 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec3(decvec2 v) => new vec3((float)v.x, (float)v.y, default(float));
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(decvec2 v) => new vec4((float)v.x, (float)v.y, default(float), default(float));
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(decvec2 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec3(decvec2 v) => new dvec3((double)v.x, (double)v.y, default(double));
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(decvec2 v) => new dvec4((double)v.x, (double)v.y, default(double), default(double));
        
        /// <summary>
        /// Explicitly converts this to a decvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec3(decvec2 v) => new decvec3((decimal)v.x, (decimal)v.y, default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a decvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec4(decvec2 v) => new decvec4((decimal)v.x, (decimal)v.y, default(decimal), default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(decvec2 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec3(decvec2 v) => new cvec3((Complex)v.x, (Complex)v.y, default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a cvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec4(decvec2 v) => new cvec4((Complex)v.x, (Complex)v.y, default(Complex), default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(decvec2 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec3(decvec2 v) => new lvec3((long)v.x, (long)v.y, default(long));
        
        /// <summary>
        /// Explicitly converts this to a lvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec4(decvec2 v) => new lvec4((long)v.x, (long)v.y, default(long), default(long));
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(decvec2 v) => new bvec2(v.x != default(decimal), v.y != default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a bvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec3(decvec2 v) => new bvec3(v.x != default(decimal), v.y != default(decimal), default(bool));
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(decvec2 v) => new bvec4(v.x != default(decimal), v.y != default(decimal), default(bool), default(bool));
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<decimal> GetEnumerator()
        {
            yield return x;
            yield return y;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public int Count => 2;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public decimal this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: this.x = value; break;
                    case 1: this.y = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(decvec2 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is decvec2 && Equals((decvec2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(decvec2 lhs, decvec2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(decvec2 lhs, decvec2 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((x.GetHashCode()) * 397) ^ y.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public decimal MinElement => Math.Min(x, y);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public decimal MaxElement => Math.Max(x, y);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public decimal Length => (decimal)x*x + y*y.Sqrt();
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public decimal LengthSqr => x*x + y*y;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public decimal Sum => x + y;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public decimal Norm => (decimal)x*x + y*y.Sqrt();
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public decimal Norm1 => Math.Abs(x) + Math.Abs(y);
        
        /// <summary>
        /// Returns the two-norm of this vector.
        /// </summary>
        public decimal Norm2 => (decimal)x*x + y*y.Sqrt();
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public decimal NormMax => Math.Max(Math.Abs(x), Math.Abs(y));
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow((double)Math.Abs(x), p) + Math.Pow((double)Math.Abs(y), p), 1 / p);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static decvec2 operator+(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static decvec2 operator+(decvec2 lhs, decimal rhs) => new decvec2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static decvec2 operator+(decimal lhs, decvec2 rhs) => new decvec2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static decvec2 operator-(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static decvec2 operator-(decvec2 lhs, decimal rhs) => new decvec2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static decvec2 operator-(decimal lhs, decvec2 rhs) => new decvec2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static decvec2 operator/(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static decvec2 operator/(decvec2 lhs, decimal rhs) => new decvec2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static decvec2 operator/(decimal lhs, decvec2 rhs) => new decvec2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static decvec2 operator*(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static decvec2 operator*(decvec2 lhs, decimal rhs) => new decvec2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static decvec2 operator*(decimal lhs, decvec2 rhs) => new decvec2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Executes a component-wise unary + (add).
        /// </summary>
        public static decvec2 operator+(decvec2 v) => v;
        
        /// <summary>
        /// Executes a component-wise unary - (subtract).
        /// </summary>
        public static decvec2 operator-(decvec2 v) => new decvec2(-v.x, -v.y);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bvec2 operator<(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator<(decvec2 lhs, decimal rhs) => new bvec2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator<(decimal lhs, decvec2 rhs) => new bvec2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bvec2 operator<=(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator<=(decvec2 lhs, decimal rhs) => new bvec2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator<=(decimal lhs, decvec2 rhs) => new bvec2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bvec2 operator>(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator>(decvec2 lhs, decimal rhs) => new bvec2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator>(decimal lhs, decvec2 rhs) => new bvec2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bvec2 operator>=(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator>=(decvec2 lhs, decimal rhs) => new bvec2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator>=(decimal lhs, decvec2 rhs) => new bvec2(lhs >= rhs.x, lhs >= rhs.y);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public decvec2 Normalized => this / Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public decvec2 NormalizedSafe => this == Zero ? Zero : this / Length;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static decimal Dot(decvec2 lhs, decvec2 rhs) => lhs.x * rhs.x + lhs.y * rhs.y;
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static decimal Distance(decvec2 lhs, decvec2 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static decimal DistanceSqr(decvec2 lhs, decvec2 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static decimal Cross(decvec2 l, decvec2 r) => l.x * r.y - l.y * r.x;
        
        /// <summary>
        /// Returns the vector angle (atan2(y, x)) in radians.
        /// </summary>
        public double Angle => Math.Atan2((double)y, (double)x);
        
        /// <summary>
        /// Returns a unit 2D vector with a given angle in radians (CAUTION: result may be truncated for integer types).
        /// </summary>
        public static decvec2 FromAngle(double angleInRad) => new decvec2((decimal)Math.Cos(angleInRad), (decimal)Math.Sin(angleInRad));
        
        /// <summary>
        /// Returns a 2D vector that was rotated by a given angle in radians (CAUTION: result is casted and may be truncated).
        /// </summary>
        public decvec2 Rotated(double angleInRad) => (decvec2)(dvec2.FromAngle(Angle) * (double)Length);
        
        /// <summary>
        /// Returns a component-wise executed Abs.
        /// </summary>
        public static decvec2 Abs(decvec2 v) => new decvec2(Math.Abs(v.x), Math.Abs(v.y));
        
        /// <summary>
        /// Returns a component-wise executed Acos.
        /// </summary>
        public static decvec2 Acos(decvec2 v) => new decvec2((decimal)Math.Acos((double)v.x), (decimal)Math.Acos((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Asin.
        /// </summary>
        public static decvec2 Asin(decvec2 v) => new decvec2((decimal)Math.Asin((double)v.x), (decimal)Math.Asin((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Atan.
        /// </summary>
        public static decvec2 Atan(decvec2 v) => new decvec2((decimal)Math.Atan((double)v.x), (decimal)Math.Atan((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Cos.
        /// </summary>
        public static decvec2 Cos(decvec2 v) => new decvec2((decimal)Math.Cos((double)v.x), (decimal)Math.Cos((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Cosh.
        /// </summary>
        public static decvec2 Cosh(decvec2 v) => new decvec2((decimal)Math.Cosh((double)v.x), (decimal)Math.Cosh((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Exp.
        /// </summary>
        public static decvec2 Exp(decvec2 v) => new decvec2((decimal)Math.Exp((double)v.x), (decimal)Math.Exp((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static decvec2 Log(decvec2 v) => new decvec2((decimal)Math.Log((double)v.x), (decimal)Math.Log((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Log2.
        /// </summary>
        public static decvec2 Log2(decvec2 v) => new decvec2((decimal)Math.Log((double)v.x, 2), (decimal)Math.Log((double)v.y, 2));
        
        /// <summary>
        /// Returns a component-wise executed Log10.
        /// </summary>
        public static decvec2 Log10(decvec2 v) => new decvec2((decimal)Math.Log10((double)v.x), (decimal)Math.Log10((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Floor.
        /// </summary>
        public static decvec2 Floor(decvec2 v) => new decvec2((decimal)Math.Floor(v.x), (decimal)Math.Floor(v.y));
        
        /// <summary>
        /// Returns a component-wise executed Ceiling.
        /// </summary>
        public static decvec2 Ceiling(decvec2 v) => new decvec2((decimal)Math.Ceiling(v.x), (decimal)Math.Ceiling(v.y));
        
        /// <summary>
        /// Returns a component-wise executed Round.
        /// </summary>
        public static decvec2 Round(decvec2 v) => new decvec2((decimal)Math.Round(v.x), (decimal)Math.Round(v.y));
        
        /// <summary>
        /// Returns a component-wise executed Sin.
        /// </summary>
        public static decvec2 Sin(decvec2 v) => new decvec2((decimal)Math.Sin((double)v.x), (decimal)Math.Sin((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Sinh.
        /// </summary>
        public static decvec2 Sinh(decvec2 v) => new decvec2((decimal)Math.Sinh((double)v.x), (decimal)Math.Sinh((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Sqrt.
        /// </summary>
        public static decvec2 Sqrt(decvec2 v) => new decvec2((decimal)Math.Sqrt((double)v.x), (decimal)Math.Sqrt((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Tan.
        /// </summary>
        public static decvec2 Tan(decvec2 v) => new decvec2((decimal)Math.Tan((double)v.x), (decimal)Math.Tan((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Tanh.
        /// </summary>
        public static decvec2 Tanh(decvec2 v) => new decvec2((decimal)Math.Tanh((double)v.x), (decimal)Math.Tanh((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Truncate.
        /// </summary>
        public static decvec2 Truncate(decvec2 v) => new decvec2((decimal)Math.Truncate((double)v.x), (decimal)Math.Truncate((double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Sign.
        /// </summary>
        public static ivec2 Sign(decvec2 v) => new ivec2(Math.Sign(v.x), Math.Sign(v.y));
        
        /// <summary>
        /// Returns a component-wise executed Sqr.
        /// </summary>
        public static decvec2 Sqr(decvec2 v) => new decvec2(v.x * v.x, v.y * v.y);
        
        /// <summary>
        /// Returns a component-wise executed Max.
        /// </summary>
        public static decvec2 Max(decvec2 lhs, decvec2 rhs) => new decvec2(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static decvec2 Max(decvec2 v, decimal s) => new decvec2(Math.Max(v.x, s), Math.Max(v.y, s));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static decvec2 Max(decimal s, decvec2 v) => new decvec2(Math.Max(s, v.x), Math.Max(s, v.y));
        
        /// <summary>
        /// Returns a component-wise executed Min.
        /// </summary>
        public static decvec2 Min(decvec2 lhs, decvec2 rhs) => new decvec2(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static decvec2 Min(decvec2 v, decimal s) => new decvec2(Math.Min(v.x, s), Math.Min(v.y, s));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static decvec2 Min(decimal s, decvec2 v) => new decvec2(Math.Min(s, v.x), Math.Min(s, v.y));
        
        /// <summary>
        /// Returns a component-wise executed Pow.
        /// </summary>
        public static decvec2 Pow(decvec2 lhs, decvec2 rhs) => new decvec2((decimal)Math.Pow((double)lhs.x, (double)rhs.x), (decimal)Math.Pow((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static decvec2 Pow(decvec2 v, decimal s) => new decvec2((decimal)Math.Pow((double)v.x, (double)s), (decimal)Math.Pow((double)v.y, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static decvec2 Pow(decimal s, decvec2 v) => new decvec2((decimal)Math.Pow((double)s, (double)v.x), (decimal)Math.Pow((double)s, (double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static decvec2 Log(decvec2 lhs, decvec2 rhs) => new decvec2((decimal)Math.Log((double)lhs.x, (double)rhs.x), (decimal)Math.Log((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static decvec2 Log(decvec2 v, decimal s) => new decvec2((decimal)Math.Log((double)v.x, (double)s), (decimal)Math.Log((double)v.y, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static decvec2 Log(decimal s, decvec2 v) => new decvec2((decimal)Math.Log((double)s, (double)v.x), (decimal)Math.Log((double)s, (double)v.y));
    }
}