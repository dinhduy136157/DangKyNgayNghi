﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DangKyNgayNghi
{
    /// <summary>
    /// Interaction logic for ChiTiet.xaml
    /// </summary>
    public partial class ChiTiet : Window
    {
        private List<NgayNghi> ngayNghis;

        public ChiTiet(List<NgayNghi> ngayNghis)
        {
            InitializeComponent();
            this.ngayNghis = ngayNghis;
            dgvEmployeeInfo.ItemsSource = ngayNghis;

        }

    }
}
