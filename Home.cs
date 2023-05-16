using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIBITI
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        public void set_active_page(UserControl control)
        {
            this.Visible = false;

            control.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            tipo_de_conversao_txt.SelectedIndex = 0;
        }

        private void tipo_de_conversao_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipo_de_conversao_txt.SelectedIndex == 0)
            {
                nome_conversao_txt.Text = "Valor da base úmida:";
            }
            else
            {
                nome_conversao_txt.Text = "Valor da base seca:";
            }

            conversao_res_title.Visible = false;
            conversao_res.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conversao_res_title.Visible = true;
            conversao_res.Visible = true;

            float resultado = 0.0F;

            if (tipo_de_conversao_txt.SelectedIndex == 0)
            {
                float umida = Single.Parse(conversao_txt.Text, CultureInfo.InvariantCulture);
                resultado = (100 * umida) / (100 - umida);
            }
            else
            {
                float seca = Single.Parse(conversao_txt.Text, CultureInfo.InvariantCulture);
                resultado = (100 * seca) / (100 + seca);
            }

            conversao_res.Text = string.Format(CultureInfo.InvariantCulture, "{0:N2}%", resultado);
        }

        private void conversao_txt_TextChanged(object sender, EventArgs e)
        {
            conversao_res_title.Visible = false;
            conversao_res.Visible = false;
        }
    }
}
