using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        bool IsGameActive = true;

        readonly string X_img = "multimediaResources/Images/X_picture.png";
        readonly string O_img = "multimediaResources/Images/O_picture.png";
        public Form1()
        {
            InitializeComponent();
        }

        const int Rows = 3;
        const int Columns = 3;
        const int MaxLinesAmount = 8;
        int[,] field = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int[] lines = { 0, 0, 0, 0, 0, 0, 0, 0 };


        //int diagonal = 0;

        public void EnemyTurn()
        {
            var rand = new Random();

            int x = 0, y = 0;

            do
            {
                x = rand.Next(3);
                y = rand.Next(3);
            } while (field[x, y] != 0);

            field[x, y] = -1;

            switch (x * 3 + y + 1)
            {
                case 1:
                    pictureBox1.Load(O_img);
                    break;
                case 2:
                    pictureBox2.Load(O_img);
                    break;
                case 3:
                    pictureBox3.Load(O_img);
                    break;
                case 4:
                    pictureBox4.Load(O_img);
                    break;
                case 5:
                    pictureBox5.Load(O_img);
                    break;
                case 6:
                    pictureBox6.Load(O_img);
                    break;
                case 7:
                    pictureBox7.Load(O_img);
                    break;
                case 8:
                    pictureBox8.Load(O_img);
                    break;
                case 9:
                    pictureBox9.Load(O_img);
                    break;

            }
        }
        public void Process()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    
                    if (i == j)
                    {
                        if (field[i, j] == 1)
                            lines[7]++;
                        else if (field[i, j] == -1)
                            lines[7]--;
                    }

                    if (i + j == 2)
                    {
                        if (field[i, j] == 1)
                            lines[6]++;
                        else if (field[i, j] == -1)
                            lines[6]--;
                    }
                    
                    if (field[i, j] == 1)
                    {
                        lines[i + 3]++;
                        lines[j]++;
                    }
                    else if (field[i, j] == -1)
                    {
                        lines[i + 3]--;
                        lines[j]--;
                    }

                }

            }

            for (int i = 0; i < MaxLinesAmount; i++)
                if (lines[i] == 3) 
                {
                    label1.Visible = true;
                    IsGameActive = false;
                    break;
                } else if (lines[i] == -3)
                {
                    label1.Text = "Вы проиграли!";
                    label1.Visible = true;
                    IsGameActive = false;
                    break;
                } else
                {
                    lines[i] = 0;
                }
           // diagonal = 0;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = false;
            if (pictureBox1.Image == null && IsGameActive)
            {
                pictureBox1.Load(X_img);
                field[0, 0] = 1;
                Process();
                if (IsGameActive)
                {
                    EnemyTurn();
                    Process();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null && IsGameActive)
            {
                pictureBox2.Load(X_img);
                field[0, 1] = 1;
                Process();
                if (IsGameActive)
                {
                    EnemyTurn();
                    Process();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == null && IsGameActive)
            {
                pictureBox3.Load(X_img);
                field[0, 2] = 1;
                Process();
                if (IsGameActive)
                {
                    EnemyTurn();
                    Process();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image == null && IsGameActive)
            {
                pictureBox6.Load(X_img);
                field[1, 2] = 1;
                Process();
                if (IsGameActive)
                {
                    EnemyTurn();
                    Process();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == null && IsGameActive)
            {
                pictureBox5.Load(X_img);
                field[1, 1] = 1;
                Process();
                if (IsGameActive)
                {
                    EnemyTurn();
                    Process();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image == null && IsGameActive)
            {
                pictureBox4.Load(X_img);
                field[1, 0] = 1;
                Process();
                if (IsGameActive)
                {
                    EnemyTurn();
                    Process();
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Image == null && IsGameActive)
            {
                pictureBox9.Load(X_img);
                field[2, 2] = 1;
                Process();
                if (IsGameActive)
                {
                    EnemyTurn();
                    Process();
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Image == null && IsGameActive)
            {
                pictureBox8.Load(X_img);
                field[2, 1] = 1;
                Process();
                if (IsGameActive)
                {
                    EnemyTurn();
                    Process();
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image == null && IsGameActive)
            {
                pictureBox7.Load(X_img);
                field[2, 0] = 1;
                Process();
                if (IsGameActive)
                {
                    EnemyTurn();
                    Process();
                }
            }
        }
    }
}
