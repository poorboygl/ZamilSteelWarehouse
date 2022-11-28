using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace API.Tekla
{
    public class UserInteraction
    {
        Model MyModel;
        public TransformationPlane CurrentWorkPlan { get; set; }
        public Vector VectorX { get; set; }
        public Vector VectorY { get; set; }
        public Point original { get; set; }
        public UserInteraction(Model model)
        {
            this.MyModel = model;
        }
        private Vector NormalVector(Point origin, Vector VectorX)
        {
            LineSegment lineSegment = new LineSegment(origin, new Point(VectorX.X, VectorX.Y, VectorX.Z));
            VectorX = lineSegment.GetDirectionVector();
            double x = 5;
            double y = (origin.Y * VectorX.Y - (x - origin.X)* VectorX.X) / VectorX.Y;
            Vector vectorNormal = new Vector(x, y, 0);
            return vectorNormal;
        }
        public int SetWorkPlanOnGridA()
        {
            int ret = 0;
            Vector vectorUnitX = new Vector(1,0,0);
            Vector vectorUnitY = new Vector(0, 0, 1);

            Point originPoint = new Point(0, 0, 0);

            TransformationPlane currentPlane = new TransformationPlane(originPoint, vectorUnitX,vectorUnitY);
            bool check= MyModel.GetWorkPlaneHandler().SetCurrentTransformationPlane(currentPlane);           
            if (check)
            {
                this.CurrentWorkPlan = currentPlane;
                ret = 1;
            }
            return ret;
        }
        public int SetWorkPlanByBeam(Beam myBeam)
        {
            int ret = 0;
            TransformationPlane beamPlane = new TransformationPlane(myBeam.GetCoordinateSystem());
            bool check = MyModel.GetWorkPlaneHandler().SetCurrentTransformationPlane(beamPlane);          
            if (check)
            {
                this.CurrentWorkPlan = beamPlane;
                ret = 1;
            }
            return ret;
           
        }
        public int SetWorkPlanBy2Points(Point startPoint , Point endPoint)
        {
            int ret = 0;
            LineSegment lineX = new LineSegment(startPoint, endPoint);
            Vector vectorX = lineX.GetDirectionVector();
            Vector vectorY = NormalVector(startPoint, vectorX);
            TransformationPlane transformationPlane = new TransformationPlane(startPoint, vectorX, vectorY);
            bool check = MyModel.GetWorkPlaneHandler().SetCurrentTransformationPlane(transformationPlane);
            if (check)
            {
                this.CurrentWorkPlan = transformationPlane;
                this.VectorX = vectorX;
                this.VectorY = vectorY;
                this.original = startPoint;
                ret = 1;
            }
            return ret;

        }
    }
}
