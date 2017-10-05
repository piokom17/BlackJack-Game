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
            
            button2.Enabled = false;
            button3.Enabled = false;
            
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
                    temp = dealersHand.card_name; //chowamy tą drugą kartę...
                    dealersHand.getResult();
                    listBox2.Items.Add("***");
                }
                if (playersHand.scoreOfPlayer == 22) //w przypadku gdy wylosuje dwa asy
                {
                    playersHand.scoreOfPlayer = 12; //jeden as liczy sie jako 1
                    label3.Text = playersHand.getResult();
                }
                if(i==0)
                {
                    listBox2.Items.Add(dealersHand.card_name);
                    label4.Text = dealersHand.getResult();
                }
                if (playersHand.scoreOfPlayer == 21)
                {
                    MessageBox.Show(" CONGRATS You have BlackJack :=) ");
                    ask_player();
                }
                
                                
            }
           
        }

        private void else_Deal(Hand currentPlayer, Deck currentDeck)
        {
            currentPlayer.Deal(playDeck);
            
            
                if (currentPlayer == playersHand)
                {
                    
                    listBox1.Items.Add(playersHand.printCardName());
                    label3.Text = playersHand.getResult();
                    if (currentPlayer.scoreOfPlayer > 21)
                    {
                        MessageBox.Show(" PLAYER BUSTED :=( ");
                        ask_player();
                    }
                    if (currentPlayer.scoreOfPlayer == 21)
                    {
                        MessageBox.Show("PLAYER CONGRATS You have BlackJack :=) ");
                        ask_player();
                    }
                }
                if (currentPlayer == dealersHand)
                {


                    listBox2.Items.Add(currentPlayer.printCardName());
                    label4.Text = currentPlayer.getResult();
                }
           
                                                         
        }
        private void compare_Results()
        {
            if (playersHand.scoreOfPlayer > dealersHand.scoreOfPlayer && playersHand.scoreOfPlayer <= 21)
            {
                MessageBox.Show("PLAYER WON");
                ask_player();
            }
            if(dealersHand.scoreOfPlayer > playersHand.scoreOfPlayer && dealersHand.scoreOfPlayer <= 21 )
            {
                MessageBox.Show("DEALER WON! YOU LOST :(");
                ask_player();
            }
            if (playersHand.scoreOfPlayer > 21)
            {
                MessageBox.Show("PLAYER  BUSTED :=( ");
                ask_player();
            }

            if (dealersHand.scoreOfPlayer > 21)
            {
                MessageBox.Show("DEALER  BUSTED :=( ");
                ask_player();
            }
            if (dealersHand.scoreOfPlayer == playersHand.scoreOfPlayer)
            {
                MessageBox.Show("YOU DRAW  :(");
                ask_player();
            }

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            first_Deal(playDeck);
            button1.Enabled = false;  // dezaktywujemy przycisk pierwszego rozdania kart
            button2.Enabled = true;
            button3.Enabled = true;
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


            for(int i=0;i<2;i++)
            {
                if(dealersHand.scoreOfPlayer<17)
                {

                    else_Deal(dealersHand, playDeck);

                }

                listBox2.Items[1] = temp;
                
                label4.Text = dealersHand.scoreOfPlayer.ToString();
            
                compare_Results();
            }
        }
        private void ask_player()
        {
            DialogResult dialog = MessageBox.Show(" If you want to play again press: RETRY ", "DO YOU WANT TO CANCEL? ", MessageBoxButtons.RetryCancel);
            if (dialog == DialogResult.Retry)
            {

            }
            else if (dialog == DialogResult.Cancel)
            {
                this.Close();
            }

        }
        private void reload_game() //zastanowic sie nad currentDeck
        {
            //wyczyscic listBoxy
            //wyczyscic textLabels
            //deaaktywowac przyciski hit i stand zostawic aktywnym deal
            //potem wywolac funkcje firstdeal :) i ma kurde dzialac
        }
        
        /*private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message =
                "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
        }
         * */
       
    }
}
