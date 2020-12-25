using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeventhLessonTaskTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            gameControl.InfoEvent += GameControl_InfoEvent;
            gameControl.WinEvent += GameControl_WinEvent;
            gameControl.ErrorStr += GameControl_ErrorStr;
            randomNumber.GenerateNumber += RandomNumber_GenerateNumber;

        }

        private void GameControl_ErrorStr(object sender, EventArgs e)
        {
            MessageBox.Show("Ошибка", "Неккоректное число", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RandomNumber_GenerateNumber(object sender, NumberGenerate e)
        {
            MessageBox.Show("Информация", "Число сгенерировано", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GameControl_WinEvent(object sender, CounterEventArgs e)
        {
            MessageBox.Show("Победа", $"Вы победили за {e.Counter} попыток", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GameControl_InfoEvent(object sender, InfoEventArgs e)
        {
            MessageBox.Show("Информация", e.Str, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
