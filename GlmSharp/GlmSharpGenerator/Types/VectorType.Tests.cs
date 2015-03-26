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
                    yield return string.Format("var v = {0};", Construct(this, vals)).Indent();
                    foreach (var field in Fields)
                        yield return string.Format("Assert.AreEqual({1}, v.{0});", field, vals[0]).Indent();
                    yield return "}";
                }
                {
                    yield return "{";
                    var vals = BaseType.RandomSmallVals(Components);
                    yield return string.Format("var v = {0};", Construct(this, vals)).Indent();
                    var it = vals.GetEnumerator();
                    foreach (var field in Fields)
                        yield return string.Format("Assert.AreEqual({1}, v.{0});", field, it.MoveNext() ? it.Current : ZeroValue).Indent();
                    yield return "}";
                }
                for (var comps = 2; comps <= 4; ++comps)
                {
                    yield return "{";
                    var vals = BaseType.RandomSmallVals(comps);
                    yield return string.Format("var v = {0};", Construct(this, Construct(new VectorType(BaseType, comps), vals))).Indent();
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
                yield return string.Format("var v = {0};", Construct(this, vals));

                for (var i = 0; i < vals.Length; ++i)
                    yield return string.Format("Assert.AreEqual({0}, v[{1}]);", vals[i], i);

                yield return "";
                foreach (var index in new[] { int.MinValue, -1, Components, int.MaxValue, 5 })
                {
                    yield return string.Format("Assert.Throws<ArgumentOutOfRangeException>(() => {{ var s = v[{0}]; }} );", index);
                    yield return string.Format("Assert.Throws<ArgumentOutOfRangeException>(() => {{ v[{0}] = {1}; }} );", index, ZeroValue);
                }

                yield return "";
                foreach (var val in BaseType.ValuesSmallVals)
                {
                    var i = Random.Next(Components);
                    yield return string.Format("v[{0}] = {1};", i, val);
                    yield return string.Format("Assert.AreEqual({0}, v[{1}]);", val, i);
                }
            }
        }

        private IEnumerable<string> TestPropertyValue
        {
            get
            {
                var vals = BaseType.RandomSmallVals(Components);
                yield return string.Format("var v = {0};", Construct(this, vals));
                yield return "var vals = v.Values;";
                for (var i = 0; i < vals.Length; ++i)
                    yield return string.Format("Assert.AreEqual({0}, vals[{1}]);", vals[i], i);

                yield return string.Format("Assert.That(vals.SequenceEqual(v.ToArray()));");
            }
        }

        private IEnumerable<string> TestStaticProperties
        {
            get
            {
                foreach (var f in Fields)
                    yield return string.Format("Assert.AreEqual({0}, {1}.Zero.{2});", ZeroValue, NameThat, f);

                if (!string.IsNullOrEmpty(OneValue))
                {
                    yield return "";
                    foreach (var f in Fields)
                        yield return string.Format("Assert.AreEqual({0}, {1}.Ones.{2});", OneValue, NameThat, f);

                    foreach (var uf in Fields)
                    {
                        yield return "";
                        foreach (var f in Fields)
                            yield return string.Format("Assert.AreEqual({0}, {1}.Unit{2}.{3});", f == uf ? OneValue : ZeroValue, NameThat, uf.ToUpper(), f);
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

                yield return string.Format("var v1 = {0};", Construct(this, vals));
                yield return string.Format("var v2 = {0};", Construct(this, vals));
                yield return string.Format("var v3 = {0};", Construct(this, vals.Reverse()));
                yield return string.Format("Assert.That(v1 == {0});", Construct(this, "v1"));
                yield return string.Format("Assert.That(v2 == {0});", Construct(this, "v2"));
                yield return string.Format("Assert.That(v3 == {0});", Construct(this, "v3"));
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
                yield return string.Format("var v = {0};", Construct(this, vals));

                yield return "";
                yield return string.Format("var s0 = v.ToString();");
                yield return string.Format("var s1 = v.ToString(\"#\");");

                if (!BaseType.IsComplex && !BaseType.Generic)
                {
                    yield return "";
                    yield return string.Format("var v0 = {0}.Parse(s0);", Name);
                    yield return string.Format("var v1 = {0}.Parse(s1, \"#\");", Name);
                    yield return string.Format("Assert.AreEqual(v, v0);");
                    yield return string.Format("Assert.AreEqual(v, v1);");
                    yield return "";
                    yield return string.Format("var b0 = {0}.TryParse(s0, out v0);", Name);
                    yield return string.Format("var b1 = {0}.TryParse(s1, \"#\", out v1);", Name);
                    yield return string.Format("Assert.That(b0);");
                    yield return string.Format("Assert.That(b1);");
                    yield return string.Format("Assert.AreEqual(v, v0);");
                    yield return string.Format("Assert.AreEqual(v, v1);");
                    yield return "";
                    yield return string.Format("b0 = {0}.TryParse(null, out v0);", Name);
                    yield return string.Format("Assert.False(b0);");
                    yield return string.Format("b0 = {0}.TryParse(\"\", out v0);", Name);
                    yield return string.Format("Assert.False(b0);");
                    yield return string.Format("b0 = {0}.TryParse(s0 + \", 0\", out v0);", Name);
                    yield return string.Format("Assert.False(b0);");
                    yield return "";
                    yield return string.Format("Assert.Throws<NullReferenceException>(() => {{ {0}.Parse(null); }});", Name);
                    yield return string.Format("Assert.Throws<FormatException>(() => {{ {0}.Parse(\"\"); }});", Name);
                    yield return string.Format("Assert.Throws<FormatException>(() => {{ {0}.Parse(s0 + \", 0\"); }});", Name);
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
                        yield return string.Format("var v3 = {0}.Parse(s3, \"; \", NumberStyles.Number);", Name);
                        yield return string.Format("var v4 = {0}.Parse(s4, \"; \", NumberStyles.Number, CultureInfo.InvariantCulture);", Name);
                        yield return string.Format("Assert.AreEqual(v, v3);");
                        yield return string.Format("Assert.AreEqual(v, v4);");
                        yield return "";
                        yield return string.Format("var b4 = {0}.TryParse(s4, \"; \", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);", Name);
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
                yield return string.Format("var v0 = {0};", Construct(this, vals));
                yield return string.Format("var s0 = JsonConvert.SerializeObject(v0);");
                yield return "";
                yield return string.Format("var v1 = JsonConvert.DeserializeObject<{0}>(s0);", NameThat);
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
        }
    }
}
