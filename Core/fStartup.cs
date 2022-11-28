using API.Tekla;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Tekla.Structures.Model;

namespace Core
{

    public partial class fStartup : Form
    {
        Model MyModel;
        Provider provider;
        //private Events _events = new Events();
        public fStartup(Model mymodel)
        {
            InitializeComponent();
            this.MyModel = mymodel;
            this.provider = new Provider(mymodel);
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            provider.FootingRepository.InsertPadFootings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            fCreateColumnTest fcreatecolumn = new fCreateColumnTest(MyModel);
            fcreatecolumn.ShowDialog();
            //siteProvider.ColumnRepository.InsertColumns();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            provider.BaseplateRepository.CreateBasePlate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //siteProvider.RebarRepository.CreateRebars();
            fCreateRebar fcreaterebar = new fCreateRebar(MyModel);
            fcreaterebar.ShowDialog();
        }

        private void btn_GetGrid_Click(object sender, EventArgs e)
        {
            List<Grid> grids = provider.GridRepository.SelectGrid("Grid");
            grids[0].CoordinateX = "0.00 5*2000.00";
            grids[0].CoordinateY = "0.00 5*2000.00";
            grids[0].Modify();
            MyModel.CommitChanges();

        }

        private void btn_ChangeWorkPlane_Click(object sender, EventArgs e)
        {
            using (ChangeWorkPlane changeWorkPlane = new ChangeWorkPlane(MyModel))
            {
                int ret = changeWorkPlane.SetWorkPlanOnGridA();
            }

        }

        private void btn_GetAssemply_Click(object sender, EventArgs e)
        {
            //List <Assembly> assemblies = provider.AssemblyRepository.SelectAssemblies();
            List <Assembly> assemblies = provider.AssemblyRepository.SelectAssemblies("COLUMN");
            ModelObject modelObject=assemblies[0].GetMainPart();
            ArrayList arrayList2 = new ArrayList();
            ArrayList arrayList = assemblies[0].GetSecondaries();
            ModelObjectEnumerator modelObjectEnumerator = assemblies[0].GetChildren();
            while (modelObjectEnumerator.MoveNext())
            {
                arrayList2.Add(modelObjectEnumerator.Current);
            }
        }
        private void btn_CreateAssembly_Click(object sender, EventArgs e)
        {
            fCreateColumn fCreateColumn = new fCreateColumn(MyModel);
            fCreateColumn.Show();
        }

        private void fStartup_Load(object sender, EventArgs e)
        {
            if (!MyModel.GetConnectionStatus())
            {
                MessageBox.Show("Tekla chưa bật lên");
                this.Close();
            }      
        }





        //private void _events_ClashDetected(ClashCheckData ClashData)
        //{


        //   string identifier1 = ClashData.Object1.Identifier.ToString();
        //    string identifier2 = ClashData.Object2.Identifier.ToString();

        //    List<string> identifiers = new List<string>() { identifier1, identifier2 };
        //    List<Beam> beams = new List<Beam>();
        //    foreach (string item in identifiers)
        //    {
        //        for (int i = 0; i < GetModelObjects.Count; i++)
        //        {
        //            Beam beam = GetModelObjects[i] as Beam;
        //            if (beam !=null)
        //            {
        //                if (beam.Identifier.ToString() == item)
        //                {
        //                    beams.Add(beam);
        //                }

        //            }

        //        }

        //    }
        //    int a = 0;
        //}
    }
}
