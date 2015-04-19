using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Tests;

namespace GlmSharpGenerator.Types
{
    partial class VectorType
    {
        private IEnumerable<string> TestConstructor
        {
            get
            {
                {
                    yield return "{";
                    var vals = BaseType.RandomSmallVals(1);
                    yield return $"var v = {Construct(this, vals)};".Indent();
                    foreach (var field in Fields)
                        yield return string.Format("Assert.AreEqual({1}, v.{0});", field, vals[0]).Indent();
                    yield return "}";
                }
                {
                    yield return "{";
                    var vals = BaseType.RandomSmallVals(Components);
                    yield return $"var v = {Construct(this, vals)};".Indent();
                    var it = vals.GetEnumerator();
                    foreach (var field in Fields)
                        yield return string.Format("Assert.AreEqual({1}, v.{0});", field, it.MoveNext() ? it.Current : ZeroValue).Indent();
                    yield return "}";
                }
                for (var comps = 2; comps <= 4; ++comps)
                {
                    yield return "{";
                    var vals = BaseType.RandomSmallVals(comps);
                    yield return $"var v = {Construct(this, Construct(new VectorType(BaseType, comps), vals))};".Indent();
                    var it = vals.GetEnumerator();
                    foreach (var field in Fields)
                        yield return string.Format("Assert.AreEqual({1}, v.{0});", field, it.MoveNext() ? it.Current : ZeroValue).Indent();
                    yield return "}";
                }
            }
        }

        private IEnumerable<string> TestIndexer
        {
            get
            {
                var vals = BaseType.RandomSmallVals(Components);
                yield return $"var v = {Construct(this, vals)};";

                for (var i = 0; i < vals.Length; ++i)
                    yield return $"Assert.AreEqual({vals[i]}, v[{i}]);";

                yield return "";
                foreach (var index in new[] { int.MinValue, -1, Components, int.MaxValue, 5 })
                {
                    yield return $"Assert.Throws<ArgumentOutOfRangeException>(() => {{ var s = v[{index}]; }} );";
                    yield return $"Assert.Throws<ArgumentOutOfRangeException>(() => {{ v[{index}] = {ZeroValue}; }} );";
                }

                yield return "";
                foreach (var val in BaseType.ValuesSmallVals)
                {
                    var i = Random.Next(Components);
                    yield return $"v[{i}] = {val};";
                    yield return $"Assert.AreEqual({val}, v[{i}]);";
                }
            }
        }

        private IEnumerable<string> TestPropertyValue
        {
            get
            {
                var vals = BaseType.RandomSmallVals(Components);
                yield return $"var v = {Construct(this, vals)};";
                yield return "var vals = v.Values;";
                for (var i = 0; i < vals.Length; ++i)
                    yield return $"Assert.AreEqual({vals[i]}, vals[{i}]);";

                yield return string.Format("Assert.That(vals.SequenceEqual(v.ToArray()));");
            }
        }

        private IEnumerable<string> TestStaticProperties
        {
            get
            {
                foreach (var f in Fields)
                    yield return $"Assert.AreEqual({ZeroValue}, {NameThat}.Zero.{f});";

                if (!string.IsNullOrEmpty(OneValue))
                {
                    yield return "";
                    foreach (var f in Fields)
                        yield return $"Assert.AreEqual({OneValue}, {NameThat}.Ones.{f});";

                    foreach (var uf in Fields)
                    {
                        yield return "";
                        foreach (var f in Fields)
                            yield return $"Assert.AreEqual({(f == uf ? OneValue : ZeroValue)}, {NameThat}.Unit{uf.ToUpper()}.{f});";
                    }
                }

                foreach (var constant in BaseType.TypeConstants)
                {
                    yield return "";
                    foreach (var f in Fields)
                        yield return string.Format("Assert.AreEqual({0}.{2}, {1}.{2}.{3});", BaseTypeName, NameThat, constant, f);
                }
            }
        }

        private IEnumerable<string> TestOperators
        {
            get
            {
                var vals = BaseType.RandomSmallVals(Components);
                while (vals.All(v => v == vals[0]))
                    vals = BaseType.RandomSmallVals(Components);

                yield return $"var v1 = {Construct(this, vals)};";
                yield return $"var v2 = {Construct(this, vals)};";
                yield return $"var v3 = {Construct(this, vals.Reverse())};";
                yield return $"Assert.That(v1 == {Construct(this, "v1")});";
                yield return $"Assert.That(v2 == {Construct(this, "v2")});";
                yield return $"Assert.That(v3 == {Construct(this, "v3")});";
                yield return string.Format("Assert.That(v1 == v2);");
                yield return string.Format("Assert.That(v1 != v3);");
                yield return string.Format("Assert.That(v2 != v3);");
            }
        }

        private IEnumerable<string> TestStringInterop
        {
            get
            {
                var vals = BaseType.RandomSmallVals(Components);
                yield return $"var v = {Construct(this, vals)};";

                yield return "";
                yield return string.Format("var s0 = v.ToString();");
                yield return string.Format("var s1 = v.ToString(\"#\");");

                if (!BaseType.IsComplex && !BaseType.Generic)
                {
                    yield return "";
                    yield return $"var v0 = {Name}.Parse(s0);";
                    yield return $"var v1 = {Name}.Parse(s1, \"#\");";
                    yield return string.Format("Assert.AreEqual(v, v0);");
                    yield return string.Format("Assert.AreEqual(v, v1);");
                    yield return "";
                    yield return $"var b0 = {Name}.TryParse(s0, out v0);";
                    yield return $"var b1 = {Name}.TryParse(s1, \"#\", out v1);";
                    yield return string.Format("Assert.That(b0);");
                    yield return string.Format("Assert.That(b1);");
                    yield return string.Format("Assert.AreEqual(v, v0);");
                    yield return string.Format("Assert.AreEqual(v, v1);");
                    yield return "";
                    yield return $"b0 = {Name}.TryParse(null, out v0);";
                    yield return string.Format("Assert.False(b0);");
                    yield return $"b0 = {Name}.TryParse(\"\", out v0);";
                    yield return string.Format("Assert.False(b0);");
                    yield return $"b0 = {Name}.TryParse(s0 + \", 0\", out v0);";
                    yield return string.Format("Assert.False(b0);");
                    yield return "";
                    yield return $"Assert.Throws<NullReferenceException>(() => {{ {Name}.Parse(null); }});";
                    yield return $"Assert.Throws<FormatException>(() => {{ {Name}.Parse(\"\"); }});";
                    yield return $"Assert.Throws<FormatException>(() => {{ {Name}.Parse(s0 + \", 0\"); }});";
                }

                if (!BaseType.Generic)
                {
                    yield return "";
                    yield return string.Format("var s2 = v.ToString(\";\", CultureInfo.InvariantCulture);");
                    yield return string.Format("Assert.That(s2.Length > 0);");

                    if (BaseType.HasFormatString && !BaseType.IsComplex)
                    {
                        yield return "";
                        yield return string.Format("var s3 = v.ToString(\"; \", \"G\");");
                        yield return string.Format("var s4 = v.ToString(\"; \", \"G\", CultureInfo.InvariantCulture);");
                        yield return $"var v3 = {Name}.Parse(s3, \"; \", NumberStyles.Number);";
                        yield return $"var v4 = {Name}.Parse(s4, \"; \", NumberStyles.Number, CultureInfo.InvariantCulture);";
                        yield return string.Format("Assert.AreEqual(v, v3);");
                        yield return string.Format("Assert.AreEqual(v, v4);");
                        yield return "";
                        yield return $"var b4 = {Name}.TryParse(s4, \"; \", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);";
                        yield return string.Format("Assert.That(b4);");
                        yield return string.Format("Assert.AreEqual(v, v4);");
                    }
                }
            }
        }

        private IEnumerable<string> SerializationJson
        {
            get
            {
                var vals = BaseType.RandomSmallVals(Components);
                yield return $"var v0 = {Construct(this, vals)};";
                yield return string.Format("var s0 = JsonConvert.SerializeObject(v0);");
                yield return "";
                yield return $"var v1 = JsonConvert.DeserializeObject<{NameThat}>(s0);";
                yield return string.Format("var s1 = JsonConvert.SerializeObject(v1);");
                yield return "";
                yield return string.Format("Assert.AreEqual(v0, v1);");

                yield return string.Format("Assert.AreEqual(s0, s1);");
            }
        }

        public override IEnumerable<TestFunc> GenerateTests()
        {
            yield return new TestFunc(this, "Constructors", TestConstructor);
            yield return new TestFunc(this, "Indexer", TestIndexer);
            yield return new TestFunc(this, "PropertyValues", TestPropertyValue);
            yield return new TestFunc(this, "StaticProperties", TestStaticProperties);
            yield return new TestFunc(this, "Operators", TestOperators);
            yield return new TestFunc(this, "StringInterop", TestStringInterop);
            if (!BaseType.IsComplex)
                yield return new TestFunc(this, "SerializationJson", SerializationJson);

            if (BaseType.HasArithmetics)
            {
                yield return new InvariantTestFunc(this, "InvariantId", "$V0 == +$V0");
                yield return new InvariantTestFunc(this, "InvariantDouble", "$V0 + $V0 == 2 * $V0");
                yield return new InvariantTestFunc(this, "InvariantTriple", "$V0 + $V0 + $V0 == 3 * $V0");
                yield return new InvariantTestFunc(this, "InvariantCommutative", "$V0 + $V1 == $V1 + $V0", "$V0 * $V1 == $V1 * $V0");
                yield return new InvariantTestFunc(this, "InvariantAssociative", "$V0 * ($V1 + $V2) == $V0 * $V1 + $V0 * $V2");
                if (BaseType.IsSigned)
                {
                    yield return new InvariantTestFunc(this, "InvariantIdNeg", "$V0 == -(-$V0)");
                    yield return new InvariantTestFunc(this, "InvariantCommutativeNeg", "$V0 - $V1 == -($V1 - $V0)");
                    yield return new InvariantTestFunc(this, "InvariantAssociativeNeg", "$V0 * ($V1 - $V2) == $V0 * $V1 - $V0 * $V2");
                }
                yield return new InvariantTestFunc(this, "TriangleInequality",
                    "$V0.Length + $V1.Length >= ($V0 + $V1).Length",
                    "$V0.LengthSqr + $V1.LengthSqr >= ($V0 + $V1).LengthSqr",
                    "$V0.Norm + $V1.Norm >= ($V0 + $V1).Norm",
                    "$V0.Norm1 + $V1.Norm1 >= ($V0 + $V1).Norm1",
                    "$V0.Norm2 + $V1.Norm2 >= ($V0 + $V1).Norm2",
                    "$V0.NormMax + $V1.NormMax >= ($V0 + $V1).NormMax");
                yield return new InvariantTestFunc(this, "InvariantNorm", "$V0.NormMax <= $V0.Norm");
                if (Components == 3 && !BaseType.IsComplex)
                    yield return new InvariantTestFunc(this, "InvariantCrossDot", "glm.Abs(glm.Dot($V0, glm.Cross($V0, $V1))) < 0.1");
            }

            // Random
            if (BaseType.IsInteger)
            {
                for (var i = 0; i < 5; ++i)
                {
                    var min = Random.Next(-5, 5);
                    if (!BaseType.IsSigned)
                        min = Math.Abs(min);
                    var max = min + Random.Next(1, 5);
                    var range = max - min + 1;
                    yield return new DistributionTestFunc(this, "RandomUniform" + i, "Random" + (i % 2 == 0 ? "" : "Uniform"), min + ", " + (max + 1), (min + max) / 2.0, (range * range - 1) / 12.0);
                }
                for (var i = 0; i < 5; ++i)
                {
                    var lambda = Random.NextDouble() * 3 + 0.5;
                    yield return new DistributionTestFunc(this, "RandomPoisson" + i, "RandomPoisson", lambda.ToString(CultureInfo.InvariantCulture), lambda, lambda);
                }
            }
            else if (BaseType.IsFloatingPoint)
            {
                for (var i = 0; i < 5; ++i)
                {
                    var min = Random.Next(-5, 5);
                    if (!BaseType.IsSigned)
                        min = Math.Abs(min);
                    var max = min + Random.Next(1, 5);
                    var range = max - min;
                    yield return new DistributionTestFunc(this, "RandomUniform" + i, "Random" + (i % 2 == 0 ? "" : "Uniform"), min + ", " + max, (min + max) / 2.0, range * range / 12.0);
                }
                for (var i = 0; i < 5; ++i)
                {
                    var mean = Random.NextDouble() * 4 - 2;
                    var variance = Random.NextDouble() * 10;
                    yield return new DistributionTestFunc(this, "RandomGaussian" + i, "Random" + (i % 2 == 0 ? "Normal" : "Gaussian"), ConstantSuffixFor(mean.ToString(CultureInfo.InvariantCulture)) + ", " + ConstantSuffixFor(variance.ToString(CultureInfo.InvariantCulture)), mean, variance);
                }
                for (var i = 0; i < 5; ++i)
                {
                    yield return new DistributionTestFunc(this, "RandomNormal" + i, "RandomNormal", "", 0.0, 1.0);
                }
            }
        }
    }
}
