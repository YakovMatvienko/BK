using System;
using System.Windows.Forms;

namespace BK
{
    public partial class Form_Game : Form
    {
        private static Random randomGenerator;
        private static int roundCount;
        private static bool isPlayerTurn;
        private static bool isFullRound;
        private static Actor player;
        private static Actor opponent;

        public Form_Game()
        {
            InitializeComponent();
            panel_Menu.Show();
            panel_Game.Hide();
            panel_FinalScreen.Hide();
            panel_InputName.Hide();
        }

        private void Initialize(string name)
        {
            randomGenerator = new Random((int)DateTime.UtcNow.Ticks);
            player = new Actor(name);
            opponent = new Actor("Противник");
            richTextBox_FightLog.Text = "";
            roundCount = 1;
            label_Round.Text = "Раунд " + roundCount;
            label_Player.Text = player.Name;
            label_Opponent.Text = opponent.Name;
            progressBar_Opponent.Value = opponent.HP;
            progressBar_Player.Value = player.HP;
            label_OpponentHP.Text = opponent.HP.ToString();
            label_PlayerHP.Text = player.HP.ToString();
            player.Block += BlockEvent;
            player.Wound += WoundEvent;
            player.Death += DeathEvent;
            opponent.Block += BlockEvent;
            opponent.Wound += WoundEvent;
            opponent.Death += DeathEvent;
        }

        private void Attack(Actor attacker, Actor defender)
        {
            if (isFullRound == isPlayerTurn)
            {
                roundCount++;
                label_Round.Text = "Раунд " + roundCount;
            }
            BodyComponents attackedPart = BodyComponents.NONE;
            Array bodyParts = Enum.GetValues(typeof(BodyComponents));
            if (attacker.Name == "Противник")
            {
                attackedPart = (BodyComponents)bodyParts.GetValue(randomGenerator.Next(1, 3));
                if (radioButton_Head.Checked)
                {
                    defender.SetBlock(BodyComponents.HEAD);
                }
                if (radioButton_Body.Checked)
                {
                    defender.SetBlock(BodyComponents.BODY);
                }
                if (radioButton_Legs.Checked)
                {
                    defender.SetBlock(BodyComponents.LEGS);
                }
            }
            else
            {
                if (radioButton_Head.Checked)
                {
                    attackedPart = BodyComponents.HEAD;
                }
                if (radioButton_Body.Checked)
                {
                    attackedPart = BodyComponents.BODY;
                }
                if (radioButton_Legs.Checked)
                {
                    attackedPart = BodyComponents.LEGS;
                }
                defender.SetBlock((BodyComponents)bodyParts.GetValue(randomGenerator.Next(1, 3)));
            }
            isPlayerTurn = !isPlayerTurn;

            CombatEventArgs e = new CombatEventArgs(defender, attackedPart, 0, randomGenerator);
            defender.TryBlock(attackedPart, e);
        }

        private string GetBodyPartString(BodyComponents component)
        {
            if ((component & BodyComponents.HEAD) != 0)
            {
                return "голову";
            }
            if ((component & BodyComponents.BODY) != 0)
            {
                return "тело";
            }
            if ((component & BodyComponents.LEGS) != 0)
            {
                return "ноги";
            }
            return "Ничего";
        }
        private void FinishGame()
        {
            player.Block -= BlockEvent;
            player.Wound -= WoundEvent;
            player.Death -= DeathEvent;
            opponent.Block -= BlockEvent;
            opponent.Wound -= WoundEvent;
            opponent.Death -= DeathEvent;
            panel_Game.Hide();
            if (player.HP > opponent.HP)
            {
                label_Result.Text = "Поздравляю с победой в честной, насколько это возможно, схватке!";
            }
            else
            {
                label_Result.Text = "К сожалению, Вы не оказались столь же сильны или ловки.\nМожет, повезет в другой раз!";
            }
            panel_FinalScreen.Show();
        }

        private void BlockEvent(object sender, CombatEventArgs e)
        {
            richTextBox_FightLog.Text += e.actor.Name + " успешно отбил атаку\n";
        }
        private void DeathEvent(object sender, CombatEventArgs e)
        {
            richTextBox_FightLog.Text += e.actor.Name + " не выдержал удара и упал навзничь\n";
            FinishGame();
        }

        private void WoundEvent(object sender, CombatEventArgs e)
        {
            if (e.actor.Name != "Противник")
            {
                label_PlayerHP.Text = e.actor.HP.ToString();
                progressBar_Player.Value = e.actor.HP;
            }
            else
            {
                label_OpponentHP.Text = e.actor.HP.ToString();
                progressBar_Opponent.Value = e.actor.HP;
            }
            richTextBox_FightLog.Text += e.actor.Name + " решил защитить " + GetBodyPartString(e.actor.Blocked) + " вместо " + GetBodyPartString(e.attackedPart) + ", поэтому теперь у него " + e.currentHP + " здоровья\n";
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            panel_Menu.Hide();
            panel_InputName.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Action_Click(object sender, EventArgs e)
        {
            if (radioButton_Body.Checked || radioButton_Head.Checked || radioButton_Legs.Checked)
            {
                if (isPlayerTurn)
                {
                    label_AttDef.Text = "Защита";
                    Attack(player, opponent);
                }
                else
                {
                    label_AttDef.Text = "Атака";
                    Attack(opponent, player);
                }
            }
        }

        private void button_Restart_Click(object sender, EventArgs e)
        {
            panel_FinalScreen.Hide();
            Initialize(player.Name);
            panel_Game.Show();
        }

        private void button_ToMenu_Click(object sender, EventArgs e)
        {
            panel_FinalScreen.Hide();
            panel_Menu.Show();
        }

        private void button_PlayerName_Click(object sender, EventArgs e)
        {
            string name = textBox_PlayerName.Text;
            if (name != "Противник")
            {
                Initialize(name);
                panel_InputName.Hide();
                panel_Game.Show();
                if (randomGenerator.Next(1, 2) == 1)
                {
                    isPlayerTurn = true;
                    isFullRound = isPlayerTurn;
                    label_AttDef.Text = "Атака";
                    richTextBox_FightLog.Text += "Первым наносит удар " + player.Name + "\n";
                }
                else
                {
                    isPlayerTurn = false;
                    isFullRound = isPlayerTurn;
                    label_AttDef.Text = "Защита";
                    richTextBox_FightLog.Text += "Первым наносит удар противник\n";
                }
            }
        }
    }
}
