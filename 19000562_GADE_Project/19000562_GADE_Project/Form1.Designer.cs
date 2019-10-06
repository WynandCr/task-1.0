namespace _19000562_GADE_Project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeStamp = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.Location = new System.Drawing.Point(12, 22);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(385, 332);
            this.pnlInfo.TabIndex = 0;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInfo_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Exit.png");
            this.imageList1.Images.SetKeyName(1, "Pause.png");
            this.imageList1.Images.SetKeyName(2, "Play.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elapsedn Time";
            // 
            // lblTimeStamp
            // 
            this.lblTimeStamp.AutoSize = true;
            this.lblTimeStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeStamp.Location = new System.Drawing.Point(601, 36);
            this.lblTimeStamp.Name = "lblTimeStamp";
            this.lblTimeStamp.Size = new System.Drawing.Size(71, 29);
            this.lblTimeStamp.TabIndex = 3;
            this.lblTimeStamp.Text = "00:00\r\n";
            // 
            // btnPause
            // 
            this.btnPause.ImageKey = "Pause.png";
            this.btnPause.ImageList = this.imageList1;
            this.btnPause.Location = new System.Drawing.Point(12, 360);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(97, 78);
            this.btnPause.TabIndex = 4;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.ImageKey = "Play.png";
            this.btnPlay.ImageList = this.imageList1;
            this.btnPlay.Location = new System.Drawing.Point(115, 360);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(97, 78);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImageKey = "Exit.png";
            this.btnExit.ImageList = this.imageList1;
            this.btnExit.Location = new System.Drawing.Point(625, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 78);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(232, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 78);
            this.label2.TabIndex = 7;
            this.label2.Text = "Key:\r\n🗡️   -   Melee Unit\r\n🏹   -   Ranged Unit \r\n";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.listBox);
            this.grpBox.Location = new System.Drawing.Point(408, 68);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(341, 286);
            this.grpBox.TabIndex = 8;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "groupBox1";
            this.grpBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(6, 25);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(329, 244);
            this.listBox.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblTimeStamp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeStamp;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Timer timer1;
    }
}

