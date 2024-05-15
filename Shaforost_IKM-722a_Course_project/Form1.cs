using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaforost_IKM_722a_Course_project
{
    public partial class Form1 : Form
    {
        private bool Mode; // Режим дозволу / заборони введення даних
        private MajorWork MajorObject; // Створення об'єкта класу MajorWork

        public Form1()
        {
            InitializeComponent();
        }

        private void tClock_Tick(object sender, EventArgs e)
        {
            tClock.Stop();
            MessageBox.Show("Минуло 25 секунд", "Увага");// Виведення повідомлення "Минуло 25 секунд" на екран
            tClock.Start();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (Mode)
            {
                tbInput.Enabled = true;// Режим дозволу   введення
                tbInput.Focus();
                tClock.Start();
                bStart.Text = "Стоп"; // зміна тексту на кнопці на "Стоп"
                this.Mode = false;
            }
            else
            {

                MajorObject.Write(tbInput.Text);// Запис даних у об'єкт
                MajorObject.Task();// Обробка даних
                label1.Text = MajorObject.Read();// Відображення результату
                tClock.Stop();
                tbInput.Enabled = false;// Режим заборони введення
                bStart.Text = "Пуск";// зміна тексту на кнопці на "Пуск"
                this.Mode = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Mode = true;
            MajorObject = new MajorWork();
            About A = new About(); // створення форми About
            A.tAbout.Start();
            A.ShowDialog(); // відображення діалогового вікна About
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            tClock.Stop();
            tClock.Start();
            if ((e.KeyChar >= '0') & (e.KeyChar <= '9') | (e.KeyChar == (char)8))
            {
                return;
            }
            else
            {
                tClock.Stop();
                MessageBox.Show("Неправильний символ", "Помилка");
                tClock.Start();
                e.KeyChar = (char)0;
            }
        }
    }
}
