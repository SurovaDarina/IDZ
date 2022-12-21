using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Планировка_магазина1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //инициалиация компонентов
        }
        PictureBox pct; //объявление PictureBox
        public int sch = 0; //заводим счетчик для того, чтобы была возможность создавать несколько элементов
        private void button1_Click(object sender, EventArgs e) //обработка кнопки кассы
        {
            pct = new PictureBox();
            pct.Height = 119; // параметры элемента
            pct.Width = 128;
            pct.Name = "pct" + sch;
            pct.Left = 20 + sch * 110; //координаты появления элемента
            pct.Top = 30;
            pct.Image = Properties.Resources.kassa; //прикрепляем картинку к PictureBox
            panel1.Controls.Add(pct); //добавляем элемент на панель
            sch += 1;
            pct.MouseUp += pct_MouseUp; //ссылки на события
            pct.MouseDown += pct_MouseDown;
            pct.MouseMove += pct_MouseMove;
        }
        //реализация движения объектов
        private bool Dragging1;
        private int xPos1; //координаты элемента
        private int yPos1;

        private void pct_MouseUp(object sender, MouseEventArgs e) //если элемент не выбран
        {
            Dragging1 = false;
        }

        private void pct_MouseDown(object sender, MouseEventArgs e) //добавление элемента
        {

            if (e.Button == MouseButtons.Left) //если нажатa левая кнока мыши
            {
                Dragging1 = true;
                xPos1 = e.X;
                yPos1 = e.Y;
            }
        }

        private void pct_MouseMove(object sender, MouseEventArgs e) // перенесение элемента по схеме
        {
            Control c = sender as Control;
            if (Dragging1 && c != null)
            {
                c.Top = e.Y + c.Top - yPos1;
                c.Left = e.X + c.Left - xPos1;
            }
        }

        PictureBox pictureBox1; //объявление PictureBox1
        public int sch1 = 0;//заводим счетчик для того, чтобы была возможность создавать несколько элементов
        private void button3_Click(object sender, EventArgs e) //обработка кнопки холодильника
        {
            pictureBox1 = new PictureBox();
            pictureBox1.Height = 200; //параметры элемента
            pictureBox1.Width = 85;
            pictureBox1.Name = "pictureBox1" + sch1;
            pictureBox1.Left = 20 + sch1 * 110; //координаты появления элемента
            pictureBox1.Top = 30;
            pictureBox1.Image = Properties.Resources.holod;//прикрепляем картинку к PictureBox1
            panel1.Controls.Add(pictureBox1); //добавляем элемент на панель
            sch1 += 1;
            pictureBox1.MouseUp += pictureBox1_MouseUp_1; //ссылки на события
            pictureBox1.MouseDown += pictureBox1_MouseDown_1;
            pictureBox1.MouseMove += pictureBox1_MouseMove_1;
        }
        //реализация движения элемента
        private bool Dragging;
        private int xPos;
        private int yPos;

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e) //если элемент не выбран
        {
            Dragging = false;
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e) //добавление элемента
        {
            if (e.Button == MouseButtons.Left) //если мы нажимием на левую кнопку мыши
            {
                Dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }
        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e) //перемещение элемента
        {
            Control c = sender as Control;
            if (Dragging && c != null)
            {
                c.Top = e.Y + c.Top - yPos;
                c.Left = e.X + c.Left - xPos;
            }
        }

        PictureBox pictureBox2; //объявление PictureBox2
        public int sch2 = 0;//заводим счетчик для того, чтобы была возможность создавать несколько элементов
        private void button4_Click(object sender, EventArgs e) //обработка кнопки 4
        {
            pictureBox2 = new PictureBox();
            pictureBox2.Height = 120; //параметры элемента
            pictureBox2.Width = 120;
            pictureBox2.Name = "pictureBox2" + sch2;
            pictureBox2.Left = 20 + sch2 * 110; //координаты появления элемента
            pictureBox2.Top = 30;
            pictureBox2.Image = Properties.Resources.showcase1; //прикрепляем картинку к PictureBox2
            panel1.Controls.Add(pictureBox2);//добавляем элемент на панель
            sch2 += 1;
            pictureBox2.MouseUp += pictureBox2_MouseUp_2; //ссылки на события
            pictureBox2.MouseDown += pictureBox2_MouseDown_2;
            pictureBox2.MouseMove += pictureBox2_MouseMove_2;
        }
        //реализация движения элемента
        private bool Dragging2;
        private int xPos2;
        private int yPos2;

        private void pictureBox2_MouseUp_2(object sender, MouseEventArgs e)//если элемент не выбран
        {
            Dragging2 = false;
        }
        private void pictureBox2_MouseDown_2(object sender, MouseEventArgs e)//добавление элемента
        {

            if (e.Button == MouseButtons.Left)
            {
                Dragging2 = true;
                xPos2 = e.X;
                yPos2 = e.Y;
            }
        }

        private void pictureBox2_MouseMove_2(object sender, MouseEventArgs e)//перемещение элемента
        {
            Control c = sender as Control;
            if (Dragging2 && c != null)
            {
                c.Top = e.Y + c.Top - yPos2;
                c.Left = e.X + c.Left - xPos2;
            }
        }

        PictureBox pictureBox3;//объявление PictureBox1
        public int sch3 = 0;//заводим счетчик для того, чтобы была возможность создавать несколько элементов

        private void button2_Click(object sender, EventArgs e)//обработка кнопки 2
        {
            pictureBox3 = new PictureBox();
            pictureBox3.Height = 120;//параметры элемента
            pictureBox3.Width = 120;
            pictureBox3.Name = "pictureBox3" + sch3;
            pictureBox3.Left = 20 + sch3 * 110; //координаты появления элемента
            pictureBox3.Top = 30;
            pictureBox3.Image = Properties.Resources.showcase3; //прикрепляем картинку к PictureBox
            panel1.Controls.Add(pictureBox3); //добавление элемента на панель
            sch3 += 1;
            pictureBox3.MouseUp += pictureBox3_MouseUp_3; //ссылки на события
            pictureBox3.MouseDown += pictureBox3_MouseDown_3;
            pictureBox3.MouseMove += pictureBox3_MouseMove_3;
        }
        //реализация перемещения элемента
        private bool Dragging3;
        private int xPos3;
        private int yPos3;

        private void pictureBox3_MouseUp_3(object sender, MouseEventArgs e) //если элемент не выбран
        {
            Dragging3 = false;
        }

        private void pictureBox3_MouseDown_3(object sender, MouseEventArgs e) //добавление элемента
        {

            if (e.Button == MouseButtons.Left)
            {
                Dragging3 = true;
                xPos3 = e.X;
                yPos3 = e.Y;
            }
        }

        private void pictureBox3_MouseMove_3(object sender, MouseEventArgs e)//перемещение элемента
        {
            Control c = sender as Control;
            if (Dragging3 && c != null)
            {
                c.Top = e.Y + c.Top - yPos3;
                c.Left = e.X + c.Left - xPos3;
            }
        }
        //реализация кнопок удаления элементов
        private void button5_Click(object sender, EventArgs e)
        {
            pct.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Dispose();
            sch1 = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Dispose();
            sch2 = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox3.Dispose();
            sch3 = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
