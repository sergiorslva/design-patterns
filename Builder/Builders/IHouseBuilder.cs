using Builder.Models;

namespace Builder.Builders
{
    public interface IHouseBuilder
    {
        public void Reset();
        public HouseBuilder WithWalls(List<WallModel> walls);
        public HouseBuilder WithWindows(List<WindowModel> windows);
        public HouseBuilder WithRoof(RoofModel roofModel);
        public House Build();
    }
}
