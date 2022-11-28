using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Solid;

namespace API.Tekla
{
    public class GetCoordinatesMaxValue
    {
        public double Max_CoordinatesValueX { get; }
        public double Max_CoordinatesValueY { get; }
        public double Max_CoordinatesValueZ { get; }
       
        public  GetCoordinatesMaxValue(Beam beam)
        {
           
            Solid solidobject = beam.GetSolid();
            FaceEnumerator MyFaceEnum = solidobject.GetFaceEnumerator();
            List<Point> MyList = new List<Point>();
            ArrayList MyFaceNormalList = new ArrayList();
            while (MyFaceEnum.MoveNext())
            {
                Face MyFace = MyFaceEnum.Current as Face;
                if (MyFace != null)
                {
                    MyFaceNormalList.Add(MyFace.Normal);

                    LoopEnumerator MyLoopEnum = MyFace.GetLoopEnumerator();
                    while (MyLoopEnum.MoveNext())
                    {
                        Loop MyLoop = MyLoopEnum.Current as Loop;
                        if (MyLoop != null)
                        {
                            VertexEnumerator MyVertexEnum = MyLoop.GetVertexEnumerator() as VertexEnumerator;
                            while (MyVertexEnum.MoveNext())
                            {
                                Point MyVertex = MyVertexEnum.Current as Point;
                                if (MyVertex != null)
                                {
                                    MyList.Add(MyVertex);
                                }
                            }
                        }
                    }
                }
            }
            double max_CoordinatesValueX = MyList[0].X;
            double max_CoordinatesValueY = MyList[0].Y;
            double max_CoordinatesValueZ = MyList[0].Z;

            for (int i = 1; i < MyList.Count; i++)
            {

                if (MyList[i].X>max_CoordinatesValueX)
                {
                    max_CoordinatesValueX = MyList[i].X;
                }
                if (MyList[i].Y > max_CoordinatesValueY)
                {
                    max_CoordinatesValueY = MyList[i].Y;
                }
                if (MyList[i].Z > max_CoordinatesValueZ)
                {
                    max_CoordinatesValueZ = MyList[i].Z;
                }
            }


            this.Max_CoordinatesValueX = max_CoordinatesValueX;
            this.Max_CoordinatesValueY = max_CoordinatesValueY;
            this.Max_CoordinatesValueZ = max_CoordinatesValueZ;
        }
        public GetCoordinatesMaxValue(ContourPlate plate)
        {

            Solid solidobject = plate.GetSolid();
            FaceEnumerator MyFaceEnum = solidobject.GetFaceEnumerator();
            List<Point> MyList = new List<Point>();
            ArrayList MyFaceNormalList = new ArrayList();
            while (MyFaceEnum.MoveNext())
            {
                Face MyFace = MyFaceEnum.Current as Face;
                if (MyFace != null)
                {
                    MyFaceNormalList.Add(MyFace.Normal);

                    LoopEnumerator MyLoopEnum = MyFace.GetLoopEnumerator();
                    while (MyLoopEnum.MoveNext())
                    {
                        Loop MyLoop = MyLoopEnum.Current as Loop;
                        if (MyLoop != null)
                        {
                            VertexEnumerator MyVertexEnum = MyLoop.GetVertexEnumerator() as VertexEnumerator;
                            while (MyVertexEnum.MoveNext())
                            {
                                Point MyVertex = MyVertexEnum.Current as Point;
                                if (MyVertex != null)
                                {
                                    MyList.Add(MyVertex);
                                }
                            }
                        }
                    }
                }
            }
            double max_CoordinatesValueX = MyList[0].X;
            double max_CoordinatesValueY = MyList[0].Y;
            double max_CoordinatesValueZ = MyList[0].Z;

            for (int i = 1; i < MyList.Count; i++)
            {

                if (MyList[i].X > max_CoordinatesValueX)
                {
                    max_CoordinatesValueX = MyList[i].X;
                }
                if (MyList[i].Y > max_CoordinatesValueY)
                {
                    max_CoordinatesValueY = MyList[i].Y;
                }
                if (MyList[i].Z > max_CoordinatesValueZ)
                {
                    max_CoordinatesValueZ = MyList[i].Z;
                }
            }


            this.Max_CoordinatesValueX = max_CoordinatesValueX;
            this.Max_CoordinatesValueY = max_CoordinatesValueY;
            this.Max_CoordinatesValueZ = max_CoordinatesValueZ;
        }



    }
}
