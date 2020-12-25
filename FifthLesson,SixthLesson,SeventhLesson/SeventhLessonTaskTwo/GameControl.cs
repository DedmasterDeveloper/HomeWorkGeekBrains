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

    

    public partial class GameControl : UserControl
    {
        public event EventHandler<CounterEventArgs> WinEvent;
        public event EventHandler<InfoEventArgs> InfoEvent;
        public event EventHandler ErrorStr;

        public int Counter { get; set; } = 0;

        private static Random random = new Random();

        private int hiddenNumber = 0;

        public GameControl()
        {
            InitializeComponent();

            randomNumber.GenerateNumber += RandomNumber_GenerateNumber;
        }

        private void RandomNumber_GenerateNumber(object sender, NumberGenerate e)
        {
            hiddenNumber = e.Number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userAnswer = new int();
            if (!int.TryParse(textBox1.Text, out userAnswer))
                ErrorStr.Invoke(sender, new EventArgs());
            if(userAnswer == hiddenNumber)
            {
                WinEvent.Invoke(sender, new CounterEventArgs(Counter));
            }
            else
            {
                Counter++;
                if (hiddenNumber > userAnswer)
                {
                    InfoEvent.Invoke(sender, new InfoEventArgs("Загаданное число больше больше вашего"));
                }
                else if(hiddenNumber < userAnswer)
                {
                    InfoEvent.Invoke(sender, new InfoEventArgs("Загаданное число меньше вашего"));
                }
            }
        }
    }

    public class CounterEventArgs : EventArgs
    {
        public int Counter { get; set; }

        public CounterEventArgs() { }

        public CounterEventArgs(int counter)
        {
            Counter = counter;
        }
    }

    public class InfoEventArgs : EventArgs
    {
        public string Str { get; set; }

        public InfoEventArgs() { }

        public InfoEventArgs(string info)
        {
            Str = info;
        }
    }





}
