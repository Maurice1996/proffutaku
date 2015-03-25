namespace ICT4Events
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Voetbal");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tennis");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Handbal");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Sport", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Celebrity");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Muziek");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Grappige plaatjes");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Entertainment", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Schilderijen");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Toneel");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Opera");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Kunst", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Concepten");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Programmas");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Programmeren", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Event A", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12,
            treeNode15});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node6";
            treeNode1.Text = "Voetbal";
            treeNode2.Name = "Node8";
            treeNode2.Text = "Tennis";
            treeNode3.Name = "Node9";
            treeNode3.Text = "Handbal";
            treeNode4.Name = "Sport";
            treeNode4.Text = "Sport";
            treeNode5.Name = "Node10";
            treeNode5.Text = "Celebrity";
            treeNode6.Name = "Node11";
            treeNode6.Text = "Muziek";
            treeNode7.Name = "Node12";
            treeNode7.Text = "Grappige plaatjes";
            treeNode8.Name = "Node3";
            treeNode8.Text = "Entertainment";
            treeNode9.Name = "Node13";
            treeNode9.Text = "Schilderijen";
            treeNode10.Name = "Node14";
            treeNode10.Text = "Toneel";
            treeNode11.Name = "Node15";
            treeNode11.Text = "Opera";
            treeNode12.Name = "Node4";
            treeNode12.Text = "Kunst";
            treeNode13.Name = "Node16";
            treeNode13.Text = "Concepten";
            treeNode14.Name = "Node17";
            treeNode14.Text = "Programmas";
            treeNode15.Name = "Node5";
            treeNode15.Text = "Programmeren";
            treeNode16.Name = "Event A";
            treeNode16.Text = "Event A";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(522, 570);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Map toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 596);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hernoemen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Lizzy: Awesome foto!",
            "Doperd99: Keivet",
            "Lieke: Moooi ",
            "Marijn: heeeuy"});
            this.listBox2.Location = new System.Drawing.Point(540, 422);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(740, 134);
            this.listBox2.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1124, 380);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "+1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1198, 380);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "Niet OK";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1140, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "+26";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1215, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "-2";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1048, 380);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Download";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(540, 562);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(652, 18);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Typ hier een bericht";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1198, 560);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 23);
            this.button9.TabIndex = 20;
            this.button9.Text = "Send";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ICT4Events.Properties.Resources.blue_rain_photography_hd_wallpaper_1920x1200_3748;
            this.pictureBox1.Location = new System.Drawing.Point(540, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::ICT4Events.Properties.Resources.searchsmall;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(478, 595);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 8;
            this.button5.Text = " ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ICT4Events.Properties.Resources.uploadsmall3;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(509, 595);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 7;
            this.button4.Text = " ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::ICT4Events.Properties.Resources.group;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Location = new System.Drawing.Point(821, 595);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(25, 25);
            this.button10.TabIndex = 21;
            this.button10.Text = " ";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ICT4Events.Properties.Resources.poweroffsmall;
            this.button3.Location = new System.Drawing.Point(852, 595);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 22;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::ICT4Events.Properties.Resources.profile;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Location = new System.Drawing.Point(790, 595);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(25, 25);
            this.button11.TabIndex = 23;
            this.button11.Text = " ";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1323, 632);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Form1";
            this.Text = "ICT4Events";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button11;
    }
}

