# GlmSharp

Open-source MIT-licensed C#/.NET math library for small vectors and matrices.

The naming and behavior is inspired by the excellent [http://glm.g-truc.net/](OpenGL Mathematics) lib by Christophe Riccio.

## Overview

Install via [NuGet](https://www.nuget.org/):

> PM> Install-Package GlmSharp

Supported types: 
* `vec2`
* `vec3`
* `vec4`
* `mat2`
* `mat3`
* `mat4`
* other mats (2x3, 2x4, 3x4, 3x2, 4x2, 4x3)

Supported base types:
* `int`
* `uint`
* `long`
* `float`
* `double`
* `decimal`
* `complex`
* `long`
* `bool`
* generic `T`

(Currently a total of 108 types)

Supports swizzling `v.swizzle.bgr`.


## Syntax, Usage

Instead of introducing a `glm` namespace, GlmSharp puts most functions in the respective type.
For example, `glm.dot(v1, v2)` for `vec3` is now `vec3.Dot(v1, v2)`.


## Requirements

The code itself is written using C# 6 features, the NuGet package however only requires .NET 4.5 (due to IReadOnlyList).


## Features

* Arithmetic type support: int, uint, long, float, double, decimal
* Boolean vectors, matrices
* `System.Numerics.Complex` support
* Generic `gvec<T>, gmat<T>` support
* Swizzling
* Basetype constants are propagated (double.Epsilon => dvec3.Epsilon)
* Basetype functions are propagated
* Performance considerations
* Extensive operator overloading
* Proper ToString, Parse, TryParse for vectors (including format providers)
* Most `Math` and basetype functions work component-wise for vectors (e.g. float.IsInfinite(v) => vec3.IsInfinite(v))
* Vectors and matrices implement IReadOnlyList<> and IEquatable<>
* Various constructors and explicit casts for vectors
* Implicit casts for vectors where base types can be casted implicitly
* Most GLSL functions
* Radians-only lib
* Generated library


### Swizzling

In theory, each swizzle string ('xyz') could be implemented as a property in the respective vector struct.
However, this absolutely spams Intellisense (706 combinations for vec4). (Extension methods are not solution either as tools like Resharper show all available methods.)

Thus, swizzling is implemented as a swizzle surrogate type (e.g. `swizzle_vec4`) that has all combinations as properties.
Each vector type has a `swizzle` property that returns an instance of the surrogate type.
Therefore, swizzling becomes `v.swizzle.xz`.
(Hopefully, the runtime engine elides all superfluous moves/copies.)

Swizzling is generated for `xyzw` and `rgba`.


### Performance consideration

All vectors and matrices are value-types and contain all components directly. (A matrix is not an array of vectors.)
These types are therefore suited for serialization and marshalling.

Most functions are "rolled out" by the generator and should therefore have minimal overhead.


## License

This library is MIT-licensed.


## TODO-List

* quaternions
* test generation
* basetype functions (e.g. Smoothstep on floats)
* ToString, Parse, TryParse for matrices
* More constructors and casts for matrices
* Some GLU functions (e.g. PickMatrix)
