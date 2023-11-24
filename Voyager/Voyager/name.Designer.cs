namespace Voyager
{
    partial class name
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
            this.components = new System.ComponentModel.Container();
            this.confname = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // confname
            // 
            this.confname.BackColor = System.Drawing.Color.Aquamarine;
            this.confname.Location = new System.Drawing.Point(223, 72);
            this.confname.Name = "confname";
            this.confname.Size = new System.Drawing.Size(88, 60);
            this.confname.TabIndex = 0;
            this.confname.Text = "Confirm Name";
            this.confname.UseVisualStyleBackColor = false;
            this.confname.Click += new System.EventHandler(this.confname_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Aquamarine;
            this.Login.Location = new System.Drawing.Point(344, 12);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(86, 60);
            this.Login.TabIndex = 0;
            this.Login.Text = "Start Game";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Visible = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(223, 31);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(100, 22);
            this.txt_ime.TabIndex = 1;
            this.txt_ime.TextChanged += new System.EventHandler(this.txt_ime_TextChanged);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGoBack.Location = new System.Drawing.Point(450, 376);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 2;
            this.btnGoBack.Text = "Quit";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Morate unijeti ime!!!";
            this.label1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.richTextBox1.Location = new System.Drawing.Point(29, 157);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(148, 91);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Space to shoot\nUp and Down to move\nEscape to exit\nHave fun!!!\n";
            // 
            // name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Voyager.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 411);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.confname);
            this.Name = "name";
            this.Text = "name";
            this.Load += new System.EventHandler(this.name_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confname;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}