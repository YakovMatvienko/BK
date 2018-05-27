namespace BK
{
    partial class Form_Game
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.panel_Game = new System.Windows.Forms.Panel();
            this.label_AttDef = new System.Windows.Forms.Label();
            this.button_Action = new System.Windows.Forms.Button();
            this.label_Round = new System.Windows.Forms.Label();
            this.label_OpponentHP = new System.Windows.Forms.Label();
            this.label_PlayerHP = new System.Windows.Forms.Label();
            this.richTextBox_FightLog = new System.Windows.Forms.RichTextBox();
            this.radioButton_Legs = new System.Windows.Forms.RadioButton();
            this.radioButton_Body = new System.Windows.Forms.RadioButton();
            this.radioButton_Head = new System.Windows.Forms.RadioButton();
            this.label_Opponent = new System.Windows.Forms.Label();
            this.label_Player = new System.Windows.Forms.Label();
            this.progressBar_Opponent = new System.Windows.Forms.ProgressBar();
            this.progressBar_Player = new System.Windows.Forms.ProgressBar();
            this.panel_FinalScreen = new System.Windows.Forms.Panel();
            this.button_ToMenu = new System.Windows.Forms.Button();
            this.button_Restart = new System.Windows.Forms.Button();
            this.label_Result = new System.Windows.Forms.Label();
            this.panel_InputName = new System.Windows.Forms.Panel();
            this.button_PlayerName = new System.Windows.Forms.Button();
            this.textBox_PlayerName = new System.Windows.Forms.TextBox();
            this.panel_Menu.SuspendLayout();
            this.panel_Game.SuspendLayout();
            this.panel_FinalScreen.SuspendLayout();
            this.panel_InputName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.button_Exit);
            this.panel_Menu.Controls.Add(this.button_Start);
            this.panel_Menu.Location = new System.Drawing.Point(250, 76);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(243, 255);
            this.panel_Menu.TabIndex = 0;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(70, 161);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(100, 50);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(70, 60);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(100, 50);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Начать игру";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // panel_Game
            // 
            this.panel_Game.Controls.Add(this.label_AttDef);
            this.panel_Game.Controls.Add(this.button_Action);
            this.panel_Game.Controls.Add(this.label_Round);
            this.panel_Game.Controls.Add(this.label_OpponentHP);
            this.panel_Game.Controls.Add(this.label_PlayerHP);
            this.panel_Game.Controls.Add(this.richTextBox_FightLog);
            this.panel_Game.Controls.Add(this.radioButton_Legs);
            this.panel_Game.Controls.Add(this.radioButton_Body);
            this.panel_Game.Controls.Add(this.radioButton_Head);
            this.panel_Game.Controls.Add(this.label_Opponent);
            this.panel_Game.Controls.Add(this.label_Player);
            this.panel_Game.Controls.Add(this.progressBar_Opponent);
            this.panel_Game.Controls.Add(this.progressBar_Player);
            this.panel_Game.Location = new System.Drawing.Point(0, 0);
            this.panel_Game.Name = "panel_Game";
            this.panel_Game.Size = new System.Drawing.Size(751, 461);
            this.panel_Game.TabIndex = 1;
            // 
            // label_AttDef
            // 
            this.label_AttDef.AutoSize = true;
            this.label_AttDef.Location = new System.Drawing.Point(373, 76);
            this.label_AttDef.Name = "label_AttDef";
            this.label_AttDef.Size = new System.Drawing.Size(35, 13);
            this.label_AttDef.TabIndex = 13;
            this.label_AttDef.Text = "label1";
            // 
            // button_Action
            // 
            this.button_Action.Location = new System.Drawing.Point(343, 368);
            this.button_Action.Name = "button_Action";
            this.button_Action.Size = new System.Drawing.Size(112, 44);
            this.button_Action.TabIndex = 12;
            this.button_Action.Text = "Выполнить действие";
            this.button_Action.UseVisualStyleBackColor = true;
            this.button_Action.Click += new System.EventHandler(this.button_Action_Click);
            // 
            // label_Round
            // 
            this.label_Round.AutoSize = true;
            this.label_Round.Location = new System.Drawing.Point(373, 60);
            this.label_Round.Name = "label_Round";
            this.label_Round.Size = new System.Drawing.Size(35, 13);
            this.label_Round.TabIndex = 11;
            this.label_Round.Text = "label1";
            // 
            // label_OpponentHP
            // 
            this.label_OpponentHP.AutoSize = true;
            this.label_OpponentHP.Location = new System.Drawing.Point(614, 307);
            this.label_OpponentHP.Name = "label_OpponentHP";
            this.label_OpponentHP.Size = new System.Drawing.Size(35, 13);
            this.label_OpponentHP.TabIndex = 10;
            this.label_OpponentHP.Text = "label1";
            // 
            // label_PlayerHP
            // 
            this.label_PlayerHP.AutoSize = true;
            this.label_PlayerHP.Location = new System.Drawing.Point(70, 307);
            this.label_PlayerHP.Name = "label_PlayerHP";
            this.label_PlayerHP.Size = new System.Drawing.Size(35, 13);
            this.label_PlayerHP.TabIndex = 9;
            this.label_PlayerHP.Text = "label1";
            // 
            // richTextBox_FightLog
            // 
            this.richTextBox_FightLog.Location = new System.Drawing.Point(223, 249);
            this.richTextBox_FightLog.Name = "richTextBox_FightLog";
            this.richTextBox_FightLog.ReadOnly = true;
            this.richTextBox_FightLog.Size = new System.Drawing.Size(300, 100);
            this.richTextBox_FightLog.TabIndex = 8;
            this.richTextBox_FightLog.Text = "";
            // 
            // radioButton_Legs
            // 
            this.radioButton_Legs.AutoSize = true;
            this.radioButton_Legs.Location = new System.Drawing.Point(367, 195);
            this.radioButton_Legs.Name = "radioButton_Legs";
            this.radioButton_Legs.Size = new System.Drawing.Size(50, 17);
            this.radioButton_Legs.TabIndex = 7;
            this.radioButton_Legs.TabStop = true;
            this.radioButton_Legs.Text = "Ноги";
            this.radioButton_Legs.UseVisualStyleBackColor = true;
            // 
            // radioButton_Body
            // 
            this.radioButton_Body.AutoSize = true;
            this.radioButton_Body.Location = new System.Drawing.Point(367, 153);
            this.radioButton_Body.Name = "radioButton_Body";
            this.radioButton_Body.Size = new System.Drawing.Size(50, 17);
            this.radioButton_Body.TabIndex = 6;
            this.radioButton_Body.TabStop = true;
            this.radioButton_Body.Text = "Тело";
            this.radioButton_Body.UseVisualStyleBackColor = true;
            // 
            // radioButton_Head
            // 
            this.radioButton_Head.AutoSize = true;
            this.radioButton_Head.Location = new System.Drawing.Point(367, 113);
            this.radioButton_Head.Name = "radioButton_Head";
            this.radioButton_Head.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Head.TabIndex = 5;
            this.radioButton_Head.TabStop = true;
            this.radioButton_Head.Text = "Голова";
            this.radioButton_Head.UseVisualStyleBackColor = true;
            // 
            // label_Opponent
            // 
            this.label_Opponent.AutoSize = true;
            this.label_Opponent.Location = new System.Drawing.Point(605, 76);
            this.label_Opponent.Name = "label_Opponent";
            this.label_Opponent.Size = new System.Drawing.Size(35, 13);
            this.label_Opponent.TabIndex = 4;
            this.label_Opponent.Text = "label2";
            // 
            // label_Player
            // 
            this.label_Player.AutoSize = true;
            this.label_Player.Location = new System.Drawing.Point(67, 76);
            this.label_Player.Name = "label_Player";
            this.label_Player.Size = new System.Drawing.Size(35, 13);
            this.label_Player.TabIndex = 3;
            this.label_Player.Text = "label1";
            // 
            // progressBar_Opponent
            // 
            this.progressBar_Opponent.Location = new System.Drawing.Point(585, 326);
            this.progressBar_Opponent.Name = "progressBar_Opponent";
            this.progressBar_Opponent.Size = new System.Drawing.Size(100, 23);
            this.progressBar_Opponent.TabIndex = 2;
            // 
            // progressBar_Player
            // 
            this.progressBar_Player.Location = new System.Drawing.Point(38, 326);
            this.progressBar_Player.Name = "progressBar_Player";
            this.progressBar_Player.Size = new System.Drawing.Size(100, 23);
            this.progressBar_Player.TabIndex = 1;
            // 
            // panel_FinalScreen
            // 
            this.panel_FinalScreen.Controls.Add(this.button_ToMenu);
            this.panel_FinalScreen.Controls.Add(this.button_Restart);
            this.panel_FinalScreen.Controls.Add(this.label_Result);
            this.panel_FinalScreen.Location = new System.Drawing.Point(0, 0);
            this.panel_FinalScreen.Name = "panel_FinalScreen";
            this.panel_FinalScreen.Size = new System.Drawing.Size(751, 461);
            this.panel_FinalScreen.TabIndex = 13;
            // 
            // button_ToMenu
            // 
            this.button_ToMenu.Location = new System.Drawing.Point(321, 307);
            this.button_ToMenu.Name = "button_ToMenu";
            this.button_ToMenu.Size = new System.Drawing.Size(100, 75);
            this.button_ToMenu.TabIndex = 2;
            this.button_ToMenu.Text = "Возврат в меню";
            this.button_ToMenu.UseVisualStyleBackColor = true;
            this.button_ToMenu.Click += new System.EventHandler(this.button_ToMenu_Click);
            // 
            // button_Restart
            // 
            this.button_Restart.Location = new System.Drawing.Point(321, 166);
            this.button_Restart.Name = "button_Restart";
            this.button_Restart.Size = new System.Drawing.Size(100, 75);
            this.button_Restart.TabIndex = 1;
            this.button_Restart.Text = "Начать сначала";
            this.button_Restart.UseVisualStyleBackColor = true;
            this.button_Restart.Click += new System.EventHandler(this.button_Restart_Click);
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(247, 48);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(65, 13);
            this.label_Result.TabIndex = 0;
            this.label_Result.Text = "label_Result";
            // 
            // panel_InputName
            // 
            this.panel_InputName.Controls.Add(this.button_PlayerName);
            this.panel_InputName.Controls.Add(this.textBox_PlayerName);
            this.panel_InputName.Location = new System.Drawing.Point(223, 166);
            this.panel_InputName.Name = "panel_InputName";
            this.panel_InputName.Size = new System.Drawing.Size(272, 146);
            this.panel_InputName.TabIndex = 3;
            // 
            // button_PlayerName
            // 
            this.button_PlayerName.Location = new System.Drawing.Point(110, 99);
            this.button_PlayerName.Name = "button_PlayerName";
            this.button_PlayerName.Size = new System.Drawing.Size(75, 23);
            this.button_PlayerName.TabIndex = 1;
            this.button_PlayerName.Text = "Ввести имя";
            this.button_PlayerName.UseVisualStyleBackColor = true;
            this.button_PlayerName.Click += new System.EventHandler(this.button_PlayerName_Click);
            // 
            // textBox_PlayerName
            // 
            this.textBox_PlayerName.Location = new System.Drawing.Point(94, 46);
            this.textBox_PlayerName.Name = "textBox_PlayerName";
            this.textBox_PlayerName.Size = new System.Drawing.Size(100, 20);
            this.textBox_PlayerName.TabIndex = 0;
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(748, 461);
            this.Controls.Add(this.panel_Game);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_InputName);
            this.Controls.Add(this.panel_FinalScreen);
            this.Name = "Form_Game";
            this.Text = "Бойцовский клуб";
            this.panel_Menu.ResumeLayout(false);
            this.panel_Game.ResumeLayout(false);
            this.panel_Game.PerformLayout();
            this.panel_FinalScreen.ResumeLayout(false);
            this.panel_FinalScreen.PerformLayout();
            this.panel_InputName.ResumeLayout(false);
            this.panel_InputName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Panel panel_Game;
        private System.Windows.Forms.Label label_Opponent;
        private System.Windows.Forms.Label label_Player;
        private System.Windows.Forms.ProgressBar progressBar_Opponent;
        private System.Windows.Forms.ProgressBar progressBar_Player;
        private System.Windows.Forms.RadioButton radioButton_Head;
        private System.Windows.Forms.RadioButton radioButton_Legs;
        private System.Windows.Forms.RadioButton radioButton_Body;
        private System.Windows.Forms.Label label_OpponentHP;
        private System.Windows.Forms.Label label_PlayerHP;
        private System.Windows.Forms.RichTextBox richTextBox_FightLog;
        private System.Windows.Forms.Label label_Round;
        private System.Windows.Forms.Button button_Action;
        private System.Windows.Forms.Panel panel_FinalScreen;
        private System.Windows.Forms.Button button_ToMenu;
        private System.Windows.Forms.Button button_Restart;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Panel panel_InputName;
        private System.Windows.Forms.Button button_PlayerName;
        private System.Windows.Forms.TextBox textBox_PlayerName;
        private System.Windows.Forms.Label label_AttDef;
    }
}

