using System;
using System.Windows.Forms;
using RoadMapApp.Controller;
using RoadMapApp.Services;
using RoadMapApp.Repositories;
using RoadMapApp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RoadMapApp.View
{
    public partial class MainForm : Form
    {
        private readonly RoadMapController _controller;
        bool flag = false;

        public MainForm()
        {
            InitializeComponent();
            var rulesRepository = new RulesRepository();
            var userService = new UserService(rulesRepository);
            _controller = new RoadMapController(userService);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxGoal.Items.AddRange(new string[] {
                "Отметка в качестве участника Государственной программы переселения соотечественников",
                "Компенсация расходов по найму жилья",
                "Меры государственной поддержки"
            });

            dateTimePickerRegistrationDate.Enabled = false;
        }

        private void comboBoxGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelGoal.Text = "Цель въезда: ";
        }

        private void dateTimePickerRegistrationDate_ValueChanged(object sender, EventArgs e)
        {
            flag = true;
            labelRegistrationDate.Text = "Дата постановки на учет: " + dateTimePickerRegistrationDate.Value.ToShortDateString();

        }

        private void buttonForm_Click(object sender, EventArgs e)
        {
            if (flag == false) 
            {
                if (comboBoxGoal.Text == "Компенсация расходов по найму жилья")
                    MessageBox.Show("Перед тем как получить компенсации расходов по найму жилья вам необходимо прибыть для постановки на учет в качестве участника Государственной программы в Управление по вопросам миграции МВД России (предварительно записаться)");
                else if (comboBoxGoal.Text == "Отметка в качестве участника Государственной программы переселения соотечественников")
                    MessageBox.Show("Вам необходимо прибыть для постановки на учет в качестве участника Государственной программы в Управление по вопросам миграции МВД России (предварительно записаться)");
                else if (comboBoxGoal.Text == "Меры государственной поддержки")
                    MessageBox.Show("Перед тем как получить меры государственной поддержки вам необходимо прибыть для постановки на учет в качестве участника Государственной программы в Управление по вопросам миграции МВД России (предварительно записаться)");
            }
            else
            {
                var user = new User
                {
                    Goal = comboBoxGoal.SelectedItem.ToString(),
                    RegistrationDate = dateTimePickerRegistrationDate.Value
                };

                string instructions = GetInstructions(user);
                textBoxInstructions.Text = instructions;
            }
        }

        private string GetInstructions(User user)
        {
            switch (user.Goal)
            {
                case "Отметка в качестве участника Государственной программы переселения соотечественников":
                    return "Вам необходимо прибыть для постановки на учет в качестве участника Государственной программы в Управление по вопросам миграции МВД России (предварительно записаться).";
                case "Меры государственной поддержки":
                    return "Вам необходимо обратиться в Управление по вопросам миграции МВД России (предварительно записаться).";
                case "Компенсация расходов по найму жилья":
                    return "Для получения компенсации расходов по найму жилья, Вам необходимо предоставить документы, подтверждающие ваши расходы на аренду жилья, и обратиться центр занятости населения по месту пребывания.";
                default:
                    return "Инструкции не найдены.";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox1.CheckState)
            {
                case CheckState.Checked:
                    dateTimePickerRegistrationDate.Enabled = true;
                    break;
                case CheckState.Unchecked:
                    dateTimePickerRegistrationDate.Enabled = false;
                    break;
            }
        }

        private void labelGoal_Click(object sender, EventArgs e)
        {

        }

        private void labelRegistrationDate_Click(object sender, EventArgs e)
        {

        }
    }
}