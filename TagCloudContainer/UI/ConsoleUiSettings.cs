using CommandLine;

namespace TagCloudContainer.UI
{
    public class ConsoleUiSettings : IUi
    {
        [Option('f', "font", Required = false, Default = "Arial", HelpText = "Font name")]
        public string FontName { get; set; }

        [Option('g', "backgroundcolor", Required = false, Default = "White", HelpText = "Background color")]
        public string BackGroundColor { get; set; }

        [Option('c', "brushcolor", Required = false, Default = "Red", HelpText = "Brush color")]
        public string BrushColor { get; set; }

        [Option('s',
            "savepath",
            Required = false,
            Default = "../visualization",
            HelpText = "Path to directory to save image")]
        public string PathToSave { get; set; }

        [Option('o',
            "openpath",
            Required = false,
            Default = "../testfile.txt",
            HelpText = "Path to file with words")]
        public string PathToOpen { get; set; }

        [Option('q',
            "saveformat",
            Required = false,
            Default = "png",
            HelpText = "Format to result picture")]
        public string FormatToSave { get; set; }

        [Option('w', "width", Required = false, Default = 1000, HelpText = "Width of canvas")]
        public int CanvasWidth { get; set; }

        [Option('h', "height", Required = false, Default = 1000, HelpText = "Height of canvas")]
        public int CanvasHeight { get; set; }

        [Option('b', "border", Required = false, Default = 150, HelpText = "Borders of canvas")]
        public int CanvasBorder { get; set; }

        [Option('r', "radius", Required = false, Default = 0.1, HelpText = "Radius offset")]
        public double RadiusOffset { get; set; }

        [Option('a', "angle", Required = false, Default = 1, HelpText = "Angle offset")]
        public double AngleOffset { get; set; }

        [Option('e', "coloring", Required = false, Default = "gd",
            HelpText =
                "Algorithm for coloring words. Variants: d (every word has the same color), gd (brightness of word depends on it's size), g (brightness of word depends on it's position)")]
        public string WordsColoringAlgorithm { get; set; }

        [Option('u', "layouter", Required = false, Default = "d", HelpText = "Layoter algorithm")]
        public string Layouter { get; set; }
    }
}