using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Members;

namespace GlmSharpGenerator.Types
{
    partial class SwizzleType
    {
        public override IEnumerable<Member> GenerateMembers()
        {
            // fields
            foreach (var f in Fields)
                yield return new Field(f, BaseType)
                {
                    Readonly = true,
                    Visibility = "internal",
                    Comment = $"{f}-component"
                };

            // ctor
            yield return new Constructor(this, Fields)
            {
                Visibility = "internal",
                Parameters = Fields.TypedArgs(BaseType),
                Initializers = Fields,
                Comment = $"Constructor for {Name}."
            };

            // properties
            foreach (var swizzle in Swizzle(0))
            {
                var type = VectorTypeFor(swizzle.Length);

                // xyzw
                yield return new Property(swizzle, type)
                {
                    GetterLine = Construct(type, swizzle.CommaSeparated()),
                    Comment = $"Returns {VectorType.Name}.{swizzle} swizzling."
                };

                // rgba
                yield return new Property(ToRgba(swizzle), type)
                {
                    GetterLine = Construct(type, swizzle.CommaSeparated()),
                    Comment = string.Format("Returns {0}.{1} swizzling (equivalent to {0}.{2}).", VectorType.Name, ToRgba(swizzle), swizzle)
                };
            }
        }
    }
}
