# GlmSharp

Open-source MIT-licensed C#/.NET math library for small vectors and matrices.

The naming and behavior is inspired by the excellent [OpenGL Mathematics](http://glm.g-truc.net/) lib by Christophe Riccio.

## NuGet

Install via [NuGet](https://www.nuget.org/packages/GlmSharp/):

> PM> Install-Package GlmSharp

Current version: _0.9.7_

## Overview

Supported types: 
* `vec2`
* `vec3`
* `vec4`
* `mat2`
* `mat3`
* `mat4`
* `quat`
* non-quadratic mats (`mat2x3`, `mat2x4`, `mat3x4`, `mat3x2`, `mat4x2`, `mat4x3`)

Supported base types:
* `int` (`ivec`)
* `uint` (`uvec`)
* `long` (`lvec`)
* `float` (`vec`)
* `double` (`dvec`)
* `decimal` (`decvec`)
* `System.Numerics.Complex` (`cvec`, only in .NET 4.5 and higher)
* `long` (`lvec`)
* `bool` (`bvec`)
* generic `T` (`gvec<T>`)

(Currently a total of 144 types in about 40k LOC)

Supports swizzling, e.g. `v.swizzle.bgr` (or equivalently `v.swizzle.zyx`).


## Syntax, Usage

Instead of introducing a `glm` namespace, GlmSharp puts most functions in the respective type.
For example, `glm.dot(v1, v2)` for `vec3` is now `vec3.Dot(v1, v2)`.


## Requirements

The code itself is written using C# 6 features, the NuGet package however only requires .NET 2.0 (with some restrictions).
Starting with .NET 4.5, `System.Numerics.Complex` and `IReadOnlyList<T>` are supported in GlmSharp.


## Features

* Arithmetic type support: `int`, `uint`, `long`, `float`, `double`, `decimal`
* Boolean vectors, matrices
* `System.Numerics.Complex` support
* Generic `gvec<T>, gmat<T>` support
* Swizzling
* Basetype constants are propagated (`double.Epsilon` => `dvec3.Epsilon`)
* Basetype functions are propagated
* Performance considerations
* Extensive operator overloading
* Proper `ToString`, `Parse`, `TryParse` for vectors (including format providers)
* Most `Math` and basetype functions work component-wise for vectors (e.g. `float.IsInfinite(v)` => `vec3.IsInfinite(v)`)
* Vectors and matrices implement `IReadOnlyList<>` and `IEquatable<>`
* Various constructors and explicit casts for vectors and matrices
* Implicit casts for vectors where base types can be casted implicitly
* Most GLSL functions
* Radians-only lib
* Serialization via `[Serializable]`, `[DataContract]` and `[DataMember]` (and thus [Json.NET](https://github.com/JamesNK/Newtonsoft.Json))
* Marshalling via `[StructLayout(LayoutKind.Sequential)]`
* Quaternions
* Support for .NET 2.0 (with new features since .NET 4.5)
* Aggregated functionality in static `glm` class
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

* test generation
* ToString, Parse, TryParse for matrices
* some GLU functions (e.g. PickMatrix)
* advanced glsl/glm functions
* extensive documentation (parameters, return values, formulas)
* inline-swizzle and swizzle as L-ref?
* noise functions
* random extensions
* explicit JSON support
