//////////////////////////////////////////////////////////////////////////////
//
// Author:  Frank Simon
//
// Description:
//
// Creation Date: 2/29/2008
//
// Copyright (C) 1999-2008 Keysight Technologies, Inc.
//
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Globalization;
using System.Windows.Data;

namespace Keysight.PCIeAnalysis
{
  [ValueConversion(typeof(int), typeof(string))]
  public class AddSuffixToIntValueConverter : IValueConverter
  {
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value != null)
      {
        string strValue = String.Empty;
        if (value is int)
        {
          var intValue = (int) value;
          strValue = intValue.ToString();
        }
        else if ( value is string )
        {
          strValue = value as string;
        }

        if (!String.IsNullOrEmpty(strValue))
        {
          var strSuffix = parameter as string;
          return strValue + " " + strSuffix;
        }
      }
      return value;
    }

    object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return Binding.DoNothing;

  //    throw new NotSupportedException("ConvertBack not supported.");
    }
  }

}
