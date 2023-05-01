namespace Geometria.FormasG.TrianguloT
{
    partial class Triangulo
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
            txt_altura = new TextBox();
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
            label4.Location = new Point(164, 156);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 67;
            label4.Text = "Comprimento Altura:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_altura
            // 
            txt_altura.Location = new Point(326, 149);
            txt_altura.Name = "txt_altura";
            txt_altura.Size = new Size(125, 27);
            txt_altura.TabIndex = 66;
            txt_altura.TextChanged += txt_altura_TextChanged;
            // 
            // btn_Calculo
            // 
            btn_Calculo.Location = new Point(341, 225);
            btn_Calculo.Name = "btn_Calculo";
            btn_Calculo.Size = new Size(94, 29);
            btn_Calculo.TabIndex = 65;
            btn_Calculo.Text = "Calcular";
            btn_Calculo.UseVisualStyleBackColor = true;
            btn_Calculo.Click += btn_Calculo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 375);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 64;
            label5.Text = "Área:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_area
            // 
            txt_area.Location = new Point(326, 368);
            txt_area.Name = "txt_area";
            txt_area.Size = new Size(125, 27);
            txt_area.TabIndex = 63;
            txt_area.TextChanged += txt_area_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 332);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 62;
            label3.Text = "Perimetro:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_ResultadoP
            // 
            txt_ResultadoP.Location = new Point(326, 329);
            txt_ResultadoP.Name = "txt_ResultadoP";
            txt_ResultadoP.Size = new Size(125, 27);
            txt_ResultadoP.TabIndex = 61;
            txt_ResultadoP.TextChanged += txt_ResultadoP_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 119);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 60;
            label2.Text = "Comprimento Base:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_Lado
            // 
            txt_Lado.Location = new Point(326, 116);
            txt_Lado.Name = "txt_Lado";
            txt_Lado.Size = new Size(125, 27);
            txt_Lado.TabIndex = 59;
            txt_Lado.TextChanged += txt_Lado_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(136, 55);
            label1.Name = "label1";
            label1.Size = new Size(511, 33);
            label1.TabIndex = 58;
            label1.Text = "Calcule as propriedades do triangulo\r\n";
            // 
            // TrianguloT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txt_altura);
            Controls.Add(btn_Calculo);
            Controls.Add(label5);
            Controls.Add(txt_area);
            Controls.Add(label3);
            Controls.Add(txt_ResultadoP);
            Controls.Add(label2);
            Controls.Add(txt_Lado);
            Controls.Add(label1);
            Name = "Triangulo";
            Text = "Triangulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txt_altura;
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