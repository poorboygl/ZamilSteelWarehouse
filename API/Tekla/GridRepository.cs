using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tekla.Structures.Model;

namespace API.Tekla
{
    public class GridRepository
    {
        Model MyModel;
        Provider provider;
        public GridRepository(Model mymodel)
        {
            this.MyModel = mymodel;
            provider = new Provider(mymodel);
        }
        public List<Grid> SelectGrid()
        {
            ModelObjectEnumerator ObjectsInModel = MyModel.GetModelObjectSelector().GetAllObjects();
            List<Grid> list = new List<Grid>();

            while (ObjectsInModel.MoveNext())
            {
                Grid grid = ObjectsInModel.Current as Grid;

                if (grid != null)
                {
                    list.Add(grid);

                }
            }
            return list;
        }
        public List<Grid> SelectGrid(string name)
        {
            ModelObjectEnumerator ObjectsInModel = MyModel.GetModelObjectSelector().GetAllObjects();
            List<Grid> list = new List<Grid>();

            while (ObjectsInModel.MoveNext())
            {
                Grid grid = ObjectsInModel.Current as Grid;

                if (grid != null && grid.Name == name)
                {
                    list.Add(grid);

                }
            }
            return list;
        }
    }
}
