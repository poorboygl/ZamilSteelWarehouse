using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace API.Tekla
{
    public class ContourPlateRepository
    {
        Model MyModel;
        Provider provider;
        public ContourPlateRepository(Model mymodel)
        {
            this.MyModel = mymodel;
            provider = new Provider(mymodel);
        }
        public ContourPlate  Insert(List<Point> listpoint)
        {
            ContourPlate contourPlate = new ContourPlate();
            List<ContourPoint> listcontourPoint = new List<ContourPoint>();
            foreach (Point obj in listpoint)
            {
                ContourPoint point = new ContourPoint(obj, null);
                listcontourPoint.Add(point);
            }
            foreach (ContourPoint obj in listcontourPoint)
            {
                contourPlate.AddContourPoint(obj);
            }
            contourPlate.Finish = "FOO";
            contourPlate.Profile.ProfileString = "PL6";
            contourPlate.Material.MaterialString = "SS400";

            contourPlate.Insert();
            return contourPlate;

        }

        public ContourPlate Add()
        {
            ContourPlate contourPlate = new ContourPlate();
            return contourPlate;
        }




    }
}
