namespace HW3_WF_Vasilchenko
{
    partial class Calculator
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
            this.btnSign = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.btnPow2 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnUnder = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.lblCurOper = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSign.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSign.Location = new System.Drawing.Point(84, 328);
            this.btnSign.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(64, 64);
            this.btnSign.TabIndex = 0;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNum0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNum0.Location = new System.Drawing.Point(154, 328);
            this.btnNum0.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(64, 64);
            this.btnNum0.TabIndex = 1;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDot.Location = new System.Drawing.Point(224, 328);
            this.btnDot.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(64, 64);
            this.btnDot.TabIndex = 2;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnResult.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnResult.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnResult.Location = new System.Drawing.Point(294, 258);
            this.btnResult.MaximumSize = new System.Drawing.Size(64, 200);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(64, 134);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPlus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlus.Location = new System.Drawing.Point(364, 327);
            this.btnPlus.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(64, 64);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.operBtn_click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNum3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNum3.Location = new System.Drawing.Point(224, 258);
            this.btnNum3.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(64, 64);
            this.btnNum3.TabIndex = 6;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNum2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNum2.Location = new System.Drawing.Point(154, 258);
            this.btnNum2.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(64, 64);
            this.btnNum2.TabIndex = 5;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNum1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNum1.Location = new System.Drawing.Point(84, 258);
            this.btnNum1.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(64, 64);
            this.btnNum1.TabIndex = 4;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinus.Location = new System.Drawing.Point(364, 258);
            this.btnMinus.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(64, 64);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.operBtn_click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNum6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNum6.Location = new System.Drawing.Point(224, 188);
            this.btnNum6.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(64, 64);
            this.btnNum6.TabIndex = 10;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNum5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNum5.Location = new System.Drawing.Point(154, 188);
            this.btnNum5.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(64, 64);
            this.btnNum5.TabIndex = 9;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNum4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNum4.Location = new System.Drawing.Point(84, 188);
            this.btnNum4.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(64, 64);
            this.btnNum4.TabIndex = 8;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMultiply.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMultiply.Location = new System.Drawing.Point(364, 188);
            this.btnMultiply.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(64, 64);
            this.btnMultiply.TabIndex = 15;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.operBtn_click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNum9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNum9.Location = new System.Drawing.Point(224, 118);
            this.btnNum9.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(64, 64);
            this.btnNum9.TabIndex = 14;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNum8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNum8.Location = new System.Drawing.Point(154, 118);
            this.btnNum8.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(64, 64);
            this.btnNum8.TabIndex = 13;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNum7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNum7.Location = new System.Drawing.Point(84, 118);
            this.btnNum7.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(64, 64);
            this.btnNum7.TabIndex = 12;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.numBtn_click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Salmon;
            this.btnClearAll.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearAll.Location = new System.Drawing.Point(14, 188);
            this.btnClearAll.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(64, 64);
            this.btnClearAll.TabIndex = 17;
            this.btnClearAll.Text = "<-";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.BackColor = System.Drawing.Color.Salmon;
            this.btnClearEntry.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearEntry.Location = new System.Drawing.Point(14, 328);
            this.btnClearEntry.MaximumSize = new System.Drawing.Size(64, 200);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(64, 63);
            this.btnClearEntry.TabIndex = 18;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnDevide
            // 
            this.btnDevide.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDevide.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDevide.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDevide.Location = new System.Drawing.Point(294, 188);
            this.btnDevide.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(64, 64);
            this.btnDevide.TabIndex = 19;
            this.btnDevide.Text = "/";
            this.btnDevide.UseVisualStyleBackColor = false;
            this.btnDevide.Click += new System.EventHandler(this.operBtn_click);
            // 
            // btnPow2
            // 
            this.btnPow2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPow2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnPow2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPow2.Location = new System.Drawing.Point(434, 118);
            this.btnPow2.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnPow2.Name = "btnPow2";
            this.btnPow2.Size = new System.Drawing.Size(64, 64);
            this.btnPow2.TabIndex = 21;
            this.btnPow2.Text = "X^2";
            this.btnPow2.UseVisualStyleBackColor = false;
            this.btnPow2.Click += new System.EventHandler(this.btnPow2_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSqrt.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSqrt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSqrt.Location = new System.Drawing.Point(364, 118);
            this.btnSqrt.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(64, 64);
            this.btnSqrt.TabIndex = 20;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(12, 58);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(486, 45);
            this.tbInput.TabIndex = 23;
            this.tbInput.Text = "0";
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPercent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnPercent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPercent.Location = new System.Drawing.Point(294, 118);
            this.btnPercent.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(64, 64);
            this.btnPercent.TabIndex = 27;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLog.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnLog.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLog.Location = new System.Drawing.Point(434, 188);
            this.btnLog.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(64, 64);
            this.btnLog.TabIndex = 26;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnLn
            // 
            this.btnLn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnLn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLn.Location = new System.Drawing.Point(434, 258);
            this.btnLn.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(64, 64);
            this.btnLn.TabIndex = 25;
            this.btnLn.Text = "ln(x)";
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnUnder
            // 
            this.btnUnder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUnder.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnUnder.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUnder.Location = new System.Drawing.Point(434, 327);
            this.btnUnder.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnUnder.Name = "btnUnder";
            this.btnUnder.Size = new System.Drawing.Size(64, 64);
            this.btnUnder.TabIndex = 24;
            this.btnUnder.Text = "1/x";
            this.btnUnder.UseVisualStyleBackColor = false;
            this.btnUnder.Click += new System.EventHandler(this.btnUnder_Click);
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.Red;
            this.btnOff.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnOff.Location = new System.Drawing.Point(14, 118);
            this.btnOff.MaximumSize = new System.Drawing.Size(64, 64);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(64, 64);
            this.btnOff.TabIndex = 28;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // lblCurOper
            // 
            //this.lblCurOper.AutoSize = true;
            //this.lblCurOper.ForeColor = System.Drawing.SystemColors.ControlDark;
            //this.lblCurOper.Location = new System.Drawing.Point(33, 26);
            //this.lblCurOper.Name = "lblCurOper";
            //this.lblCurOper.Size = new System.Drawing.Size(0, 16);
            //this.lblCurOper.TabIndex = 29;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Salmon;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(14, 258);
            this.btnClear.MaximumSize = new System.Drawing.Size(64, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 63);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 403);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCurOper);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnUnder);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnPow2);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnDevide);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnSign);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnDevide;
        private System.Windows.Forms.Button btnPow2;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnUnder;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Label lblCurOper;
        private System.Windows.Forms.Button btnClear;
    }
}