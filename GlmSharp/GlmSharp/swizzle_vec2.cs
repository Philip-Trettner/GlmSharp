using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_vec2
    {
        public readonly float x;
        public readonly float y;
        
        public swizzle_vec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        
        // XYZW Versions
        public vec2 xx => new vec2(x, x);
        public vec3 xxx => new vec3(x, x, x);
        public vec4 xxxx => new vec4(x, x, x, x);
        public vec4 xxxy => new vec4(x, x, x, y);
        public vec3 xxy => new vec3(x, x, y);
        public vec4 xxyx => new vec4(x, x, y, x);
        public vec4 xxyy => new vec4(x, x, y, y);
        public vec2 xy => new vec2(x, y);
        public vec3 xyx => new vec3(x, y, x);
        public vec4 xyxx => new vec4(x, y, x, x);
        public vec4 xyxy => new vec4(x, y, x, y);
        public vec3 xyy => new vec3(x, y, y);
        public vec4 xyyx => new vec4(x, y, y, x);
        public vec4 xyyy => new vec4(x, y, y, y);
        public vec2 yx => new vec2(y, x);
        public vec3 yxx => new vec3(y, x, x);
        public vec4 yxxx => new vec4(y, x, x, x);
        public vec4 yxxy => new vec4(y, x, x, y);
        public vec3 yxy => new vec3(y, x, y);
        public vec4 yxyx => new vec4(y, x, y, x);
        public vec4 yxyy => new vec4(y, x, y, y);
        public vec2 yy => new vec2(y, y);
        public vec3 yyx => new vec3(y, y, x);
        public vec4 yyxx => new vec4(y, y, x, x);
        public vec4 yyxy => new vec4(y, y, x, y);
        public vec3 yyy => new vec3(y, y, y);
        public vec4 yyyx => new vec4(y, y, y, x);
        public vec4 yyyy => new vec4(y, y, y, y);
        
        // RGBA Versions
        public vec2 rr => new vec2(x, x);
        public vec3 rrr => new vec3(x, x, x);
        public vec4 rrrr => new vec4(x, x, x, x);
        public vec4 rrrg => new vec4(x, x, x, y);
        public vec3 rrg => new vec3(x, x, y);
        public vec4 rrgr => new vec4(x, x, y, x);
        public vec4 rrgg => new vec4(x, x, y, y);
        public vec2 rg => new vec2(x, y);
        public vec3 rgr => new vec3(x, y, x);
        public vec4 rgrr => new vec4(x, y, x, x);
        public vec4 rgrg => new vec4(x, y, x, y);
        public vec3 rgg => new vec3(x, y, y);
        public vec4 rggr => new vec4(x, y, y, x);
        public vec4 rggg => new vec4(x, y, y, y);
        public vec2 gr => new vec2(y, x);
        public vec3 grr => new vec3(y, x, x);
        public vec4 grrr => new vec4(y, x, x, x);
        public vec4 grrg => new vec4(y, x, x, y);
        public vec3 grg => new vec3(y, x, y);
        public vec4 grgr => new vec4(y, x, y, x);
        public vec4 grgg => new vec4(y, x, y, y);
        public vec2 gg => new vec2(y, y);
        public vec3 ggr => new vec3(y, y, x);
        public vec4 ggrr => new vec4(y, y, x, x);
        public vec4 ggrg => new vec4(y, y, x, y);
        public vec3 ggg => new vec3(y, y, y);
        public vec4 gggr => new vec4(y, y, y, x);
        public vec4 gggg => new vec4(y, y, y, y);
    }
}
