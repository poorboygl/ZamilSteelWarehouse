using API.Tekla;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;


namespace Core
{
    public partial class fCreateColumn : Form
    {
        Provider provider;
        Model MyModel;
        public fCreateColumn(Model mymodel)
        {
            InitializeComponent();
            this.MyModel = mymodel;
            this.provider = new Provider(mymodel);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            double Length_ISteelbottom = 450;
            double Length_ISteeltop = 1200;
            double Width_ISteel = 300;
            double Height = 8000;
            double FlangeThinkness = 16;
            double WebThinkness = 16;
            double ThinknessBasePlate = 20;
            double Length_BasePlate = 700;
            double ThinknessTopPlate = 10;
            double Length_TopPlate = 1600;

            string profile_Flange = $"PL{FlangeThinkness.ToString()}*{Width_ISteel.ToString()}";
            string Profile_BasePlate = $"PL{ThinknessBasePlate.ToString()}*{Width_ISteel.ToString()}";
            string Profile_TopPlate = $"PL{ThinknessTopPlate.ToString()}*{Width_ISteel.ToString()}";

            using (ChangeWorkPlane changeWorkPlane = new ChangeWorkPlane(MyModel))
            {
                changeWorkPlane.SetWorkPlanOnGridA();
                Beam BasePlate = provider.BeamRepository.InsertBeam(new Point(-Length_BasePlate / 2, 0, 0), new Point(Length_BasePlate / 2, 0, 0), Profile_BasePlate, plane: Position.PlaneEnum.LEFT, rotation: Position.RotationEnum.TOP, depth: Position.DepthEnum.MIDDLE);
                BasePlate.Name = "BASE PLATE";
                BasePlate.Modify();
                GetCoordinatesMaxValue maxValueBasePlate = new GetCoordinatesMaxValue(BasePlate);
                GetCoordinatesMinValue minValueBasePlate = new GetCoordinatesMinValue(BasePlate);
                //Hashtable BasePlateAtributes = new Hashtable();
                // GetAtrributeObject.GetAtrribute(BasePlate, ref BasePlateAtributes);
                Beam TopPlate = provider.BeamRepository.InsertBeam(new Point(-(Length_ISteelbottom/2 + 140), Height, 0), new Point(Length_TopPlate - (Length_ISteelbottom / 2  + 140), Height, 0), Profile_TopPlate, plane: Position.PlaneEnum.RIGHT, rotation: Position.RotationEnum.TOP, depth: Position.DepthEnum.MIDDLE);
                TopPlate.Name = "TOP PLATE";
                TopPlate.Modify();
                GetCoordinatesMaxValue maxValueTopPlate = new GetCoordinatesMaxValue(TopPlate);
                GetCoordinatesMinValue minValueTopPlate = new GetCoordinatesMinValue(TopPlate);
                Beam FlangeOutside = provider.BeamRepository.InsertBeam(new Point(-Length_ISteelbottom / 2, maxValueBasePlate.Max_CoordinatesValueY, 0), new Point(-Length_ISteelbottom / 2, Height - (maxValueTopPlate.Max_CoordinatesValueY - minValueTopPlate.Min_CoordinatesValueY), 0), profile_Flange, "2");
                FlangeOutside.Name = "FLANGE OUTSIDE";
                FlangeOutside.Modify();
                GetCoordinatesMaxValue maxValueFlangeOutside = new GetCoordinatesMaxValue(FlangeOutside);

                List<Point> listPointforWebSteel = new List<Point>() {
                  new Point(maxValueFlangeOutside.Max_CoordinatesValueX, maxValueBasePlate.Max_CoordinatesValueY, 0),
                  new Point(maxValueFlangeOutside.Max_CoordinatesValueX, minValueTopPlate.Min_CoordinatesValueY, 0),
                  new Point(maxValueFlangeOutside.Max_CoordinatesValueX+(Length_ISteeltop-2*FlangeThinkness), minValueTopPlate.Min_CoordinatesValueY, 0),
                  new Point(maxValueFlangeOutside.Max_CoordinatesValueX+(Length_ISteelbottom-2*FlangeThinkness),maxValueBasePlate.Max_CoordinatesValueY,0)
                };
                ContourPlate Web = provider.ContourPlateRepository.Insert(listPointforWebSteel);
                GetCoordinatesMaxValue maxValueWeb = new GetCoordinatesMaxValue(Web);
                GetCoordinatesMinValue minValueTopWeb = new GetCoordinatesMinValue(Web);

                Web.Profile.ProfileString = $"PL{WebThinkness.ToString()}";
                Web.Modify();
                Beam FlangeInside = provider.BeamRepository.InsertBeam(listPointforWebSteel[3], listPointforWebSteel[2], profile_Flange, "2");
                FlangeInside.Name = "FLANGE INSIDE";
                // GetCoordinatesMaxValue maxValueFlangeInside = new  GetCoordinatesMaxValue(FlangeInside);
                //cho nay co va cham

                int ret = provider.UserInteraction.SetWorkPlanBy2Points(listPointforWebSteel[3], listPointforWebSteel[2]);
                Point FlangeInside4 = new Point(0, -FlangeThinkness, 0);
                Point FlangeInside3 = new Point(5, -FlangeThinkness, 0);
                ret = provider.UserInteraction.SetWorkPlanBy2Points(FlangeInside4, FlangeInside3);
                TransformationPlane currentPlane = provider.UserInteraction.CurrentWorkPlan;
                Matrix transformationMatrix = currentPlane.TransformationMatrixToGlobal;
                FlangeInside4 = transformationMatrix.Transform(new Point(0, 0, 0));
                FlangeInside3 = transformationMatrix.Transform(new Point(5, 0, 0));

                changeWorkPlane.SetGlobalPlan();
                changeWorkPlane.SetWorkPlanOnGridA();
                currentPlane = changeWorkPlane.CurrentPlane;
                transformationMatrix = currentPlane.TransformationMatrixToLocal;
                FlangeInside4 = transformationMatrix.Transform(FlangeInside4);
                FlangeInside3 = transformationMatrix.Transform(FlangeInside3);
                Line lineFlangeInside = new Line(FlangeInside4, FlangeInside3);
                Line lineconstructionFlangeInside = new Line(new Point(minValueBasePlate.Min_CoordinatesValueX, maxValueBasePlate.Max_CoordinatesValueY, 0), new Point(maxValueBasePlate.Max_CoordinatesValueX, maxValueBasePlate.Max_CoordinatesValueY, 0));
                LineSegment lineSegment = Intersection.LineToLine(lineFlangeInside, lineconstructionFlangeInside);
                Point IntersectionPoint = lineSegment.Point1;
                Vector MoveVector = new Vector(IntersectionPoint.X - FlangeInside4.X, IntersectionPoint.Y - FlangeInside4.Y, 0);
                MoveVector.Translate(FlangeInside.StartPoint.X, FlangeInside.StartPoint.Y, FlangeInside.StartPoint.Z);
                FlangeInside.StartPoint = new Point(MoveVector.X, MoveVector.Y, MoveVector.Z);
                FlangeInside.Modify();
                //Create Stiffiner
                List<ContourPlate> Stiffiners = new List<ContourPlate>();
                //ContourPlate Stiffiner = new ContourPlate(ContourPlate);








                //Assembly assembly = Web.GetAssembly();
                //assembly.Add(BasePlate);
                //assembly.Add(TopPlate);
                //assembly.Add(FlangeOutside);
                //assembly.Add(FlangeInside);

                //assembly.Modify();

                //TSM.ModelObjectSelector selector = new TSM.ModelObjectSelector();
                //selector.Select(new ArrayList() { assembly});
                //MyModel.CommitChanges();
            }
        }

        private void btnAddStiffener_Click(object sender, EventArgs e)
        {
            MyModel.CommitChanges();
        }
    }
}
