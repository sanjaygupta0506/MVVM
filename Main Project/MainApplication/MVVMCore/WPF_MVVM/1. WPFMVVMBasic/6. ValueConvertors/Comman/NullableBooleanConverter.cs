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
    [ValueConversion(typeof(bool?), typeof(string))]
    public class NullableBooleanConverter : IValueConverter
    {
        private const string NullString = "[[NullString]]";

        /// <summary> 
        /// Converts a nullable boolean to a string using a substitute to represent null
        /// </summary> 
        /// <param name="value">The value produced by the binding source.</param> 
        /// <param name="targetType">The type of the binding target property.</param> 
        /// <param name="parameter">The converter parameter to use.</param> 
        /// <param name="culture">The culture to use in the converter.</param> 
        /// <returns> 
        /// A converted value. If the method returns null, the valid null value is used. 
        /// </returns> 
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool parsedValue;

            if (value == null)
            {
                return NullString;
            }
            else
            {
                if (bool.TryParse(value.ToString(), out parsedValue))
                {
                    return parsedValue ? bool.TrueString : bool.FalseString;
                }
                else
                {
                    return NullString;
                }
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
            bool parsedValue;
            if (value == null)
            {
                return null;
            }
            else
            {
                if (bool.TryParse(value.ToString(), out parsedValue))
                {
                    return parsedValue;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
