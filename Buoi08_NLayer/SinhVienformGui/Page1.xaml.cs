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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SinhVienformGui
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        SinhVienBLL svBLL = new SinhVienBLL();
        List<SinhVienDTO> dssv = new List<SinhVienDTO>();
        public Page1()
        {
            InitializeComponent();
        }

        private void Form_Load(object)
    }
}
