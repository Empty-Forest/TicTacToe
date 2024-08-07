using System.Text;

namespace 井字棋
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameScreen();
        }
        private void GameScreen()//游戏开始与结束时，不能下棋与悔棋
        {
            gameArea.Enabled = false;
            //悔棋不可见
            retract.Visible = false;
            //显示
            moveRound.Text = "请开始游戏";
            //清空棋盘内的数值
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    chess[i, j] = 0;
                }
            }
            //使开始游戏能够点击
            playerGame.Enabled = true;
            playerGame.Visible = true;
            computerGame.Enabled = true;
            computerGame.Visible = true;
            #region 棋盘还原
            chess0.Text = "?";
            chess0.Enabled = true;
            chess1.Text = "?";
            chess1.Enabled = true;
            chess2.Text = "?";
            chess2.Enabled = true;
            chess3.Text = "?";
            chess3.Enabled = true;
            chess4.Text = "?";
            chess4.Enabled = true;
            chess5.Text = "?";
            chess5.Enabled = true;
            chess6.Text = "?";
            chess6.Enabled = true;
            chess7.Text = "?";
            chess7.Enabled = true;
            chess8.Text = "?";
            chess8.Enabled = true;
            #endregion
            //人机还原
            computer = false;
            //回合还原
            round = 1;
            //清除对局步骤
            step = 0;
            for(int i = 0; i < 9; i++)
            {
                chessStep[i] = null;
                chessStepRound[i] = 0;
                chessStepi[i] = 0;
                chessStepj[i] = 0;
            }
        }
        private int round = 1;
        //回合变化，一开始是圆圈方回合，1是圆圈方，2是叉叉方
        private void Round(Button button)//传进一个按钮以确定是下哪个位置
        {
            //如果圆圈方下棋了，就变为叉叉方回合，反之亦然
            switch (round)
            {
                case 1:
                    round = 2;
                    button.Text = "⚪";//下棋后所下位置变为圆圈
                    button.Enabled = false;//不能再更改
                    moveRound.Text = "叉叉方回合";
                    break;
                case 2:
                    round = 1;
                    button.Text = "X";//下棋后所下位置变为叉叉
                    button.Enabled = false;//不能再更改
                    moveRound.Text = "圆圈方回合";
                    break;

            }
        }
        private void Victory()//检测是否有一方胜利
        {
            //判断第一行
            if (chess[0, 0] == chess[0, 1] && chess[0, 0] == chess[0, 2] && chess[0, 0] != 0)
            {
                if (chess[0, 0] == 1 || chess[0, 1] == 1 || chess[0, 2] == 1)
                {
                    MessageBox.Show("圆圈方胜利！");
                    GameScreen();
                }
                else if (chess[0, 0] == 2 || chess[0, 1] == 2 || chess[0, 2] == 2)
                {
                    MessageBox.Show("叉叉方胜利！");
                    GameScreen();
                }
            }
            //判断第二行
            else if (chess[1, 0] == chess[1, 1] && chess[1, 0] == chess[1, 2] && chess[1, 0] != 0)
            {
                if (chess[1, 0] == 1 || chess[1, 1] == 1 || chess[1, 2] == 1)
                {
                    MessageBox.Show("圆圈方胜利！");
                    GameScreen();
                }
                else if (chess[1, 0] == 2 || chess[1, 1] == 2 || chess[1, 2] == 2)
                {
                    MessageBox.Show("叉叉方胜利！");
                    GameScreen();
                }
            }
            //判断第三行
            else if (chess[2, 0] == chess[2, 1] && chess[2, 0] == chess[2, 2] && chess[2, 0] != 0)
            {
                if (chess[2, 0] == 1 || chess[2, 1] == 1 || chess[2, 2] == 1)
                {
                    MessageBox.Show("圆圈方胜利！");
                    GameScreen();
                }
                else if (chess[2, 0] == 2 || chess[2, 1] == 2 || chess[2, 2] == 2)
                {
                    MessageBox.Show("叉叉方胜利！");
                    GameScreen();
                }
            }
            //判断第一列
            else if (chess[0, 0] == chess[1, 0] && chess[0, 0] == chess[2, 0] && chess[0, 0] != 0)
            {
                if (chess[0, 0] == 1 || chess[1, 0] == 1 || chess[2, 0] == 1)
                {
                    MessageBox.Show("圆圈方胜利！");
                    GameScreen();
                }
                else if (chess[0, 0] == 2 || chess[1, 0] == 2 || chess[2, 0] == 2)
                {
                    MessageBox.Show("叉叉方胜利！");
                    GameScreen();
                }
            }
            //判断第二列
            else if (chess[0, 1] == chess[1, 1] && chess[0, 1] == chess[2, 1] && chess[0, 1] != 0)
            {
                if (chess[0, 1] == 1 || chess[1, 1] == 1 || chess[2, 1] == 1)
                {
                    MessageBox.Show("圆圈方胜利！");
                    GameScreen();
                }
                else if (chess[0, 1] == 2 || chess[1, 1] == 2 || chess[2, 1] == 2)
                {
                    MessageBox.Show("叉叉方胜利！");
                    GameScreen();
                }
            }
            //判断第三列
            else if (chess[0, 2] == chess[1, 2] && chess[0, 2] == chess[2, 2] && chess[0, 2] != 0)
            {
                if (chess[0, 2] == 1 || chess[1, 2] == 1 || chess[2, 2] == 1)
                {
                    MessageBox.Show("圆圈方胜利！");
                    GameScreen();
                }
                else if (chess[0, 2] == 2 || chess[1, 2] == 2 || chess[2, 2] == 2)
                {
                    MessageBox.Show("叉叉方胜利！");
                    GameScreen();
                }
            }
            //判断左斜角
            else if (chess[0, 0] == chess[1, 1] && chess[0, 0] == chess[2, 2] && chess[0, 0] != 0)
            {
                if (chess[0, 0] == 1 || chess[1, 1] == 1 || chess[2, 2] == 1)
                {
                    MessageBox.Show("圆圈方胜利！");
                    GameScreen();
                }
                else if (chess[0, 0] == 2 || chess[1, 1] == 2 || chess[2, 2] == 2)
                {
                    MessageBox.Show("叉叉方胜利！");
                    GameScreen();
                }
            }
            //判断右斜角
            else if (chess[0, 2] == chess[1, 1] && chess[0, 2] == chess[2, 0] && chess[0, 2] != 0)
            {
                if (chess[0, 2] == 1 || chess[1, 1] == 1 || chess[2, 0] == 1)
                {
                    MessageBox.Show("圆圈方胜利！");
                    GameScreen();
                }
                else if (chess[0, 2] == 2 || chess[1, 1] == 2 || chess[2, 0] == 2)
                {
                    MessageBox.Show("叉叉方胜利！");
                    GameScreen();
                }
            }
            //平局
            else if (chess[0, 0] != 0 && chess[0, 1] != 0 && chess[0, 2] != 0 && chess[1, 0] != 0 && chess[1, 1] != 0 && chess[1, 2] != 0 && chess[2, 0] != 0 && chess[2, 1] != 0 && chess[2, 2] != 0)
            {
                MessageBox.Show("平局！");
                GameScreen();
            }
        }
        private void playerGame_Click(object sender, EventArgs e)//玩家对战
        {
            gameArea.Enabled = true;
            playerGame.Enabled = false;
            //人机对战不可见
            computerGame.Visible = false;
            //悔棋可见
            retract.Visible = true;
            moveRound.Text = "圆圈方回合";
        }
        #region 棋盘
        private int[,] chess = new int[3, 3];
        private void chess0_Click(object sender, EventArgs e)
        {
            chess[0, 0] = round;//首先执行使棋盘该位置数值由0变为该回合下的棋子的数值
            Round(chess0);//下棋后的回合及数值变化
            Victory();//判断是否胜利
            Computer();
            Step(chess0, chess[0, 0], 0, 0);
        }

        private void chess1_Click(object sender, EventArgs e)
        {
            chess[0, 1] = round;//首先执行使棋盘该位置数值由0变为该回合下的棋子的数值
            Round(chess1);//下棋后的回合及数值变化
            Victory();//判断是否胜利
            Computer();
            Step(chess1, chess[0, 1], 0, 1);
        }

        private void chess2_Click(object sender, EventArgs e)
        {
            chess[0, 2] = round;//首先执行使棋盘该位置数值由0变为该回合下的棋子的数值
            Round(chess2);//下棋后的回合及数值变化
            Victory();//判断是否胜利
            Computer();
            Step(chess2, chess[0, 2], 0, 2);
        }

        private void chess3_Click(object sender, EventArgs e)
        {
            chess[1, 0] = round;//首先执行使棋盘该位置数值由0变为该回合下的棋子的数值
            Round(chess3);//下棋后的回合及数值变化
            Victory();//判断是否胜利
            Computer();
            Step(chess3, chess[1, 0], 1, 0);
        }

        private void chess4_Click(object sender, EventArgs e)
        {
            chess[1, 1] = round;//首先执行使棋盘该位置数值由0变为该回合下的棋子的数值
            Round(chess4);//下棋后的回合及数值变化
            Victory();//判断是否胜利
            Computer();
            Step(chess4, chess[1, 1], 1, 1);
        }

        private void chess5_Click(object sender, EventArgs e)
        {
            chess[1, 2] = round;//首先执行使棋盘该位置数值由0变为该回合下的棋子的数值
            Round(chess5);//下棋后的回合及数值变化
            Victory();//判断是否胜利
            Computer();
            Step(chess5, chess[1, 2], 1, 2);
        }

        private void chess6_Click(object sender, EventArgs e)
        {
            chess[2, 0] = round;//首先执行使棋盘该位置数值由0变为该回合下的棋子的数值
            Round(chess6);//下棋后的回合及数值变化
            Victory();//判断是否胜利
            Computer();
            Step(chess6, chess[2, 0], 2, 0);
        }

        private void chess7_Click(object sender, EventArgs e)
        {
            chess[2, 1] = round;//首先执行使棋盘该位置数值由0变为该回合下的棋子的数值
            Round(chess7);//下棋后的回合及数值变化
            Victory();//判断是否胜利
            Computer();
            Step(chess7, chess[2, 1], 2, 1);
        }

        private void chess8_Click(object sender, EventArgs e)
        {
            chess[2, 2] = round;//首先执行使棋盘该位置数值由0变为该回合下的棋子的数值
            Round(chess8);//下棋后的回合及数值变化
            Victory();//判断是否胜利
            Computer();
            Step(chess8, chess[2, 2], 2, 2);
        }
        #endregion
        //是否是人机对战
        private bool computer = false;
        private void computerGame_Click(object sender, EventArgs e)//人机对战
        {
            gameArea.Enabled = true;
            //玩家对战不可见
            playerGame.Visible = false;
            computerGame.Enabled = false;
            //悔棋不可见可见
            retract.Visible = false;
            moveRound.Text = "圆圈方回合";
            computer = true;
        }
        private void Computer()//人机下棋
        {
            //人机回合为叉叉方回合
            if (computer && round == 2)
            {
                ComputerLogic();
            }
        }
        private void ComputerLogic()//人机逻辑
        {
            Button[,] chesses = new Button[3, 3] { { chess0, chess1, chess2 }, { chess3, chess4, chess5 }, { chess6, chess7, chess8 } };
            Random random = new Random();
            //随机确定下在棋盘的位置
            int randomChessi = random.Next(3);
            int randomChessj = random.Next(3);
            if (chess[randomChessi, randomChessj] == 0 && chess[randomChessi, randomChessj] != 1 && chess[randomChessi, randomChessj] != 2)
            {
                chess[randomChessi, randomChessj] = round;//首先执行使棋盘该位置数值由0变为该回合下的棋子的数值
                Round(chesses[randomChessi, randomChessj]);//下棋后的回合及数值变化
                Victory();//判断是否胜利
            }
            else
            {
                ComputerLogic();
            }
        }
        //对局的每一步
        Button[] chessStep = new Button[9];
        int[] chessStepRound = new int[9];
        int[] chessStepi = new int[9];
        int[] chessStepj = new int[9];
        int step = 0;
        //记录对局中的每一步
        private void Step(Button button,int chess,int i , int j)
        {
            //将下的棋记录
            chessStep[step] = button;
            chessStepRound[step] = chess;
            //记录是棋盘上的哪一个位置（哪一行，哪一列）
            chessStepi[step] = i;
            chessStepj[step] = j;
            //预备下一步
            step++;
        }
        private void retract_Click(object sender, EventArgs e)//悔棋
        {
            if(step <= 0)//防止悔棋过度报错
            {
                MessageBox.Show("已经是第一步了！");
                step = 0;
            }
            else
            {
                //回到上一步
                step--;
                //棋盘可用
                chessStep[step].Enabled = true;
                chessStep[step].Text = "?";
                round = chessStepRound[step];
                switch (round)
                {
                    case 1:
                        moveRound.Text = "圆圈方回合";
                    break;
                    case 2:
                        moveRound.Text = "叉叉方回合";
                    break;
                }
                chess[chessStepi[step], chessStepj[step]] = 0;
            }
        }
    }
}
