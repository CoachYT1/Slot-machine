using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slot_machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnleva_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            // ciliegia=1
            //uva=3
            //mela=2
            int img_1 = 0, img_2 = 0, img_3 = 0;
            img1.Image = Image.FromFile("7.png");
            img2.Image = Image.FromFile("7.png");
            img3.Image = Image.FromFile("7.png");
            switch (rnd.Next(1,4))
            {
                case 1:
                    img1.Image = Image.FromFile("ciliegie.jpg");
                    img_1 = 1;
                    break;
                case 2: 
                    img1.Image = Image.FromFile("mela.jpg");
                    img_1 = 2;
                    break;
                case 3:
                    img1.Image = Image.FromFile("uva.jpg");
                    img_1 = 3;
                    break;
                default:
                    break;
            }
            switch (rnd.Next(1, 4))
            {
                case 1:
                    img2.Image = Image.FromFile("ciliegie.jpg");
                    img_2 = 1;
                    break;
                case 2:
                    img2.Image = Image.FromFile("mela.jpg");
                    img_2 = 2;
                    break;
                case 3:
                    img2.Image = Image.FromFile("uva.jpg");
                    img_2 = 3;
                    break;
                default:
                    break;
            }
            switch (rnd.Next(1, 4))
            {
                case 1:
                    img3.Image = Image.FromFile("ciliegie.jpg");
                    img_3 = 1;
                    break;
                case 2:
                    img3.Image = Image.FromFile("mela.jpg");
                    img_3 = 2;
                    break;
                case 3:
                    img3.Image = Image.FromFile("uva.jpg");
                    img_3 = 3;
                    break;
                default:
                    break;
            }

            if (img_1 == 1 && img_2 == 1 && img_3 == 1)
                MessageBox.Show("Hai Vinto!!");

            else if (img_1 == 2 && img_2 == 2 && img_3 == 2)
                MessageBox.Show("Hai Vinto!!");

            else if (img_1 == 3 && img_2 == 3 && img_3 == 3)
                MessageBox.Show("Hai Vinto!!");

            else
                MessageBox.Show("Riprova!");
        }
    }
}
