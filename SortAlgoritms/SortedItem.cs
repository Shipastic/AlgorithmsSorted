using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgoritms
{
    class SortedItem
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get; private set; }
        public Label Label { get; private set; }
        public int Value { get; set; }
        public SortedItem(int value)
        {
            Value = value;
            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label = new Label();
            // verticalProgressBar1
            // 
            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = System.Drawing.Color.Blue;
            ProgressBar.Location = new System.Drawing.Point(15, 12);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "verticalProgressBar1";
            ProgressBar.Size = new System.Drawing.Size(16, 120);
            ProgressBar.Step = 1;
            ProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ProgressBar.TabIndex = 0;
            ProgressBar.Value = Value;

            // label3
            // 
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(12, 135);
            Label.Name = "label3";
            Label.Size = new System.Drawing.Size(19, 13);
            Label.TabIndex = 2;
            Label.Text = Value.ToString();
        }
    }
}
