using System;
using System.Collections.Generic;
using Tekla.Structures.Model;

namespace API.Tekla
{
    public class AssemblyRepository
    {
        Model MyModel;
        Provider provider;
        public AssemblyRepository(Model mymodel)
        {
            this.MyModel = mymodel;
            provider = new Provider(mymodel);
        }
        public List<Assembly> SelectAssemblies()
        {
            ModelObjectEnumerator ObjectsInModel = MyModel.GetModelObjectSelector().GetAllObjectsWithType(  new Type[]{ typeof(Assembly)});
            List<Assembly> list = new List<Assembly>();

            while (ObjectsInModel.MoveNext())
            {
                Assembly assembly = (ObjectsInModel.Current) as Assembly;

                if (assembly != null && (assembly.Name=="COLUMN"|| assembly.Name == "FOOTING"))
                {
                    list.Add(assembly);

                }
            }
            return list;
        }
        public List<Assembly> SelectAssemblies(string name)
        {
            ModelObjectEnumerator ObjectsInModel = MyModel.GetModelObjectSelector().GetAllObjectsWithType(new Type[] { typeof(Assembly) });
            List<Assembly> list = new List<Assembly>();

            while (ObjectsInModel.MoveNext())
            {
                Assembly assembly = (ObjectsInModel.Current) as Assembly;

                if (assembly != null && assembly.Name == name)
                {
                    list.Add(assembly);

                }
            }
            return list;
        }

        //public List<Assembly> SelectAssemblies(string name)
        //{
        //    ModelObjectEnumerator ObjectsInModel = MyModel.GetModelObjectSelector().GetAllObjectsWithType(ModelObject.ModelObjectEnum.ASSEMBLY);
        //    List<Assembly> list = new List<Assembly>();

        //    while (ObjectsInModel.MoveNext())
        //    {
        //        Assembly assembly = (ObjectsInModel.Current) as Assembly;

        //        if (assembly != null && assembly.Name == name)
        //        {
        //            list.Add(assembly);

        //        }
        //    }
        //    return list;
        //}

    }
}
