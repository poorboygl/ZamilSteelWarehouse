using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tekla.Structures;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace API.Tekla
{
   public class BeamRepository
    {
        Model MyModel;
        Provider provider; 
        public BeamRepository(Model mymodel)
        {
            this.MyModel = mymodel;
            provider = new Provider(mymodel);
        }
        public List<Beam> SelectAllBeam(string name)
        {
            ModelObjectEnumerator ObjectsInModel = MyModel.GetModelObjectSelector().GetAllObjects();
            List<Beam> list = new List<Beam>();

            while (ObjectsInModel.MoveNext())
            {
                Beam MyBeam = ObjectsInModel.Current as Beam;

                if (MyBeam != null && MyBeam.Name == name)
                {
                    list.Add(MyBeam);

                }
            }
            return list;
        }



        public Beam InsertBeam(Point startpoint, Point endpoint, string profilestring, string color = "99",string material = "SS400" ,Position.PlaneEnum plane = Position.PlaneEnum.RIGHT, Position.RotationEnum rotation = Position.RotationEnum.TOP, Position.DepthEnum depth = Position.DepthEnum.MIDDLE)
        {

            Beam beam = new Beam();

            beam.Name = SetConstData.ColumnName;
            beam.Profile.ProfileString = profilestring;
            beam.Material.MaterialString = material;
            beam.Class = color;
            beam.StartPoint.X = startpoint.X;
            beam.StartPoint.Y = startpoint.Y;
            beam.StartPoint.Z = startpoint.Z;
            beam.EndPoint.X = endpoint.X;
            beam.EndPoint.Y = endpoint.Y;
            beam.EndPoint.Z = endpoint.Z;
            beam.Position.Plane = plane;
            beam.Position.Rotation = rotation;   
            beam.Position.Depth = depth;

            beam.Insert();
          
            return beam;
        }
     
    }
}
