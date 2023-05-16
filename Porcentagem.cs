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
    public partial class Porcentagem : UserControl
    {
        public Porcentagem()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            float umidade_final = Single.Parse(umidade_final_txt.Text, CultureInfo.InvariantCulture);
            float umidade_inicial = Single.Parse(umidade_inicial_txt.Text, CultureInfo.InvariantCulture);

            float resultado = ((umidade_inicial - umidade_final) / (100 - umidade_final)) * 100;

            porcentagem_res_title.Visible = true;
            porcentagem_res.Visible = true;

            porcentagem_res.Text = string.Format(CultureInfo.InvariantCulture, "{0:N2}%", resultado);

        }

        private void umidade_inicial_txt_TextChanged(object sender, EventArgs e)
        {
            porcentagem_res.Visible = false;
            porcentagem_res_title.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            porcentagem_res.Visible = false;
            porcentagem_res_title.Visible = false;
        }
    }
}
