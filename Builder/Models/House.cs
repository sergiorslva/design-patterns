using System.Text;

namespace Builder.Models
{
    public class House
    {
        public List<WindowModel> Windows { get; set; } = new();
        public RoofModel Roof { get; set; } = new();
        public List<WallModel> Walls { get; set; } = new();

        public override string ToString()
        {
            StringBuilder builderMaterials = new StringBuilder();
            builderMaterials.AppendLine("House materials...");

            builderMaterials.AppendLine($"{Windows.Count()} Windows");
            Windows.ForEach(x => builderMaterials.AppendLine(x.Size));            

            builderMaterials.AppendLine($"{Walls.Count()} Walls");
            Walls.ForEach(x => builderMaterials.AppendLine(x.Type));

            builderMaterials.AppendLine($"Roof type: {Roof.Type}");

            return builderMaterials.ToString();
        }
    }
}
