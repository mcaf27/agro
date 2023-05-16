namespace TIBITI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        public void go_to_homepage()
        {
            home1.Visible = false;
            porcentagem1.Visible = false;
            ajuda1.Visible = false;
            prev_btn.Visible = false;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            go_to_homepage();
        }

        public void set_active_page(UserControl control)
        {
            home1.Visible = false;
            porcentagem1.Visible = false;
            ajuda1.Visible = false;

            control.Visible = true;
            prev_btn.Visible = true;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            go_to_homepage();
        }

        private void porcentagem_btn_Click(object sender, EventArgs e)
        {
            set_active_page(porcentagem1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            set_active_page(home1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            set_active_page(home1);
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            set_active_page(ajuda1);
        }
    }
}