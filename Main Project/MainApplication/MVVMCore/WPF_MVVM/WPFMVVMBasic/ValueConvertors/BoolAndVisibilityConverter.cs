using System;
using System.Windows;
using System.Windows.Data;
using System.Globalization;

namespace Keysight.PCIeAnalysis
{
 
  public class BoolAndVisibilityConverter : IMultiValueConverter
  {
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
      foreach (object value in values)
      {
        if ((value is bool) && (bool)value == false)
        {
          return Visibility.Collapsed;
        }
      }
      return Visibility.Visible;
    }

    public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
    {
      throw new NotSupportedException("BoolAndVisibilityConverter is a OneWay converter.");
    }
  }
    /// <summary>
    /// This is custom converter used for transaction header.xml
    /// SSIC binding should be last parameter.
  /// In case of SSIC it should return Visibility.Collapsed.
    /// </summary>
  public class BoolAndVisibilityCustomConverter : IMultiValueConverter
  {
      public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
      {
          for (int count = 0; count < values.Length; count++ )
          {
              if (count == values.Length -1)
              {
                  if ((values[count] is bool) && (bool)values[count] == true)
                  {
                      return Visibility.Collapsed;
                  }
              }
              else
              { 
                if((values[count] is bool) && (bool)values[count] == false)
                {
                    return Visibility.Collapsed;
                }
              }
          }
              
          return Visibility.Visible;
      }

      public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
      {
          throw new NotSupportedException("BoolAndVisibilityConverter is a OneWay converter.");
      }
  }
  public class BooleanComplementToVisibilityMultiConverter : IMultiValueConverter
  {
      public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
      {

          foreach (object value in values)
          {
              if ((value is bool) && (bool)value == true)
              {
                  return Visibility.Collapsed;
              }
          }

          return Visibility.Visible;

      }

      public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
      {
          throw new NotImplementedException();
      }
  }
  public class BooleanAndConverter : IMultiValueConverter
  {
    public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      foreach (object value in values)
      {
        if ((value is bool) && (bool)value == false)
        {
          return false;
        }
      }
      return true;
    }
    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotSupportedException("BooleanAndConverter is a OneWay converter.");
    }
  }
}
