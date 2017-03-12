using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class fMessage : Form
    {
        public int timeAnswer; // копия переменной сколько дается на ответ
        public fMessage()
        {
            InitializeComponent();
            timeAnswer = Victorina.timeForAnswer;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeAnswer--;
            label_time.Text = timeAnswer.ToString();
            if (timeAnswer == 0)
            {
                timer.Stop();
            }
        }

        private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }

        private void label_showAnswer_Click(object sender, EventArgs e) // если кликаем по label Melody получаем название данной мелодии
        {
            label_showAnswer.Text = Victorina.answer;
        }
    }
}
