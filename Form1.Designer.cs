namespace TIBITI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pageSetupDialog1 = new PageSetupDialog();
            home1 = new Home();
            porcentagem1 = new Porcentagem();
            ajuda1 = new Ajuda();
            label1 = new Label();
            prev_btn = new Button();
            button3 = new Button();
            help_btn = new Button();
            button2 = new Button();
            porcentagem_btn = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // home1
            // 
            home1.BackColor = Color.FromArgb(16, 117, 40);
            home1.ForeColor = Color.White;
            home1.Location = new Point(12, 79);
            home1.Name = "home1";
            home1.Size = new Size(514, 333);
            home1.TabIndex = 3;
            // 
            // porcentagem1
            // 
            porcentagem1.BackColor = Color.FromArgb(16, 117, 40);
            porcentagem1.ForeColor = Color.White;
            porcentagem1.Location = new Point(12, 79);
            porcentagem1.Name = "porcentagem1";
            porcentagem1.Size = new Size(514, 333);
            porcentagem1.TabIndex = 4;
            // 
            // ajuda1
            // 
            ajuda1.BackColor = Color.FromArgb(16, 117, 40);
            ajuda1.ForeColor = Color.White;
            ajuda1.Location = new Point(12, 79);
            ajuda1.Name = "ajuda1";
            ajuda1.Size = new Size(514, 333);
            ajuda1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(158, 27);
            label1.Name = "label1";
            label1.Size = new Size(195, 30);
            label1.TabIndex = 6;
            label1.Text = "Projeto PIBITI";
            // 
            // prev_btn
            // 
            prev_btn.BackColor = Color.FromArgb(16, 117, 40);
            prev_btn.FlatStyle = FlatStyle.Flat;
            prev_btn.ForeColor = Color.FromArgb(16, 117, 40);
            prev_btn.Image = (Image)resources.GetObject("prev_btn.Image");
            prev_btn.Location = new Point(12, 12);
            prev_btn.Name = "prev_btn";
            prev_btn.Size = new Size(28, 28);
            prev_btn.TabIndex = 7;
            prev_btn.UseVisualStyleBackColor = false;
            prev_btn.Visible = false;
            prev_btn.Click += prev_btn_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(3, 71, 19);
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(135, 237);
            button3.Name = "button3";
            button3.Size = new Size(105, 105);
            button3.TabIndex = 13;
            button3.Text = "Conversão de bases";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // help_btn
            // 
            help_btn.BackColor = Color.FromArgb(3, 71, 19);
            help_btn.BackgroundImageLayout = ImageLayout.Center;
            help_btn.Cursor = Cursors.Hand;
            help_btn.FlatStyle = FlatStyle.Flat;
            help_btn.ForeColor = Color.White;
            help_btn.Image = (Image)resources.GetObject("help_btn.Image");
            help_btn.Location = new Point(271, 237);
            help_btn.Name = "help_btn";
            help_btn.Size = new Size(105, 105);
            help_btn.TabIndex = 12;
            help_btn.Text = "Ajuda";
            help_btn.TextAlign = ContentAlignment.BottomCenter;
            help_btn.UseVisualStyleBackColor = false;
            help_btn.Click += help_btn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(3, 71, 19);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(271, 117);
            button2.Name = "button2";
            button2.Size = new Size(105, 105);
            button2.TabIndex = 11;
            button2.Text = "Umidade de equilíbrio";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // porcentagem_btn
            // 
            porcentagem_btn.BackColor = Color.FromArgb(3, 71, 19);
            porcentagem_btn.BackgroundImageLayout = ImageLayout.Center;
            porcentagem_btn.Cursor = Cursors.Hand;
            porcentagem_btn.FlatStyle = FlatStyle.Flat;
            porcentagem_btn.ForeColor = Color.White;
            porcentagem_btn.Image = (Image)resources.GetObject("porcentagem_btn.Image");
            porcentagem_btn.Location = new Point(135, 117);
            porcentagem_btn.Name = "porcentagem_btn";
            porcentagem_btn.Size = new Size(105, 105);
            porcentagem_btn.TabIndex = 10;
            porcentagem_btn.Text = "Porcentagem de quebra";
            porcentagem_btn.TextAlign = ContentAlignment.BottomCenter;
            porcentagem_btn.UseVisualStyleBackColor = false;
            porcentagem_btn.Click += porcentagem_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(105, 57);
            label2.Name = "label2";
            label2.Size = new Size(298, 19);
            label2.TabIndex = 14;
            label2.Text = "Calculadoras sobre pós-colheita de grãos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 117, 40);
            ClientSize = new Size(538, 424);
            Controls.Add(label2);
            Controls.Add(prev_btn);
            Controls.Add(label1);
            Controls.Add(ajuda1);
            Controls.Add(porcentagem1);
            Controls.Add(home1);
            Controls.Add(button3);
            Controls.Add(help_btn);
            Controls.Add(button2);
            Controls.Add(porcentagem_btn);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PageSetupDialog pageSetupDialog1;
        public Home home1;
        public Porcentagem porcentagem1;
        private Ajuda ajuda1;
        private Label label1;
        private Button prev_btn;
        private Button button3;
        private Button help_btn;
        private Button button2;
        private Button porcentagem_btn;
        private Label label2;
    }
}