using System;
using System.Drawing;
using System.IO;


namespace Snake
{
   public static class Images
    {
        public readonly static Image HeadUP = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"assets\headUp.png"));
        public readonly static Image HeadRIGHT = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"assets\headRight.png"));
        public readonly static Image HeadDOWN = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"assets\headDown.png"));
        public readonly static Image HeadLEFT = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"assets\headLeft.png"));
        public readonly static Image Body = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"assets\body.png"));
        public readonly static Image Fruit = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"assets\fruit.png"));

        public readonly static Color BackGroundC = ColorTranslator.FromHtml("#AFE67E");
        public readonly static Color BorderC = ColorTranslator.FromHtml("#3D9982");
    }
}
