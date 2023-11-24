namespace Voyager
{
    partial class score
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
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Up2 = new System.Windows.Forms.Button();
            this.listReadFile = new System.Windows.Forms.ListBox();
            this.listImena = new System.Windows.Forms.ListBox();
            this.listSortFile = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.Search = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.Aquamarine;
            this.Updatebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Updatebutton.Location = new System.Drawing.Point(203, 36);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(106, 62);
            this.Updatebutton.TabIndex = 0;
            this.Updatebutton.Text = "Show Scores";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Up2
            // 
            this.Up2.BackColor = System.Drawing.Color.Aquamarine;
            this.Up2.Location = new System.Drawing.Point(38, 36);
            this.Up2.Name = "Up2";
            this.Up2.Size = new System.Drawing.Size(106, 62);
            this.Up2.TabIndex = 1;
            this.Up2.Text = "Show Names";
            this.Up2.UseVisualStyleBackColor = false;
            this.Up2.Click += new System.EventHandler(this.Up2_Click);
            // 
            // listReadFile
            // 
            this.listReadFile.BackColor = System.Drawing.Color.Aquamarine;
            this.listReadFile.FormattingEnabled = true;
            this.listReadFile.ItemHeight = 16;
            this.listReadFile.Location = new System.Drawing.Point(178, 146);
            this.listReadFile.Name = "listReadFile";
            this.listReadFile.Size = new System.Drawing.Size(160, 292);
            this.listReadFile.TabIndex = 2;
            this.listReadFile.SelectedIndexChanged += new System.EventHandler(this.listReadFile_SelectedIndexChanged);
            // 
            // listImena
            // 
            this.listImena.BackColor = System.Drawing.Color.Aquamarine;
            this.listImena.FormattingEnabled = true;
            this.listImena.ItemHeight = 16;
            this.listImena.Location = new System.Drawing.Point(12, 146);
            this.listImena.Name = "listImena";
            this.listImena.Size = new System.Drawing.Size(160, 292);
            this.listImena.TabIndex = 2;
            this.listImena.SelectedIndexChanged += new System.EventHandler(this.listImena_SelectedIndexChanged);
            // 
            // listSortFile
            // 
            this.listSortFile.BackColor = System.Drawing.Color.Aquamarine;
            this.listSortFile.FormattingEnabled = true;
            this.listSortFile.ItemHeight = 16;
            this.listSortFile.Location = new System.Drawing.Point(344, 146);
            this.listSortFile.Name = "listSortFile";
            this.listSortFile.Size = new System.Drawing.Size(160, 292);
            this.listSortFile.TabIndex = 2;
            this.listSortFile.SelectedIndexChanged += new System.EventHandler(this.listSortFIle_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Aquamarine;
            this.textBoxSearch.Location = new System.Drawing.Point(633, 113);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 22);
            this.textBoxSearch.TabIndex = 3;
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.BackColor = System.Drawing.Color.Aquamarine;
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.ItemHeight = 16;
            this.listBoxSearch.Location = new System.Drawing.Point(620, 170);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(130, 100);
            this.listBoxSearch.TabIndex = 2;
            this.listBoxSearch.SelectedIndexChanged += new System.EventHandler(this.listSortFIle_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Aquamarine;
            this.Search.Location = new System.Drawing.Point(642, 36);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBack.Location = new System.Drawing.Point(642, 362);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(63, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(232, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Score";
            // 
            // score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Voyager.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listBoxSearch);
            this.Controls.Add(this.listSortFile);
            this.Controls.Add(this.listImena);
            this.Controls.Add(this.listReadFile);
            this.Controls.Add(this.Up2);
            this.Controls.Add(this.Updatebutton);
            this.Name = "score";
            this.Text = "score";
            this.Load += new System.EventHandler(this.score_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Up2;
        private System.Windows.Forms.ListBox listReadFile;
        private System.Windows.Forms.ListBox listImena;
        private System.Windows.Forms.ListBox listSortFile;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListBox listBoxSearch;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}