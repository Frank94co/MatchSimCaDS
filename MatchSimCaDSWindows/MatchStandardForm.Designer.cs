namespace MatchSimCaDSWindows
{
    partial class MatchStandardForm
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
            this.btnStdResult = new System.Windows.Forms.Button();
            this.cmbVisitante = new System.Windows.Forms.ComboBox();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStdResult
            // 
            this.btnStdResult.Location = new System.Drawing.Point(135, 139);
            this.btnStdResult.Name = "btnStdResult";
            this.btnStdResult.Size = new System.Drawing.Size(75, 23);
            this.btnStdResult.TabIndex = 14;
            this.btnStdResult.Text = "Resultado";
            this.btnStdResult.UseVisualStyleBackColor = true;
            this.btnStdResult.Click += new System.EventHandler(this.btnStdResult_Click);
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
            this.cmbVisitante.Location = new System.Drawing.Point(179, 83);
            this.cmbVisitante.Name = "cmbVisitante";
            this.cmbVisitante.Size = new System.Drawing.Size(121, 23);
            this.cmbVisitante.TabIndex = 13;
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
            this.cmbLocal.Location = new System.Drawing.Point(179, 28);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(121, 23);
            this.cmbLocal.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nivel del visitante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nivel del local";
            // 
            // MatchStandardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 190);
            this.Controls.Add(this.btnStdResult);
            this.Controls.Add(this.cmbVisitante);
            this.Controls.Add(this.cmbLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MatchStandardForm";
            this.Text = "Partido estándar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStdResult;
        private ComboBox cmbVisitante;
        private ComboBox cmbLocal;
        private Label label2;
        private Label label1;
    }
}