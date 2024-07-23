using System;
using System.Windows.Forms;

namespace InBetween
{
    public partial class frm1 : Form
    {
        Random randomize = new Random();
        int computerOne;
        int computerTwo;
        int player;
        public frm1()
        {
            InitializeComponent();
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            computerOne = randomize.Next(1, 13);
            computerTwo = randomize.Next(1, 13);
            lblComputer1.Text = computerOne.ToString();
            lblComputer2.Text = computerTwo.ToString();
            lblPlayer.Text = "";
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            player = randomize.Next(1, 13);
            lblPlayer.Text = player.ToString();

            if (player > computerOne & player < computerTwo)
            {
                MessageBox.Show("You Win!");
                lblPlayer.Text = "";
            }
            else if (player < computerOne & player > computerTwo)
            {
                MessageBox.Show("You Win!");
                lblPlayer.Text = "";
            }
            else
            {
                MessageBox.Show("You Lose.");
                lblPlayer.Text = "";
            }

            computerOne = randomize.Next(1, 13);
            computerTwo = randomize.Next(1, 13);
            lblComputer1.Text = computerOne.ToString();
            lblComputer2.Text = computerTwo.ToString();

        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            lblComputer1.Text = "";
            lblComputer2.Text = "";
            lblPlayer.Text = "";

            computerOne = randomize.Next(1, 13);
            computerTwo = randomize.Next(1, 13);

            lblComputer1.Text = computerOne.ToString();
            lblComputer2.Text = computerTwo.ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            computerOne = 1;
            computerTwo = 13;
            lblComputer1.Text = computerOne.ToString();
            lblComputer2.Text = computerTwo.ToString();
            lblPlayer.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
