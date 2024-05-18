using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaforost_IKM_722a_Course_project
{
    internal class MajorWork
    {
        private string Data; //вхідні дані
        private string Result; // Поле результату
        private System.DateTime TimeBegin; // час початку роботи програми
        private string SaveFileName;// ім’я файлу для запису
        private string OpenFileName;// ім’я файлу для читання

        public void Write(string D)
        {
            this.Data = D;
        }

        public string Read()
        {
            return this.Result;// метод відображення результату
        }

        public void Task()
        {
            if (this.Data.Length > 5)
            {
                this.Result = Convert.ToString(true);

            }
            else
            {
                this.Result = Convert.ToString(false);
            }
        }

        public void SetTime() // метод запису часу початку роботи програми
        {
            this.TimeBegin = System.DateTime.Now;
        }

        public System.DateTime GetTime() // Метод отримання часу завершення програми
        {
            return this.TimeBegin;
        }

        
        public void WriteSaveFileName(string S)// метод запису даних в об'єкт
        {
            this.SaveFileName = S;// запам'ятати ім’я файлу для запису
        }
        public void WriteOpenFileName(string S)
        {
            this.OpenFileName = S;// запам'ятати ім’я файлу для відкриття
        }

    }
}
