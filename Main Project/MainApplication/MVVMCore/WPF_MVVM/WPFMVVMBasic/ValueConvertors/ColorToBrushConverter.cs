using System;
using System.Windows.Data;
using System.Windows.Media;

namespace Keysight.PCIeAnalysis.ValueConverters
{
  [ValueConversion(typeof(Color), typeof(Brush))]
  public class ColorToBrushConverter : IValueConverter
  {
    #region IValueConverter Members

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      if (targetType != typeof(Brush)) return null;
      if (!(value is Color)) return null;
      SolidColorBrush scb = new SolidColorBrush((Color)value);
      return scb;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}