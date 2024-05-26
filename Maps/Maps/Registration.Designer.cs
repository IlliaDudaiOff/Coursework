namespace Maps {
    partial class Registration {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label4 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.passLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.repPass = new System.Windows.Forms.TextBox();
            this.repLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Показати";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passBox.Location = new System.Drawing.Point(34, 203);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(266, 29);
            this.passBox.TabIndex = 14;
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logBox.Location = new System.Drawing.Point(34, 134);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(266, 29);
            this.logBox.TabIndex = 13;
            // 
            // passLab
            // 
            this.passLab.AutoSize = true;
            this.passLab.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passLab.Location = new System.Drawing.Point(34, 175);
            this.passLab.Name = "passLab";
            this.passLab.Size = new System.Drawing.Size(78, 25);
            this.passLab.TabIndex = 12;
            this.passLab.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Логін";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(34, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Реєстрація";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Реєстрація";
            // 
            // repPass
            // 
            this.repPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.repPass.Location = new System.Drawing.Point(34, 275);
            this.repPass.Name = "repPass";
            this.repPass.Size = new System.Drawing.Size(266, 29);
            this.repPass.TabIndex = 17;
            // 
            // repLab
            // 
            this.repLab.AutoSize = true;
            this.repLab.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.repLab.Location = new System.Drawing.Point(34, 247);
            this.repLab.Name = "repLab";
            this.repLab.Size = new System.Drawing.Size(168, 25);
            this.repLab.TabIndex = 16;
            this.repLab.Text = "Повторіть пароль";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 391);
            this.Controls.Add(this.repPass);
            this.Controls.Add(this.repLab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.passLab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KyivMaps";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox passBox;
        private TextBox logBox;
        private Label passLab;
        private Label label2;
        private Button button2;
        private Label label1;
        private TextBox repPass;
        private Label repLab;
    }
}