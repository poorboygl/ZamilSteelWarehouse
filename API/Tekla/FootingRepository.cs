using System;
using System.Collections.Generic;
using System.Text;
using Tekla.Structures.Model;

namespace API.Tekla
{
   public class FootingRepository
    {
        Provider provider;
        Model MyModel; 
        public FootingRepository(Model mymodel)
        {
            this.MyModel = mymodel;
            provider = new Provider(mymodel);
        }

        public void InsertPadFootings()
        {
           int count = 1;
            // Always remember to check that you really have working connection

            // Loop through X-axis  (these loops should be changed to match current grid)
            for (double PositionX = 0.0; PositionX <= 12000.0; PositionX += 3000.0)
                {
                    // In first and in last line
                    if (PositionX.Equals(0.0) || PositionX.Equals(12000.0))
                    {
                        // Loop through Y-axis to get pad footings on the longer sides of the grid
                        for (double PositionY = 0.0; PositionY <= 30000.0; PositionY += 6000.0)
                        {
                        PadFootingAttribute(PositionX, PositionY);
    
                        }
                    }
                    else
                    {   // Create pad footings on the shorter sides of the grid
                    PadFootingAttribute(PositionX, 0.0);
                    PadFootingAttribute(PositionX, 30000.0);
                    }
                }
                // Always remember to commit changes to Tekla Structures, otherwise some things might be left in uncertain state
                MyModel.CommitChanges();
            }


        private  void PadFootingAttribute(double PositionX, double PositionY)
        {

            Beam PadFooting = new Beam();

            PadFooting.Name = SetConstData.FootingName;
            PadFooting.Profile.ProfileString = $"{SetConstData.FootingSize}*{SetConstData.FootingSize}";
            PadFooting.Material.MaterialString = "K30-2";
            PadFooting.Class = "8";
            PadFooting.StartPoint.X = PositionX;
            PadFooting.StartPoint.Y = PositionY;
            PadFooting.StartPoint.Z = 0.0;
            PadFooting.EndPoint.X = PositionX;
            PadFooting.EndPoint.Y = PositionY;
            PadFooting.EndPoint.Z = -500.0;
            PadFooting.Position.Rotation = Position.RotationEnum.FRONT;
            PadFooting.Position.Plane = Position.PlaneEnum.MIDDLE;
            PadFooting.Position.Depth = Position.DepthEnum.MIDDLE;

            PadFooting.Insert();
        }

    }
}
