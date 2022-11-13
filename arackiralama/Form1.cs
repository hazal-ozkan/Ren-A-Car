using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arackiralama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
    
        }
        int gun;
        int ay;
        int yil;
        int ucret;
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char nokta = '.';
            String teslim = dateTimePicker4.Text;
            String alim = dateTimePicker3.Text;
            String[] tarih = teslim.Split(nokta);
            String[] tarih2 = alim.Split(nokta);
            gun = Convert.ToInt32(tarih[0]) - Convert.ToInt32(tarih2[0]);
            ay = Convert.ToInt32(tarih[1]) - Convert.ToInt32(tarih2[1]);
            yil = Convert.ToInt32(tarih[2]) - Convert.ToInt32(tarih2[2]);

            if (ay > 0)
            {
                gun = ay * 30 + gun;
            }
            if (yil > 0)
            {
                gun = yil * 365 + gun;
            }
            ucret = gun * Convert.ToInt32(checkedListBox1.Text);
            textBox6.Text = ucret.ToString();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            if (textBox6.Text == "")
            {
                MessageBox.Show("Ücret hesaplanmadan kiralama işlemi yapılamaz!!");
            }else if(textBox4.Text =="" || textBox5.Text =="")
            {
                MessageBox.Show("Müşteri bilgileri girilmeden kiralama işlemi yapılamaz!!");
            }else if(checkedListBox2.CheckedItems.Count == 0)
            {
                MessageBox.Show("Araba seçilmeden kiralama işlemi yapılamaz!!");
            }
            else {
                MessageBox.Show("Kiralama işlemi tamamlandı!!", "Kirala", MessageBoxButtons.OKCancel);
                this.Close();
            }
            
            
        }
    }
}
