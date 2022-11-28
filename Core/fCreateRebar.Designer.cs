
namespace Core
{
    partial class fCreateRebar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tekla_reinforcementCatalog = new Tekla.Structures.Dialog.UIControls.ReinforcementCatalog();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_BendingRadiusRebars = new System.Windows.Forms.TextBox();
            this.tb_GradeRebar = new System.Windows.Forms.TextBox();
            this.tb_sizeRebar = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.structuresExtender.SetAttributeName(this.groupBox1, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox1, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox1, null);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tekla_reinforcementCatalog);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_BendingRadiusRebars);
            this.groupBox1.Controls.Add(this.tb_GradeRebar);
            this.groupBox1.Controls.Add(this.tb_sizeRebar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 110);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rebars";
            // 
            // groupBox3
            // 
            this.structuresExtender.SetAttributeName(this.groupBox3, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox3, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox3, null);
            this.groupBox3.Location = new System.Drawing.Point(238, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(2, 77);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // tekla_reinforcementCatalog
            // 
            this.structuresExtender.SetAttributeName(this.tekla_reinforcementCatalog, null);
            this.structuresExtender.SetAttributeTypeName(this.tekla_reinforcementCatalog, null);
            this.tekla_reinforcementCatalog.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.tekla_reinforcementCatalog, null);
            this.tekla_reinforcementCatalog.Location = new System.Drawing.Point(247, 48);
            this.tekla_reinforcementCatalog.Name = "tekla_reinforcementCatalog";
            this.tekla_reinforcementCatalog.SelectedRebarBendingRadius = 0D;
            this.tekla_reinforcementCatalog.SelectedRebarGrade = "";
            this.tekla_reinforcementCatalog.SelectedRebarSize = "";
            this.tekla_reinforcementCatalog.Size = new System.Drawing.Size(88, 23);
            this.tekla_reinforcementCatalog.TabIndex = 12;
            this.tekla_reinforcementCatalog.SelectClicked += new System.EventHandler(this.Tekla_reinforcementCatalog_SelectClicked);
            this.tekla_reinforcementCatalog.SelectionDone += new System.EventHandler(this.Tekla_reinforcementCatalog_SelectionDone);
            // 
            // label4
            // 
            this.structuresExtender.SetAttributeName(this.label4, null);
            this.structuresExtender.SetAttributeTypeName(this.label4, null);
            this.label4.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label4, null);
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bending radius:";
            // 
            // label3
            // 
            this.structuresExtender.SetAttributeName(this.label3, null);
            this.structuresExtender.SetAttributeTypeName(this.label3, null);
            this.label3.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label3, null);
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grade:";
            // 
            // label2
            // 
            this.structuresExtender.SetAttributeName(this.label2, null);
            this.structuresExtender.SetAttributeTypeName(this.label2, null);
            this.label2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label2, null);
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Size:";
            // 
            // tb_BendingRadiusRebars
            // 
            this.structuresExtender.SetAttributeName(this.tb_BendingRadiusRebars, "BendingRadius");
            this.structuresExtender.SetAttributeTypeName(this.tb_BendingRadiusRebars, "Distance");
            this.structuresExtender.SetBindPropertyName(this.tb_BendingRadiusRebars, null);
            this.tb_BendingRadiusRebars.Location = new System.Drawing.Point(99, 75);
            this.tb_BendingRadiusRebars.Name = "tb_BendingRadiusRebars";
            this.tb_BendingRadiusRebars.Size = new System.Drawing.Size(131, 20);
            this.tb_BendingRadiusRebars.TabIndex = 8;
            this.tb_BendingRadiusRebars.Text = "40";
            // 
            // tb_GradeRebar
            // 
            this.structuresExtender.SetAttributeName(this.tb_GradeRebar, "Grade");
            this.structuresExtender.SetAttributeTypeName(this.tb_GradeRebar, "String");
            this.structuresExtender.SetBindPropertyName(this.tb_GradeRebar, null);
            this.tb_GradeRebar.Location = new System.Drawing.Point(99, 49);
            this.tb_GradeRebar.Name = "tb_GradeRebar";
            this.tb_GradeRebar.Size = new System.Drawing.Size(131, 20);
            this.tb_GradeRebar.TabIndex = 7;
            this.tb_GradeRebar.Text = "A500HW";
            // 
            // tb_sizeRebar
            // 
            this.structuresExtender.SetAttributeName(this.tb_sizeRebar, "Size");
            this.structuresExtender.SetAttributeTypeName(this.tb_sizeRebar, "String");
            this.structuresExtender.SetBindPropertyName(this.tb_sizeRebar, null);
            this.tb_sizeRebar.Location = new System.Drawing.Point(99, 23);
            this.tb_sizeRebar.Name = "tb_sizeRebar";
            this.tb_sizeRebar.Size = new System.Drawing.Size(131, 20);
            this.tb_sizeRebar.TabIndex = 6;
            this.tb_sizeRebar.Tag = "";
            this.tb_sizeRebar.Text = "12";
            // 
            // btn_Cancel
            // 
            this.structuresExtender.SetAttributeName(this.btn_Cancel, null);
            this.structuresExtender.SetAttributeTypeName(this.btn_Cancel, null);
            this.structuresExtender.SetBindPropertyName(this.btn_Cancel, null);
            this.btn_Cancel.Location = new System.Drawing.Point(188, 128);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(88, 23);
            this.btn_Cancel.TabIndex = 22;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Apply
            // 
            this.structuresExtender.SetAttributeName(this.btn_Apply, null);
            this.structuresExtender.SetAttributeTypeName(this.btn_Apply, null);
            this.structuresExtender.SetBindPropertyName(this.btn_Apply, null);
            this.btn_Apply.Location = new System.Drawing.Point(81, 128);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(88, 23);
            this.btn_Apply.TabIndex = 21;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // fCreateRebar
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(395, 158);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.groupBox1);
            this.Name = "fCreateRebar";
            this.Text = "fCreateRebar";
            this.Load += new System.EventHandler(this.fCreateRebar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Tekla.Structures.Dialog.UIControls.ReinforcementCatalog tekla_reinforcementCatalog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_BendingRadiusRebars;
        private System.Windows.Forms.TextBox tb_GradeRebar;
        private System.Windows.Forms.TextBox tb_sizeRebar;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Apply;
    }
}