using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            playDeck.Shuffle();
            //playersHand.Deal(playDeck);
        }
        
        
        //tworzymy talie kart
        Deck playDeck = new Deck();
        //tworzymy "Hand" Playera
        Hand playersHand = new Hand();
        //tworzymy "Hand" Dealera
        Hand dealersHand = new Hand();
        private string temp = "";

        private void first_Deal(Deck currentDeck)
        {
            for (int i = 0; i < 2; i++)
            {
                playersHand.Deal(playDeck);
                listBox1.Items.Add(playersHand.printCardName());
                label3.Text = playersHand.getResult();
                dealersHand.Deal(playDeck);
                if (i == 1)
                {
                    temp = dealersHand.printCardName(); //chowamy tą drugą kartę...
                    dealersHand.getResult();
                    listBox2.Items.Add("***");
                }
                else
                {
                    listBox2.Items.Add(dealersHand.printCardName());
                    label4.Text = dealersHand.getResult();
                }
                if (playersHand.scoreOfPlayer == 21)
                {
                    MessageBox.Show(" CONGRATS You have BlackJack :=) ");
                }
                                
            }
        }

        private void else_Deal(Hand currentPlayer, Deck currentDeck)
        {
            currentPlayer.Deal(playDeck);
            
            
                if (currentPlayer == playersHand)
                {
                    currentPlayer.getResult();
                    listBox1.Items.Add(playersHand.printCardName());
                    label3.Text = playersHand.scoreOfPlayer.ToString();
                }
            if(currentPlayer.scoreOfPlayer > 21)
            {  
                MessageBox.Show(" PLAYER BUSTED :=( ");
            }
            if (currentPlayer.scoreOfPlayer == 21)
            {
                MessageBox.Show("PLAYER CONGRATS You have BlackJack :=) ");
            }
            
            
            else if (currentPlayer == dealersHand)
            {
                
                
                listBox2.Items.Add(dealersHand.printCardName());
                label4.Text = dealersHand.scoreOfPlayer.ToString();
            }

            
        }
        private void compare_Results()
        {
            if (playersHand.scoreOfPlayer > dealersHand.scoreOfPlayer && playersHand.scoreOfPlayer <= 21)
            {
                MessageBox.Show("PLAYER WON");
            }
            if(dealersHand.scoreOfPlayer > playersHand.scoreOfPlayer && dealersHand.scoreOfPlayer <= 21 )
            {
                MessageBox.Show("DEALER WON! YOU LOST :(");
            }
            if (playersHand.scoreOfPlayer > 21)
            {
                MessageBox.Show("PLAYER  BUSTED :=( ");
            }

            if (dealersHand.scoreOfPlayer > 21)
            {
                MessageBox.Show("DEALER  BUSTED :=( ");
            }

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            first_Deal(playDeck);
            button1.Enabled = false;  // dezaktywujemy przycisk pierwszego rozdania kart
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            else_Deal(playersHand, playDeck);
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //gdy punkty dealera sa mniejsze od 17 dobieramy, dobieramy poki nie bedzie mial wiecej niz 21

                       
                       
                if (dealersHand.scoreOfPlayer < 17)
                {
                    else_Deal(dealersHand, playDeck);
                }
                listBox2.Items[1] = temp;
                dealersHand.getResult();
                label4.Text = dealersHand.getResult();
            
                compare_Results();

        }
    }
}
