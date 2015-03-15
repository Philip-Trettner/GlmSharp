using GlmSharp;

namespace GlmSharpSwizzle
{
    public static class swizzle
    {
        public static vec3 xyz(this vec4 v) => new vec3 {x = v.x, y = v.y, z = v.z};
    }
}
