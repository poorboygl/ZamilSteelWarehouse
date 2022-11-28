using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace API.Tekla
{
   public class ChangeWorkPlane : IDisposable
    {
        Model MyModel;
        public TransformationPlane CurrentPlane { get; set; }
        public ChangeWorkPlane(Model model)
        {
            this.MyModel = model;
        }
        public int SetWorkPlanOnGridA()
        {
            int ret = 0;
            Vector vectorUnitX = new Vector(1, 0, 0);
            Vector vectorUnitY = new Vector(0, 0, 1);

            Point originPoint = new Point(0, 0, 0);

            TransformationPlane currentPlane = new TransformationPlane(originPoint, vectorUnitX, vectorUnitY);
            
            bool check = MyModel.GetWorkPlaneHandler().SetCurrentTransformationPlane(currentPlane);

            if (check)
            {
                this.CurrentPlane = currentPlane;
                ret = 1;
            }
            return ret;
        }
        public int SetGlobalPlan()
        {
            int ret = 0;
            TransformationPlane globalPlane = new TransformationPlane();
            bool check = MyModel.GetWorkPlaneHandler().SetCurrentTransformationPlane(globalPlane);

            if (check)
            {
                this.CurrentPlane = globalPlane;
                ret = 1;
            }
            return ret;
        }

        public void Dispose()
        {
            Console.WriteLine("Chuyen lai He toa do Global");
            TransformationPlane globalPlane = new TransformationPlane();
            MyModel.GetWorkPlaneHandler().SetCurrentTransformationPlane(globalPlane);
            MyModel.CommitChanges();
        }
    }
}
