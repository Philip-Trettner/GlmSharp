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
                        code.Add(string.Format("    var v{0} = {1};", i, type.Construct(type, vals)));
                    }
                    if (inv.Contains("=="))
                    {
                        var parts = inv.Split(new[] { "==" }, StringSplitOptions.None);
                        Debug.Assert(parts.Length == 2);
                        code.Add(string.Format("    Assert.AreEqual({0}, {1});", parts[0].Trim(), parts[1].Trim()));
                    }
                    else if (inv.Contains(" < "))
                    {
                        var parts = inv.Split(new[] { " < " }, StringSplitOptions.None);
                        Debug.Assert(parts.Length == 2);
                        code.Add(string.Format("    Assert.Less({0}, {1});", parts[0].Trim(), parts[1].Trim()));
                    }
                    else if (inv.Contains(" <= "))
                    {
                        var parts = inv.Split(new[] { " <= " }, StringSplitOptions.None);
                        Debug.Assert(parts.Length == 2);
                        code.Add(string.Format("    Assert.LessOrEqual({0}, {1});", parts[0].Trim(), parts[1].Trim()));
                    }
                    else if (inv.Contains(" > "))
                    {
                        var parts = inv.Split(new[] { " > " }, StringSplitOptions.None);
                        Debug.Assert(parts.Length == 2);
                        code.Add(string.Format("    Assert.Greater({0}, {1});", parts[0].Trim(), parts[1].Trim()));
                    }
                    else if (inv.Contains(" >= "))
                    {
                        var parts = inv.Split(new[] { " >= " }, StringSplitOptions.None);
                        Debug.Assert(parts.Length == 2);
                        code.Add(string.Format("    Assert.GreaterOrEqual({0}, {1});", parts[0].Trim(), parts[1].Trim()));
                    }
                    else if (inv.Contains("~"))
                    {
                        var parts = inv.Split(new[] { "~" }, StringSplitOptions.None);
                        Debug.Assert(parts.Length == 2);
                        code.Add(string.Format("    Assert.That(glm.ApproxEqual({0}, {1}));", parts[0].Trim(), parts[1].Trim()));
                    }
                    else 
                        code.Add(string.Format("    Assert.That({0});", inv));
                    code.Add("}");
                }
                Code = code;
            }
        }
    }
}
