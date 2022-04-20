using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Headcheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void myButton_Click(object sender, EventArgs e)
        {
            Button myButton = sender as Button;
            myButton.Text = "clicked";
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox myCheckBox = sender as CheckBox;
            myCheckBox.Text = "funktioniert";
        }

        public void control_of_UI(int zx, int zy, EventArgs e)
        {
            //verändern wenn zx ungleich 0
            if (zx != 0)
            {
                //auswählen mit zy s.u.
                switch (zy)
                {
                    case 0:
                        object sender1 = myButton;
                        //RoutedEventArgs e = null;
                        myButton_Click(sender1, e);
                        break;
                    case 1:
                        object sender2 = button1;
                        //RoutedEventArgs f = null;
                        button1_Click(sender2, e);
                        break;
                    case 2:
                        object sender3 = button2;
                        //RoutedEventArgs g = null;
                        button2_Click(sender3, e);
                        break;
                    case 3:
                        object sender4 = checkBox1;
                        //RoutedEventArgs h = null;
                        checkBox1_CheckedChanged(sender4, e);
                        checkBox1.Checked = true;
                        break;
                    default:
                        //...button müßen hier angefügt werden
                        break;

                }
                // 0 --> Stop Knopf wird gedrückt
                // 1 --> Start Knopf wird gedrückt
                // 2 --> MyButton wird gedrückt
                // 3 --> Checkbox wird gecheckt/nicht
                // default --> noch offen
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            button1.Text = "started";
            control_of_UI(1, 3, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button2 = sender as Button;
            button2.Text = "stopped";
        }
    }
}
