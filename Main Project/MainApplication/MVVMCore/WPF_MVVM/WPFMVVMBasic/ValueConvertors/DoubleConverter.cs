using System;
using System.Globalization;
using System.Windows.Data;

namespace Keysight.PCIeAnalysis
{
  [ValueConversion(typeof(object), typeof(double))]
  public class DoubleConverter : IValueConverter
  {
    public object Convert(object value, Type targetType,
                          object parameter, CultureInfo culture)
    {
      double dblValue = (double)value;
      double scale = Double.Parse((string)parameter);
      return dblValue * scale;
    }

    public object ConvertBack(object value, Type targetType,
                              object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}