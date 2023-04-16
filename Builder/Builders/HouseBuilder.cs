using Builder.Models;

namespace Builder.Builders
{
    public class HouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public HouseBuilder WithRoof(RoofModel roof)
        {
            _house.Roof = roof;
            return this;
        }

        public HouseBuilder WithWalls(List<WallModel> walls)
        {
            _house.Walls = walls;
            return this;
        }

        public HouseBuilder WithWindows(List<WindowModel> windows)
        {
            _house.Windows = windows;
            return this;
        }

        public House Build()
        {
            House result = _house;
            this.Reset();
            return result;
        }

        public void Reset()
        {
            _house = new House();
        }
    }
}
