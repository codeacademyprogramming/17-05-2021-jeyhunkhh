using _160720.Models;
using _160720.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _160720.Windows
{
    public partial class StudentsWindow : Window
    {
        private readonly GroupService _groupService;
        private readonly StudentService _studentService;
        private Student _selectedStudent;
        public StudentsWindow()
        {
            InitializeComponent();

            _groupService = new GroupService();
            _studentService = new StudentService();


            FillGroups();
            FillStudents();
        }

        private void FillStudents()
        {
            DgvStudents.ItemsSource = _studentService.GetStudents();
        }
        private void FillGroups()
        {
            CmbGroups.ItemsSource = _groupService.GetGroups();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                GroupId = (int)CmbGroups.SelectedValue,
                Birthday = (DateTime)DtpBirthday.SelectedDate
            };

            _studentService.Insert(student);

            ResetForm();

            MessageBox.Show("Tələbə əlavə olundu");
        }

        private void ResetForm()
        {
            TxtName.Clear();
            TxtSurname.Clear();
            CmbGroups.SelectedItem = null;
            DtpBirthday.SelectedDate = null;

            BtnCreate.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;

            FillStudents();

            _selectedStudent = null;
        }

        private void DgvStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvStudents.SelectedItem == null) return;

            _selectedStudent = (Student)DgvStudents.SelectedItem;

            BtnCreate.Visibility = Visibility.Hidden;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;

            TxtName.Text = _selectedStudent.Name;
            TxtSurname.Text = _selectedStudent.Surname;

            CmbGroups.SelectedValue = _selectedStudent.Group.Id;

            DtpBirthday.SelectedDate = _selectedStudent.Birthday;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            _selectedStudent.Name = TxtName.Text;
            _selectedStudent.Surname = TxtSurname.Text;
            _selectedStudent.GroupId = (int)CmbGroups.SelectedValue;
            _selectedStudent.Birthday = (DateTime)DtpBirthday.SelectedDate;

            _studentService.Update(_selectedStudent);

            ResetForm();

            MessageBox.Show("Tələbə yeniləndi");
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Silməyə əminsiniz mi?", "Silmə", MessageBoxButton.OKCancel);

            if (r == MessageBoxResult.OK)
            {
                _studentService.Delete(_selectedStudent.Id);

                ResetForm();

                MessageBox.Show("Tələbə silindi");
            }
        }
    }
}
