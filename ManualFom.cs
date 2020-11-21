using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FruitIshido
{
    public partial class ManualForm : Form
    {
        public ManualForm()
        {
            InitializeComponent();
        }

        //manual labels text
        private void ManualForm_Load(object sender, EventArgs e)
        {
            lblManualFirstPage.Text = "Ishido is a board logic game. Its first computer version the ’’Way of The Stones’’ run " +
                                       "on DOS, it was released in 1989. It’s an easy to learn but difficult to master game. " +
                                       "The goal of the game is to reach the highest possible score. This requires a lot of " + 
                                       "observation skills and planning. It is a puzzle game similar to Mahjong. The game lasts " +
                                       "until all stones have been used, or cannot be placed in a way that matches the rules of the game. " +
                                       "During the game we have to place 72 stones on the board (96 fields). ";

            lblManualSecondPage.Text = "Every stone has to properties, a colour and a shape. There’re 6 different colours and 6 " +
                                        "different shapes, so we have 36 possible stones. There’re 2 of each stone, which makes 72. " +
                                        "The first six stones are placed down by the computer automatically, which places down one of " +
                                        "each colour and shape.";

            lblManualThirdPage.Text = "We can only place a stone next to another one if one of its properties matches the other one’s " +
                                        "next to it. If we place a stone between 2 other stones, then the stone has to match one property " +
                                        "on one side and one property on the other. With 3 neighbouring stones it has to match 1 property " +
                                        "for 2 stones and another property for the third one. When there’re 4 neighbouring stones, it needs " +
                                        "to match 2-2 properties.";

            lblManualFourthPage.Text = "You don’t get a score for the area shaded a different colour on the side of the board. You get scored " +
                                        "based on the number of neighbouring stones. If the stone has 1/2/3/4 neighbours then you can get 1/2/4 or 8 points. " + "\r\n" + "\r\n" +
                                        "Bonus points are given if there are 4 neighbouring stones (Four Way). 25 points on the first one, 50 on the " + 
                                        "second one, then in order 100, 200, 400, 600, 800, 1000, 5000, 10000, 25000, 50000. For 50000 bonus points you " +
                                        "have to do 12 ’’Four Way’’. The number of ’’Four Way’’ achieved can further increase the score, with every store " +
                                        "this score can be doubled." + "\r\n" + "\r\n" +
                                        "Further bonuses are given for placing all the stones (1000), if there’s only one left then 500 and if there’s 2 left then 100. " +
                                        "If one of the scores is beaten in the top 10 list, you can replace that score with yours. ";

                     
                        
            lblManualFifthPage.Text = "Fruit Icons: http://www.artdocks.com/40-freshy-fruits-icons/" + "\r\n" + "\r\n" +
                                        "Main idea and logical operations: http://www.pulykakakas.com/2010/08/ishido-c-v01_5613.html" ;
            //Invisible panels
            panSecondPage.Visible = false;
            panThirdPage.Visible = false;
            panFourthPage.Visible = false;
            panFifthPage.Visible = false;

        }


        //Previous and next buttons controls
        private void btnNext1_Click(object sender, EventArgs e)
        {
            panSecondPage.Visible = true;
        }


        private void btnNextSecondPage_Click(object sender, EventArgs e)
        {
            panThirdPage.Visible = true;
        }

        private void btnPrevSecondPage_Click(object sender, EventArgs e)
        {
            panSecondPage.Visible = false;
        }


        private void btnNextThirdPage_Click(object sender, EventArgs e)
        {
            panFourthPage.Visible = true;
        }

        private void btnPrevThirdPage_Click(object sender, EventArgs e)
        {
            panThirdPage.Visible = false;
            panSecondPage.Visible = true;
        }

        private void btnNextFourthPage_Click(object sender, EventArgs e)
        {
            panFifthPage.Visible = true;
        }

        private void btnPrevFourthPage_Click(object sender, EventArgs e)
        {
            panFourthPage.Visible = false;
            panThirdPage.Visible = true;
        }


        private void btnPrevFifthPage_Click(object sender, EventArgs e)
        {
            panFifthPage.Visible = false;
            panFourthPage.Visible = true;
        }

        private void btnHomeFifthPage_Click(object sender, EventArgs e)
        {
            panSecondPage.Visible = false;
            panThirdPage.Visible = false;
            panFourthPage.Visible = false;
            panFifthPage.Visible = false;

        }

        
        //picture boxes
        private void pictFirstPage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picThirdPage_Click(object sender, EventArgs e)
        {

        }

        private void picFourthPage_Click(object sender, EventArgs e)
        {

        }        

    }
}
