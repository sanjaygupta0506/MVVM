using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Keysight.PCIeAnalysis
{
  /// <summary>  
  /// Inverses the visibility of a control based on a boolean value.  
  /// </summary>  
  /// 
  public class BoolComplementToVisibilityConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value == null)
        return false;

      var bValue = (bool)value;

      if (bValue == false)
      {
        return Visibility.Visible;
      }
      else
      {
        return Visibility.Hidden;
      }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value == null)
        return null;

      var visValue = (Visibility)value;

      if (visValue == Visibility.Hidden)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }

  // This converter are use to visible or invisible with same bool value. For setting invisible set the IsReversed proerty true.
  public sealed class BooleanToVisibilityConverterWithInvert : IValueConverter
  {
    public bool IsReversed
    {
      get;
      set;
    }

    public bool UseHidden
    {
      get;
      set;
    }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      var val = System.Convert.ToBoolean(value, CultureInfo.InvariantCulture);

      if (this.IsReversed)
      {
        val = !val;
      }

      if (val)
      {
        return Visibility.Visible;
      }

      return this.UseHidden ? Visibility.Hidden : Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }

  public class BoolComplementToVisibilityCollapseConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value == null)
        return false;

      var bValue = (bool)value;

      if (bValue == false)
      {
        return Visibility.Visible;
      }
      else
      {
        return Visibility.Collapsed;
      }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value == null)
        return null;

      var visValue = (Visibility)value;

      if (visValue == Visibility.Collapsed)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }

  public class BoolToVisibilityCollapseConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value == null)
        return false;

      var bValue = (bool)value;

      if (bValue == false)
      {
        return Visibility.Collapsed;
      }
      else
      {
        return Visibility.Visible;
      }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value == null)
        return null;

      var visValue = (Visibility)value;

      if (visValue == Visibility.Collapsed)
      {
        return false;
      }
      else
      {
        return true;
      }
    }
  }

}
