using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AlgorithmsBase;

namespace SortAlgoritms
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();
        public Form1()
        {
            InitializeComponent();
        }
        private void ButAdd_Click(object sender, EventArgs e)
        {
            //добавляем значения в коллекцию
            if (int.TryParse(textBoxAdd.Text, out int value))
            {
                var item = new SortedItem(value);
                items.Add(item);
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }
           //очищаем текстовое поле
            textBoxAdd.Text = "";
        }

        private void ButFill_Click(object sender, EventArgs e)
        {
          //заполняем коллекцию необходимым количеством случайных элементов
            if (int.TryParse(textBoxFill.Text, out int value))
            {
                var rnd = new Random();
                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next());
                    items.Add(item);
                    panel3.Controls.Add(item.ProgressBar);
                    panel3.Controls.Add(item.Label);
                }
            }
            //очищаем текстовое поле
            textBoxFill.Text = "";
        }
    }
}
