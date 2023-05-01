namespace Geometria.FormasG.CirculoC
{
    partial class Circulo
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
            label1 = new Label();
            txt_Raio = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_ResultadoP = new TextBox();
            label4 = new Label();
            txt_Diametro = new TextBox();
            label5 = new Label();
            txt_area = new TextBox();
            btn_Caculo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(153, 65);
            label1.Name = "label1";
            label1.Size = new Size(488, 33);
            label1.TabIndex = 0;
            label1.Text = "Calcule as propriedades do Circulo";
            // 
            // txt_Raio
            // 
            txt_Raio.Location = new Point(343, 126);
            txt_Raio.Name = "txt_Raio";
            txt_Raio.Size = new Size(125, 27);
            txt_Raio.TabIndex = 1;
            txt_Raio.TextChanged += txt_Raio_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 129);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "Raio:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 346);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 4;
            label3.Text = "Perimetro ou Circuferencia:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_ResultadoP
            // 
            txt_ResultadoP.Location = new Point(343, 339);
            txt_ResultadoP.Name = "txt_ResultadoP";
            txt_ResultadoP.Size = new Size(125, 27);
            txt_ResultadoP.TabIndex = 3;
            txt_ResultadoP.TextChanged += txt_ResultadoP_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 418);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 6;
            label4.Text = "Diâmetro:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_Diametro
            // 
            txt_Diametro.Location = new Point(343, 411);
            txt_Diametro.Name = "txt_Diametro";
            txt_Diametro.Size = new Size(125, 27);
            txt_Diametro.TabIndex = 5;
            txt_Diametro.TextChanged += txt_Diametro_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 385);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 8;
            label5.Text = "Área:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_area
            // 
            txt_area.Location = new Point(343, 378);
            txt_area.Name = "txt_area";
            txt_area.Size = new Size(125, 27);
            txt_area.TabIndex = 7;
            txt_area.TextChanged += txt_area_TextChanged;
            // 
            // btn_Caculo
            // 
            btn_Caculo.Location = new Point(354, 174);
            btn_Caculo.Name = "btn_Caculo";
            btn_Caculo.Size = new Size(94, 29);
            btn_Caculo.TabIndex = 9;
            btn_Caculo.Text = "Calcular";
            btn_Caculo.UseVisualStyleBackColor = true;
            btn_Caculo.Click += btn_Caculo_Click;
            // 
            // CirculoC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Caculo);
            Controls.Add(label5);
            Controls.Add(txt_area);
            Controls.Add(label4);
            Controls.Add(txt_Diametro);
            Controls.Add(label3);
            Controls.Add(txt_ResultadoP);
            Controls.Add(label2);
            Controls.Add(txt_Raio);
            Controls.Add(label1);
            Name = "Circulo";
            Text = "Circulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Raio;
        private Label label2;
        private Label label3;
        private TextBox txt_ResultadoP;
        private Label label4;
        private TextBox txt_Diametro;
        private Label label5;
        private TextBox txt_area;
        private Button btn_Caculo;
    }
}