using System;

namespace TheoryVsPractice
{
    /// <summary>
    /// Not all relationships, as they are defined in theory or even the real
    /// world, directly translate to good relationships when it comes to
    /// relations within an object-oriented design.
    /// </summary>

    public class Rectangle
    {
        public uint Width { get; set; }
        public uint Height { get; set; }
    }

    public class Square // : Rectangle
    {
        public uint Width { get; set; }
    }
}