
namespace StartUp
{
    partial class fCreateFooting
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tekla_profileCatalogColumn = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Material = new System.Windows.Forms.TextBox();
            this.MaterialButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Profile = new System.Windows.Forms.TextBox();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.structuresExtender.SetAttributeName(this.groupBox2, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox2, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox2, null);
            this.groupBox2.Controls.Add(this.Tekla_profileCatalogColumn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_Material);
            this.groupBox2.Controls.Add(this.MaterialButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_Profile);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 81);
            this.groupBox2.TabIndex = 15;
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
            // tb_Material
            // 
            this.structuresExtender.SetAttributeName(this.tb_Material, null);
            this.structuresExtender.SetAttributeTypeName(this.tb_Material, null);
            this.structuresExtender.SetBindPropertyName(this.tb_Material, null);
            this.tb_Material.Location = new System.Drawing.Point(99, 46);
            this.tb_Material.Name = "tb_Material";
            this.tb_Material.Size = new System.Drawing.Size(131, 20);
            this.tb_Material.TabIndex = 8;
            this.tb_Material.Text = "S235JR";
            // 
            // MaterialButton
            // 
            this.structuresExtender.SetAttributeName(this.MaterialButton, null);
            this.structuresExtender.SetAttributeTypeName(this.MaterialButton, null);
            this.structuresExtender.SetBindPropertyName(this.MaterialButton, null);
            this.MaterialButton.Location = new System.Drawing.Point(247, 46);
            this.MaterialButton.Name = "MaterialButton";
            this.MaterialButton.Size = new System.Drawing.Size(88, 22);
            this.MaterialButton.TabIndex = 7;
            this.MaterialButton.Text = "Select...";
            this.MaterialButton.UseVisualStyleBackColor = true;
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
            // tb_Profile
            // 
            this.structuresExtender.SetAttributeName(this.tb_Profile, null);
            this.structuresExtender.SetAttributeTypeName(this.tb_Profile, null);
            this.structuresExtender.SetBindPropertyName(this.tb_Profile, null);
            this.tb_Profile.Location = new System.Drawing.Point(99, 20);
            this.tb_Profile.Name = "tb_Profile";
            this.tb_Profile.Size = new System.Drawing.Size(131, 20);
            this.tb_Profile.TabIndex = 4;
            this.tb_Profile.Text = "HEA400";
            // 
            // btn_Apply
            // 
            this.structuresExtender.SetAttributeName(this.btn_Apply, null);
            this.structuresExtender.SetAttributeTypeName(this.btn_Apply, null);
            this.structuresExtender.SetBindPropertyName(this.btn_Apply, null);
            this.btn_Apply.Location = new System.Drawing.Point(21, 99);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(88, 23);
            this.btn_Apply.TabIndex = 16;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.structuresExtender.SetAttributeName(this.btn_Cancel, null);
            this.structuresExtender.SetAttributeTypeName(this.btn_Cancel, null);
            this.structuresExtender.SetBindPropertyName(this.btn_Cancel, null);
            this.btn_Cancel.Location = new System.Drawing.Point(128, 99);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(88, 23);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // fCreateFooting
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(376, 133);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.groupBox2);
            this.Name = "fCreateFooting";
            this.Text = "CreateFooting";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog Tekla_profileCatalogColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Material;
        private System.Windows.Forms.Button MaterialButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Profile;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Cancel;
    }
}