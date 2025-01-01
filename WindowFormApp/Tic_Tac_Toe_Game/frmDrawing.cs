using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class frmDrawing : Form
    {
        public frmDrawing()
        {
            InitializeComponent();
        }

        bool IsX = false;

        short PlayerCount = 0;

        bool CheckbtnIsEmpty(PictureBox picture)
        {
            return picture.Tag.ToString() == "0" ? true : false;
        }

        void PutColorToPic(PictureBox pb)
        {
            pb.BackColor = Color.GreenYellow;
        }

        bool ChangeCaseColor(string Mark)
        {
            if (pb1.Tag.ToString() == Mark && pb2.Tag.ToString() == Mark && pb3.Tag.ToString() == Mark)
            {
                PutColorToPic(pb1);
                PutColorToPic(pb2);
                PutColorToPic(pb3);
                return true;
            } 
            else if (pb4.Tag.ToString() == Mark && pb5.Tag.ToString() == Mark && pb6.Tag.ToString() == Mark)
            {
                PutColorToPic(pb4);
                PutColorToPic(pb5);
                PutColorToPic(pb6);
                return true;
            } 
            else if(pb7.Tag.ToString() == Mark && pb8.Tag.ToString() == Mark && pb9.Tag.ToString() == Mark)
            {
                PutColorToPic(pb7);
                PutColorToPic(pb8);
                PutColorToPic(pb9);
                return true;
            } 
            else if (pb2.Tag.ToString() == Mark && pb5.Tag.ToString() == Mark && pb8.Tag.ToString() == Mark)
            {
                PutColorToPic(pb2);
                PutColorToPic(pb5);
                PutColorToPic(pb8);                
                return true;
            }
            else if(pb3.Tag.ToString() == Mark && pb6.Tag.ToString() == Mark && pb9.Tag.ToString() == Mark)
            {
                PutColorToPic(pb3);
                PutColorToPic(pb6);
                PutColorToPic(pb9);
                return true;
            }
            else if(pb1.Tag.ToString() == Mark && pb5.Tag.ToString() == Mark && pb9.Tag.ToString() == Mark)
            {
                PutColorToPic(pb1);
                PutColorToPic(pb5);
                PutColorToPic(pb9);
                return true;
            }
            else if(pb7.Tag.ToString() == Mark && pb5.Tag.ToString() == Mark && pb9.Tag.ToString() == Mark)
            {
                PutColorToPic(pb7);
                PutColorToPic(pb5);
                PutColorToPic(pb9);
                return true;
            }
            return false;
        }

        void GetWinner()
        {
            if (ChangeCaseColor("1"))
            {
                lblWinner.Text = "Player1";
                MessageBox.Show("Game Over!!", "EndOfGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ChangeCaseColor("2"))
            {
                lblWinner.Text = "Player2";
                MessageBox.Show("Game Over!!", "EndOfGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (PlayerCount == 9) 
            {
                lblWinner.Text = "Draw";
                MessageBox.Show("Game Over!!", "EndOfGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        void PutXorO(PictureBox picture)
        {
            if (!IsX)
            {
                picture.Image = Resources.X;
                IsX = true;
                picture.Tag = "1";
            }
            else
            {
                picture.Image = Resources.O;
                IsX = false;
                picture.Tag = "2";
            }

        }

        void PlayerTurn()
        {
            if (lblPlayer1.Tag.ToString() == "Y")
            {
                lblPlayer1.BackColor = Color.Black;
                lblPlayer1.Tag = "N";
                lblPlayer2.BackColor = Color.Green;
                lblPlayer2.Tag = "Y";
            }
            else
            {
                lblPlayer2.BackColor = Color.Black;
                lblPlayer2.Tag = "N";
                lblPlayer1.BackColor = Color.Green;
                lblPlayer1.Tag = "Y";

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255,255,255,255);
            Pen Pen = new Pen(Black);
            Pen.Width = 5;

            //Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            //draw horizontal lines
            e.Graphics.DrawLine(Pen, 540, 120 ,760,120  );
            e.Graphics.DrawLine(Pen, 540, 180, 760,180 );

            //draw Vertical lines
            e.Graphics.DrawLine(Pen, 620, 60, 620, 230);
            e.Graphics.DrawLine(Pen, 690, 60, 690, 230);

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

            PlayerTurn();

            if (CheckbtnIsEmpty((PictureBox)sender))
            {
                PutXorO((PictureBox)sender);

            }
            else
                MessageBox.Show("You have to choose another position", "Error", MessageBoxButtons.OK);
            PlayerCount++;
            GetWinner();
        }

        void ReturnToDefaultValue(PictureBox pb)
        {
            pb.Image = Resources.question_mark_96;
            pb.BackColor = Color.Black;
            pb.Tag = "0";
        }
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            pb1.Image = Resources.question_mark_96;

            ReturnToDefaultValue(pb1);
            ReturnToDefaultValue(pb2);
            ReturnToDefaultValue(pb3);
            ReturnToDefaultValue(pb4);
            ReturnToDefaultValue(pb5);
            ReturnToDefaultValue(pb6);
            ReturnToDefaultValue(pb7);
            ReturnToDefaultValue(pb8);
            ReturnToDefaultValue(pb9);

            lblWinner.Text = "In Progress"; 
            lblPlayer1.Tag = "Y"; 
            lblPlayer2.Tag = "N";
            PlayerCount = 0;
        }

        private void frmDrawing_Load(object sender, EventArgs e)
        {
            lblPlayer1.BackColor = Color.Green;
        }
    }
}

