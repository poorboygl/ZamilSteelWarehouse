
namespace Core
{
    partial class fCreateColumn
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAddStiffener = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 23);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnAddStiffener
            // 
            this.btnAddStiffener.Location = new System.Drawing.Point(106, 12);
            this.btnAddStiffener.Name = "btnAddStiffener";
            this.btnAddStiffener.Size = new System.Drawing.Size(88, 23);
            this.btnAddStiffener.TabIndex = 23;
            this.btnAddStiffener.Text = "Add Stiffener";
            this.btnAddStiffener.UseVisualStyleBackColor = true;
            this.btnAddStiffener.Click += new System.EventHandler(this.btnAddStiffener_Click);
            // 
            // fCreateColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 296);
            this.Controls.Add(this.btnAddStiffener);
            this.Controls.Add(this.btnCreate);
            this.Name = "fCreateColumn";
            this.Text = "fCreateColumn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAddStiffener;
    }
}