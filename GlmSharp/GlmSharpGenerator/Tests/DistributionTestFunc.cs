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

            code.Add($"var random = new Random({AbstractType.Random.Next()});");
            code.Add($"var sum = {dtype.Construct(dtype, dtype.ZeroValue)};");
            code.Add($"var sumSqr = {dtype.Construct(dtype, dtype.ZeroValue)};");

            code.Add("");
            code.Add("const int count = 50000;");
            code.Add("for (var _ = 0; _ < count; ++_)");
            code.Add("{");
            code.Add($"    var v = {type.Name}.{randomFuncName}(random{(string.IsNullOrEmpty(funcArgs) ? "" : ", " + funcArgs)});");
            code.Add($"    sum += ({dtype.Name})v;");
            code.Add($"    sumSqr += glm.Pow2(({dtype.Name})v);");
            code.Add("}");

            code.Add("");
            code.Add("var avg = sum / (double)count;");
            code.Add("var variance = sumSqr / (double)count - avg * avg;");

            code.Add("");
            for (var c = 0; c < type.Components; ++c)
                code.Add($"Assert.AreEqual(avg.{type.ArgOf(c)}, {avg}, 1.0);");

            code.Add("");
            for (var c = 0; c < type.Components; ++c)
                code.Add($"Assert.AreEqual(variance.{type.ArgOf(c)}, {variance}, 3.0);");

            Code = code;
        }
    }
}
