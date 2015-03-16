using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct cvec4 : IReadOnlyList<Complex>, IEquatable<cvec4>
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        public Complex x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public Complex y;
        
        /// <summary>
        /// z-component
        /// </summary>
        public Complex z;
        
        /// <summary>
        /// w-component
        /// </summary>
        public Complex w;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_cvec4 swizzle => new swizzle_cvec4(x, y, z, w);
        
        /// <summary>
        /// Predefined all-zero vector (DO NOT MODIFY)
        /// </summary>
        public static readonly cvec4 Zero = new cvec4(default(Complex), default(Complex), default(Complex), default(Complex));
        
        /// <summary>
        /// Predefined all-ones vector (DO NOT MODIFY)
        /// </summary>
        public static readonly cvec4 Ones = new cvec4(1.0, 1.0, 1.0, 1.0);
        
        /// <summary>
        /// Predefined unit-X vector (DO NOT MODIFY)
        /// </summary>
        public static readonly cvec4 UnitX = new cvec4(1.0, default(Complex), default(Complex), default(Complex));
        
        /// <summary>
        /// Predefined unit-Y vector (DO NOT MODIFY)
        /// </summary>
        public static readonly cvec4 UnitY = new cvec4(default(Complex), 1.0, default(Complex), default(Complex));
        
        /// <summary>
        /// Predefined unit-Z vector (DO NOT MODIFY)
        /// </summary>
        public static readonly cvec4 UnitZ = new cvec4(default(Complex), default(Complex), 1.0, default(Complex));
        
        /// <summary>
        /// Predefined unit-W vector (DO NOT MODIFY)
        /// </summary>
        public static readonly cvec4 UnitW = new cvec4(default(Complex), default(Complex), default(Complex), 1.0);
        
        /// <summary>
        /// Predefined all-imaginary-ones vector (DO NOT MODIFY)
        /// </summary>
        public static readonly cvec4 ImaginaryOnes = new cvec4(Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne);
        
        /// <summary>
        /// Predefined unit-imaginary-X vector (DO NOT MODIFY)
        /// </summary>
        public static readonly cvec4 ImaginaryUnitX = new cvec4(Complex.ImaginaryOne, default(Complex), default(Complex), default(Complex));
        
        /// <summary>
        /// Predefined unit-imaginary-Y vector (DO NOT MODIFY)
        /// </summary>
        public static readonly cvec4 ImaginaryUnitY = new cvec4(default(Complex), Complex.ImaginaryOne, default(Complex), default(Complex));
        
        /// <summary>
        /// Predefined unit-imaginary-Z vector (DO NOT MODIFY)
        /// </summary>
        public static readonly cvec4 ImaginaryUnitZ = new cvec4(default(Complex), default(Complex), Complex.ImaginaryOne, default(Complex));
        
        /// <summary>
        /// Predefined unit-imaginary-W vector (DO NOT MODIFY)
        /// </summary>
        public static readonly cvec4 ImaginaryUnitW = new cvec4(default(Complex), default(Complex), default(Complex), Complex.ImaginaryOne);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public Complex[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public cvec4(Complex x, Complex y, Complex z, Complex w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public cvec4(Complex v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public cvec4(cvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = default(Complex);
            this.w = default(Complex);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public cvec4(cvec2 v, Complex z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = default(Complex);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public cvec4(cvec2 v, Complex z, Complex w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public cvec4(cvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = default(Complex);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public cvec4(cvec3 v, Complex w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public cvec4(cvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(cvec4 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(cvec4 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<Complex> GetEnumerator()
        {
            yield return x;
            yield return y;
            yield return z;
            yield return w;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public Complex this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    case 3: return w;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: this.x = value; break;
                    case 1: this.y = value; break;
                    case 2: this.z = value; break;
                    case 3: this.w = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(cvec4 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y) && z.Equals(rhs.z) && w.Equals(rhs.w);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is cvec4 && Equals((cvec4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(cvec4 lhs, cvec4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(cvec4 lhs, cvec4 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((x.GetHashCode()) * 397) ^ y.GetHashCode()) * 397) ^ z.GetHashCode()) * 397) ^ w.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a vector containing component-wise magnitudes.
        /// </summary>
        public dvec4 Magnitude => new dvec4(x.Magnitude, y.Magnitude, z.Magnitude, w.Magnitude);
        
        /// <summary>
        /// Returns a vector containing component-wise phases.
        /// </summary>
        public dvec4 Phase => new dvec4(x.Phase, y.Phase, z.Phase, w.Phase);
        
        /// <summary>
        /// Returns a vector containing component-wise imaginary parts.
        /// </summary>
        public dvec4 Imaginary => new dvec4(x.Imaginary, y.Imaginary, z.Imaginary, w.Imaginary);
        
        /// <summary>
        /// Returns a vector containing component-wise real parts.
        /// </summary>
        public dvec4 Real => new dvec4(x.Real, y.Real, z.Real, w.Real);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public double Length => (double)Math.Sqrt(x.LengthSqr() + y.LengthSqr() + z.LengthSqr() + w.LengthSqr());
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public double LengthSqr => x.LengthSqr() + y.LengthSqr() + z.LengthSqr() + w.LengthSqr();
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public Complex Sum => x + y + z + w;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public double Norm => (double)Math.Sqrt(x.LengthSqr() + y.LengthSqr() + z.LengthSqr() + w.LengthSqr());
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public double Norm1 => x.Magnitude + y.Magnitude + z.Magnitude + w.Magnitude;
        
        /// <summary>
        /// Returns the two-norm of this vector.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt(x.LengthSqr() + y.LengthSqr() + z.LengthSqr() + w.LengthSqr());
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public Complex NormMax => Math.Max(Math.Max(Math.Max(x.Magnitude, y.Magnitude), z.Magnitude), w.Magnitude);
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow((double)x.Magnitude, p) + Math.Pow((double)y.Magnitude, p) + Math.Pow((double)z.Magnitude, p) + Math.Pow((double)w.Magnitude, p), 1 / p);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static cvec4 operator+(cvec4 lhs, cvec4 rhs) => new cvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static cvec4 operator+(cvec4 lhs, Complex rhs) => new cvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static cvec4 operator+(Complex lhs, cvec4 rhs) => new cvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static cvec4 operator-(cvec4 lhs, cvec4 rhs) => new cvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static cvec4 operator-(cvec4 lhs, Complex rhs) => new cvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static cvec4 operator-(Complex lhs, cvec4 rhs) => new cvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static cvec4 operator/(cvec4 lhs, cvec4 rhs) => new cvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static cvec4 operator/(cvec4 lhs, Complex rhs) => new cvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static cvec4 operator/(Complex lhs, cvec4 rhs) => new cvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static cvec4 operator*(cvec4 lhs, cvec4 rhs) => new cvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static cvec4 operator*(cvec4 lhs, Complex rhs) => new cvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static cvec4 operator*(Complex lhs, cvec4 rhs) => new cvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Executes a component-wise unary + (add).
        /// </summary>
        public static cvec4 operator+(cvec4 v) => v;
        
        /// <summary>
        /// Executes a component-wise unary - (subtract).
        /// </summary>
        public static cvec4 operator-(cvec4 v) => new cvec4(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public cvec4 Normalized => this / Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public cvec4 NormalizedSafe => this == Zero ? Zero : this / Length;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static Complex Dot(cvec4 lhs, cvec4 rhs) => lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z + lhs.w * rhs.w;
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(cvec4 lhs, cvec4 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(cvec4 lhs, cvec4 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Returns a component-wise executed Abs.
        /// </summary>
        public static dvec4 Abs(cvec4 v) => new dvec4(v.x.Magnitude, v.y.Magnitude, v.z.Magnitude, v.w.Magnitude);
        
        /// <summary>
        /// Returns a component-wise executed complex Acos.
        /// </summary>
        public static cvec4 Acos(cvec4 v) => new cvec4(Complex.Acos(v.x), Complex.Acos(v.y), Complex.Acos(v.z), Complex.Acos(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Asin.
        /// </summary>
        public static cvec4 Asin(cvec4 v) => new cvec4(Complex.Asin(v.x), Complex.Asin(v.y), Complex.Asin(v.z), Complex.Asin(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Atan.
        /// </summary>
        public static cvec4 Atan(cvec4 v) => new cvec4(Complex.Atan(v.x), Complex.Atan(v.y), Complex.Atan(v.z), Complex.Atan(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Cos.
        /// </summary>
        public static cvec4 Cos(cvec4 v) => new cvec4(Complex.Cos(v.x), Complex.Cos(v.y), Complex.Cos(v.z), Complex.Cos(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Cosh.
        /// </summary>
        public static cvec4 Cosh(cvec4 v) => new cvec4(Complex.Cosh(v.x), Complex.Cosh(v.y), Complex.Cosh(v.z), Complex.Cosh(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Exp.
        /// </summary>
        public static cvec4 Exp(cvec4 v) => new cvec4(Complex.Exp(v.x), Complex.Exp(v.y), Complex.Exp(v.z), Complex.Exp(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Log.
        /// </summary>
        public static cvec4 Log(cvec4 v) => new cvec4(Complex.Log(v.x), Complex.Log(v.y), Complex.Log(v.z), Complex.Log(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Log2.
        /// </summary>
        public static cvec4 Log2(cvec4 v) => new cvec4(Complex.Log(v.x, 2.0), Complex.Log(v.y, 2.0), Complex.Log(v.z, 2.0), Complex.Log(v.w, 2.0));
        
        /// <summary>
        /// Returns a component-wise executed complex Log10.
        /// </summary>
        public static cvec4 Log10(cvec4 v) => new cvec4(Complex.Log10(v.x), Complex.Log10(v.y), Complex.Log10(v.z), Complex.Log10(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Reciprocal.
        /// </summary>
        public static cvec4 Reciprocal(cvec4 v) => new cvec4(Complex.Reciprocal(v.x), Complex.Reciprocal(v.y), Complex.Reciprocal(v.z), Complex.Reciprocal(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Sin.
        /// </summary>
        public static cvec4 Sin(cvec4 v) => new cvec4(Complex.Sin(v.x), Complex.Sin(v.y), Complex.Sin(v.z), Complex.Sin(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Sinh.
        /// </summary>
        public static cvec4 Sinh(cvec4 v) => new cvec4(Complex.Sinh(v.x), Complex.Sinh(v.y), Complex.Sinh(v.z), Complex.Sinh(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Sqrt.
        /// </summary>
        public static cvec4 Sqrt(cvec4 v) => new cvec4(Complex.Sqrt(v.x), Complex.Sqrt(v.y), Complex.Sqrt(v.z), Complex.Sqrt(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Tan.
        /// </summary>
        public static cvec4 Tan(cvec4 v) => new cvec4(Complex.Tan(v.x), Complex.Tan(v.y), Complex.Tan(v.z), Complex.Tan(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Tanh.
        /// </summary>
        public static cvec4 Tanh(cvec4 v) => new cvec4(Complex.Tanh(v.x), Complex.Tanh(v.y), Complex.Tanh(v.z), Complex.Tanh(v.w));
        
        /// <summary>
        /// Returns a component-wise executed complex Conjugate.
        /// </summary>
        public static cvec4 Conjugate(cvec4 v) => new cvec4(Complex.Conjugate(v.x), Complex.Conjugate(v.y), Complex.Conjugate(v.z), Complex.Conjugate(v.w));
        
        /// <summary>
        /// Returns a component-wise executed Pow.
        /// </summary>
        public static cvec4 Pow(cvec4 lhs, cvec4 rhs) => new cvec4(Complex.Pow(lhs.x, rhs.x), Complex.Pow(lhs.y, rhs.y), Complex.Pow(lhs.z, rhs.z), Complex.Pow(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static cvec4 Pow(cvec4 v, Complex s) => new cvec4(Complex.Pow(v.x, s), Complex.Pow(v.y, s), Complex.Pow(v.z, s), Complex.Pow(v.w, s));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static cvec4 Pow(Complex s, cvec4 v) => new cvec4(Complex.Pow(s, v.x), Complex.Pow(s, v.y), Complex.Pow(s, v.z), Complex.Pow(s, v.w));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static cvec4 Pow(double s, cvec4 v) => new cvec4(Complex.Pow(s, v.x), Complex.Pow(s, v.y), Complex.Pow(s, v.z), Complex.Pow(s, v.w));
        
        /// <summary>
        /// Returns a component-wise executed Pow.
        /// </summary>
        public static cvec4 Pow(cvec4 lhs, dvec4 rhs) => new cvec4(Complex.Pow(lhs.x, rhs.x), Complex.Pow(lhs.y, rhs.y), Complex.Pow(lhs.z, rhs.z), Complex.Pow(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static cvec4 Pow(cvec4 v, double s) => new cvec4(Complex.Pow(v.x, s), Complex.Pow(v.y, s), Complex.Pow(v.z, s), Complex.Pow(v.w, s));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static cvec4 Log(cvec4 lhs, dvec4 rhs) => new cvec4(Complex.Log(lhs.x, rhs.x), Complex.Log(lhs.y, rhs.y), Complex.Log(lhs.z, rhs.z), Complex.Log(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static cvec4 Log(cvec4 v, double s) => new cvec4(Complex.Log(v.x, s), Complex.Log(v.y, s), Complex.Log(v.z, s), Complex.Log(v.w, s));
        
        /// <summary>
        /// Returns a component-wise executed FromPolarCoordinates.
        /// </summary>
        public static cvec4 FromPolarCoordinates(dvec4 lhs, dvec4 rhs) => new cvec4(Complex.FromPolarCoordinates(lhs.x, rhs.x), Complex.FromPolarCoordinates(lhs.y, rhs.y), Complex.FromPolarCoordinates(lhs.z, rhs.z), Complex.FromPolarCoordinates(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed FromPolarCoordinates with a scalar.
        /// </summary>
        public static cvec4 FromPolarCoordinates(double s, dvec4 v) => new cvec4(Complex.FromPolarCoordinates(s, v.x), Complex.FromPolarCoordinates(s, v.y), Complex.FromPolarCoordinates(s, v.z), Complex.FromPolarCoordinates(s, v.w));
        
        /// <summary>
        /// Returns a component-wise executed FromPolarCoordinates with a scalar.
        /// </summary>
        public static cvec4 FromPolarCoordinates(dvec4 v, double s) => new cvec4(Complex.FromPolarCoordinates(v.x, s), Complex.FromPolarCoordinates(v.y, s), Complex.FromPolarCoordinates(v.z, s), Complex.FromPolarCoordinates(v.w, s));
        
        /// <summary>
        /// Returns a component-wise executed Sqr.
        /// </summary>
        public static cvec4 Sqr(cvec4 v) => new cvec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
    }
}