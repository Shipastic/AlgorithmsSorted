using System;
using System.Windows.Forms;
using AlgorithmsBase;

namespace SortAlgoritms
{
    public partial class Form1 : Form
    {
        AlgorithmBase<int> algorithms = new BubbleSort<int>();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// добавляет элементы в коллекцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //добавляем значения в коллекцию
            if (int.TryParse(textBox1.Text, out int value))
            {
                algorithms.Items.Add(value);
                label1.Text += " " + value;
            }
        }

        /// <summary>
        /// Выводит отсортированную коллекцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //сортируем коллекцию
            algorithms.Sort();
            // выводим отсортированные элементы в label2
            foreach (var item in algorithms.Items)
            {
                label2.Text += " " + item; 
            }
        }
    }
}
