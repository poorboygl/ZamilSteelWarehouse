
namespace Core
{
    partial class fCreateColumnTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tekla_profileCatalogColumn = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_MaterialColumn = new System.Windows.Forms.TextBox();
            this.btn_selectMaterial = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ProfileColumn = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.structuresExtender.SetAttributeName(this.btn_Cancel, null);
            this.structuresExtender.SetAttributeTypeName(this.btn_Cancel, null);
            this.structuresExtender.SetBindPropertyName(this.btn_Cancel, null);
            this.btn_Cancel.Location = new System.Drawing.Point(185, 99);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(88, 23);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Apply
            // 
            this.structuresExtender.SetAttributeName(this.btn_Apply, null);
            this.structuresExtender.SetAttributeTypeName(this.btn_Apply, null);
            this.structuresExtender.SetBindPropertyName(this.btn_Apply, null);
            this.btn_Apply.Location = new System.Drawing.Point(82, 99);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(88, 23);
            this.btn_Apply.TabIndex = 19;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // groupBox2
            // 
            this.structuresExtender.SetAttributeName(this.groupBox2, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox2, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox2, null);
            this.groupBox2.Controls.Add(this.Tekla_profileCatalogColumn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_MaterialColumn);
            this.groupBox2.Controls.Add(this.btn_selectMaterial);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_ProfileColumn);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 81);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columns";
            // 
            // Tekla_profileCatalogColumn
            // 
            this.structuresExtender.SetAttributeName(this.Tekla_profileCatalogColumn, null);
            this.structuresExtender.SetAttributeTypeName(this.Tekla_profileCatalogColumn, null);
            this.Tekla_profileCatalogColumn.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.Tekla_profileCatalogColumn, null);
            this.Tekla_profileCatalogColumn.Location = new System.Drawing.Point(247, 20);
            this.Tekla_profileCatalogColumn.Name = "Tekla_profileCatalogColumn";
            this.Tekla_profileCatalogColumn.SelectedProfile = "";
            this.Tekla_profileCatalogColumn.Size = new System.Drawing.Size(88, 20);
            this.Tekla_profileCatalogColumn.TabIndex = 10;
            this.Tekla_profileCatalogColumn.SelectClicked += new System.EventHandler(this.Tekla_profileCatalogColumn_SelectClicked);
            this.Tekla_profileCatalogColumn.SelectionDone += new System.EventHandler(this.Tekla_profileCatalogColumn_SelectionDone);
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Material:";
            // 
            // tb_MaterialColumn
            // 
            this.structuresExtender.SetAttributeName(this.tb_MaterialColumn, "Material");
            this.structuresExtender.SetAttributeTypeName(this.tb_MaterialColumn, "String");
            this.structuresExtender.SetBindPropertyName(this.tb_MaterialColumn, null);
            this.tb_MaterialColumn.Location = new System.Drawing.Point(99, 46);
            this.tb_MaterialColumn.Name = "tb_MaterialColumn";
            this.tb_MaterialColumn.Size = new System.Drawing.Size(131, 20);
            this.tb_MaterialColumn.TabIndex = 8;
            // 
            // btn_selectMaterial
            // 
            this.structuresExtender.SetAttributeName(this.btn_selectMaterial, null);
            this.structuresExtender.SetAttributeTypeName(this.btn_selectMaterial, null);
            this.structuresExtender.SetBindPropertyName(this.btn_selectMaterial, null);
            this.btn_selectMaterial.Location = new System.Drawing.Point(247, 46);
            this.btn_selectMaterial.Name = "btn_selectMaterial";
            this.btn_selectMaterial.Size = new System.Drawing.Size(88, 22);
            this.btn_selectMaterial.TabIndex = 7;
            this.btn_selectMaterial.Text = "Select...";
            this.btn_selectMaterial.UseVisualStyleBackColor = true;
            this.btn_selectMaterial.Click += new System.EventHandler(this.btn_selectMaterial_Click);
            // 
            // label5
            // 
            this.structuresExtender.SetAttributeName(this.label5, null);
            this.structuresExtender.SetAttributeTypeName(this.label5, null);
            this.label5.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label5, null);
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Profile:";
            // 
            // tb_ProfileColumn
            // 
            this.structuresExtender.SetAttributeName(this.tb_ProfileColumn, "Profile");
            this.structuresExtender.SetAttributeTypeName(this.tb_ProfileColumn, "String");
            this.structuresExtender.SetBindPropertyName(this.tb_ProfileColumn, null);
            this.tb_ProfileColumn.Location = new System.Drawing.Point(99, 20);
            this.tb_ProfileColumn.Name = "tb_ProfileColumn";
            this.tb_ProfileColumn.Size = new System.Drawing.Size(131, 20);
            this.tb_ProfileColumn.TabIndex = 4;
            // 
            // fCreateColumnTest
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(374, 139);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.groupBox2);
            this.Name = "fCreateColumnTest";
            this.Text = "CreateColumn";
            this.Load += new System.EventHandler(this.fCreateColumnTest_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.GroupBox groupBox2;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog Tekla_profileCatalogColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MaterialColumn;
        private System.Windows.Forms.Button btn_selectMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ProfileColumn;
    }
}