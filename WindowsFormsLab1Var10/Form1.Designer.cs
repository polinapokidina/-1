namespace WindowsFormsLab1Var10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblR = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(45, 49);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(104, 13);
            this.lblR.TabIndex = 1;
            this.lblR.Text = "Введите радиус (R)";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(156, 49);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 2;
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(169, 187);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(100, 20);
            this.txtL.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Длина окружности (L)";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(45, 235);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(101, 13);
            this.lblS.TabIndex = 6;
            this.lblS.Text = "Площадь круга (S)";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(169, 232);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(100, 20);
            this.txtS.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(48, 110);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(98, 29);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(182, 110);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 29);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 278);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.lblR);
            this.Name = "Form1";
            this.Text = "Вычисления площади и длины круга";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
    }
}

