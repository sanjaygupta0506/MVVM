using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Keysight.PCIeAnalysis
{
  public class ContrastConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value != null)
      {
        var convertFromString = ColorConverter.ConvertFromString((string) value);
        if (convertFromString != null)
        {
          Color c = (Color) convertFromString;


          int brightness = (int) Math.Sqrt(
            c.R*c.R*.241 +
            c.G*c.G*.691 +
            c.B*c.B*.068);

          SolidColorBrush textColor = brightness < 126 ? Brushes.White : Brushes.Black;
          
          return textColor;
        }
      }
      return Brushes.Black;
    }

    public object ConvertBack(object value, Type targetType, object parameter,
                              CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}