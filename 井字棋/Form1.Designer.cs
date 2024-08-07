namespace 井字棋
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gameArea = new Panel();
            chess8 = new Button();
            chess5 = new Button();
            chess2 = new Button();
            chess7 = new Button();
            chess4 = new Button();
            chess1 = new Button();
            chess3 = new Button();
            chess6 = new Button();
            chess0 = new Button();
            chooseArea = new Panel();
            moveRound = new Label();
            retract = new Button();
            computerGame = new Button();
            playerGame = new Button();
            gameArea.SuspendLayout();
            chooseArea.SuspendLayout();
            SuspendLayout();
            // 
            // gameArea
            // 
            gameArea.BackColor = SystemColors.Info;
            gameArea.Controls.Add(chess8);
            gameArea.Controls.Add(chess5);
            gameArea.Controls.Add(chess2);
            gameArea.Controls.Add(chess7);
            gameArea.Controls.Add(chess4);
            gameArea.Controls.Add(chess1);
            gameArea.Controls.Add(chess3);
            gameArea.Controls.Add(chess6);
            gameArea.Controls.Add(chess0);
            gameArea.Location = new Point(2, 3);
            gameArea.Name = "gameArea";
            gameArea.Size = new Size(500, 450);
            gameArea.TabIndex = 0;
            // 
            // chess8
            // 
            chess8.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            chess8.Location = new Point(322, 294);
            chess8.Name = "chess8";
            chess8.Size = new Size(130, 130);
            chess8.TabIndex = 8;
            chess8.Text = "?";
            chess8.UseVisualStyleBackColor = true;
            chess8.Click += chess8_Click;
            // 
            // chess5
            // 
            chess5.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            chess5.Location = new Point(322, 157);
            chess5.Name = "chess5";
            chess5.Size = new Size(130, 130);
            chess5.TabIndex = 7;
            chess5.Text = "?";
            chess5.UseVisualStyleBackColor = true;
            chess5.Click += chess5_Click;
            // 
            // chess2
            // 
            chess2.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            chess2.Location = new Point(322, 21);
            chess2.Name = "chess2";
            chess2.Size = new Size(130, 130);
            chess2.TabIndex = 6;
            chess2.Text = "?";
            chess2.UseVisualStyleBackColor = true;
            chess2.Click += chess2_Click;
            // 
            // chess7
            // 
            chess7.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            chess7.Location = new Point(186, 294);
            chess7.Name = "chess7";
            chess7.Size = new Size(130, 130);
            chess7.TabIndex = 5;
            chess7.Text = "?";
            chess7.UseVisualStyleBackColor = true;
            chess7.Click += chess7_Click;
            // 
            // chess4
            // 
            chess4.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            chess4.Location = new Point(186, 157);
            chess4.Name = "chess4";
            chess4.Size = new Size(130, 130);
            chess4.TabIndex = 4;
            chess4.Text = "?";
            chess4.UseVisualStyleBackColor = true;
            chess4.Click += chess4_Click;
            // 
            // chess1
            // 
            chess1.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            chess1.Location = new Point(186, 21);
            chess1.Name = "chess1";
            chess1.Size = new Size(130, 130);
            chess1.TabIndex = 3;
            chess1.Text = "?";
            chess1.UseVisualStyleBackColor = true;
            chess1.Click += chess1_Click;
            // 
            // chess3
            // 
            chess3.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            chess3.Location = new Point(50, 157);
            chess3.Name = "chess3";
            chess3.Size = new Size(130, 130);
            chess3.TabIndex = 2;
            chess3.Text = "?";
            chess3.UseVisualStyleBackColor = true;
            chess3.Click += chess3_Click;
            // 
            // chess6
            // 
            chess6.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            chess6.Location = new Point(50, 294);
            chess6.Name = "chess6";
            chess6.Size = new Size(130, 130);
            chess6.TabIndex = 1;
            chess6.Text = "?";
            chess6.UseVisualStyleBackColor = true;
            chess6.Click += chess6_Click;
            // 
            // chess0
            // 
            chess0.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            chess0.Location = new Point(50, 21);
            chess0.Name = "chess0";
            chess0.Size = new Size(130, 130);
            chess0.TabIndex = 0;
            chess0.Text = "?";
            chess0.UseVisualStyleBackColor = true;
            chess0.Click += chess0_Click;
            // 
            // chooseArea
            // 
            chooseArea.BackColor = SystemColors.MenuHighlight;
            chooseArea.Controls.Add(moveRound);
            chooseArea.Controls.Add(retract);
            chooseArea.Controls.Add(computerGame);
            chooseArea.Controls.Add(playerGame);
            chooseArea.Location = new Point(508, 3);
            chooseArea.Name = "chooseArea";
            chooseArea.Size = new Size(272, 450);
            chooseArea.TabIndex = 1;
            // 
            // moveRound
            // 
            moveRound.AutoSize = true;
            moveRound.Font = new Font("微软雅黑", 24F, FontStyle.Bold, GraphicsUnit.Point);
            moveRound.Location = new Point(34, 52);
            moveRound.Name = "moveRound";
            moveRound.Size = new Size(198, 52);
            moveRound.TabIndex = 3;
            moveRound.Text = "XX方回合";
            // 
            // retract
            // 
            retract.Font = new Font("微软雅黑", 18F, FontStyle.Bold, GraphicsUnit.Point);
            retract.Location = new Point(24, 127);
            retract.Name = "retract";
            retract.Size = new Size(226, 74);
            retract.TabIndex = 2;
            retract.Text = "悔棋";
            retract.UseVisualStyleBackColor = true;
            retract.Click += retract_Click;
            // 
            // computerGame
            // 
            computerGame.Font = new Font("微软雅黑", 18F, FontStyle.Bold, GraphicsUnit.Point);
            computerGame.Location = new Point(24, 350);
            computerGame.Name = "computerGame";
            computerGame.Size = new Size(226, 74);
            computerGame.TabIndex = 1;
            computerGame.Text = "人机对战";
            computerGame.UseVisualStyleBackColor = true;
            computerGame.Click += computerGame_Click;
            // 
            // playerGame
            // 
            playerGame.Font = new Font("微软雅黑", 18F, FontStyle.Bold, GraphicsUnit.Point);
            playerGame.Location = new Point(24, 256);
            playerGame.Name = "playerGame";
            playerGame.Size = new Size(226, 74);
            playerGame.TabIndex = 0;
            playerGame.Text = "玩家对战";
            playerGame.UseVisualStyleBackColor = true;
            playerGame.Click += playerGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(chooseArea);
            Controls.Add(gameArea);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "井字棋";
            gameArea.ResumeLayout(false);
            chooseArea.ResumeLayout(false);
            chooseArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel gameArea;
        private Panel chooseArea;
        private Label moveRound;
        private Button retract;
        private Button computerGame;
        private Button playerGame;
        private Button chess0;
        private Button chess8;
        private Button chess5;
        private Button chess2;
        private Button chess7;
        private Button chess4;
        private Button chess1;
        private Button chess3;
        private Button chess6;
    }
}
