//Brandan Fennimore, Jacqueline Powers, Gurjot Athwal
//Project 1
//02/20/22


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form1 : Form
    {
        int eaglesScoreCounter;
        int commercialCounter;
        int chiefsScoreCounter;
        int counterTwo;
        int counterThree;
        int counterSix;

       
        public Form1()
        {
            InitializeComponent();
        }

        private void Chiefs_Click(object sender, EventArgs e)
        {

        }

        private void onePoint_Click(object sender, EventArgs e)
        {
            chiefsScoreCounter += 1;
            chiefsScore.Text= chiefsScoreCounter.ToString();
            
        }

        private void twoPoints_Click(object sender, EventArgs e)
        {
            chiefsScoreCounter+= 2;
            chiefsScore.Text= chiefsScoreCounter.ToString();
        }

        private void Commercial_Click(object sender, EventArgs e)
        {
            commercialCounter += 600000000;
            commShown.Text= commercialCounter.ToString();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void beerBreak_Click(object sender, EventArgs e)
        {
            double percentage = 0;
            Console.WriteLine("Enter a number: ");
            percentage = double.Parse(Console.ReadLine());
            Console.WriteLine(percentage.ToString());
            Console.ReadLine();

        }

        private void threePoints_Click(object sender, EventArgs e)
        {
            chiefsScoreCounter += 3;
            chiefsScore.Text = chiefsScoreCounter.ToString();
        }

        private void sixPoints_Click(object sender, EventArgs e)
        {
            chiefsScoreCounter += 6;
            chiefsScore.Text = chiefsScoreCounter.ToString();
        }

        private void onePointE_Click(object sender, EventArgs e)
        {
            eaglesScoreCounter+= 1;
            eaglesScore.Text= eaglesScoreCounter.ToString();
        }

        private void twoPointE_Click(object sender, EventArgs e)
        {
            eaglesScoreCounter += 2;
            eaglesScore.Text = eaglesScoreCounter.ToString();
        }

        private void threePointE_Click(object sender, EventArgs e)
        {
            eaglesScoreCounter += 3;
            eaglesScore.Text = eaglesScoreCounter.ToString();
        }

        private void sixPointE_Click(object sender, EventArgs e)
        {
            eaglesScoreCounter += 6;
            eaglesScore.Text = eaglesScoreCounter.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
