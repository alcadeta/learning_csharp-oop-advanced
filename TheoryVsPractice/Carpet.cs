namespace TheoryVsPractice
{
    /// <summary>
    /// Inheriting a class is not always the answer. Often times it's much
    /// better to use multiple interfaces that each define a specific contract.
    /// When, for example, some instances of a class may have the given
    /// properties/methods and some may not. In this case, it's much better to
    /// have an interface (or multiple thereof) than to extend a base class that
    /// provides the given properties/methods for all instances.
    /// </summary>

    public class Carpet : ICleanable, IExhibition
        // : Art
    {
        public uint Length { get; set; }
        public uint Width { get; set; }
        public string Pattern { get; set; }
        public string Origin { get; set; }

        public void Sweep() { }
        public void Exhibit() { }
    }

    // public class Art
    // {
    //     public decimal Valuation { get; set; }
    //     public void Exhibit() { }
    // }

    public interface ICleanable { void Sweep(); }
    public interface IExhibition { void Exhibit(); }
}