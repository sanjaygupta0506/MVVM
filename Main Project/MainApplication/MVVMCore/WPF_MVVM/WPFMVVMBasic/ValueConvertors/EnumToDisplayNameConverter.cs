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
  /// <summary>
  /// Returns the value of the DescriptionAttribute applied to an enum value, or an empty string
  /// if the enum value is not decorated with the attribute.
  /// </summary>
  [ValueConversion(typeof(Enum), typeof(string))]
  public class EnumToDisplayNameConverter : IValueConverter
  {
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      //Debug.Assert(value is Enum, "value should be an Enum");
      //Debug.Assert(targetType.IsAssignableFrom(typeof(string)), "targetType should assignable from a String");

      if (value != null)
      {
        return EnumHelper.GetDescription(value as Enum);
      }
      return String.Empty;
    }

    object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return Binding.DoNothing;
//      return Enum.Parse(targetType, (string)value, true);
    }
  }
}
