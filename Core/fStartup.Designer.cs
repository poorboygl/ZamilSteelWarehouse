
namespace Core
{
    partial class fStartup
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_GetGrid = new System.Windows.Forms.Button();
            this.btn_ChangeWorkPlane = new System.Windows.Forms.Button();
            this.btn_GetAssemply = new System.Windows.Forms.Button();
            this.btn_CreateAssembly = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "CreateFooting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "CreateColumn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "CreateBaseplate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "CreateRebar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_GetGrid
            // 
            this.btn_GetGrid.Location = new System.Drawing.Point(49, 97);
            this.btn_GetGrid.Name = "btn_GetGrid";
            this.btn_GetGrid.Size = new System.Drawing.Size(90, 23);
            this.btn_GetGrid.TabIndex = 4;
            this.btn_GetGrid.Text = "GetGrid";
            this.btn_GetGrid.UseVisualStyleBackColor = true;
            this.btn_GetGrid.Click += new System.EventHandler(this.btn_GetGrid_Click);
            // 
            // btn_ChangeWorkPlane
            // 
            this.btn_ChangeWorkPlane.Location = new System.Drawing.Point(155, 97);
            this.btn_ChangeWorkPlane.Name = "btn_ChangeWorkPlane";
            this.btn_ChangeWorkPlane.Size = new System.Drawing.Size(193, 23);
            this.btn_ChangeWorkPlane.TabIndex = 5;
            this.btn_ChangeWorkPlane.Text = "ChangeWorkPlane";
            this.btn_ChangeWorkPlane.UseVisualStyleBackColor = true;
            this.btn_ChangeWorkPlane.Click += new System.EventHandler(this.btn_ChangeWorkPlane_Click);
            // 
            // btn_GetAssemply
            // 
            this.btn_GetAssemply.Location = new System.Drawing.Point(354, 97);
            this.btn_GetAssemply.Name = "btn_GetAssemply";
            this.btn_GetAssemply.Size = new System.Drawing.Size(193, 23);
            this.btn_GetAssemply.TabIndex = 6;
            this.btn_GetAssemply.Text = "Get Assemply";
            this.btn_GetAssemply.UseVisualStyleBackColor = true;
            this.btn_GetAssemply.Click += new System.EventHandler(this.btn_GetAssemply_Click);
            // 
            // btn_CreateAssembly
            // 
            this.btn_CreateAssembly.Location = new System.Drawing.Point(49, 155);
            this.btn_CreateAssembly.Name = "btn_CreateAssembly";
            this.btn_CreateAssembly.Size = new System.Drawing.Size(145, 23);
            this.btn_CreateAssembly.TabIndex = 7;
            this.btn_CreateAssembly.Text = "Create AssemblyColumn";
            this.btn_CreateAssembly.UseVisualStyleBackColor = true;
            this.btn_CreateAssembly.Click += new System.EventHandler(this.btn_CreateAssembly_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "4 Ví dụ cơ bản của tekla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tạo Công Cụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vẽ 1 Cột Tiền chế";
            // 
            // fStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CreateAssembly);
            this.Controls.Add(this.btn_GetAssemply);
            this.Controls.Add(this.btn_ChangeWorkPlane);
            this.Controls.Add(this.btn_GetGrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "fStartup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fStartup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_GetGrid;
        private System.Windows.Forms.Button btn_ChangeWorkPlane;
        private System.Windows.Forms.Button btn_GetAssemply;
        private System.Windows.Forms.Button btn_CreateAssembly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

