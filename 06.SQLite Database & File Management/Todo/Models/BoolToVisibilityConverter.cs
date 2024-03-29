﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Todo.Models
{
    class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert (object value, Type targetType, object parameter, string language)
        {
            return (bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            Visibility _visibility = (Visibility)value;
            return _visibility == Visibility.Collapsed ? false : true;
        }
    }
}
