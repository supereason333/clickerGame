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
            this.rubberBandPerSecondLabel = new System.Windows.Forms.Label();
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
            this.ProductionLineGroupBox = new System.Windows.Forms.GroupBox();
            this.productionLineButton = new System.Windows.Forms.Button();
            this.ProductionLineRubberBandLabel = new System.Windows.Forms.Label();
            this.productionLineAmountLabel = new System.Windows.Forms.Label();
            this.MachineGroupBox = new System.Windows.Forms.GroupBox();
            this.machineButton = new System.Windows.Forms.Button();
            this.machineRubberBandLabel = new System.Windows.Forms.Label();
            this.machineAmountLabel = new System.Windows.Forms.Label();
            this.FactoryWorkerGroupBox = new System.Windows.Forms.GroupBox();
            this.workerButtom = new System.Windows.Forms.Button();
            this.workerRubberBandLabel = new System.Windows.Forms.Label();
            this.workerAmountLabel = new System.Windows.Forms.Label();
            this.newsWorker = new System.ComponentModel.BackgroundWorker();
            this.idleGeneratorWorker = new System.ComponentModel.BackgroundWorker();
            this.rubberBandCostUpgrade = new System.Windows.Forms.Button();
            this.sellAllButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WorkerUpgradeAddLabel = new System.Windows.Forms.Label();
            this.workerUpgradeAddButton = new System.Windows.Forms.Button();
            this.UpgradeWorkerLabel = new System.Windows.Forms.Label();
            this.workerUpgradeExpButton = new System.Windows.Forms.Button();
            this.sellAllLabel = new System.Windows.Forms.Label();
            this.clrButton = new System.Windows.Forms.Button();
            this.mainUpgradePanel = new System.Windows.Forms.Panel();
            this.testPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelButton01 = new System.Windows.Forms.Button();
            this.panelButton02 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.newsPanel.SuspendLayout();
            this.idleUpgradePanel.SuspendLayout();
            this.ProductionLineGroupBox.SuspendLayout();
            this.MachineGroupBox.SuspendLayout();
            this.FactoryWorkerGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainUpgradePanel.SuspendLayout();
            this.testPanel.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Controls.Add(this.rubberBandPerSecondLabel);
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
            // rubberBandPerSecondLabel
            // 
            this.rubberBandPerSecondLabel.AutoSize = true;
            this.rubberBandPerSecondLabel.Location = new System.Drawing.Point(182, 57);
            this.rubberBandPerSecondLabel.Name = "rubberBandPerSecondLabel";
            this.rubberBandPerSecondLabel.Size = new System.Drawing.Size(46, 13);
            this.rubberBandPerSecondLabel.TabIndex = 11;
            this.rubberBandPerSecondLabel.Text = "RB/S: 0";
            // 
            // rubberBandAmountBox
            // 
            this.rubberBandAmountBox.AutoSize = true;
            this.rubberBandAmountBox.BackColor = System.Drawing.SystemColors.Window;
            this.rubberBandAmountBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rubberBandAmountBox.Location = new System.Drawing.Point(186, 37);
            this.rubberBandAmountBox.Name = "rubberBandAmountBox";
            this.rubberBandAmountBox.Size = new System.Drawing.Size(30, 15);
            this.rubberBandAmountBox.TabIndex = 10;
            this.rubberBandAmountBox.Text = "0.00";
            // 
            // moneyAmountBox
            // 
            this.moneyAmountBox.AutoSize = true;
            this.moneyAmountBox.BackColor = System.Drawing.SystemColors.Window;
            this.moneyAmountBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moneyAmountBox.Location = new System.Drawing.Point(185, 94);
            this.moneyAmountBox.Name = "moneyAmountBox";
            this.moneyAmountBox.Size = new System.Drawing.Size(36, 15);
            this.moneyAmountBox.TabIndex = 9;
            this.moneyAmountBox.Text = "$0.00";
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
            this.newsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.errorLabel.Location = new System.Drawing.Point(26, 106);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(55, 13);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "ErrorLabel";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(29, 54);
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
            this.TESTLABEL.Location = new System.Drawing.Point(29, 88);
            this.TESTLABEL.Name = "TESTLABEL";
            this.TESTLABEL.Size = new System.Drawing.Size(37, 15);
            this.TESTLABEL.TabIndex = 8;
            this.TESTLABEL.Text = "label1";
            // 
            // idleUpgradePanel
            // 
            this.idleUpgradePanel.AutoScroll = true;
            this.idleUpgradePanel.BackColor = System.Drawing.SystemColors.Window;
            this.idleUpgradePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.idleUpgradePanel.Controls.Add(this.ProductionLineGroupBox);
            this.idleUpgradePanel.Controls.Add(this.MachineGroupBox);
            this.idleUpgradePanel.Controls.Add(this.FactoryWorkerGroupBox);
            this.idleUpgradePanel.Location = new System.Drawing.Point(0, 3);
            this.idleUpgradePanel.Name = "idleUpgradePanel";
            this.idleUpgradePanel.Size = new System.Drawing.Size(264, 305);
            this.idleUpgradePanel.TabIndex = 9;
            // 
            // ProductionLineGroupBox
            // 
            this.ProductionLineGroupBox.Controls.Add(this.productionLineButton);
            this.ProductionLineGroupBox.Controls.Add(this.ProductionLineRubberBandLabel);
            this.ProductionLineGroupBox.Controls.Add(this.productionLineAmountLabel);
            this.ProductionLineGroupBox.Location = new System.Drawing.Point(13, 242);
            this.ProductionLineGroupBox.Name = "ProductionLineGroupBox";
            this.ProductionLineGroupBox.Size = new System.Drawing.Size(227, 108);
            this.ProductionLineGroupBox.TabIndex = 15;
            this.ProductionLineGroupBox.TabStop = false;
            this.ProductionLineGroupBox.Text = "Production Line";
            // 
            // productionLineButton
            // 
            this.productionLineButton.Location = new System.Drawing.Point(9, 19);
            this.productionLineButton.Name = "productionLineButton";
            this.productionLineButton.Size = new System.Drawing.Size(205, 47);
            this.productionLineButton.TabIndex = 0;
            this.productionLineButton.Text = "Production Line $700.00";
            this.productionLineButton.UseVisualStyleBackColor = true;
            this.productionLineButton.Click += new System.EventHandler(this.productionLineButton_Click);
            // 
            // ProductionLineRubberBandLabel
            // 
            this.ProductionLineRubberBandLabel.AutoSize = true;
            this.ProductionLineRubberBandLabel.Location = new System.Drawing.Point(6, 85);
            this.ProductionLineRubberBandLabel.Name = "ProductionLineRubberBandLabel";
            this.ProductionLineRubberBandLabel.Size = new System.Drawing.Size(138, 13);
            this.ProductionLineRubberBandLabel.TabIndex = 12;
            this.ProductionLineRubberBandLabel.Text = "0 Rubber Band Per Second";
            // 
            // productionLineAmountLabel
            // 
            this.productionLineAmountLabel.AutoSize = true;
            this.productionLineAmountLabel.Location = new System.Drawing.Point(6, 69);
            this.productionLineAmountLabel.Name = "productionLineAmountLabel";
            this.productionLineAmountLabel.Size = new System.Drawing.Size(95, 13);
            this.productionLineAmountLabel.TabIndex = 11;
            this.productionLineAmountLabel.Text = "0 Production Lines";
            // 
            // MachineGroupBox
            // 
            this.MachineGroupBox.Controls.Add(this.machineButton);
            this.MachineGroupBox.Controls.Add(this.machineRubberBandLabel);
            this.MachineGroupBox.Controls.Add(this.machineAmountLabel);
            this.MachineGroupBox.Location = new System.Drawing.Point(13, 128);
            this.MachineGroupBox.Name = "MachineGroupBox";
            this.MachineGroupBox.Size = new System.Drawing.Size(227, 108);
            this.MachineGroupBox.TabIndex = 14;
            this.MachineGroupBox.TabStop = false;
            this.MachineGroupBox.Text = "Rubber Band Machine";
            // 
            // machineButton
            // 
            this.machineButton.Location = new System.Drawing.Point(9, 19);
            this.machineButton.Name = "machineButton";
            this.machineButton.Size = new System.Drawing.Size(205, 47);
            this.machineButton.TabIndex = 0;
            this.machineButton.Text = "Machine: $270.00";
            this.machineButton.UseVisualStyleBackColor = true;
            this.machineButton.Click += new System.EventHandler(this.machineButton_Click);
            // 
            // machineRubberBandLabel
            // 
            this.machineRubberBandLabel.AutoSize = true;
            this.machineRubberBandLabel.Location = new System.Drawing.Point(6, 85);
            this.machineRubberBandLabel.Name = "machineRubberBandLabel";
            this.machineRubberBandLabel.Size = new System.Drawing.Size(138, 13);
            this.machineRubberBandLabel.TabIndex = 12;
            this.machineRubberBandLabel.Text = "0 Rubber Band Per Second";
            // 
            // machineAmountLabel
            // 
            this.machineAmountLabel.AutoSize = true;
            this.machineAmountLabel.Location = new System.Drawing.Point(6, 69);
            this.machineAmountLabel.Name = "machineAmountLabel";
            this.machineAmountLabel.Size = new System.Drawing.Size(62, 13);
            this.machineAmountLabel.TabIndex = 11;
            this.machineAmountLabel.Text = "0 Machines";
            // 
            // FactoryWorkerGroupBox
            // 
            this.FactoryWorkerGroupBox.Controls.Add(this.workerButtom);
            this.FactoryWorkerGroupBox.Controls.Add(this.workerRubberBandLabel);
            this.FactoryWorkerGroupBox.Controls.Add(this.workerAmountLabel);
            this.FactoryWorkerGroupBox.Location = new System.Drawing.Point(13, 14);
            this.FactoryWorkerGroupBox.Name = "FactoryWorkerGroupBox";
            this.FactoryWorkerGroupBox.Size = new System.Drawing.Size(227, 108);
            this.FactoryWorkerGroupBox.TabIndex = 13;
            this.FactoryWorkerGroupBox.TabStop = false;
            this.FactoryWorkerGroupBox.Text = "Factory Worker";
            // 
            // workerButtom
            // 
            this.workerButtom.Location = new System.Drawing.Point(9, 19);
            this.workerButtom.Name = "workerButtom";
            this.workerButtom.Size = new System.Drawing.Size(205, 47);
            this.workerButtom.TabIndex = 0;
            this.workerButtom.Text = "Factory Worker $10.00 to Hire";
            this.workerButtom.UseVisualStyleBackColor = true;
            this.workerButtom.Click += new System.EventHandler(this.workerButtom_Click);
            // 
            // workerRubberBandLabel
            // 
            this.workerRubberBandLabel.AutoSize = true;
            this.workerRubberBandLabel.Location = new System.Drawing.Point(6, 85);
            this.workerRubberBandLabel.Name = "workerRubberBandLabel";
            this.workerRubberBandLabel.Size = new System.Drawing.Size(138, 13);
            this.workerRubberBandLabel.TabIndex = 12;
            this.workerRubberBandLabel.Text = "0 Rubber Band Per Second";
            // 
            // workerAmountLabel
            // 
            this.workerAmountLabel.AutoSize = true;
            this.workerAmountLabel.Location = new System.Drawing.Point(6, 69);
            this.workerAmountLabel.Name = "workerAmountLabel";
            this.workerAmountLabel.Size = new System.Drawing.Size(56, 13);
            this.workerAmountLabel.TabIndex = 11;
            this.workerAmountLabel.Text = "0 Workers";
            // 
            // newsWorker
            // 
            this.newsWorker.WorkerReportsProgress = true;
            this.newsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.newsWorker_DoWork);
            this.newsWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.NewsWorker_ProgressChanged);
            // 
            // idleGeneratorWorker
            // 
            this.idleGeneratorWorker.WorkerReportsProgress = true;
            this.idleGeneratorWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.idleGeneratorWorker_DoWork);
            this.idleGeneratorWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.idleGeneratorWorker_ProgressChanged);
            // 
            // rubberBandCostUpgrade
            // 
            this.rubberBandCostUpgrade.Location = new System.Drawing.Point(626, 116);
            this.rubberBandCostUpgrade.Name = "rubberBandCostUpgrade";
            this.rubberBandCostUpgrade.Size = new System.Drawing.Size(152, 70);
            this.rubberBandCostUpgrade.TabIndex = 10;
            this.rubberBandCostUpgrade.Text = "Good rubber band prduction $0.20 per band $2600 to buy";
            this.rubberBandCostUpgrade.UseVisualStyleBackColor = true;
            this.rubberBandCostUpgrade.Click += new System.EventHandler(this.rubberBandUpgradeButton_Click);
            // 
            // sellAllButton
            // 
            this.sellAllButton.Location = new System.Drawing.Point(12, 14);
            this.sellAllButton.Name = "sellAllButton";
            this.sellAllButton.Size = new System.Drawing.Size(205, 51);
            this.sellAllButton.TabIndex = 11;
            this.sellAllButton.Text = "$15,000 Sacrfice all generators and rubber bands for 1.4 * rubber band production" +
    "";
            this.sellAllButton.UseVisualStyleBackColor = true;
            this.sellAllButton.Click += new System.EventHandler(this.sellAllButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.WorkerUpgradeAddLabel);
            this.panel1.Controls.Add(this.workerUpgradeAddButton);
            this.panel1.Controls.Add(this.UpgradeWorkerLabel);
            this.panel1.Controls.Add(this.workerUpgradeExpButton);
            this.panel1.Controls.Add(this.sellAllLabel);
            this.panel1.Controls.Add(this.sellAllButton);
            this.panel1.Location = new System.Drawing.Point(286, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 305);
            this.panel1.TabIndex = 12;
            // 
            // WorkerUpgradeAddLabel
            // 
            this.WorkerUpgradeAddLabel.AutoSize = true;
            this.WorkerUpgradeAddLabel.BackColor = System.Drawing.SystemColors.Window;
            this.WorkerUpgradeAddLabel.Location = new System.Drawing.Point(12, 214);
            this.WorkerUpgradeAddLabel.Name = "WorkerUpgradeAddLabel";
            this.WorkerUpgradeAddLabel.Size = new System.Drawing.Size(90, 13);
            this.WorkerUpgradeAddLabel.TabIndex = 16;
            this.WorkerUpgradeAddLabel.Text = "Worker + 0 / Sec";
            // 
            // workerUpgradeAddButton
            // 
            this.workerUpgradeAddButton.Location = new System.Drawing.Point(12, 162);
            this.workerUpgradeAddButton.Name = "workerUpgradeAddButton";
            this.workerUpgradeAddButton.Size = new System.Drawing.Size(205, 49);
            this.workerUpgradeAddButton.TabIndex = 15;
            this.workerUpgradeAddButton.Text = "Upgrade Worker +10 costs $1000";
            this.workerUpgradeAddButton.UseVisualStyleBackColor = true;
            this.workerUpgradeAddButton.Click += new System.EventHandler(this.workerUpgradeAddButton_Click);
            // 
            // UpgradeWorkerLabel
            // 
            this.UpgradeWorkerLabel.AutoSize = true;
            this.UpgradeWorkerLabel.BackColor = System.Drawing.SystemColors.Window;
            this.UpgradeWorkerLabel.Location = new System.Drawing.Point(12, 143);
            this.UpgradeWorkerLabel.Name = "UpgradeWorkerLabel";
            this.UpgradeWorkerLabel.Size = new System.Drawing.Size(109, 13);
            this.UpgradeWorkerLabel.TabIndex = 14;
            this.UpgradeWorkerLabel.Text = "Worker Efficiency ^ 1";
            // 
            // workerUpgradeExpButton
            // 
            this.workerUpgradeExpButton.Location = new System.Drawing.Point(12, 91);
            this.workerUpgradeExpButton.Name = "workerUpgradeExpButton";
            this.workerUpgradeExpButton.Size = new System.Drawing.Size(205, 49);
            this.workerUpgradeExpButton.TabIndex = 13;
            this.workerUpgradeExpButton.Text = "Upgrade Worker ^ 1.1 costs 10 workers";
            this.workerUpgradeExpButton.UseVisualStyleBackColor = true;
            this.workerUpgradeExpButton.Click += new System.EventHandler(this.workerUpgradeButton_Click);
            // 
            // sellAllLabel
            // 
            this.sellAllLabel.AutoSize = true;
            this.sellAllLabel.BackColor = System.Drawing.SystemColors.Window;
            this.sellAllLabel.Location = new System.Drawing.Point(12, 72);
            this.sellAllLabel.Name = "sellAllLabel";
            this.sellAllLabel.Size = new System.Drawing.Size(81, 13);
            this.sellAllLabel.TabIndex = 12;
            this.sellAllLabel.Text = "Producton * 1.0";
            // 
            // clrButton
            // 
            this.clrButton.Location = new System.Drawing.Point(29, 25);
            this.clrButton.Name = "clrButton";
            this.clrButton.Size = new System.Drawing.Size(75, 23);
            this.clrButton.TabIndex = 13;
            this.clrButton.Text = "clear idle workers";
            this.clrButton.UseVisualStyleBackColor = true;
            this.clrButton.Click += new System.EventHandler(this.clrButton_Click);
            // 
            // mainUpgradePanel
            // 
            this.mainUpgradePanel.Controls.Add(this.idleUpgradePanel);
            this.mainUpgradePanel.Controls.Add(this.panel1);
            this.mainUpgradePanel.Location = new System.Drawing.Point(12, 269);
            this.mainUpgradePanel.Name = "mainUpgradePanel";
            this.mainUpgradePanel.Size = new System.Drawing.Size(608, 313);
            this.mainUpgradePanel.TabIndex = 14;
            // 
            // testPanel
            // 
            this.testPanel.Controls.Add(this.panel2);
            this.testPanel.Controls.Add(this.panel3);
            this.testPanel.Location = new System.Drawing.Point(797, 24);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(608, 313);
            this.testPanel.TabIndex = 15;
            this.testPanel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(286, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 305);
            this.panel3.TabIndex = 15;
            // 
            // panelButton01
            // 
            this.panelButton01.Location = new System.Drawing.Point(12, 240);
            this.panelButton01.Name = "panelButton01";
            this.panelButton01.Size = new System.Drawing.Size(75, 23);
            this.panelButton01.TabIndex = 16;
            this.panelButton01.Text = "Main Upgrades";
            this.panelButton01.UseVisualStyleBackColor = true;
            this.panelButton01.Click += new System.EventHandler(this.panelButton01_Click);
            // 
            // panelButton02
            // 
            this.panelButton02.Location = new System.Drawing.Point(93, 240);
            this.panelButton02.Name = "panelButton02";
            this.panelButton02.Size = new System.Drawing.Size(75, 23);
            this.panelButton02.TabIndex = 17;
            this.panelButton02.Text = "Test Panel";
            this.panelButton02.UseVisualStyleBackColor = true;
            this.panelButton02.Click += new System.EventHandler(this.panelButton02_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.clrButton);
            this.panel2.Controls.Add(this.errorLabel);
            this.panel2.Controls.Add(this.testButton);
            this.panel2.Controls.Add(this.TESTLABEL);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 305);
            this.panel2.TabIndex = 14;
            // 
            // gameForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 609);
            this.Controls.Add(this.panelButton02);
            this.Controls.Add(this.panelButton01);
            this.Controls.Add(this.testPanel);
            this.Controls.Add(this.mainUpgradePanel);
            this.Controls.Add(this.rubberBandCostUpgrade);
            this.Controls.Add(this.newsPanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "gameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Rubber Band Game";
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.newsPanel.ResumeLayout(false);
            this.newsPanel.PerformLayout();
            this.idleUpgradePanel.ResumeLayout(false);
            this.ProductionLineGroupBox.ResumeLayout(false);
            this.ProductionLineGroupBox.PerformLayout();
            this.MachineGroupBox.ResumeLayout(false);
            this.MachineGroupBox.PerformLayout();
            this.FactoryWorkerGroupBox.ResumeLayout(false);
            this.FactoryWorkerGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainUpgradePanel.ResumeLayout(false);
            this.testPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label TESTLABEL;
        private System.Windows.Forms.Label moneyAmountBox;
        private System.Windows.Forms.Label rubberBandAmountBox;
        private System.Windows.Forms.Label newsBox;
        private System.Windows.Forms.Panel idleUpgradePanel;
        private System.Windows.Forms.Button workerButtom;
        private System.ComponentModel.BackgroundWorker newsWorker;
        private System.ComponentModel.BackgroundWorker idleGeneratorWorker;
        private System.Windows.Forms.Label workerRubberBandLabel;
        private System.Windows.Forms.Label workerAmountLabel;
        private System.Windows.Forms.GroupBox FactoryWorkerGroupBox;
        private System.Windows.Forms.GroupBox ProductionLineGroupBox;
        private System.Windows.Forms.Button productionLineButton;
        private System.Windows.Forms.Label ProductionLineRubberBandLabel;
        private System.Windows.Forms.Label productionLineAmountLabel;
        private System.Windows.Forms.GroupBox MachineGroupBox;
        private System.Windows.Forms.Button machineButton;
        private System.Windows.Forms.Label machineRubberBandLabel;
        private System.Windows.Forms.Label machineAmountLabel;
        private System.Windows.Forms.Button rubberBandCostUpgrade;
        private System.Windows.Forms.Button sellAllButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sellAllLabel;
        public System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button workerUpgradeExpButton;
        private System.Windows.Forms.Button clrButton;
        private System.Windows.Forms.Label rubberBandPerSecondLabel;
        private System.Windows.Forms.Label UpgradeWorkerLabel;
        private System.Windows.Forms.Label WorkerUpgradeAddLabel;
        private System.Windows.Forms.Button workerUpgradeAddButton;
        private System.Windows.Forms.Panel mainUpgradePanel;
        private System.Windows.Forms.Panel testPanel;
        private System.Windows.Forms.Button panelButton01;
        private System.Windows.Forms.Button panelButton02;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

