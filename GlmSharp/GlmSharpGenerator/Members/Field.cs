using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Types;

namespace GlmSharpGenerator.Members
{
    class Field : Member
    {
        /// <summary>
        /// Member type
        /// </summary>
        public AbstractType Type { get; set; }

        public override IEnumerable<string> Lines
        {
            get
            {
                foreach (var line in base.Lines)
                    yield return line;

                yield return string.Format("{0} {1} {2};", Visibility, Type.BaseName, Name);
            }
        }
    }
}
