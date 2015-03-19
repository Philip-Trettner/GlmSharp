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

        public override IEnumerable<TestFunc> GenerateTests()
        {
            TestMode = true;
            Random = new Random(1234 + Components * 397 + TestClassName.GetHashCode());

            yield return new TestFunc("Constructors", TestConstructor);
            yield return new TestFunc("Indexer", TestIndexer);

            TestMode = false;
        }
    }
}
