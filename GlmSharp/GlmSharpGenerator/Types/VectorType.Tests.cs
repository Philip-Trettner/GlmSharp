using System;
using System.Collections.Generic;
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
                while(vals.All(v => v == vals[0]))
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

        public override IEnumerable<TestFunc> GenerateTests()
        {
            yield return new TestFunc(this, "Constructors", TestConstructor);
            yield return new TestFunc(this, "Indexer", TestIndexer);
            yield return new TestFunc(this, "PropertyValues", TestPropertyValue);
            yield return new TestFunc(this, "StaticProperties", TestStaticProperties);
            yield return new TestFunc(this, "Operators", TestOperators);
        }
    }
}
