using System.Collections;
using System.Collections.Generic;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Solid;

namespace API.Tekla
{
    public class GetCoordinatesMinValue
    {
        public double Min_CoordinatesValueX { get; }
        public double Min_CoordinatesValueY { get; }
        public double Min_CoordinatesValueZ { get; }
        public GetCoordinatesMinValue(Beam beam)
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
            double min_CoordinatesValueX = MyList[0].X;
            double min_CoordinatesValueY = MyList[0].Y;
            double min_CoordinatesValueZ = MyList[0].Z;

            for (int i = 1; i < MyList.Count; i++)
            {

                if (MyList[i].X < min_CoordinatesValueX)
                {
                    min_CoordinatesValueX = MyList[i].X;
                }
                if (MyList[i].Y < min_CoordinatesValueY)
                {
                    min_CoordinatesValueY = MyList[i].Y;
                }
                if (MyList[i].Z < min_CoordinatesValueZ)
                {
                    min_CoordinatesValueZ = MyList[i].Z;
                }
            }


            this.Min_CoordinatesValueX = min_CoordinatesValueX;
            this.Min_CoordinatesValueY = min_CoordinatesValueY;
            this.Min_CoordinatesValueZ = min_CoordinatesValueZ;
        }
        public GetCoordinatesMinValue(ContourPlate plate)
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
            double min_CoordinatesValueX = MyList[0].X;
            double min_CoordinatesValueY = MyList[0].Y;
            double min_CoordinatesValueZ = MyList[0].Z;

            for (int i = 1; i < MyList.Count; i++)
            {

                if (MyList[i].X < min_CoordinatesValueX)
                {
                    min_CoordinatesValueX = MyList[i].X;
                }
                if (MyList[i].Y < min_CoordinatesValueY)
                {
                    min_CoordinatesValueY = MyList[i].Y;
                }
                if (MyList[i].Z < min_CoordinatesValueZ)
                {
                    min_CoordinatesValueZ = MyList[i].Z;
                }
            }


            this.Min_CoordinatesValueX = min_CoordinatesValueX;
            this.Min_CoordinatesValueY = min_CoordinatesValueY;
            this.Min_CoordinatesValueZ = min_CoordinatesValueZ;
        }
    }
}
