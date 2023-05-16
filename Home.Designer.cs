namespace TIBITI
{
    partial class Home
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
            label2 = new Label();
            umidade_final_err = new Label();
            umidade_inicial_err = new Label();
            conversao_btn = new Button();
            conversao_res = new Label();
            conversao_res_title = new Label();
            conversao_txt = new TextBox();
            nome_conversao_txt = new Label();
            label1 = new Label();
            tipo_de_conversao_txt = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(123, 28);
            label2.Name = "label2";
            label2.Size = new Size(199, 23);
            label2.TabIndex = 2;
            label2.Text = "Conversão de bases";
            // 
            // umidade_final_err
            // 
            umidade_final_err.AutoSize = true;
            umidade_final_err.BackColor = Color.Crimson;
            umidade_final_err.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            umidade_final_err.ForeColor = Color.White;
            umidade_final_err.Location = new Point(202, 137);
            umidade_final_err.Name = "umidade_final_err";
            umidade_final_err.Size = new Size(0, 15);
            umidade_final_err.TabIndex = 18;
            // 
            // umidade_inicial_err
            // 
            umidade_inicial_err.AutoSize = true;
            umidade_inicial_err.BackColor = Color.Crimson;
            umidade_inicial_err.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            umidade_inicial_err.ForeColor = Color.White;
            umidade_inicial_err.Location = new Point(216, 75);
            umidade_inicial_err.Name = "umidade_inicial_err";
            umidade_inicial_err.Size = new Size(0, 15);
            umidade_inicial_err.TabIndex = 17;
            // 
            // conversao_btn
            // 
            conversao_btn.BackColor = Color.YellowGreen;
            conversao_btn.Cursor = Cursors.Hand;
            conversao_btn.FlatStyle = FlatStyle.Popup;
            conversao_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            conversao_btn.ForeColor = Color.Black;
            conversao_btn.Location = new Point(185, 192);
            conversao_btn.Name = "conversao_btn";
            conversao_btn.Size = new Size(98, 41);
            conversao_btn.TabIndex = 16;
            conversao_btn.Text = "Calcular";
            conversao_btn.UseVisualStyleBackColor = false;
            conversao_btn.Click += button1_Click;
            // 
            // conversao_res
            // 
            conversao_res.BackColor = Color.OliveDrab;
            conversao_res.CausesValidation = false;
            conversao_res.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            conversao_res.ForeColor = Color.White;
            conversao_res.Location = new Point(22, 280);
            conversao_res.Name = "conversao_res";
            conversao_res.Padding = new Padding(8);
            conversao_res.Size = new Size(136, 32);
            conversao_res.TabIndex = 15;
            conversao_res.Visible = false;
            // 
            // conversao_res_title
            // 
            conversao_res_title.AutoSize = true;
            conversao_res_title.Location = new Point(22, 256);
            conversao_res_title.Name = "conversao_res_title";
            conversao_res_title.Size = new Size(105, 15);
            conversao_res_title.TabIndex = 14;
            conversao_res_title.Text = "Valor da base seca:";
            conversao_res_title.Visible = false;
            // 
            // conversao_txt
            // 
            conversao_txt.Location = new Point(123, 155);
            conversao_txt.Name = "conversao_txt";
            conversao_txt.Size = new Size(258, 23);
            conversao_txt.TabIndex = 13;
            conversao_txt.TextChanged += conversao_txt_TextChanged;
            // 
            // nome_conversao_txt
            // 
            nome_conversao_txt.AutoSize = true;
            nome_conversao_txt.Location = new Point(123, 137);
            nome_conversao_txt.Name = "nome_conversao_txt";
            nome_conversao_txt.Size = new Size(116, 15);
            nome_conversao_txt.TabIndex = 12;
            nome_conversao_txt.Text = "Valor da base úmida:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 75);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 10;
            label1.Text = "Tipo de conversão";
            // 
            // tipo_de_conversao_txt
            // 
            tipo_de_conversao_txt.FormattingEnabled = true;
            tipo_de_conversao_txt.Items.AddRange(new object[] { "base úmida para base seca", "base seca para base úmida" });
            tipo_de_conversao_txt.Location = new Point(123, 93);
            tipo_de_conversao_txt.Name = "tipo_de_conversao_txt";
            tipo_de_conversao_txt.Size = new Size(258, 23);
            tipo_de_conversao_txt.TabIndex = 19;
            tipo_de_conversao_txt.SelectedIndexChanged += tipo_de_conversao_txt_SelectedIndexChanged;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 117, 40);
            Controls.Add(tipo_de_conversao_txt);
            Controls.Add(umidade_final_err);
            Controls.Add(umidade_inicial_err);
            Controls.Add(conversao_btn);
            Controls.Add(conversao_res);
            Controls.Add(conversao_res_title);
            Controls.Add(conversao_txt);
            Controls.Add(nome_conversao_txt);
            Controls.Add(label1);
            Controls.Add(label2);
            ForeColor = Color.White;
            Name = "Home";
            Size = new Size(514, 333);
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label umidade_final_err;
        private Label umidade_inicial_err;
        private Button conversao_btn;
        private Label conversao_res;
        private Label conversao_res_title;
        private TextBox conversao_txt;
        private Label nome_conversao_txt;
        private Label label1;
        private ComboBox tipo_de_conversao_txt;
    }
}
