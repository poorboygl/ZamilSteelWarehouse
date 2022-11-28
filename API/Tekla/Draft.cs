using Tekla.Structures.Model;

namespace API.Tekla
{
    public class Draft
    {
        Model MyModel;
        Provider provider;
        public Draft(Model mymodel)
        {
            this.MyModel = mymodel;
            provider = new Provider(mymodel);
        }
        //Duyet Kiem tra coi lai

        public void SelectAllBeam_UseWhile(string name)
        {

            ModelObjectEnumerator ObjectsInModel = MyModel.GetModelObjectSelector().GetAllObjects();

            while (ObjectsInModel.MoveNext())
            {
                Beam MyBeam = ObjectsInModel.Current as Beam;

                if (MyBeam != null && MyBeam.Name == name) //use same name as given in exercise 1
                {
                    ModelObjectEnumerator BeamChildren = MyBeam.GetChildren();
                    bool HasRebars = false;

                    while (BeamChildren.MoveNext())
                    {
                        if (BeamChildren.Current is Reinforcement)
                        {
                            HasRebars = true;
                        }
                    }

                    //    if (HasRebars)
                    //    {
                    //        AttributeRebar(MyBeam, MyBeam.StartPoint.X, MyBeam.StartPoint.Y);
                    //    }
                    //    else
                    //    {
                    //        AttributeRebar(MyBeam, MyBeam.StartPoint.X, MyBeam.StartPoint.Y);
                    //    }

                }
            }

        }


        //Duyet Phan Loai
        //public List<Beam> SelectAllObject_UseFor(string name)
        //{      
        //    ModelObjectSelector modelObjects = MyModel.GetModelObjectSelector();
        //    List<Beam> list = new List<Beam>();
        //    foreach(ModelObject MO in modelObjects)
        //    {
        //        Beam beam = MO as Beam;
        //        if (beam != null)
        //        {
        //            if (beam.Name == name)
        //            {
        //                list.Add(beam);
        //            }
        //        }


        //    }    
        //    return list;
        //}
    }
}

