using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatkTaskMeometryArea
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ObjectChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ObjectChoice.Text == "Треугольник")
            {
                Name1.Visible = true;
                Name2.Visible = true;
                Name3.Visible = false;
                Argument1.Visible = true;
                Argument2.Visible = true;
                Argument3.Visible = false;
                Name1.Text = "b";
                Name2.Text = "h";
            }
            if (ObjectChoice.Text == "Прямоугольник")
            {
                Name1.Visible = true;
                Name2.Visible = true;
                Name3.Visible = false;
                Argument1.Visible = true;
                Argument2.Visible = true;
                Argument3.Visible = false;
                Name1.Text = "a";
                Name2.Text = "b";
            }
            if (ObjectChoice.Text == "Ромб")
            {
                Name1.Visible = true;
                Name2.Visible = true;
                Name3.Visible = false;
                Argument1.Visible = true;
                Argument2.Visible = true;
                Argument3.Visible = false;
                Name1.Text = "d1";
                Name2.Text = "d2";
            }
            if (ObjectChoice.Text == "Параллелограмм")
            {
                Name1.Visible = true;
                Name2.Visible = true;
                Name3.Visible = false;
                Argument1.Visible = true;
                Argument2.Visible = true;
                Argument3.Visible = false;
                Name1.Text = "a";
                Name2.Text = "h";
            }
            if (ObjectChoice.Text == "Круг")
            {
                Name1.Visible = true;
                Name2.Visible = false;
                Name3.Visible = false;
                Argument1.Visible = true;
                Argument2.Visible = false;
                Argument3.Visible = false;
                Name1.Text = "R";
            }
            if (ObjectChoice.Text == "Трапеция")
            {
                Name1.Visible = true;
                Name2.Visible = true;
                Name3.Visible = true;
                Argument1.Visible = true;
                Argument2.Visible = true;
                Argument3.Visible = true;
                Name1.Text = "a";
                Name2.Text = "b";
                Name3.Text = "h";
            }
            if (ObjectChoice.Text == "Эллипс")
            {
                Name1.Visible = true;
                Name2.Visible = true;
                Name3.Visible = false;
                Argument1.Visible = true;
                Argument2.Visible = true;
                Argument3.Visible = false;
                Name1.Text = "r";
                Name2.Text = "R";
            }
            if (ObjectChoice.Text == "Выпуклый четырехугольник")
            {
                Name1.Visible = true;
                Name2.Visible = true;
                Name3.Visible = true;
                Argument1.Visible = true;
                Argument2.Visible = true;
                Argument3.Visible = true;
                Name1.Text = "d1";
                Name2.Text = "d2";
                Name3.Text = "sinφ";
            }
        }

        private void AreaSolution_Click(object sender, EventArgs e)
        {
            double x, y, z;
            string s;
            if (ObjectChoice.Text == "Треугольник")
            {
                x = Convert.ToDouble(Argument1.Text);
                y = Convert.ToDouble(Argument2.Text);
                s = Convert.ToString(0.5 * x * y);
                Solution.Text = s;
            }
            if (ObjectChoice.Text == "Прямоугольник")
            {
                x = Convert.ToDouble(Argument1.Text);
                y = Convert.ToDouble(Argument2.Text);
                s = Convert.ToString(x * y);
                Solution.Text = s;
            }
            if (ObjectChoice.Text == "Ромб")
            {
                x = Convert.ToDouble(Argument1.Text);
                y = Convert.ToDouble(Argument2.Text);
                s = Convert.ToString(0.5 * x * y);
                Solution.Text = s;
            }
            if (ObjectChoice.Text == "Параллелограмм")
            {
                x = Convert.ToDouble(Argument1.Text);
                y = Convert.ToDouble(Argument2.Text);
                s = Convert.ToString(x * y);
                Solution.Text = s;
            }
            if (ObjectChoice.Text == "Круг")
            {
                x = Convert.ToDouble(Argument1.Text);
                s = Convert.ToString(Math.PI * x * x);
                Solution.Text = s;
            }
            if (ObjectChoice.Text == "Трапеция")
            {
                x = Convert.ToDouble(Argument1.Text);
                y = Convert.ToDouble(Argument2.Text);
                z = Convert.ToDouble(Argument3.Text);
                s = Convert.ToString(0.5 * z * (x + y));
                Solution.Text = s;
            }
            if (ObjectChoice.Text == "Эллипс")
            {
                x = Convert.ToDouble(Argument1.Text);
                y = Convert.ToDouble(Argument2.Text);
                s = Convert.ToString(Math.PI * x * y);
                Solution.Text = s;
            }
            if (ObjectChoice.Text == "Выпуклый четырехугольник")
            {
                x = Convert.ToDouble(Argument1.Text);
                y = Convert.ToDouble(Argument2.Text);
                z = Convert.ToDouble(Argument3.Text);
                s = Convert.ToString(0.5 * x * y * z);
                Solution.Text = s;
            }
        }
    }
}
