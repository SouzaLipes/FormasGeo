namespace Geometria.FormasG.HexagonoH
{
    partial class Hexagono
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
            btn_Calculo = new Button();
            label5 = new Label();
            txt_area = new TextBox();
            label3 = new Label();
            txt_ResultadoP = new TextBox();
            label2 = new Label();
            txt_Lado = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txt_Apotema = new TextBox();
            SuspendLayout();
            // 
            // btn_Calculo
            // 
            btn_Calculo.Location = new Point(357, 148);
            btn_Calculo.Name = "btn_Calculo";
            btn_Calculo.Size = new Size(94, 29);
            btn_Calculo.TabIndex = 19;
            btn_Calculo.Text = "Calcular";
            btn_Calculo.UseVisualStyleBackColor = true;
            btn_Calculo.Click += btn_Calculo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 359);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 18;
            label5.Text = "Área:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_area
            // 
            txt_area.Location = new Point(346, 352);
            txt_area.Name = "txt_area";
            txt_area.Size = new Size(125, 27);
            txt_area.TabIndex = 17;
            txt_area.TextChanged += txt_area_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 316);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 14;
            label3.Text = "Perimetro:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_ResultadoP
            // 
            txt_ResultadoP.Location = new Point(346, 313);
            txt_ResultadoP.Name = "txt_ResultadoP";
            txt_ResultadoP.Size = new Size(125, 27);
            txt_ResultadoP.TabIndex = 13;
            txt_ResultadoP.TextChanged += txt_ResultadoP_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 103);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 12;
            label2.Text = "Comprimento lado:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_Lado
            // 
            txt_Lado.Location = new Point(346, 100);
            txt_Lado.Name = "txt_Lado";
            txt_Lado.Size = new Size(125, 27);
            txt_Lado.TabIndex = 11;
            txt_Lado.TextChanged += txt_Lado_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(156, 39);
            label1.Name = "label1";
            label1.Size = new Size(527, 33);
            label1.TabIndex = 10;
            label1.Text = "Calcule as propriedades do Hexagono\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 392);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 21;
            label4.Text = "Apotema:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_Apotema
            // 
            txt_Apotema.Location = new Point(346, 385);
            txt_Apotema.Name = "txt_Apotema";
            txt_Apotema.Size = new Size(125, 27);
            txt_Apotema.TabIndex = 20;
            txt_Apotema.TextChanged += txt_Apotema_TextChanged;
            // 
            // HexagonoH
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
            Name = "Hexagono";
            Text = "Hexagono";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Calculo;
        private Label label5;
        private TextBox txt_area;
        private Label label3;
        private TextBox txt_ResultadoP;
        private Label label2;
        private TextBox txt_Lado;
        private Label label1;
        private Label label4;
        private TextBox txt_Apotema;
    }
}