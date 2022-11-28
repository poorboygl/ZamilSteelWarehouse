using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tekla.Structures;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace StartUp
{
    class ColumnRepository
    {
        Model MyModel;
        SiteProvider siteProvider = new SiteProvider();
        public ColumnRepository(Model model)
        {
            this.MyModel = model;
        }
        public void InsertColumns()
        {
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
                        CreateColumn(PositionX, PositionY);
                    }
                }
                else
                {
                    CreateColumn(PositionX, 0.0);
                    CreateColumn(PositionX, 30000.0);
                }
                // Always remember to commit changes to Tekla Structures, otherwise some things might be left in uncertain state
                MyModel.CommitChanges();
            }
        }
        public  void InsertColumns(string profilestring, string material)
        {
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
                        CreateColumn(PositionX, PositionY,profilestring,material);
                        }
                    }
                    else
                    {
                    CreateColumn(PositionX, 0.0,profilestring,material);
                    CreateColumn(PositionX, 30000.0,profilestring,material);
                    }
                // Always remember to commit changes to Tekla Structures, otherwise some things might be left in uncertain state
                MyModel.CommitChanges();
            }
        }
        private  void CreateColumn(double PositionX, double PositionY)
        {
            ModelObject Column = Fetch(PositionX, PositionY);
        }
        private void CreateColumn(double PositionX, double PositionY, string profilestring, string material)
        {
            ModelObject Column = Fetch(PositionX, PositionY, profilestring, material);
        }
        private ModelObject Fetch(double PositionX, double PositionY,string profilestring, string material)
        {

            Beam Column = new Beam();

            Column.Name = Data.columnname;
            Column.Profile.ProfileString = profilestring;
            Column.Material.MaterialString = material;
            Column.Class = "2";
            Column.StartPoint.X = PositionX;
            Column.StartPoint.Y = PositionY;
            Column.EndPoint.X = PositionX;
            Column.EndPoint.Y = PositionY;
            Column.EndPoint.Z = 5000.0;
            Column.Position.Rotation = Position.RotationEnum.FRONT;
            Column.Position.Plane = Position.PlaneEnum.MIDDLE;
            Column.Position.Depth = Position.DepthEnum.MIDDLE;

            if (!Column.Insert())
            {
                Console.WriteLine("Insertion of column failed.");
            }

            return Column;
        }
        private ModelObject Fetch(double PositionX, double PositionY)
        {
    
            Beam Column = new Beam();

            Column.Name = Data.columnname;
            Column.Profile.ProfileString = "PH400*400*13*21";
            Column.Material.MaterialString = "Q345";
            Column.Class = "2";
            Column.StartPoint.X = PositionX;
            Column.StartPoint.Y = PositionY;
            Column.EndPoint.X = PositionX;
            Column.EndPoint.Y = PositionY;
            Column.EndPoint.Z = 5000.0;
            Column.Position.Rotation = Position.RotationEnum.FRONT;
            Column.Position.Plane = Position.PlaneEnum.MIDDLE;
            Column.Position.Depth = Position.DepthEnum.MIDDLE;

            if (!Column.Insert())
            {
                Console.WriteLine("Insertion of column failed.");
            }

            return Column;
        }
     
    }
}
