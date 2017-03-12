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
    public partial class fGame : Form
    {
        private Random rnd;
        private int musicDuration;
        public fGame()
        {
            InitializeComponent();
            rnd = new Random();
            progressBar.Maximum = Victorina.gameDuration; // инициализируем progressBar, Victorina.gameDuration - продолжительность игры
        }

        void MakeMusic()// процедура MakeMusic выбирает музыку из списка и проигрывает ее заданное время
        {
            if (Victorina.list.Count == 0)
            {
                EndGame();
            }
            else
            {
                musicDuration = Victorina.musicDuration; // копируем продолжительность игры в переменную musicDuration
                int n = rnd.Next(0, Victorina.list.Count - 1); // случайным образом выбираем мелодию  (Victorina.list.Count - 1    - чтоб не выйти за пределы списка)
                WMP.URL = Victorina.list[n];// запускаем мелодию с помощью проигрователя
                Victorina.answer = System.IO.Path.GetFileNameWithoutExtension(WMP.URL); // записываем название мелодии для определения правильности ответа
                Victorina.list.RemoveAt(n); // удаляем название мелодии из списка мелодий для игры
                label_melodyCounter.Text = Victorina.list.Count.ToString(); // обновляем количество оставших мелодий 
            }
        }

        void GamePause()
        {
            timer.Stop();
            WMP.CtlControls.stop();
        }

        void GamePlay()
        {
            timer.Start();
            WMP.CtlControls.play();
        }

        void EndGame()
        {
            WMP.CtlControls.stop();
            timer.Stop();
        }

        private void button_nextMelody_Click(object sender, EventArgs e)
        {
            MakeMusic();
            timer.Start();
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            GamePause();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            label_melodyCounter.Text = Victorina.list.Count.ToString(); // загружаем количество мелодий из папки мелодий 
            progressBar.Value = 0; // обнуляем progressBar
            progressBar.Maximum = Victorina.gameDuration; // задаем максимальное значение, исходя из продолжительности игры
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value++;
            musicDuration--;

            if (progressBar.Value == progressBar.Maximum)
            {
                EndGame();
                return;
            }
            if (musicDuration == 0) // если время проигрывания одной елодии истекло, рандомно выбираем следующую мелодию
            {
                MakeMusic();
            }
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e) // когда на клавеатуре нажимаем на любую кнопку, при этом окно программы должно быть активным
        {
            if (e.KeyData == Keys.A)
            {
                if (timer.Enabled == false)
                {
                    return;
                }

                GamePause();
                fMessage fm = new fMessage();
                fm.label_player.Text = "Player 1";
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    label_firstPlayer.Text = Convert.ToString(Convert.ToInt32(label_firstPlayer.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
            if (e.KeyData == Keys.P)
            {
                if (timer.Enabled == false)
                {
                    return;
                }
                GamePause();
                fMessage fm = new fMessage();
                fm.label_player.Text = "Player 2";
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    label_secondPlayer.Text = Convert.ToString(Convert.ToInt32(label_secondPlayer.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }
    }
}
