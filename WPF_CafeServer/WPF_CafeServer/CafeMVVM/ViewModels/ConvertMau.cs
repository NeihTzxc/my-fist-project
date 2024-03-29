﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace CafeMVVM.ViewModels
{
    public class ConvertMau : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!string.IsNullOrEmpty(value.ToString()) && value.ToString() == "Trống")
            {
                //return new SolidColorBrush(Colors.Black);
                return Brushes.Black;
            }               
            else
            {
                //return new SolidColorBrush(Colors.Red);
                return Brushes.Red;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
