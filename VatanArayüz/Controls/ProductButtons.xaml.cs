﻿using ForControllers.VatanArayüz;
using System;
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

namespace VatanArayüz.Controls
{
    /// <summary>
    /// ProductButtons.xaml etkileşim mantığı
    /// </summary>
    public partial class ProductButtons : UserControl
    {
        public Product product;
        public ProductButtons()
        {
            InitializeComponent();
        }
    }
}
