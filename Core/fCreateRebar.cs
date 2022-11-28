using API.Tekla;
using System;
using System.Globalization;
using Tekla.Structures.Dialog;
using Tekla.Structures.Model;
using TSD = Tekla.Structures.Datatype;

namespace Core
{
    public partial class fCreateRebar : ApplicationFormBase
    {
        Provider provider;
        Model MyModel;
        public fCreateRebar(Model mymodel)
        {
            InitializeComponent();
            base.InitializeForm();
            this.MyModel = mymodel;
            provider = new Provider(mymodel);

        }

        private void Tekla_reinforcementCatalog_SelectClicked(object sender, EventArgs e)
        {
            tekla_reinforcementCatalog.SelectedRebarSize = tb_sizeRebar.Text;
            tekla_reinforcementCatalog.SelectedRebarGrade = tb_GradeRebar.Text;
            tekla_reinforcementCatalog.SelectedRebarBendingRadius = TSD.Distance.Parse(tb_BendingRadiusRebars.Text, CultureInfo.InvariantCulture).Millimeters;
        }

        private void Tekla_reinforcementCatalog_SelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(tb_sizeRebar, tekla_reinforcementCatalog.SelectedRebarSize);
            SetAttributeValue(tb_GradeRebar, tekla_reinforcementCatalog.SelectedRebarGrade);
            SetAttributeValue(tb_BendingRadiusRebars, new TSD.Distance(tekla_reinforcementCatalog.SelectedRebarBendingRadius));
        }

        private void fCreateRebar_Load(object sender, EventArgs e)
        {
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            int ret = provider.RebarRepository.DeleteRebarGroup(SetConstData.FootingrebarName);
            if (ret==1)
            {
                if (tb_BendingRadiusRebars.Text == "" || tb_GradeRebar.Text == "" || int.Parse(tb_BendingRadiusRebars.Text) == 0)
                {
                    provider.RebarRepository.CreateRebars();
                }
                else
                {
                    provider.RebarRepository.CreateRebars(tb_sizeRebar.Text, tb_GradeRebar.Text, tb_BendingRadiusRebars.Text);
                }
            }
          
            
            
        }
    }
}
