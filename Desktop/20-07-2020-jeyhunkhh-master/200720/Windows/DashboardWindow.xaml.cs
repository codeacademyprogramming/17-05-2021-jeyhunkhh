using _200720.Data;
using _200720.Models;
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

namespace _200720.Windows
{
    public partial class DashboardWindow : Window
    {
        private readonly HotelContext _context;
        public DashboardWindow()
        {
            InitializeComponent();
            _context = new HotelContext();
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            // Insert

            //Room room = new Room
            //{
            //    No = "101",
            //    Name = "Deluxe Suit",
            //    DailyPrice = 40
            //};

            //_context.Rooms.Add(room);

            //User user = new User
            //{
            //    Fullname = "Yolchu Nasib",
            //    IdNumber = "12312",
            //    PhoneNumber = "0556298878",
            //    Email = "yolchu@code.edu.az"
            //};


            //_context.Users.Add(user);

            //_context.SaveChanges();

            // Select

            /*_context.Rooms.ToList();*/ // Select * from Rooms

            //_context.Rooms.Where(r => r.DailyPrice > 40).ToList(); // select * from Rooms where [DailyPrice]>40

            //_context.Rooms.FirstOrDefault(r => r.DailyPrice > 40); // select top 1 * from Rooms where [DailyPrice]>40

            //_context.Rooms.Find(4); // select * from Rooms where [Id] = 4

            //_context.Rooms.OrderByDescending(r => r.DailyPrice).ToList(); // select * from Rooms Order by [DailyPrice] desc

            //_context.Rooms.Where(r => r.DailyPrice >= 100).Count(); // select COUNT(*) from Rooms where [DailyPrice]>100

            //_context.Rooms.Average(r => r.DailyPrice); // select AVG(*) from Rooms


            Room room = _context.Rooms.Find(1);
            //room.DailyPrice = 55;

            _context.Rooms.Remove(room);

            _context.SaveChanges();
        }
    }
}
