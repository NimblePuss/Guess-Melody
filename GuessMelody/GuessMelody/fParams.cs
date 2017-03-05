using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class fParams : Form
    {
        public fParams()
        {
            InitializeComponent();
        }

        void SetParams() //установка параметров по умолчанию (из реестра Widwows)
        {
            checkBox_useSubdirs.Checked = Victorina.allDirectories;

            comboBox_gameDuration.Text = Victorina.gameDuration.ToString();
            comboBox_musicDuration.Text = Victorina.musicDuration.ToString();
            comboBox_timeForAnswer.Text = Victorina.timeForAnswer.ToString();
        }



        private void button_OK_Click_1(object sender, EventArgs e)
        {
            Victorina.allDirectories = checkBox_useSubdirs.Checked;
            Victorina.gameDuration = Convert.ToInt32(comboBox_gameDuration.Text);
            Victorina.musicDuration = Convert.ToInt32(comboBox_musicDuration.Text);
            Victorina.timeForAnswer = Convert.ToInt32(comboBox_timeForAnswer.Text);
            Victorina.WriteParams(); // сохраняем параметры в реестр

            this.Hide(); // крываем окно, при этом сохранив все настройки
        }

        private void button_Cancel_Click_1(object sender, EventArgs e)
        {
            SetParams();

            this.Hide();
        }

        private void button_selectFolder_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog(); // класс типа OpenFileDialog, только выбирает папку

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                // fbd.SelectedPath - путь к папке,
                // "*.mp3" - формат
                // checkBox_useSubdirs.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly  - выбор папки верхнего уровня для поиска файлов или полный рекурсивный перебор папок
                string[] music_list = System.IO.Directory.GetFiles(fbd.SelectedPath, "*.mp3",
                    checkBox_useSubdirs.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                Victorina.lastFoder = fbd.SelectedPath;  // выбранный путь сохраняем в lastFoder статического класса Victorina, в котором у нас хранятся все настройки

                listBox_music.Items.Clear();
                listBox_music.Items.AddRange(music_list); // загружаем новые файлы
                Victorina.list.Clear();
                Victorina.list.AddRange(music_list);  // загружаем новые файлы

            }

        }

        private void fParams_Load(object sender, EventArgs e) // обработчик окна вызывается при загрузке основного окна
        {
            SetParams();
            listBox_music.Items.Clear();
            listBox_music.Items.AddRange(Victorina.list.ToArray());

        }
    }
}
