using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlmSharpGenerator.Members
{
    class Member
    {
        /// <summary>
        /// Name of the member
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Comment of the member
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Visibility modifier
        /// </summary>
        public string Visibility { get; set; } = "public";

        /// <summary>
        /// All lines of this member
        /// </summary>
        public virtual IEnumerable<string> Lines => Comment.AsComment();
    }
}
