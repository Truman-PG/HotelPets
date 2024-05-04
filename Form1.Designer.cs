namespace HotelPets
{
    partial class frmHotelPets
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnResultado = new Button();
            numQtdAnimais = new NumericUpDown();
            numQtdDias = new NumericUpDown();
            numQtdRacao = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblResultado = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numQtdAnimais).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQtdDias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQtdRacao).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.FromArgb(128, 255, 128);
            btnResultado.Cursor = Cursors.Hand;
            btnResultado.Location = new Point(33, 345);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(112, 34);
            btnResultado.TabIndex = 0;
            btnResultado.Text = "Calcular";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // numQtdAnimais
            // 
            numQtdAnimais.BackColor = Color.White;
            numQtdAnimais.Location = new Point(33, 99);
            numQtdAnimais.Name = "numQtdAnimais";
            numQtdAnimais.Size = new Size(180, 31);
            numQtdAnimais.TabIndex = 1;
            numQtdAnimais.TextAlign = HorizontalAlignment.Right;
            // 
            // numQtdDias
            // 
            numQtdDias.Location = new Point(33, 271);
            numQtdDias.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numQtdDias.Name = "numQtdDias";
            numQtdDias.Size = new Size(180, 31);
            numQtdDias.TabIndex = 2;
            numQtdDias.TextAlign = HorizontalAlignment.Right;
            // 
            // numQtdRacao
            // 
            numQtdRacao.DecimalPlaces = 2;
            numQtdRacao.Location = new Point(33, 182);
            numQtdRacao.Name = "numQtdRacao";
            numQtdRacao.Size = new Size(180, 31);
            numQtdRacao.TabIndex = 3;
            numQtdRacao.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 71);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 4;
            label1.Text = "Quantidade de animais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 154);
            label2.Name = "label2";
            label2.Size = new Size(322, 25);
            label2.TabIndex = 5;
            label2.Text = "Consumo médio de ração diária em KG";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 243);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 6;
            label3.Text = "Número de dias";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 7);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 7;
            label4.Text = "Calculo de Ração";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(527, 182);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(71, 81);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "0";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 416);
            panel1.TabIndex = 9;
            // 
            // frmHotelPets
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numQtdRacao);
            Controls.Add(numQtdDias);
            Controls.Add(numQtdAnimais);
            Controls.Add(btnResultado);
            Controls.Add(panel1);
            Name = "frmHotelPets";
            Text = "Hotel de Pets";
            ((System.ComponentModel.ISupportInitialize)numQtdAnimais).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQtdDias).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQtdRacao).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResultado;
        private NumericUpDown numQtdAnimais;
        private NumericUpDown numQtdDias;
        private NumericUpDown numQtdRacao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblResultado;
        private Panel panel1;
    }
}
