using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDescriptor
{
     class ShapeDescriptor
    {
        public string ShapeType { get; set; }

        public ShapeDescriptor(Point point1, Point point2)
        {
            ShapeType = "Line";
        }
        public ShapeDescriptor(Point point1, Point point2, Point point3)
        {
            ShapeType = "Triangle";
        }

        public ShapeDescriptor(Point point1, Point point2, Point point3, Point point4)
        {
            ShapeType = "Rectangle";
        }
    }
}
