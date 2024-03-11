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
using System.Windows;

namespace Keysight.PCIeAnalysis
{
    /// <summary>
    /// Value converter which works around known issue when binding to nullable ints (e.g. from SeletedValue property of ComboBox)
    /// </summary>

    public class TwoValueEnumToBoolConverter : IValueConverter
    {
        /// <summary>
        /// Converts the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="targetType">Type of the target.</param>
        /// <param name="parameter">The parameter.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
          if (Enum.IsDefined(value.GetType(), value) == false) return DependencyProperty.UnsetValue;

          int iValue = (int) value;
          if (iValue == 0)
          {
            return true;
          }
          return false;

        }

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
          bool b = (bool) value;
          if (b == true)
          {
            return Enum.Parse(targetType,Enum.GetName(targetType,0));
          }
          else
          {
            return Enum.Parse(targetType, Enum.GetName(targetType, 1));
          }

        }

    }

    public class TwoValueEnumToStringConverter : IValueConverter
    {
      /// <summary>
      /// Converts the specified value.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <param name="targetType">Type of the target.</param>
      /// <param name="parameter">The parameter.</param>
      /// <param name="culture">The culture.</param>
      /// <returns></returns>
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
        if (Enum.IsDefined(value.GetType(), value) == false) return DependencyProperty.UnsetValue;
        var enumType = value.GetType();
       //  return Enum.GetName(enumType, value);
        return EnumHelper.GetDescription( (Enum) value );

        //System.Reflection.FieldInfo fi = value.GetType().GetField(value.ToString());

        //value.GetType().


        //int iValue = (int)value;
        //return EnumHelper.GetDescription( Enum.Parse(targetType,Enum.GetName(targetType,iValue)));


      }

      /// <summary>
      /// Converts a value.
      /// </summary>
      /// <param name="value">The value that is produced by the binding target.</param>
      /// <param name="targetType">The type to convert to.</param>
      /// <param name="parameter">The converter parameter to use.</param>
      /// <param name="culture">The culture to use in the converter.</param>
      /// <returns>
      /// A converted value. If the method returns null, the valid null value is used.
      /// </returns>
      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
        throw new NotSupportedException();
//        return Enum.Parse(targetType, value);
      }

    }
}
