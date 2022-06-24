namespace HW3_WF_Vasilchenko
{
    partial class HW3_WF
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
            this.components = new System.ComponentModel.Container();
            this.btnTask1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.toolTipTask1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTask2 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTask1
            // 
            this.btnTask1.Location = new System.Drawing.Point(35, 105);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(125, 60);
            this.btnTask1.TabIndex = 1;
            this.btnTask1.Text = "Task1";
            this.toolTipTask1.SetToolTip(this.btnTask1, "Goods Catalogue");
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(35, 213);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(294, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTask2
            // 
            this.btnTask2.Location = new System.Drawing.Point(204, 105);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(125, 60);
            this.btnTask2.TabIndex = 4;
            this.btnTask2.Text = "Task2";
            this.toolTipTask2.SetToolTip(this.btnTask2, "Calculator");
            this.btnTask2.UseVisualStyleBackColor = true;
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vasilchenko Alexander";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Home Work #3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Windows Forms";
            // 
            // HW3_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTask2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTask1);
            this.Name = "HW3_Menu";
            this.Text = "HW3_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.ToolTip toolTipTask1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.ToolTip toolTipTask2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

