using System;
using System.Collections.Generic;
using System.Text;

namespace _170920
{
    class Student
    {
        public string Name{ get; set; }

        public string Surname { get; set; }

        private float _examResult;

        public float ExamResult
        {
            get
            {
                return this._examResult;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this._examResult = value;
                }
            }
        }

        private int _age;

        public int Age => this._age;


        public string Fullname()
        {
            return this.Name + " " + this.Surname;
        }

        private int Topla(int a,int b)
        {
            return a + b;
        }
    }
}
