using _210720.Data;
using _210720.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _210720.Windows
{
    /// <summary>
    /// Interaction logic for StudentsWindow.xaml
    /// </summary>
    public partial class StudentsWindow : Window
    {
        private readonly SchoolContext _context;
        private Student _selectedStudent;

        public StudentsWindow()
        {
            InitializeComponent();
            _context = new SchoolContext();

            FillGroups();

            FillStudents();
        }


        private void FillGroups()
        {
            CmbGroups.ItemsSource = _context.Groups.ToList();
        }

        private void FillStudents()
        {
            DgvStudents.ItemsSource = _context.Students.ToList();
        }

        private void Reset()
        {
            TxtName.Clear();
            TxtSurname.Clear();
            CmbGroups.SelectedItem = null;
            DtpBirthday.SelectedDate = null;

            BtnCreate.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;

            FillStudents();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("* olan yerleri doldurmalısınız");
                return;
            }

            Student student = new Student
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                GroupId = (int)CmbGroups.SelectedValue,
                Birthday = (DateTime)DtpBirthday.SelectedDate
            };

            _context.Students.Add(student);

            _context.SaveChanges();

            Reset();

            MessageBox.Show("Tələbə əlavə olundu");
        }

        private void DgvStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvStudents.SelectedItem == null) return;

            _selectedStudent = (Student)DgvStudents.SelectedItem;

            TxtName.Text = _selectedStudent.Name;
            TxtSurname.Text = _selectedStudent.Surname;
            CmbGroups.SelectedValue = _selectedStudent.GroupId;
            DtpBirthday.SelectedDate = _selectedStudent.Birthday;

            BtnCreate.Visibility = Visibility.Hidden;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("* olan yerleri doldurmalısınız");
                return;
            }

            _selectedStudent.Name = TxtName.Text;
            _selectedStudent.Surname = TxtSurname.Text;
            _selectedStudent.GroupId = (int)CmbGroups.SelectedValue;
            _selectedStudent.Birthday = (DateTime)DtpBirthday.SelectedDate;

            _context.SaveChanges();

            Reset();

            MessageBox.Show("Tələbə yeniləndi");
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Silməyə əminsiniz mi?", _selectedStudent.ToString(), MessageBoxButton.OKCancel);

            if (r == MessageBoxResult.OK)
            {
                _context.Students.Remove(_selectedStudent);
                _context.SaveChanges();

                Reset();

                MessageBox.Show("Tələbə silindi");
            }
        }

        private bool FormValidation()
        {
            bool hasError = false;

            if (string.IsNullOrEmpty(TxtName.Text))
            {
                LblName.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblName.Foreground = new SolidColorBrush(Colors.Black);
            }

            if (string.IsNullOrEmpty(TxtSurname.Text))
            {
                LblSurname.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblSurname.Foreground = new SolidColorBrush(Colors.Black);
            }

            if (CmbGroups.SelectedItem == null)
            {
                LblGroup.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblGroup.Foreground = new SolidColorBrush(Colors.Black);
            }

            if (DtpBirthday.SelectedDate == null)
            {
                LblBirthday.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                LblBirthday.Foreground = new SolidColorBrush(Colors.Black);
            }

            return hasError;
        }
    }
}
