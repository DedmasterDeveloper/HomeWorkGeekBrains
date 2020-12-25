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
    

    public partial class RandomNumber : UserControl
    {
        public event EventHandler<NumberGenerate> GenerateNumber;

        public RandomNumber()
        {
            InitializeComponent();
        }

        private static Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            int hiddenNumber = random.Next(0, 100);
            GenerateNumber.Invoke(sender, new NumberGenerate(hiddenNumber));
        }
    }

    public class NumberGenerate : EventArgs
    {
        public int Number { get; set; }

        public NumberGenerate() { }

        public NumberGenerate(int number)
        {
            Number = number;
        }
    }

}
