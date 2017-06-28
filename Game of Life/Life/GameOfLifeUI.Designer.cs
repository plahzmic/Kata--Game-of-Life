namespace GameOfLife
{
    partial class formUI
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
            this.topBox = new System.Windows.Forms.GroupBox();
            this.nextStep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.topBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBox
            // 
            this.topBox.Controls.Add(this.nextStep);
            this.topBox.Controls.Add(this.label1);
            this.topBox.Controls.Add(this.clearButton);
            this.topBox.Controls.Add(this.pauseButton);
            this.topBox.Controls.Add(this.goButton);
            this.topBox.Location = new System.Drawing.Point(5, 13);
            this.topBox.Name = "topBox";
            this.topBox.Size = new System.Drawing.Size(487, 54);
            this.topBox.TabIndex = 0;
            this.topBox.TabStop = false;
            // 
            // nextStep
            // 
            this.nextStep.Location = new System.Drawing.Point(385, 28);
            this.nextStep.Name = "nextStep";
            this.nextStep.ReadOnly = true;
            this.nextStep.Size = new System.Drawing.Size(96, 20);
            this.nextStep.TabIndex = 4;
            this.nextStep.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Lifecycle";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(218, 11);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 37);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(112, 11);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(100, 37);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(6, 11);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(100, 37);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(5, 73);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(489, 488);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // formUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(498, 564);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.topBox);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(520, 620);
            this.MinimumSize = new System.Drawing.Size(465, 600);
            this.Name = "formUI";
            this.Text = "Game of GameOfLife Kata";
            this.Load += new System.EventHandler(this.Game_Of_LifeUI_Load);
            this.topBox.ResumeLayout(false);
            this.topBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox topBox;
        private System.Windows.Forms.GroupBox pictureBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox nextStep;
        private System.Windows.Forms.Label label1;
    }
}

