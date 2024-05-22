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
    /// Value converter which works around known issue when binding to nullable ints (e.g. from SeletedValue property of ComboBox)
    /// </summary>
    [ValueConversion(typeof(int?), typeof(int))]
    public class NullableIntToNegativeOneConverter : IValueConverter
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
            if (value == null)
            {
                return -1;
            }
            else
            {
                return value;
            }
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
            int i;

            if (value == null)
            {
                return null;
            }
            else
            {
                if (int.TryParse(value.ToString(), out i))
                {
                    if (i == -1)
                    {
                        return null;
                    }
                    else
                    {
                        return value;
                    }
                }
                else
                {
                    return value;
                }
            }
        }

    }
}
