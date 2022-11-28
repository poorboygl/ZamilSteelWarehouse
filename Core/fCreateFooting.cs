using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tekla.Structures.Dialog;
using Tekla.Structures.Catalogs;
namespace StartUp
{
    public partial class fCreateFooting : ApplicationFormBase
    {
        private readonly List<MaterialItem> SteelMaterials;
        public fCreateFooting()
        {
            InitializeComponent();
            base.InitializeForm();
            SteelMaterials = new List<MaterialItem>();
        }

        private void Tekla_profileCatalogColumn_SelectionDone(object sender, EventArgs e)
        {
            
        }
    }
}
