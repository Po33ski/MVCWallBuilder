namespace MVCWallBuilder.Models
{
    public class WallLayoutViewModel
    {
        public string Name { get; set;}
        public float Wide { get; set; }
        public string LambdaFactor { get; set; }
        public float LFAfterConv { 
            get => float.Parse(LambdaFactor); 
            set => float.Parse(LambdaFactor); }

    }
}
