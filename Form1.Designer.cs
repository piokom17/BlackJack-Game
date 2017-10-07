namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bank_label = new System.Windows.Forms.Label();
            this.player_money = new System.Windows.Forms.Label();
            this.five_dollar = new System.Windows.Forms.Button();
            this.ten_dollar = new System.Windows.Forms.Button();
            this.twenty_dollar = new System.Windows.Forms.Button();
            this.toBet = new System.Windows.Forms.Label();
            this.cash_label = new System.Windows.Forms.Label();
            this.amount_of_cash_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(82, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 82);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(360, 60);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(172, 82);
            this.listBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dealer";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "DEAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "0     ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = " 0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(197, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "HIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button3.Location = new System.Drawing.Point(313, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 63);
            this.button3.TabIndex = 8;
            this.button3.Text = "STAND";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = " :";
            // 
            // bank_label
            // 
            this.bank_label.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank_label.Location = new System.Drawing.Point(35, 183);
            this.bank_label.Name = "bank_label";
            this.bank_label.Size = new System.Drawing.Size(152, 32);
            this.bank_label.TabIndex = 10;
            this.bank_label.Text = "$ BANK $";
            // 
            // player_money
            // 
            this.player_money.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_money.Location = new System.Drawing.Point(35, 215);
            this.player_money.Name = "player_money";
            this.player_money.Size = new System.Drawing.Size(147, 30);
            this.player_money.TabIndex = 11;
            this.player_money.Text = "$+ ";
            // 
            // five_dollar
            // 
            this.five_dollar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five_dollar.Location = new System.Drawing.Point(35, 264);
            this.five_dollar.Name = "five_dollar";
            this.five_dollar.Size = new System.Drawing.Size(45, 45);
            this.five_dollar.TabIndex = 12;
            this.five_dollar.Text = "$5";
            this.five_dollar.UseVisualStyleBackColor = true;
            this.five_dollar.Click += new System.EventHandler(this.five_dollar_Click);
            // 
            // ten_dollar
            // 
            this.ten_dollar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_dollar.Location = new System.Drawing.Point(86, 264);
            this.ten_dollar.Name = "ten_dollar";
            this.ten_dollar.Size = new System.Drawing.Size(44, 45);
            this.ten_dollar.TabIndex = 13;
            this.ten_dollar.Text = "$10";
            this.ten_dollar.UseVisualStyleBackColor = true;
            this.ten_dollar.Click += new System.EventHandler(this.ten_dollar_Click);
            // 
            // twenty_dollar
            // 
            this.twenty_dollar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twenty_dollar.Location = new System.Drawing.Point(136, 264);
            this.twenty_dollar.Name = "twenty_dollar";
            this.twenty_dollar.Size = new System.Drawing.Size(46, 45);
            this.twenty_dollar.TabIndex = 14;
            this.twenty_dollar.Text = "$20";
            this.twenty_dollar.UseVisualStyleBackColor = true;
            this.twenty_dollar.Click += new System.EventHandler(this.twenty_dollar_Click);
            // 
            // toBet
            // 
            this.toBet.AutoSize = true;
            this.toBet.Location = new System.Drawing.Point(57, 335);
            this.toBet.Name = "toBet";
            this.toBet.Size = new System.Drawing.Size(0, 13);
            this.toBet.TabIndex = 15;
            // 
            // cash_label
            // 
            this.cash_label.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_label.Location = new System.Drawing.Point(437, 183);
            this.cash_label.Name = "cash_label";
            this.cash_label.Size = new System.Drawing.Size(152, 32);
            this.cash_label.TabIndex = 16;
            this.cash_label.Text = "$ BET $";
            // 
            // amount_of_cash_label
            // 
            this.amount_of_cash_label.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_of_cash_label.Location = new System.Drawing.Point(437, 215);
            this.amount_of_cash_label.Name = "amount_of_cash_label";
            this.amount_of_cash_label.Size = new System.Drawing.Size(147, 30);
            this.amount_of_cash_label.TabIndex = 17;
            this.amount_of_cash_label.Text = "$+ ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(624, 420);
            this.Controls.Add(this.amount_of_cash_label);
            this.Controls.Add(this.cash_label);
            this.Controls.Add(this.toBet);
            this.Controls.Add(this.twenty_dollar);
            this.Controls.Add(this.ten_dollar);
            this.Controls.Add(this.five_dollar);
            this.Controls.Add(this.player_money);
            this.Controls.Add(this.bank_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bank_label;
        private System.Windows.Forms.Label player_money;
        private System.Windows.Forms.Button five_dollar;
        private System.Windows.Forms.Button ten_dollar;
        private System.Windows.Forms.Button twenty_dollar;
        private System.Windows.Forms.Label toBet;
        private System.Windows.Forms.Label cash_label;
        private System.Windows.Forms.Label amount_of_cash_label;
    }
}

