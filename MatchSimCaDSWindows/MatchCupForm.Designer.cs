namespace MatchSimCaDSWindows
{
    partial class MatchCupForm
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
            this.cmbVisitante = new System.Windows.Forms.ComboBox();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCupResult = new System.Windows.Forms.Button();
            this.chkNeutral = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbVisitante
            // 
            this.cmbVisitante.FormattingEnabled = true;
            this.cmbVisitante.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbVisitante.Location = new System.Drawing.Point(167, 77);
            this.cmbVisitante.Name = "cmbVisitante";
            this.cmbVisitante.Size = new System.Drawing.Size(121, 23);
            this.cmbVisitante.TabIndex = 18;
            // 
            // cmbLocal
            // 
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbLocal.Location = new System.Drawing.Point(167, 24);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(121, 23);
            this.cmbLocal.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nivel del visitante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nivel del local";
            // 
            // btnCupResult
            // 
            this.btnCupResult.Location = new System.Drawing.Point(112, 156);
            this.btnCupResult.Name = "btnCupResult";
            this.btnCupResult.Size = new System.Drawing.Size(75, 23);
            this.btnCupResult.TabIndex = 14;
            this.btnCupResult.Text = "Resultado";
            this.btnCupResult.UseVisualStyleBackColor = true;
            this.btnCupResult.Click += new System.EventHandler(this.btnCupResult_Click);
            // 
            // chkNeutral
            // 
            this.chkNeutral.AutoSize = true;
            this.chkNeutral.Location = new System.Drawing.Point(16, 121);
            this.chkNeutral.Name = "chkNeutral";
            this.chkNeutral.Size = new System.Drawing.Size(161, 19);
            this.chkNeutral.TabIndex = 19;
            this.chkNeutral.Text = "Partido en cancha neutral";
            this.chkNeutral.UseVisualStyleBackColor = true;
            // 
            // MatchCupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 202);
            this.Controls.Add(this.chkNeutral);
            this.Controls.Add(this.cmbVisitante);
            this.Controls.Add(this.cmbLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCupResult);
            this.Name = "MatchCupForm";
            this.Text = "Partido de Copa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbVisitante;
        private ComboBox cmbLocal;
        private Label label3;
        private Label label4;
        private Button btnCupResult;
        private CheckBox chkNeutral;
    }
}