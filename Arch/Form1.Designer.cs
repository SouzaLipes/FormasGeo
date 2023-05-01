namespace Geometria
{
    partial class Form1
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
            btn_comecar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 31);
            label1.Name = "label1";
            label1.Size = new Size(838, 33);
            label1.TabIndex = 0;
            label1.Text = "Clieque no botão abaixo para acessar as formas geométricas";
            // 
            // btn_comecar
            // 
            btn_comecar.BackColor = Color.WhiteSmoke;
            btn_comecar.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_comecar.Location = new Point(347, 104);
            btn_comecar.Name = "btn_comecar";
            btn_comecar.Size = new Size(200, 115);
            btn_comecar.TabIndex = 1;
            btn_comecar.Text = "Começar";
            btn_comecar.UseVisualStyleBackColor = false;
            btn_comecar.UseWaitCursor = true;
            btn_comecar.Click += btn_comecar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(939, 437);
            Controls.Add(btn_comecar);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.Transparent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_comecar;
    }
}