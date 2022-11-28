using API.Tekla;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Tekla.Structures.Catalogs;
using Tekla.Structures.Dialog;
using Tekla.Structures.Dialog.UIControls;
using Tekla.Structures.Model;

namespace Core
{

    public partial class fCreateColumnTest : ApplicationFormBase
    {
        ArrayList GetModelObjects;
        Provider provider;
        Model MyModel;
        private readonly List<MaterialItem> SteelMaterials;    
        public fCreateColumnTest(Model mymodel)
        {
            InitializeComponent();
            base.InitializeForm();
            this.MyModel = mymodel;
            this.provider = new Provider(mymodel);
            SteelMaterials = new List<MaterialItem>();
        }
        private void Tekla_profileCatalogColumn_SelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(tb_ProfileColumn, Tekla_profileCatalogColumn.SelectedProfile);
        }

        private void Tekla_profileCatalogColumn_SelectClicked(object sender, EventArgs e)
        {

            Tekla_profileCatalogColumn.SelectedProfile = tb_ProfileColumn.Text;
        }

        private void btn_selectMaterial_Click(object sender, EventArgs e)
        {
            MaterialSelectionForm SelectionForm = new MaterialSelectionForm(SteelMaterials, tb_MaterialColumn.Text);

            SelectionForm.ShowDialog();

            if (SelectionForm.DialogResult == DialogResult.OK)
                SetAttributeValue(tb_MaterialColumn, SelectionForm.SelectedMaterial);
        }
        //load vat lieu thep tu tekla
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);



            //Create a filtered list of steel materials available in the material catalog
            CatalogHandler CatalogHandler = new CatalogHandler();

            MaterialItemEnumerator Materials = CatalogHandler.GetMaterialItems();

            while (Materials.MoveNext())
            {
                MaterialItem Item = Materials.Current;

                if (Item.Type == MaterialItem.MaterialItemTypeEnum.MATERIAL_STEEL)
                {
                    SteelMaterials.Add(Item);
                }
            }
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
             ModelObject CreateColumn(double PositionX, double PositionY)
            {
                Beam Column = new Beam();

                Column.Name = "COLUMN";
                Column.Profile.ProfileString = tb_ProfileColumn.Text;
                Column.Material.MaterialString = tb_MaterialColumn.Text;
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
                }
                // Always remember to commit changes to Tekla Structures, otherwise some things might be left in uncertain state
                MyModel.CommitChanges();
            

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {        
        }

        private void fCreateColumnTest_Load(object sender, EventArgs e)
        {

        }
    }
}
