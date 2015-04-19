using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Types;

namespace GlmSharpGenerator.Tests
{
    class InvariantTestFunc : TestFunc
    {
        public InvariantTestFunc(AbstractType type, string name, params string[] invariants) : base(type, name)
        {
            const int cnt = 10;
            foreach (var invariant in invariants)
            {
                var inv = invariant;
                inv = inv.Replace("$T", type.NameThat);

                // stats
                var vectorsThis = 0;

                // recognize vars
                while (true)
                {
                    var n = "$V" + vectorsThis;
                    if (inv.Contains(n))
                    {
                        inv = inv.Replace(n, "v" + vectorsThis);
                        ++vectorsThis;
                    }
                    else break;
                }

                // gen code
                var comps = type is VectorType ? ((VectorType)type).Components : 1;
                var code = new List<string>();
                for (var _ = 0; _ < cnt; ++_)
                {
                    code.Add("{");
                    for (var i = 0; i < vectorsThis; ++i)
                    {
                        var vals = type.BaseType.RandomSmallVals(comps);
                        code.Add($"    var v{i} = {type.Construct(type, vals)};");
                    }
                    if (inv.Contains("=="))
                    {
                        var parts = inv.Split(new[] { "==" }, StringSplitOptions.None);
                        Debug.Assert(parts.Length == 2);
                        code.Add($"    Assert.AreEqual({parts[0].Trim()}, {parts[1].Trim()});");
                    }
                    else if (inv.Contains(" < "))
                    {
                        var parts = inv.Split(new[] { " < " }, StringSplitOptions.None);
                        Debug.Assert(parts.Length == 2);
                        code.Add($"    Assert.Less({parts[0].Trim()}, {parts[1].Trim()});");
                    }
                    else if (inv.Contains(" <= "))
                    {
                        var parts = inv.Split(new[] { " <= " }, StringSplitOptions.None);
                        Debug.Assert(parts.Length == 2);
                        code.Add($"    Assert.LessOrEqual({parts[0].Trim()}, {parts[1].Trim()});");
                    }
                    else if (inv.Contains(" > "))
                    {
                        var parts = inv.Split(new[] { " > " }, StringSplitOptions.None);
                        Debug.Assert(parts.Length == 2);
                        code.Add($"    Assert.Greater({parts[0].Trim()}, {parts[1].Trim()});");
                    }
                    else if (inv.Contains(" >= "))
                    {
                        var parts = inv.Split(new[] { " >= " }, StringSplitOptions.None);
                        Debug.Assert(parts.Length == 2);
                        code.Add($"    Assert.GreaterOrEqual({parts[0].Trim()}, {parts[1].Trim()});");
                    }
                    else if (inv.Contains("~"))
                    {
                        var parts = inv.Split(new[] { "~" }, StringSplitOptions.None);
                        Debug.Assert(parts.Length == 2);
                        code.Add($"    Assert.That(glm.ApproxEqual({parts[0].Trim()}, {parts[1].Trim()}));");
                    }
                    else 
                        code.Add($"    Assert.That({inv});");
                    code.Add("}");
                }
                Code = code;
            }
        }
    }
}
