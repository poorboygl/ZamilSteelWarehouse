using System;
using System.Collections.Generic;
using Tekla.Structures;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace API.Tekla
{
    public class BasePlateRepository
    {

        Model MyModel;
        Provider provider;
        public BasePlateRepository(Model mymodel)
        {
            this.MyModel = mymodel;
            provider = new Provider(mymodel);
        } 


        public void CreateBasePlate()
        {
            List<Beam> footing = provider.BeamRepository.SelectAllBeam(SetConstData.FootingName);
            List<Beam> column = provider.BeamRepository.SelectAllBeam(SetConstData.ColumnName);
            for (int i = 0; i < footing.Count; i++)
            {
                for (int j = 0; j < column.Count; j++)
                {
                    if (column[j].StartPoint.X==footing[i].StartPoint.X && column[j].StartPoint.Y == footing[i].StartPoint.Y)
                    {
                        Fetch(column[j], footing[i]);
                        MyModel.CommitChanges();
                    }
                }

            }

        }

        private static void Fetch(ModelObject PrimaryObject, ModelObject SecondaryObject)
        {

            Connection BasePlate = new Connection();

            BasePlate.Name = SetConstData.BaseplateName;
            BasePlate.Number = 1014;
            BasePlate.LoadAttributesFromFile("standard");
            BasePlate.UpVector = new Vector(0, 0, 1000);
            BasePlate.PositionType = PositionTypeEnum.COLLISION_PLANE;

            BasePlate.SetPrimaryObject(PrimaryObject);
            BasePlate.SetSecondaryObject(SecondaryObject);
            BasePlate.SetAttribute("cut", 1);  //Enable anchor rods

            if (!BasePlate.Insert())
            {
                Console.WriteLine("Insertion of stiffened base plate failed.");
            }
        }
    }
}
