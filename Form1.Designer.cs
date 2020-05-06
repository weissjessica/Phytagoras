namespace Weiss_Jessica_Phytagoras
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblA = new System.Windows.Forms.Label();
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtBoxC = new System.Windows.Forms.TextBox();
            this.btnCBerechnen = new System.Windows.Forms.Button();
            this.lblEingabekontrolle = new System.Windows.Forms.Label();
            this.btnABBerechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(88, 98);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(28, 20);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A: ";
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(135, 98);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(100, 26);
            this.txtBoxA.TabIndex = 1;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(88, 151);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(24, 20);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B:";
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(135, 151);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(100, 26);
            this.txtBoxB.TabIndex = 3;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(88, 203);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(28, 20);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "C: ";
            // 
            // txtBoxC
            // 
            this.txtBoxC.Location = new System.Drawing.Point(135, 197);
            this.txtBoxC.Name = "txtBoxC";
            this.txtBoxC.Size = new System.Drawing.Size(100, 26);
            this.txtBoxC.TabIndex = 6;
            // 
            // btnCBerechnen
            // 
            this.btnCBerechnen.Location = new System.Drawing.Point(319, 168);
            this.btnCBerechnen.Name = "btnCBerechnen";
            this.btnCBerechnen.Size = new System.Drawing.Size(131, 41);
            this.btnCBerechnen.TabIndex = 7;
            this.btnCBerechnen.Text = "C Berechnen";
            this.btnCBerechnen.UseVisualStyleBackColor = true;
            this.btnCBerechnen.Click += new System.EventHandler(this.btnCBerechnen_Click);
            // 
            // lblEingabekontrolle
            // 
            this.lblEingabekontrolle.AutoSize = true;
            this.lblEingabekontrolle.Location = new System.Drawing.Point(135, 287);
            this.lblEingabekontrolle.Name = "lblEingabekontrolle";
            this.lblEingabekontrolle.Size = new System.Drawing.Size(0, 20);
            this.lblEingabekontrolle.TabIndex = 8;
            // 
            // btnABBerechnen
            // 
            this.btnABBerechnen.Location = new System.Drawing.Point(306, 100);
            this.btnABBerechnen.Name = "btnABBerechnen";
            this.btnABBerechnen.Size = new System.Drawing.Size(156, 38);
            this.btnABBerechnen.TabIndex = 9;
            this.btnABBerechnen.Text = "A / B Berechnen";
            this.btnABBerechnen.UseVisualStyleBackColor = true;
            this.btnABBerechnen.Click += new System.EventHandler(this.btnABBerechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnABBerechnen);
            this.Controls.Add(this.lblEingabekontrolle);
            this.Controls.Add(this.btnCBerechnen);
            this.Controls.Add(this.txtBoxC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtBoxB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtBoxA);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtBoxC;
        private System.Windows.Forms.Button btnCBerechnen;
        private System.Windows.Forms.Label lblEingabekontrolle;
        private System.Windows.Forms.Button btnABBerechnen;
    }
}

