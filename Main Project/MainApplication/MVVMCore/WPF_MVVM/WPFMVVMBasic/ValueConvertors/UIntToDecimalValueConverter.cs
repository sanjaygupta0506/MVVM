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
  public class UIntToDecimalValueConverter : IValueConverter
  {
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      var decimalValue = (decimal)((uint)value);

      return decimalValue;
    }

    object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      var uintValue = (uint)((decimal)value);

      return uintValue;
    }
  }

  public class IntToDecimalValueConverter : IValueConverter
  {
    object IValueConverter.Convert( object value, Type targetType, object parameter, CultureInfo culture )
    {
      var decimalValue = (decimal)((int)value);

      return decimalValue;
    }

    object IValueConverter.ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
    {
      var intValue = (int)((decimal)value);

      return intValue;
    }
  }


}
