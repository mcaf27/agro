namespace TIBITI
{
    partial class Porcentagem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            umidade_inicial_txt = new TextBox();
            umidade_final_txt = new TextBox();
            label3 = new Label();
            porcentagem_res_title = new Label();
            porcentagem_res = new Label();
            button1 = new Button();
            umidade_inicial_err = new Label();
            umidade_final_err = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 75);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Umidade inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(123, 28);
            label2.Name = "label2";
            label2.Size = new Size(236, 23);
            label2.TabIndex = 1;
            label2.Text = "Porcentagem de quebra";
            // 
            // umidade_inicial_txt
            // 
            umidade_inicial_txt.Location = new Point(123, 93);
            umidade_inicial_txt.Name = "umidade_inicial_txt";
            umidade_inicial_txt.Size = new Size(258, 23);
            umidade_inicial_txt.TabIndex = 2;
            umidade_inicial_txt.TextChanged += umidade_inicial_txt_TextChanged;
            // 
            // umidade_final_txt
            // 
            umidade_final_txt.Location = new Point(123, 155);
            umidade_final_txt.Name = "umidade_final_txt";
            umidade_final_txt.Size = new Size(258, 23);
            umidade_final_txt.TabIndex = 4;
            umidade_final_txt.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 137);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 3;
            label3.Text = "Umidade final";
            label3.Click += label3_Click;
            // 
            // porcentagem_res_title
            // 
            porcentagem_res_title.AutoSize = true;
            porcentagem_res_title.Location = new Point(22, 256);
            porcentagem_res_title.Name = "porcentagem_res_title";
            porcentagem_res_title.Size = new Size(182, 15);
            porcentagem_res_title.TabIndex = 5;
            porcentagem_res_title.Text = "Valor da porcentagem de quebra:";
            porcentagem_res_title.Visible = false;
            // 
            // porcentagem_res
            // 
            porcentagem_res.BackColor = Color.OliveDrab;
            porcentagem_res.CausesValidation = false;
            porcentagem_res.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            porcentagem_res.ForeColor = Color.White;
            porcentagem_res.Location = new Point(22, 280);
            porcentagem_res.Name = "porcentagem_res";
            porcentagem_res.Padding = new Padding(8);
            porcentagem_res.Size = new Size(136, 32);
            porcentagem_res.TabIndex = 6;
            porcentagem_res.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(185, 192);
            button1.Name = "button1";
            button1.Size = new Size(98, 41);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // umidade_inicial_err
            // 
            umidade_inicial_err.AutoSize = true;
            umidade_inicial_err.BackColor = Color.Crimson;
            umidade_inicial_err.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            umidade_inicial_err.ForeColor = Color.White;
            umidade_inicial_err.Location = new Point(218, 75);
            umidade_inicial_err.Name = "umidade_inicial_err";
            umidade_inicial_err.Size = new Size(0, 15);
            umidade_inicial_err.TabIndex = 8;
            // 
            // umidade_final_err
            // 
            umidade_final_err.AutoSize = true;
            umidade_final_err.BackColor = Color.Crimson;
            umidade_final_err.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            umidade_final_err.ForeColor = Color.White;
            umidade_final_err.Location = new Point(204, 137);
            umidade_final_err.Name = "umidade_final_err";
            umidade_final_err.Size = new Size(0, 15);
            umidade_final_err.TabIndex = 9;
            // 
            // Porcentagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 117, 40);
            Controls.Add(umidade_final_err);
            Controls.Add(umidade_inicial_err);
            Controls.Add(button1);
            Controls.Add(porcentagem_res);
            Controls.Add(porcentagem_res_title);
            Controls.Add(umidade_final_txt);
            Controls.Add(label3);
            Controls.Add(umidade_inicial_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Porcentagem";
            Size = new Size(514, 333);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox umidade_inicial_txt;
        private TextBox umidade_final_txt;
        private Label label3;
        private Label porcentagem_res_title;
        private Label porcentagem_res;
        private Button button1;
        private Label umidade_inicial_err;
        private Label umidade_final_err;
    }
}
