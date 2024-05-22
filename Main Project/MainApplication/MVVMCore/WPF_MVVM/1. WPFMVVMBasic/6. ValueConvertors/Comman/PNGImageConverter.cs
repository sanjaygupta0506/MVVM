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
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Xml;

namespace Keysight.PCIeAnalysis
{

  public class PNGImageConverter : IValueConverter
  {
    public object Convert(object value,
                          Type typeTarget,
                          object param,
                          CultureInfo culture)
    {
      // Create source
#if false
      BitmapImage myBitmapImage = new BitmapImage();

      // BitmapImage.UriSource must be in a BeginInit/EndInit block
      myBitmapImage.BeginInit();

      myBitmapImage.UriSource = new Uri(value as string);
      //     myBitmapImage.UriSource = new Uri((string)(sender as Button).Tag);


      // To save significant application memory, set the DecodePixelWidth or  
      // DecodePixelHeight of the BitmapImage value of the image source to
      // the desired height or width of the rendered image. If you don't do
      // this, the application will cache the image as though it were
      // rendered as its normal size rather then just the size that is
      // displayed. Note: In order to preserve aspect ratio, set
      // DecodePixelWidth or DecodePixelHeight but not both.
      //myBitmapImage.DecodePixelWidth = 600;
      //myBitmapImage.DecodePixelHeight = 450;
      myBitmapImage.EndInit();
      Image img = new Image();
      //     System.Windows.Media.RenderOptions.SetBitmapScalingMode(img, System.Windows.Media.BitmapScalingMode.HighQuality);
      img.Source = myBitmapImage;

      return img; 
#endif

      string imageName = value.ToString();
      Uri uri = new Uri(imageName);
      BitmapFrame source = BitmapFrame.Create(uri);

      return source;


    }
    public object ConvertBack(object value,
                              Type typeTarget,
                              object param,
                              CultureInfo culture)
    {
      return null;
    }
  }
}
