namespace Geometria.FormasG.PentagonoP
{
    partial class Pentagono
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
            label4 = new Label();
            txt_Apotema = new TextBox();
            btn_Calculo = new Button();
            label5 = new Label();
            txt_area = new TextBox();
            label3 = new Label();
            txt_ResultadoP = new TextBox();
            label2 = new Label();
            txt_Lado = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 392);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 41;
            label4.Text = "Apotema:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_Apotema
            // 
            txt_Apotema.Location = new Point(330, 385);
            txt_Apotema.Name = "txt_Apotema";
            txt_Apotema.Size = new Size(125, 27);
            txt_Apotema.TabIndex = 40;
            txt_Apotema.TextChanged += txt_Apotema_TextChanged;
            // 
            // btn_Calculo
            // 
            btn_Calculo.Location = new Point(341, 148);
            btn_Calculo.Name = "btn_Calculo";
            btn_Calculo.Size = new Size(94, 29);
            btn_Calculo.TabIndex = 39;
            btn_Calculo.Text = "Calcular";
            btn_Calculo.UseVisualStyleBackColor = true;
            btn_Calculo.Click += btn_Calculo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 359);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 38;
            label5.Text = "Área:";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // txt_area
            // 
            txt_area.Location = new Point(330, 352);
            txt_area.Name = "txt_area";
            txt_area.Size = new Size(125, 27);
            txt_area.TabIndex = 37;
            txt_area.TextChanged += txt_area_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 316);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 36;
            label3.Text = "Perimetro:";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // txt_ResultadoP
            // 
            txt_ResultadoP.Location = new Point(330, 313);
            txt_ResultadoP.Name = "txt_ResultadoP";
            txt_ResultadoP.Size = new Size(125, 27);
            txt_ResultadoP.TabIndex = 35;
            txt_ResultadoP.TextChanged += txt_ResultadoP_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 103);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 34;
            label2.Text = "Comprimento lado:";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // txt_Lado
            // 
            txt_Lado.Location = new Point(330, 100);
            txt_Lado.Name = "txt_Lado";
            txt_Lado.Size = new Size(125, 27);
            txt_Lado.TabIndex = 33;
            txt_Lado.TextChanged += txt_Lado_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(140, 39);
            label1.Name = "label1";
            label1.Size = new Size(535, 33);
            label1.TabIndex = 32;
            label1.Text = "Calcule as propriedades do Pentagono";
            label1.Click += label1_Click;
            // 
            // Pentagono
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txt_Apotema);
            Controls.Add(btn_Calculo);
            Controls.Add(label5);
            Controls.Add(txt_area);
            Controls.Add(label3);
            Controls.Add(txt_ResultadoP);
            Controls.Add(label2);
            Controls.Add(txt_Lado);
            Controls.Add(label1);
            Name = "Pentagono";
            Text = "Pentagono";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txt_Apotema;
        private Button btn_Calculo;
        private Label label5;
        private TextBox txt_area;
        private Label label3;
        private TextBox txt_ResultadoP;
        private Label label2;
        private TextBox txt_Lado;
        private Label label1;
    }
}