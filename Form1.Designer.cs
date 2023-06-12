namespace clickerGame
{
    partial class gameForm
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
            this.clickerButton = new System.Windows.Forms.Button();
            this.clickerButtonLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rubberBandAmountBox = new System.Windows.Forms.Label();
            this.moneyAmountBox = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.Label();
            this.RubberBands = new System.Windows.Forms.Label();
            this.moneyButtonLabel = new System.Windows.Forms.Label();
            this.moneyButton = new System.Windows.Forms.Button();
            this.newsButton = new System.Windows.Forms.Button();
            this.newsPanel = new System.Windows.Forms.Panel();
            this.newsBox = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.TESTLABEL = new System.Windows.Forms.Label();
            this.idleUpgradePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.newsWorker = new System.ComponentModel.BackgroundWorker();
            this.mainPanel.SuspendLayout();
            this.newsPanel.SuspendLayout();
            this.idleUpgradePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clickerButton
            // 
            this.clickerButton.Location = new System.Drawing.Point(25, 20);
            this.clickerButton.Name = "clickerButton";
            this.clickerButton.Size = new System.Drawing.Size(152, 70);
            this.clickerButton.TabIndex = 0;
            this.clickerButton.Text = "Make Rubber Bands";
            this.clickerButton.UseVisualStyleBackColor = true;
            this.clickerButton.Click += new System.EventHandler(this.clickerButton_Click);
            // 
            // clickerButtonLabel
            // 
            this.clickerButtonLabel.AutoSize = true;
            this.clickerButtonLabel.Location = new System.Drawing.Point(22, 93);
            this.clickerButtonLabel.Name = "clickerButtonLabel";
            this.clickerButtonLabel.Size = new System.Drawing.Size(121, 13);
            this.clickerButtonLabel.TabIndex = 1;
            this.clickerButtonLabel.Text = "1 Rubber band per click";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainPanel.Controls.Add(this.rubberBandAmountBox);
            this.mainPanel.Controls.Add(this.moneyAmountBox);
            this.mainPanel.Controls.Add(this.Money);
            this.mainPanel.Controls.Add(this.RubberBands);
            this.mainPanel.Controls.Add(this.moneyButtonLabel);
            this.mainPanel.Controls.Add(this.moneyButton);
            this.mainPanel.Controls.Add(this.clickerButton);
            this.mainPanel.Controls.Add(this.clickerButtonLabel);
            this.mainPanel.Location = new System.Drawing.Point(12, 94);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(608, 139);
            this.mainPanel.TabIndex = 2;
            // 
            // rubberBandAmountBox
            // 
            this.rubberBandAmountBox.AutoSize = true;
            this.rubberBandAmountBox.BackColor = System.Drawing.SystemColors.Window;
            this.rubberBandAmountBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rubberBandAmountBox.Location = new System.Drawing.Point(186, 37);
            this.rubberBandAmountBox.Name = "rubberBandAmountBox";
            this.rubberBandAmountBox.Size = new System.Drawing.Size(15, 15);
            this.rubberBandAmountBox.TabIndex = 10;
            this.rubberBandAmountBox.Text = "0";
            // 
            // moneyAmountBox
            // 
            this.moneyAmountBox.AutoSize = true;
            this.moneyAmountBox.BackColor = System.Drawing.SystemColors.Window;
            this.moneyAmountBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moneyAmountBox.Location = new System.Drawing.Point(185, 94);
            this.moneyAmountBox.Name = "moneyAmountBox";
            this.moneyAmountBox.Size = new System.Drawing.Size(21, 15);
            this.moneyAmountBox.TabIndex = 9;
            this.moneyAmountBox.Text = "$0";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Location = new System.Drawing.Point(182, 77);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(42, 13);
            this.Money.TabIndex = 7;
            this.Money.Text = "Money:";
            // 
            // RubberBands
            // 
            this.RubberBands.AutoSize = true;
            this.RubberBands.Location = new System.Drawing.Point(183, 20);
            this.RubberBands.Name = "RubberBands";
            this.RubberBands.Size = new System.Drawing.Size(78, 13);
            this.RubberBands.TabIndex = 6;
            this.RubberBands.Text = "Rubber Bands:";
            // 
            // moneyButtonLabel
            // 
            this.moneyButtonLabel.AutoSize = true;
            this.moneyButtonLabel.Location = new System.Drawing.Point(422, 93);
            this.moneyButtonLabel.Name = "moneyButtonLabel";
            this.moneyButtonLabel.Size = new System.Drawing.Size(118, 13);
            this.moneyButtonLabel.TabIndex = 3;
            this.moneyButtonLabel.Text = "1 Rubber Band = $0.10";
            // 
            // moneyButton
            // 
            this.moneyButton.Location = new System.Drawing.Point(425, 20);
            this.moneyButton.Name = "moneyButton";
            this.moneyButton.Size = new System.Drawing.Size(152, 70);
            this.moneyButton.TabIndex = 2;
            this.moneyButton.Text = "Sell Rubber Bands";
            this.moneyButton.UseVisualStyleBackColor = true;
            this.moneyButton.Click += new System.EventHandler(this.moneyButton_Click);
            // 
            // newsButton
            // 
            this.newsButton.Location = new System.Drawing.Point(25, 13);
            this.newsButton.Name = "newsButton";
            this.newsButton.Size = new System.Drawing.Size(166, 23);
            this.newsButton.TabIndex = 3;
            this.newsButton.Text = "Purchase News for $1999.99";
            this.newsButton.UseVisualStyleBackColor = true;
            this.newsButton.Click += new System.EventHandler(this.newsButton_Click);
            // 
            // newsPanel
            // 
            this.newsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.newsPanel.Controls.Add(this.newsBox);
            this.newsPanel.Controls.Add(this.newsButton);
            this.newsPanel.Location = new System.Drawing.Point(12, 24);
            this.newsPanel.Name = "newsPanel";
            this.newsPanel.Size = new System.Drawing.Size(765, 51);
            this.newsPanel.TabIndex = 4;
            // 
            // newsBox
            // 
            this.newsBox.AutoSize = true;
            this.newsBox.BackColor = System.Drawing.SystemColors.Window;
            this.newsBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newsBox.Location = new System.Drawing.Point(197, 18);
            this.newsBox.Name = "newsBox";
            this.newsBox.Size = new System.Drawing.Size(65, 15);
            this.newsBox.TabIndex = 11;
            this.newsBox.Text = "News Here!";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(9, 763);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(55, 13);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "ErrorLabel";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(12, 780);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 7;
            this.testButton.Text = "testButton";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // TESTLABEL
            // 
            this.TESTLABEL.AutoSize = true;
            this.TESTLABEL.BackColor = System.Drawing.SystemColors.Window;
            this.TESTLABEL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TESTLABEL.Location = new System.Drawing.Point(12, 748);
            this.TESTLABEL.Name = "TESTLABEL";
            this.TESTLABEL.Size = new System.Drawing.Size(37, 15);
            this.TESTLABEL.TabIndex = 8;
            this.TESTLABEL.Text = "label1";
            // 
            // idleUpgradePanel
            // 
            this.idleUpgradePanel.BackColor = System.Drawing.SystemColors.Window;
            this.idleUpgradePanel.Controls.Add(this.button1);
            this.idleUpgradePanel.Location = new System.Drawing.Point(12, 253);
            this.idleUpgradePanel.Name = "idleUpgradePanel";
            this.idleUpgradePanel.Size = new System.Drawing.Size(261, 447);
            this.idleUpgradePanel.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // newsWorker
            // 
            this.newsWorker.WorkerReportsProgress = true;
            this.newsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.newsWorker_DoWork);
            this.newsWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.NewsWorker_ProgressChanged);
            // 
            // gameForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 882);
            this.Controls.Add(this.idleUpgradePanel);
            this.Controls.Add(this.TESTLABEL);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.newsPanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "gameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Rubber Band Game";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.newsPanel.ResumeLayout(false);
            this.newsPanel.PerformLayout();
            this.idleUpgradePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickerButton;
        private System.Windows.Forms.Label clickerButtonLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label moneyButtonLabel;
        private System.Windows.Forms.Button moneyButton;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Label RubberBands;
        private System.Windows.Forms.Button newsButton;
        private System.Windows.Forms.Panel newsPanel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label TESTLABEL;
        private System.Windows.Forms.Label moneyAmountBox;
        private System.Windows.Forms.Label rubberBandAmountBox;
        private System.Windows.Forms.Label newsBox;
        private System.Windows.Forms.Panel idleUpgradePanel;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker newsWorker;
    }
}

