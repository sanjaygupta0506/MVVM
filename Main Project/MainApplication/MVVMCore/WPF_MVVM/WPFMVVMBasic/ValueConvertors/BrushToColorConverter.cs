using System;
using System.Windows.Data;
using System.Windows.Media;

namespace Keysight.PCIeAnalysis.ValueConverters
{
  [ValueConversion(typeof(Brush), typeof(Color))]
  public class BrushToColorConverter : IValueConverter
  {
    #region IValueConverter Members

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      if (targetType != typeof(Color)) return null;
      if (!(value is Brush)) return null;
      SolidColorBrush scb = (SolidColorBrush)value;
      Color c = scb.Color;
      return c;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}