using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using Tekla.Structures;

namespace API.Tekla
{
    public class RebarRepository
    {
        Model MyModel;
        Provider provider;
        public RebarRepository(Model mymodel)
        {
            this.MyModel = mymodel;
            provider = new Provider(mymodel);
        }
        public int DeleteRebarGroup(string name)
        {
            ModelObjectEnumerator ObjectsInModel = MyModel.GetModelObjectSelector().GetAllObjects();

            while (ObjectsInModel.MoveNext())
            {
                RebarGroup rebarGroup = ObjectsInModel.Current as RebarGroup;

                if (rebarGroup != null && rebarGroup.Name == name)
                {
                    rebarGroup.Delete();

                }
            }
            return 1;
        }
        public void CreateRebars()
        {

            List<Beam> footings = provider.BeamRepository.SelectAllBeam(SetConstData.FootingName);
            foreach (var obj in footings)
            {

                    Fetch(obj, obj.StartPoint.X, obj.StartPoint.Y);   
                
                MyModel.CommitChanges();
            }

        }

        public void CreateRebars(string size, string grade, string bendingradius)
        {

            List<Beam> footings = provider.BeamRepository.SelectAllBeam(SetConstData.FootingName);

            foreach (var obj in footings)
            {
 
                    Fetch(obj, obj.StartPoint.X, obj.StartPoint.Y, size, grade, bendingradius);
         
                MyModel.CommitChanges();
            }

        }

        private void Fetch(ModelObject PadFooting, double PositionX, double PositionY, string size, string grade,string bendingradius)
        {
            RebarGroup Rebar = new RebarGroup();
            Polygon RebarPolygon1 = new Polygon();

            double MyFootingSize = SetConstData.FootingSize;

            //use given position and footing size
            RebarPolygon1.Points.Add(new Point(PositionX - MyFootingSize / 2.0, PositionY - MyFootingSize / 2.0, 0));
            RebarPolygon1.Points.Add(new Point(PositionX + MyFootingSize / 2.0, PositionY - MyFootingSize / 2.0, 0));
            RebarPolygon1.Points.Add(new Point(PositionX + MyFootingSize / 2.0, PositionY + MyFootingSize / 2.0, 0));
            RebarPolygon1.Points.Add(new Point(PositionX - MyFootingSize / 2.0, PositionY + MyFootingSize / 2.0, 0));
            RebarPolygon1.Points.Add(new Point(PositionX - MyFootingSize / 2.0, PositionY - MyFootingSize / 2.0, 0));
            Rebar.Polygons.Add(RebarPolygon1);

            //or calculate by rebar's solid's Axis Aligned Bounding Box
            //Rebar.Polygons.Add(GetPolygonBySolidsAABB(PadFooting as Beam));

            Rebar.StartPoint.X = PositionX;
            Rebar.StartPoint.Y = PositionY;
            Rebar.StartPoint.Z = 0.0;
            Rebar.EndPoint.X = PositionX;
            Rebar.EndPoint.Y = PositionY;
            Rebar.EndPoint.Z = -500.0;
            Rebar.Father = PadFooting;
            Rebar.EndPointOffsetType = Reinforcement.RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS;
            Rebar.EndPointOffsetValue = 20.0;
            Rebar.StartPointOffsetType = Reinforcement.RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS;
            Rebar.StartPointOffsetValue = 20.0;
            Rebar.Class = 3;
            Rebar.Name = SetConstData.FootingrebarName;
            Rebar.Grade = grade;
            Rebar.Size = size;

            Rebar.RadiusValues.Add(double.Parse(bendingradius));
            Rebar.SpacingType = BaseRebarGroup.RebarGroupSpacingTypeEnum.SPACING_TYPE_TARGET_SPACE;
            Rebar.Spacings.Add(100.0);
            Rebar.ExcludeType = BaseRebarGroup.ExcludeTypeEnum.EXCLUDE_TYPE_BOTH;
            Rebar.NumberingSeries.StartNumber = 0;
            Rebar.NumberingSeries.Prefix = "Group";
            Rebar.OnPlaneOffsets.Add(25.0);
            Rebar.FromPlaneOffset = 40;

            //Adding hooks to make rebar stronger
            Rebar.StartHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_90_DEGREES;
            Rebar.EndHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_90_DEGREES;
            Rebar.OnPlaneOffsets.Add(10.0);
            Rebar.OnPlaneOffsets.Add(25.0);

            if (!Rebar.Insert())
            {
                Console.WriteLine("Inserting rebar failed.");
            }
        }

        private void Fetch(ModelObject PadFooting, double PositionX, double PositionY)
        {
            RebarGroup Rebar = new RebarGroup();
            Polygon RebarPolygon1 = new Polygon();

            double MyFootingSize = SetConstData.FootingSize;

            //use given position and footing size
            RebarPolygon1.Points.Add(new Point(PositionX - MyFootingSize / 2.0, PositionY - MyFootingSize / 2.0, 0));
            RebarPolygon1.Points.Add(new Point(PositionX + MyFootingSize / 2.0, PositionY - MyFootingSize / 2.0, 0));
            RebarPolygon1.Points.Add(new Point(PositionX + MyFootingSize / 2.0, PositionY + MyFootingSize / 2.0, 0));
            RebarPolygon1.Points.Add(new Point(PositionX - MyFootingSize / 2.0, PositionY + MyFootingSize / 2.0, 0));
            RebarPolygon1.Points.Add(new Point(PositionX - MyFootingSize / 2.0, PositionY - MyFootingSize / 2.0, 0));
            Rebar.Polygons.Add(RebarPolygon1);

            //or calculate by rebar's solid's Axis Aligned Bounding Box
            //Rebar.Polygons.Add(GetPolygonBySolidsAABB(PadFooting as Beam));

            Rebar.StartPoint.X = PositionX;
            Rebar.StartPoint.Y = PositionY;
            Rebar.StartPoint.Z = 0.0;
            Rebar.EndPoint.X = PositionX;
            Rebar.EndPoint.Y = PositionY;
            Rebar.EndPoint.Z = -500.0;
            Rebar.Father = PadFooting;
            Rebar.EndPointOffsetType = Reinforcement.RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS;
            Rebar.EndPointOffsetValue = 20.0;
            Rebar.StartPointOffsetType = Reinforcement.RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS;
            Rebar.StartPointOffsetValue = 20.0;
            Rebar.Class = 3;
            Rebar.Name =SetConstData.FootingrebarName;
            Rebar.Grade = "A500HW";
            Rebar.Size = "12";

            Rebar.RadiusValues.Add(40.0);
            Rebar.SpacingType = BaseRebarGroup.RebarGroupSpacingTypeEnum.SPACING_TYPE_TARGET_SPACE;
            Rebar.Spacings.Add(100.0);
            Rebar.ExcludeType = BaseRebarGroup.ExcludeTypeEnum.EXCLUDE_TYPE_BOTH;
            Rebar.NumberingSeries.StartNumber = 0;
            Rebar.NumberingSeries.Prefix = "Group";
            Rebar.OnPlaneOffsets.Add(25.0);
            Rebar.FromPlaneOffset = 40;

            //Adding hooks to make rebar stronger
            Rebar.StartHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_90_DEGREES;
            Rebar.EndHook.Shape = RebarHookData.RebarHookShapeEnum.HOOK_90_DEGREES;
            Rebar.OnPlaneOffsets.Add(10.0);
            Rebar.OnPlaneOffsets.Add(25.0);

            if (!Rebar.Insert())
            {
                Console.WriteLine("Inserting rebar failed.");
            }
        }

    }
}
