using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Types;

namespace GlmSharpGenerator.Tests
{
    /// <summary>
    /// Random distribution tests
    /// </summary>
    class DistributionTestFunc : TestFunc
    {
        public DistributionTestFunc(VectorType type, string name, string randomFuncName, string funcArgs, double avg, double variance) : base(type, name)
        {
            var dtype = new VectorType(BuiltinType.TypeDouble, type.Components);

            var code = new List<string>();

            code.Add(string.Format("var random = new Random({0});", AbstractType.Random.Next()));
            code.Add(string.Format("var sum = {0};", dtype.Construct(dtype, dtype.ZeroValue)));
            code.Add(string.Format("var sumSqr = {0};", dtype.Construct(dtype, dtype.ZeroValue)));

            code.Add("");
            code.Add("const int count = 50000;");
            code.Add("for (var _ = 0; _ < count; ++_)");
            code.Add("{");
            code.Add(string.Format("    var v = {0}.{1}(random{2});", type.Name, randomFuncName, string.IsNullOrEmpty(funcArgs) ? "" : ", " + funcArgs));
            code.Add(string.Format("    sum += ({0})v;", dtype.Name));
            code.Add(string.Format("    sumSqr += glm.Pow2(({0})v);", dtype.Name));
            code.Add("}");

            code.Add("");
            code.Add("var avg = sum / (double)count;");
            code.Add("var variance =  sumSqr / (double)count - avg * avg;");

            code.Add("");
            for (var c = 0; c < type.Components; ++c)
                code.Add(string.Format("Assert.AreEqual(avg.{0}, {1}, 1.0);", type.ArgOf(c), avg));

            code.Add("");
            for (var c = 0; c < type.Components; ++c)
                code.Add(string.Format("Assert.AreEqual(variance.{0}, {1}, 3.0);", type.ArgOf(c), variance));

            Code = code;
        }
    }
}
