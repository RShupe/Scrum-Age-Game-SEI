namespace Stone_Age_Game
{
    partial class MainForm
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
            this.diceResultBox = new System.Windows.Forms.TextBox();
            this.diceRollBtn = new System.Windows.Forms.Button();
            this.numPlayersBox = new System.Windows.Forms.TextBox();
            this.numPlayersLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerDataBox = new System.Windows.Forms.TextBox();
            this.upKeepButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.instLabel = new System.Windows.Forms.Label();
            this.instTeller = new System.Windows.Forms.Label();
            this.devPlacementBox = new System.Windows.Forms.GroupBox();
            this.availPosBox = new System.Windows.Forms.TextBox();
            this.posLeft = new System.Windows.Forms.Label();
            this.whereToPlace = new System.Windows.Forms.Label();
            this.placingOnBox = new System.Windows.Forms.TextBox();
            this.confirmDevsBtn = new System.Windows.Forms.Button();
            this.devsAfterBox = new System.Windows.Forms.TextBox();
            this.devsPlacedBox = new System.Windows.Forms.TextBox();
            this.devsLeftBox = new System.Windows.Forms.TextBox();
            this.devsAfterLabel = new System.Windows.Forms.Label();
            this.devToExchLabel = new System.Windows.Forms.Label();
            this.availiableDevsLabel = new System.Windows.Forms.Label();
            this.endTurn1Btn = new System.Windows.Forms.Button();
            this.boardBox = new System.Windows.Forms.GroupBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.programBox = new System.Windows.Forms.PictureBox();
            this.hrDeptBox = new System.Windows.Forms.PictureBox();
            this.userStoryBox = new System.Windows.Forms.PictureBox();
            this.protoBox = new System.Windows.Forms.PictureBox();
            this.useCaseBox = new System.Windows.Forms.PictureBox();
            this.bankBox = new System.Windows.Forms.PictureBox();
            this.SMBox = new System.Windows.Forms.PictureBox();
            this.endTurn2Btn = new System.Windows.Forms.Button();
            this.endTurn3Btn = new System.Windows.Forms.Button();
            this.currentPlayerBox = new System.Windows.Forms.TextBox();
            this.devPlacementBox.SuspendLayout();
            this.boardBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrDeptBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStoryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useCaseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMBox)).BeginInit();
            this.SuspendLayout();
            // 
            // diceResultBox
            // 
            this.diceResultBox.Enabled = false;
            this.diceResultBox.Location = new System.Drawing.Point(568, 25);
            this.diceResultBox.Name = "diceResultBox";
            this.diceResultBox.Size = new System.Drawing.Size(110, 20);
            this.diceResultBox.TabIndex = 0;
            // 
            // diceRollBtn
            // 
            this.diceRollBtn.Enabled = false;
            this.diceRollBtn.Location = new System.Drawing.Point(603, 51);
            this.diceRollBtn.Name = "diceRollBtn";
            this.diceRollBtn.Size = new System.Drawing.Size(75, 23);
            this.diceRollBtn.TabIndex = 1;
            this.diceRollBtn.Text = "Roll Dice";
            this.diceRollBtn.UseVisualStyleBackColor = true;
            this.diceRollBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // numPlayersBox
            // 
            this.numPlayersBox.Enabled = false;
            this.numPlayersBox.Location = new System.Drawing.Point(733, 25);
            this.numPlayersBox.Multiline = true;
            this.numPlayersBox.Name = "numPlayersBox";
            this.numPlayersBox.ReadOnly = true;
            this.numPlayersBox.Size = new System.Drawing.Size(111, 20);
            this.numPlayersBox.TabIndex = 2;
            // 
            // numPlayersLab
            // 
            this.numPlayersLab.AutoSize = true;
            this.numPlayersLab.Enabled = false;
            this.numPlayersLab.Location = new System.Drawing.Point(730, 9);
            this.numPlayersLab.Name = "numPlayersLab";
            this.numPlayersLab.Size = new System.Drawing.Size(93, 13);
            this.numPlayersLab.TabIndex = 3;
            this.numPlayersLab.Text = "Number of Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(853, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Player Inventory:";
            // 
            // playerDataBox
            // 
            this.playerDataBox.Enabled = false;
            this.playerDataBox.Location = new System.Drawing.Point(856, 115);
            this.playerDataBox.Multiline = true;
            this.playerDataBox.Name = "playerDataBox";
            this.playerDataBox.ReadOnly = true;
            this.playerDataBox.Size = new System.Drawing.Size(280, 154);
            this.playerDataBox.TabIndex = 5;
            // 
            // upKeepButton
            // 
            this.upKeepButton.Location = new System.Drawing.Point(1045, 67);
            this.upKeepButton.Name = "upKeepButton";
            this.upKeepButton.Size = new System.Drawing.Size(75, 23);
            this.upKeepButton.TabIndex = 6;
            this.upKeepButton.Text = "Upkeep";
            this.upKeepButton.UseVisualStyleBackColor = true;
            this.upKeepButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(856, 281);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // instLabel
            // 
            this.instLabel.AutoSize = true;
            this.instLabel.Enabled = false;
            this.instLabel.Location = new System.Drawing.Point(18, 25);
            this.instLabel.Name = "instLabel";
            this.instLabel.Size = new System.Drawing.Size(64, 13);
            this.instLabel.TabIndex = 9;
            this.instLabel.Text = "Instructions:";
            // 
            // instTeller
            // 
            this.instTeller.AutoSize = true;
            this.instTeller.Location = new System.Drawing.Point(81, 25);
            this.instTeller.Name = "instTeller";
            this.instTeller.Size = new System.Drawing.Size(188, 13);
            this.instTeller.TabIndex = 10;
            this.instTeller.Text = "Select where to place your developers";
            // 
            // devPlacementBox
            // 
            this.devPlacementBox.Controls.Add(this.availPosBox);
            this.devPlacementBox.Controls.Add(this.posLeft);
            this.devPlacementBox.Controls.Add(this.whereToPlace);
            this.devPlacementBox.Controls.Add(this.placingOnBox);
            this.devPlacementBox.Controls.Add(this.confirmDevsBtn);
            this.devPlacementBox.Controls.Add(this.devsAfterBox);
            this.devPlacementBox.Controls.Add(this.devsPlacedBox);
            this.devPlacementBox.Controls.Add(this.devsLeftBox);
            this.devPlacementBox.Controls.Add(this.devsAfterLabel);
            this.devPlacementBox.Controls.Add(this.devToExchLabel);
            this.devPlacementBox.Controls.Add(this.availiableDevsLabel);
            this.devPlacementBox.Enabled = false;
            this.devPlacementBox.Location = new System.Drawing.Point(875, 333);
            this.devPlacementBox.Name = "devPlacementBox";
            this.devPlacementBox.Size = new System.Drawing.Size(261, 215);
            this.devPlacementBox.TabIndex = 11;
            this.devPlacementBox.TabStop = false;
            // 
            // availPosBox
            // 
            this.availPosBox.Enabled = false;
            this.availPosBox.Location = new System.Drawing.Point(154, 126);
            this.availPosBox.Name = "availPosBox";
            this.availPosBox.Size = new System.Drawing.Size(100, 20);
            this.availPosBox.TabIndex = 15;
            // 
            // posLeft
            // 
            this.posLeft.AutoSize = true;
            this.posLeft.Location = new System.Drawing.Point(41, 129);
            this.posLeft.Name = "posLeft";
            this.posLeft.Size = new System.Drawing.Size(109, 13);
            this.posLeft.TabIndex = 14;
            this.posLeft.Text = "Positions Left in Area:";
            // 
            // whereToPlace
            // 
            this.whereToPlace.AutoSize = true;
            this.whereToPlace.Location = new System.Drawing.Point(29, 16);
            this.whereToPlace.Name = "whereToPlace";
            this.whereToPlace.Size = new System.Drawing.Size(122, 13);
            this.whereToPlace.TabIndex = 13;
            this.whereToPlace.Text = "Placing Developers On: ";
            // 
            // placingOnBox
            // 
            this.placingOnBox.Enabled = false;
            this.placingOnBox.Location = new System.Drawing.Point(154, 9);
            this.placingOnBox.Name = "placingOnBox";
            this.placingOnBox.Size = new System.Drawing.Size(100, 20);
            this.placingOnBox.TabIndex = 7;
            // 
            // confirmDevsBtn
            // 
            this.confirmDevsBtn.Location = new System.Drawing.Point(94, 170);
            this.confirmDevsBtn.Name = "confirmDevsBtn";
            this.confirmDevsBtn.Size = new System.Drawing.Size(103, 23);
            this.confirmDevsBtn.TabIndex = 6;
            this.confirmDevsBtn.Text = "Confirm";
            this.confirmDevsBtn.UseVisualStyleBackColor = true;
            this.confirmDevsBtn.Click += new System.EventHandler(this.confirmDevsBtn_Click);
            // 
            // devsAfterBox
            // 
            this.devsAfterBox.Enabled = false;
            this.devsAfterBox.Location = new System.Drawing.Point(154, 95);
            this.devsAfterBox.Name = "devsAfterBox";
            this.devsAfterBox.Size = new System.Drawing.Size(100, 20);
            this.devsAfterBox.TabIndex = 5;
            // 
            // devsPlacedBox
            // 
            this.devsPlacedBox.Location = new System.Drawing.Point(154, 66);
            this.devsPlacedBox.Name = "devsPlacedBox";
            this.devsPlacedBox.Size = new System.Drawing.Size(100, 20);
            this.devsPlacedBox.TabIndex = 4;
            // 
            // devsLeftBox
            // 
            this.devsLeftBox.Enabled = false;
            this.devsLeftBox.Location = new System.Drawing.Point(154, 40);
            this.devsLeftBox.Name = "devsLeftBox";
            this.devsLeftBox.Size = new System.Drawing.Size(100, 20);
            this.devsLeftBox.TabIndex = 3;
            // 
            // devsAfterLabel
            // 
            this.devsAfterLabel.AutoSize = true;
            this.devsAfterLabel.Location = new System.Drawing.Point(8, 102);
            this.devsAfterLabel.Name = "devsAfterLabel";
            this.devsAfterLabel.Size = new System.Drawing.Size(142, 13);
            this.devsAfterLabel.TabIndex = 2;
            this.devsAfterLabel.Text = "Developers After Placement:";
            // 
            // devToExchLabel
            // 
            this.devToExchLabel.AutoSize = true;
            this.devToExchLabel.Location = new System.Drawing.Point(44, 69);
            this.devToExchLabel.Name = "devToExchLabel";
            this.devToExchLabel.Size = new System.Drawing.Size(106, 13);
            this.devToExchLabel.TabIndex = 1;
            this.devToExchLabel.Text = "Developers to Place:";
            // 
            // availiableDevsLabel
            // 
            this.availiableDevsLabel.AutoSize = true;
            this.availiableDevsLabel.Location = new System.Drawing.Point(63, 43);
            this.availiableDevsLabel.Name = "availiableDevsLabel";
            this.availiableDevsLabel.Size = new System.Drawing.Size(88, 13);
            this.availiableDevsLabel.TabIndex = 0;
            this.availiableDevsLabel.Text = "Developers Left: ";
            // 
            // endTurn1Btn
            // 
            this.endTurn1Btn.Location = new System.Drawing.Point(886, 25);
            this.endTurn1Btn.Name = "endTurn1Btn";
            this.endTurn1Btn.Size = new System.Drawing.Size(75, 23);
            this.endTurn1Btn.TabIndex = 12;
            this.endTurn1Btn.Text = "End Turn 1";
            this.endTurn1Btn.UseVisualStyleBackColor = true;
            this.endTurn1Btn.Click += new System.EventHandler(this.endTurnBtn_Click);
            // 
            // boardBox
            // 
            this.boardBox.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Full_Board;
            this.boardBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boardBox.Controls.Add(this.pictureBox13);
            this.boardBox.Controls.Add(this.pictureBox12);
            this.boardBox.Controls.Add(this.pictureBox11);
            this.boardBox.Controls.Add(this.pictureBox10);
            this.boardBox.Controls.Add(this.pictureBox9);
            this.boardBox.Controls.Add(this.pictureBox8);
            this.boardBox.Controls.Add(this.pictureBox7);
            this.boardBox.Controls.Add(this.pictureBox6);
            this.boardBox.Controls.Add(this.pictureBox5);
            this.boardBox.Controls.Add(this.pictureBox4);
            this.boardBox.Controls.Add(this.pictureBox3);
            this.boardBox.Controls.Add(this.pictureBox2);
            this.boardBox.Controls.Add(this.pictureBox1);
            this.boardBox.Controls.Add(this.programBox);
            this.boardBox.Controls.Add(this.hrDeptBox);
            this.boardBox.Controls.Add(this.userStoryBox);
            this.boardBox.Controls.Add(this.protoBox);
            this.boardBox.Controls.Add(this.useCaseBox);
            this.boardBox.Controls.Add(this.bankBox);
            this.boardBox.Controls.Add(this.SMBox);
            this.boardBox.Location = new System.Drawing.Point(12, 118);
            this.boardBox.Name = "boardBox";
            this.boardBox.Size = new System.Drawing.Size(832, 430);
            this.boardBox.TabIndex = 8;
            this.boardBox.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Position;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Location = new System.Drawing.Point(194, 65);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(36, 14);
            this.pictureBox13.TabIndex = 19;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Position;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(152, 65);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(36, 14);
            this.pictureBox12.TabIndex = 18;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Position;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(114, 65);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(36, 14);
            this.pictureBox11.TabIndex = 17;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Position;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(72, 65);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(36, 14);
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Position;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(34, 65);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(36, 14);
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Position;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Enabled = false;
            this.pictureBox8.Location = new System.Drawing.Point(714, 115);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(36, 25);
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Position;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Location = new System.Drawing.Point(672, 115);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 25);
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Position;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Location = new System.Drawing.Point(630, 115);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 25);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Position;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Location = new System.Drawing.Point(386, 79);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 14);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Position;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(506, 77);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 16);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Position;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(464, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 16);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Position;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(422, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 16);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Stone_Age_Game.Properties.Resources.Position;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(677, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 20);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // programBox
            // 
            this.programBox.BackColor = System.Drawing.Color.Transparent;
            this.programBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.programBox.Location = new System.Drawing.Point(53, 311);
            this.programBox.Name = "programBox";
            this.programBox.Size = new System.Drawing.Size(116, 113);
            this.programBox.TabIndex = 6;
            this.programBox.TabStop = false;
            // 
            // hrDeptBox
            // 
            this.hrDeptBox.BackColor = System.Drawing.Color.Transparent;
            this.hrDeptBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hrDeptBox.Location = new System.Drawing.Point(214, 124);
            this.hrDeptBox.Name = "hrDeptBox";
            this.hrDeptBox.Size = new System.Drawing.Size(235, 138);
            this.hrDeptBox.TabIndex = 5;
            this.hrDeptBox.TabStop = false;
            this.hrDeptBox.Click += new System.EventHandler(this.hrDeptBox_Click);
            // 
            // userStoryBox
            // 
            this.userStoryBox.BackColor = System.Drawing.Color.Transparent;
            this.userStoryBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userStoryBox.Location = new System.Drawing.Point(386, 0);
            this.userStoryBox.Name = "userStoryBox";
            this.userStoryBox.Size = new System.Drawing.Size(178, 113);
            this.userStoryBox.TabIndex = 4;
            this.userStoryBox.TabStop = false;
            this.userStoryBox.Click += new System.EventHandler(this.userStoryBox_Click);
            // 
            // protoBox
            // 
            this.protoBox.BackColor = System.Drawing.Color.Transparent;
            this.protoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.protoBox.Location = new System.Drawing.Point(516, 163);
            this.protoBox.Name = "protoBox";
            this.protoBox.Size = new System.Drawing.Size(215, 142);
            this.protoBox.TabIndex = 3;
            this.protoBox.TabStop = false;
            this.protoBox.Click += new System.EventHandler(this.protoBox_Click);
            // 
            // useCaseBox
            // 
            this.useCaseBox.BackColor = System.Drawing.Color.Transparent;
            this.useCaseBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.useCaseBox.Location = new System.Drawing.Point(603, 0);
            this.useCaseBox.Name = "useCaseBox";
            this.useCaseBox.Size = new System.Drawing.Size(199, 157);
            this.useCaseBox.TabIndex = 2;
            this.useCaseBox.TabStop = false;
            this.useCaseBox.Click += new System.EventHandler(this.useCaseBox_Click);
            // 
            // bankBox
            // 
            this.bankBox.BackColor = System.Drawing.Color.Transparent;
            this.bankBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bankBox.Location = new System.Drawing.Point(6, 0);
            this.bankBox.Name = "bankBox";
            this.bankBox.Size = new System.Drawing.Size(235, 113);
            this.bankBox.TabIndex = 1;
            this.bankBox.TabStop = false;
            this.bankBox.Click += new System.EventHandler(this.bankBox_Click);
            // 
            // SMBox
            // 
            this.SMBox.BackColor = System.Drawing.Color.Transparent;
            this.SMBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SMBox.Location = new System.Drawing.Point(72, 124);
            this.SMBox.Name = "SMBox";
            this.SMBox.Size = new System.Drawing.Size(116, 151);
            this.SMBox.TabIndex = 0;
            this.SMBox.TabStop = false;
            this.SMBox.Click += new System.EventHandler(this.SMBox_Click);
            // 
            // endTurn2Btn
            // 
            this.endTurn2Btn.Enabled = false;
            this.endTurn2Btn.Location = new System.Drawing.Point(969, 25);
            this.endTurn2Btn.Name = "endTurn2Btn";
            this.endTurn2Btn.Size = new System.Drawing.Size(75, 23);
            this.endTurn2Btn.TabIndex = 13;
            this.endTurn2Btn.Text = "End Turn 2";
            this.endTurn2Btn.UseVisualStyleBackColor = true;
            this.endTurn2Btn.Click += new System.EventHandler(this.endTurn2Btn_Click);
            // 
            // endTurn3Btn
            // 
            this.endTurn3Btn.Enabled = false;
            this.endTurn3Btn.Location = new System.Drawing.Point(1061, 25);
            this.endTurn3Btn.Name = "endTurn3Btn";
            this.endTurn3Btn.Size = new System.Drawing.Size(75, 23);
            this.endTurn3Btn.TabIndex = 14;
            this.endTurn3Btn.Text = "End Turn 3";
            this.endTurn3Btn.UseVisualStyleBackColor = true;
            this.endTurn3Btn.Click += new System.EventHandler(this.endTurn3Btn_Click);
            // 
            // currentPlayerBox
            // 
            this.currentPlayerBox.Enabled = false;
            this.currentPlayerBox.Location = new System.Drawing.Point(412, 54);
            this.currentPlayerBox.Name = "currentPlayerBox";
            this.currentPlayerBox.Size = new System.Drawing.Size(100, 20);
            this.currentPlayerBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 560);
            this.Controls.Add(this.currentPlayerBox);
            this.Controls.Add(this.endTurn3Btn);
            this.Controls.Add(this.endTurn2Btn);
            this.Controls.Add(this.endTurn1Btn);
            this.Controls.Add(this.devPlacementBox);
            this.Controls.Add(this.instTeller);
            this.Controls.Add(this.instLabel);
            this.Controls.Add(this.boardBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.upKeepButton);
            this.Controls.Add(this.playerDataBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numPlayersLab);
            this.Controls.Add(this.numPlayersBox);
            this.Controls.Add(this.diceRollBtn);
            this.Controls.Add(this.diceResultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stone Age - Scrum Edition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.devPlacementBox.ResumeLayout(false);
            this.devPlacementBox.PerformLayout();
            this.boardBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrDeptBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStoryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useCaseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diceResultBox;
        private System.Windows.Forms.Button diceRollBtn;
        private System.Windows.Forms.TextBox numPlayersBox;
        private System.Windows.Forms.Label numPlayersLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerDataBox;
        private System.Windows.Forms.Button upKeepButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.GroupBox boardBox;
        private System.Windows.Forms.PictureBox programBox;
        private System.Windows.Forms.PictureBox hrDeptBox;
        private System.Windows.Forms.PictureBox userStoryBox;
        private System.Windows.Forms.PictureBox protoBox;
        private System.Windows.Forms.PictureBox useCaseBox;
        private System.Windows.Forms.PictureBox bankBox;
        private System.Windows.Forms.PictureBox SMBox;
        private System.Windows.Forms.Label instLabel;
        private System.Windows.Forms.Label instTeller;
        private System.Windows.Forms.GroupBox devPlacementBox;
        private System.Windows.Forms.TextBox devsAfterBox;
        private System.Windows.Forms.TextBox devsPlacedBox;
        private System.Windows.Forms.TextBox devsLeftBox;
        private System.Windows.Forms.Label devsAfterLabel;
        private System.Windows.Forms.Label devToExchLabel;
        private System.Windows.Forms.Label availiableDevsLabel;
        private System.Windows.Forms.Button confirmDevsBtn;
        private System.Windows.Forms.Button endTurn1Btn;
        private System.Windows.Forms.Label whereToPlace;
        private System.Windows.Forms.TextBox placingOnBox;
        private System.Windows.Forms.TextBox availPosBox;
        private System.Windows.Forms.Label posLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button endTurn2Btn;
        private System.Windows.Forms.Button endTurn3Btn;
        private System.Windows.Forms.TextBox currentPlayerBox;
    }
}

