using System;
using System.Collections.Generic;
using System.Text;

namespace _010720.School
{
    class Teacher
    {
        public string Fullname { get; set; }

        private TeacherClassHour[] Lessons;

        private double _salary;
        public double Salary {
            get
            {
                CalcSalary();
                return this._salary;
            }
        }

        public Teacher(string fullname)
        {
            this.Fullname = fullname;

            this.Lessons = new TeacherClassHour[0];
        }

        public void AddLesson(int Class,int Hour)
        {
            if (Class < 1 || Class > 11) throw new ArgumentOutOfRangeException("Class");

            Array.Resize(ref this.Lessons, this.Lessons.Length + 1);

            this.Lessons[this.Lessons.Length - 1] = new TeacherClassHour
            {
                Class = Class,
                Hour = Hour
            };
        }

        public void RemoveLesson(int index)
        {
            if (index < 0 || index > this.Lessons.Length - 1) throw new IndexOutOfRangeException();

            for (int i = index; i < this.Lessons.Length-1; i++)
            {
                this.Lessons[i] = this.Lessons[i + 1];
            }

            Array.Resize(ref this.Lessons, this.Lessons.Length - 1);
        }

        private void CalcSalary()
        {
            double total = 0;

            foreach (TeacherClassHour lesson in this.Lessons)
            {
                if(lesson.Class>=1 && lesson.Class <= 4)
                {
                    total += lesson.Hour * 10;
                }
                else if(lesson.Class>=5 && lesson.Class <= 9)
                {
                    total += lesson.Hour * 15;
                }
                else
                {
                    total += lesson.Hour * 20;
                }
            }

            this._salary = total;
        }
    }


    class TeacherClassHour
    {
        public int Class { get; set; }

        public int Hour { get; set; }

        public override string ToString()
        {
            return this.Class+" "+this.Hour;
        }
    }
}
