using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineKometa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[,] Seats = new PictureBox[6,15];
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    string path = "../../Pictures/empty.png";
                    if (j > 0 && Seats[i, j - 1].ImageLocation == "../../Pictures/leftempty.png") { path = "../../Pictures/rightempty.png"; }
                    else if(rnd.Next(0,5) == 1 && j < 14) { path = "../../Pictures/leftempty.png"; }
                    Seats[i, j] = new PictureBox
                    {
                        Name = "PictureBox:" + i.ToString() + ":" + j.ToString(),
                        Size = new Size(30, 30),
                        Location = new Point(33 * j + 50, 33 * i + 20),
                        ImageLocation = @path,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    Seats[i, j].Click += new EventHandler(ChangeSeat);
                    this.Controls.Add(Seats[i, j]);
                }
            }
        }

        private void ChangeSeat(object sender, EventArgs e)
        {
            if ((sender as PictureBox).ImageLocation == "../../Pictures/empty.png") {
                if (rezervace.Checked == true) {
                    (sender as PictureBox).ImageLocation = @"../../Pictures/reserved.png";
                    MessageBox.Show("Rezervoval sis místo Řada: " + (Int32.Parse((sender as PictureBox).Name.Split(':')[1]) + 1) + "  Sedadlo: " + (Int32.Parse((sender as PictureBox).Name.Split(':')[2]) + 1));


                }
    
                else {
                    (sender as PictureBox).ImageLocation = @"../../Pictures/bought.png";
                    MessageBox.Show("Koupil sis místo Řada: " + (Int32.Parse((sender as PictureBox).Name.Split(':')[1]) + 1) + "  Sedadlo: " + (Int32.Parse((sender as PictureBox).Name.Split(':')[2]) + 1));
                }

            }
            else if ((sender as PictureBox).ImageLocation == "../../Pictures/leftempty.png")
            {
                if (rezervace.Checked == true)
                {
                    (sender as PictureBox).ImageLocation = @"../../Pictures/leftreserved.png";
                    Seats[Int32.Parse((sender as PictureBox).Name.Split(':')[1]), Int32.Parse((sender as PictureBox).Name.Split(':')[2]) + 1].ImageLocation = @"../../Pictures/rightreserved.png";
                    MessageBox.Show("Rezervoval sis místo Řada: " + (Int32.Parse((sender as PictureBox).Name.Split(':')[1]) + 1) + "  Sedadlo: " + (Int32.Parse((sender as PictureBox).Name.Split(':')[2]) + 1));
                }
                else
                {
                    (sender as PictureBox).ImageLocation = @"../../Pictures/leftbuy.png";
                    Seats[Int32.Parse((sender as PictureBox).Name.Split(':')[1]), Int32.Parse((sender as PictureBox).Name.Split(':')[2]) + 1].ImageLocation = @"../../Pictures/rightbuy.png";
                    MessageBox.Show("Koupil sis místo Řada: " + (Int32.Parse((sender as PictureBox).Name.Split(':')[1]) + 1) + "  Sedadlo: " + (Int32.Parse((sender as PictureBox).Name.Split(':')[2]) + 1));
                }
            }
            else if ((sender as PictureBox).ImageLocation == "../../Pictures/rightempty.png")
            {
                if (rezervace.Checked == true)
                {
                    (sender as PictureBox).ImageLocation = @"../../Pictures/rightreserved.png";
                    Seats[Int32.Parse((sender as PictureBox).Name.Split(':')[1]), Int32.Parse((sender as PictureBox).Name.Split(':')[2]) - 1].ImageLocation = @"../../Pictures/leftreserved.png";
                    MessageBox.Show("Rezervoval sis místo Řada: " + (Int32.Parse((sender as PictureBox).Name.Split(':')[1]) + 1) + "  Sedadlo: " + (Int32.Parse((sender as PictureBox).Name.Split(':')[2]) + 1));


                }

                else
                {
                    (sender as PictureBox).ImageLocation = @"../../Pictures/rightbuy.png";
                    Seats[Int32.Parse((sender as PictureBox).Name.Split(':')[1]), Int32.Parse((sender as PictureBox).Name.Split(':')[2]) - 1].ImageLocation = @"../../Pictures/leftbuy.png";
                    MessageBox.Show("Koupil sis místo Řada: " + (Int32.Parse((sender as PictureBox).Name.Split(':')[1]) + 1) + "  Sedadlo: " + (Int32.Parse((sender as PictureBox).Name.Split(':')[2]) + 1));
                }
            }
        }
    }

}

