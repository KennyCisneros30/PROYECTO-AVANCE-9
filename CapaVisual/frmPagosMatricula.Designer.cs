namespace CapaVisual
{
    partial class frmPagosMatricula
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
            Matriculatxt = new TextBox();
            Anotxt = new TextBox();
            Modelotxt = new TextBox();
            Colortxt = new TextBox();
            Deudatxt = new TextBox();
            Buscarbtn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Matriculatxt
            // 
            Matriculatxt.Location = new Point(100, 27);
            Matriculatxt.Name = "Matriculatxt";
            Matriculatxt.Size = new Size(167, 23);
            Matriculatxt.TabIndex = 0;
            // 
            // Anotxt
            // 
            Anotxt.Location = new Point(100, 81);
            Anotxt.Name = "Anotxt";
            Anotxt.Size = new Size(100, 23);
            Anotxt.TabIndex = 1;
            // 
            // Modelotxt
            // 
            Modelotxt.Location = new Point(100, 150);
            Modelotxt.Name = "Modelotxt";
            Modelotxt.Size = new Size(100, 23);
            Modelotxt.TabIndex = 2;
            // 
            // Colortxt
            // 
            Colortxt.Location = new Point(100, 215);
            Colortxt.Name = "Colortxt";
            Colortxt.Size = new Size(100, 23);
            Colortxt.TabIndex = 3;
            // 
            // Deudatxt
            // 
            Deudatxt.Location = new Point(100, 286);
            Deudatxt.Name = "Deudatxt";
            Deudatxt.Size = new Size(100, 23);
            Deudatxt.TabIndex = 4;
            // 
            // Buscarbtn
            // 
            Buscarbtn.Location = new Point(395, 27);
            Buscarbtn.Name = "Buscarbtn";
            Buscarbtn.Size = new Size(75, 23);
            Buscarbtn.TabIndex = 5;
            Buscarbtn.Text = "BUSCAR";
            Buscarbtn.UseVisualStyleBackColor = true;
            Buscarbtn.Click += Buscarbtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(440, 286);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmPagosMatricula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(Buscarbtn);
            Controls.Add(Deudatxt);
            Controls.Add(Colortxt);
            Controls.Add(Modelotxt);
            Controls.Add(Anotxt);
            Controls.Add(Matriculatxt);
            Name = "frmPagosMatricula";
            Text = "frmPagosMatricula";
            FormClosing += frmPagosMatricula_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Matriculatxt;
        private TextBox Anotxt;
        private TextBox Modelotxt;
        private TextBox Colortxt;
        private TextBox Deudatxt;
        private Button Buscarbtn;
        private Button button2;
    }
}