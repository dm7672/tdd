using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TagCloud
{
    public class CircularCloudLayouter
    {
        private Point Center { get; }
        private readonly List<Rectangle> rectangles = new List<Rectangle>();
        public IReadOnlyList<Rectangle> Rectangles => rectangles.AsReadOnly();

        private readonly IPointGetter pointGetter;

        public CircularCloudLayouter(Point center, IPointGetter pointGetter)
        {
            this.Center = center;
            this.pointGetter = pointGetter;
        }

        public Rectangle PutNextRectangle(Size rectangleSize)
        {

        }

        private Rectangle MoveCloserToCenter(Rectangle rect)
        {

        }
    }
}
