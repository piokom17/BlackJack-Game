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
            player_money.Text = " $+ " + playersHand.initialAmountOfMoney.ToString();
            button1.Enabled = false;
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
        //zastanowic sie gdzie zrobic funkcje obstawiania ?

        private void first_Deal(Deck currentDeck)
        {
            five_dollar.Enabled = false;
            ten_dollar.Enabled = false;
            twenty_dollar.Enabled = false;
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
                if (playersHand.scoreOfPlayer > 21) //w przypadku gdy wylosuje dwa asy
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
                    playersHand.initialAmountOfMoney += 2*playersHand.cashToBet;
                    player_money.Text = " $+ " + playersHand.initialAmountOfMoney.ToString();
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
                        currentPlayer.initialAmountOfMoney += 2*currentPlayer.cashToBet;
                        player_money.Text = " $+ " + currentPlayer.initialAmountOfMoney.ToString();
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
                playersHand.initialAmountOfMoney += 2*playersHand.cashToBet;
                player_money.Text = " $+ " + playersHand.initialAmountOfMoney.ToString();
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
                playersHand.initialAmountOfMoney += 2*playersHand.cashToBet;
                player_money.Text = " $+ " + playersHand.initialAmountOfMoney.ToString();
                ask_player();
            }
            if (dealersHand.scoreOfPlayer == playersHand.scoreOfPlayer && dealersHand.scoreOfPlayer != 0 && playersHand.scoreOfPlayer != 0)
            {
                MessageBox.Show("YOU DRAW  :(");
                playersHand.initialAmountOfMoney += playersHand.cashToBet;
                
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


            
            
                do
                {

                    else_Deal(dealersHand, playDeck);

                }while((dealersHand.scoreOfPlayer<17));

                listBox2.Items[1] = temp;
                
                label4.Text = dealersHand.scoreOfPlayer.ToString();
            
                compare_Results();
            
        }
        private void ask_player()
        {
            DialogResult dialog = MessageBox.Show(" If you want to play again press: RETRY ", "DO YOU WANT TO CANCEL? ", MessageBoxButtons.RetryCancel);
            if (dialog == DialogResult.Retry)
            {
                //sprawdzamy co robi refresh, fajne ale niedokonca o to chodzi

                reload_game();
                //Properties.Settings.Defau
            }
            else if (dialog == DialogResult.Cancel)
            {
                this.Close();
            }
            

        }
        private void reload_game() //zastanowic sie nad currentDeck
        {
            //wyczyscic listBoxy
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            //wyczyscic amount of cashlabel
            amount_of_cash_label.Text = String.Empty;
            playersHand.scoreOfPlayer = 0;
            dealersHand.scoreOfPlayer = 0;
            playersHand.cashToBet = 0;
            label3.Text = String.Empty;
            label4.Text = String.Empty;
                        //deaaktywowac przyciski hit i stand zostawic aktywnym deal
            //potem wywolac funkcje firstdeal :) i ma kurde dzialac
            playDeck.Shuffle();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            five_dollar.Enabled = true;
            ten_dollar.Enabled = true;
            twenty_dollar.Enabled = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void five_dollar_Click(object sender, EventArgs e)
        {
            playersHand.cashToBet += 5;
            amount_of_cash_label.Text = " $+ " + playersHand.cashToBet.ToString();
            playersHand.initialAmountOfMoney -= 5;
            player_money.Text = " $+ " + playersHand.initialAmountOfMoney.ToString();
            if (playersHand.cashToBet != 0)
            {
                button1.Enabled = true;
            }

        }

        private void ten_dollar_Click(object sender, EventArgs e)
        {
            playersHand.cashToBet += 10;
            amount_of_cash_label.Text = " $+ " + playersHand.cashToBet.ToString();
            playersHand.initialAmountOfMoney -= 10;
            player_money.Text = " $+ " + playersHand.initialAmountOfMoney.ToString();
            if (playersHand.cashToBet != 0)
            {
                button1.Enabled = true;
            }
        }

        private void twenty_dollar_Click(object sender, EventArgs e)
        {
            playersHand.cashToBet += 20;
            amount_of_cash_label.Text = " $+ " + playersHand.cashToBet.ToString();
            playersHand.initialAmountOfMoney -= 20;
            player_money.Text = " $+ " + playersHand.initialAmountOfMoney.ToString();
            if (playersHand.cashToBet != 0)
            {
                button1.Enabled = true;
            }
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
