using Builder.Builders;
using Builder.Models;

List<WindowModel> windows = new List<WindowModel>
{
    new WindowModel
    {
        Size = "Small"
    },
    new WindowModel
    {
        Size = "Big"
    }
};


List<WallModel> walls = new List<WallModel>
{
    new WallModel{Type = "Drywall"},
    new WallModel{Type = "Drywall" },
    new WallModel{Type = "Drywall" }
};


RoofModel roof = new RoofModel
{
    Type = "Normal"
};

House house = new HouseBuilder()
    .WithWindows(windows)
    .WithWalls(walls)
    .WithRoof(roof)
    .Build();

Console.WriteLine(house.ToString());

Console.ReadKey();