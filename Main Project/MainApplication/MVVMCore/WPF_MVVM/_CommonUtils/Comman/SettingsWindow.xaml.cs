using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Keysight.Ccl.Wsl.Extensions;
using Keysight.Ccl.Wsl.UI;
using Keysight.Ccl.Wsl.UI.Managers;
using Keysight.Ccl.Wsl.UI.Resources.Skins;
using ActiproSoftware.Windows.Themes;

namespace MainApplication.CommonUtils
{
  /// <summary>
  /// Interaction logic for Settings.xaml
  /// </summary>
  public partial class Settings : WslDialog, INotifyPropertyChanged
  {
    private const string Caption = "Caption";
    private const string SmallCaption = "SmallCaption";
    private const string Menu = "Menu";
    private const string Message = "Message";
    private const string Status = "Status";

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
      PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public Settings()
    {
      this.FontTypes = new[] { Caption, SmallCaption, Menu, Message, Status };
      this.FontStyleList = new List<FontStyle> { FontStyles.Italic, FontStyles.Normal, FontStyles.Oblique };
      this.FontWeightList = new List<FontWeight> {FontWeights.Black, FontWeights.Bold, FontWeights.DemiBold,
                                                        FontWeights.ExtraBlack, FontWeights.ExtraBold, FontWeights.ExtraLight,
                                                        FontWeights.Heavy, FontWeights.Light, FontWeights.Medium, FontWeights.Normal,
                                                        FontWeights.Regular, FontWeights.SemiBold, FontWeights.Thin,
                                                        FontWeights.UltraBlack, FontWeights.UltraBold, FontWeights.UltraLight };

      InitializeComponent();

      DataContext = this;

      _fontTypeComboBox.SelectedItem = Message;

      ColorSchemeCombo.Items.Clear();

      //NOTE: Basically allow any kind of color scheme skin fragment. Try to narrow the skin categories sufficiently so we always get color schemes
      foreach (Skin skin in SkinManager.Instance.FindSkinInstances(SkinCategories.Color | SkinCategories.Fragment | SkinCategories.UserSelectable))
      {
        if (skin == null)
          continue;

        //I don't think we want to traverse the relationships tree on this call since a base color scheme can be incompatible but a higher level color scheme can be just fine
        if ((SkinManager.Instance.FoundationalSkinInstance.IsCompatible(skin, SkinCompatibility.Incompatible)) &&
            (SkinManager.Instance.FoundationalSkinInstance.IsCompatible(skin, SkinCompatibility.NotRecommended)))
          ColorSchemeCombo.Items.Add(skin.Name);
      }

      ColorSchemeCombo.SelectedItem = SkinManager.Instance.ColorSkinFragment;
    }

    public string[] FontTypes { get; private set; }

    public IList<FontStyle> FontStyleList { get; private set; }

    public IList<FontWeight> FontWeightList { get; private set; }

    public double AcclFontSize
    {
      get
      {
        var fontType = (string)_fontTypeComboBox.SelectedItem;
        switch (fontType)
        {
          case Caption:
            return FontManager.Instance.WslCaptionFontSize;

          case SmallCaption:
            return FontManager.Instance.WslSmallCaptionFontSize;

          case Menu:
            return FontManager.Instance.WslMenuFontSize;

          case Message:
            return FontManager.Instance.WslMessageFontSize;

          case Status:
            return FontManager.Instance.WslStatusFontSize;

          default:
            throw new InvalidOperationException("Font type not recognized: " + fontType);
        }
      }
      set
      {
        // Don't set the FontManager properties if using System fonts.
        if (!(_useSystemFontsCheckBox.IsChecked ?? false))
        {
          var fontType = (string)_fontTypeComboBox.SelectedItem;
          switch (fontType)
          {
            case Caption:
              FontManager.Instance.WslCaptionFontSize = value;
              break;

            case SmallCaption:
              FontManager.Instance.WslSmallCaptionFontSize = value;
              break;

            case Menu:
              FontManager.Instance.WslMenuFontSize = value;
              break;

            case Message:
              FontManager.Instance.WslMessageFontSize = value;
              break;

            case Status:
              FontManager.Instance.WslStatusFontSize = value;
              break;

            default:
              throw new InvalidOperationException("Font type not recognized: " + fontType);
          }
        }
        //OnPropertyChanged(nameof(AcclFontSize));
        //OnPropertyChanged(nameof(IsDefaultFontSize));
      }
    }

    public bool IsDefaultFontSize
    {
      get
      {
        var fontType = (string)_fontTypeComboBox.SelectedItem;
        switch (fontType)
        {
          case Caption:
            return FontManager.Instance.DefaultWslCaptionFontSize.AlmostEquals(AcclFontSize);

          case SmallCaption:
            return FontManager.Instance.DefaultWslSmallCaptionFontSize.AlmostEquals(AcclFontSize);

          case Menu:
            return FontManager.Instance.DefaultWslMenuFontSize.AlmostEquals(AcclFontSize);

          case Message:
            return FontManager.Instance.DefaultWslMessageFontSize.AlmostEquals(AcclFontSize);

          case Status:
            return FontManager.Instance.DefaultWslStatusFontSize.AlmostEquals(AcclFontSize);

          default:
            throw new InvalidOperationException("Font type not recognized: " + fontType);
        }
      }
    }

    private void ConfigureSettingsForSelectedFontType()
    {
      FontFamily currentFontFamily;

      _fontFamilyComboBox.Items.Clear();
      foreach (var fontFamily in FontManager.Instance.ApprovedProportionalFontFamilyNames)
        _fontFamilyComboBox.Items.Add(fontFamily);

      // Load the other fields with the current value for this font type
      var fontType = (string)_fontTypeComboBox.SelectedItem;
      switch (fontType)
      {
        case Caption:
          currentFontFamily = FontManager.Instance.WslCaptionFontFamily;
          if (!FontManager.Instance.ApprovedProportionalFontFamilyNames.Contains(currentFontFamily))
          {
            _fontFamilyComboBox.Items.Add(currentFontFamily);
          }
          _fontFamilyComboBox.SelectedItem = currentFontFamily;
          AcclFontSize = FontManager.Instance.WslCaptionFontSize;
          _fontStyleComboBox.SelectedItem = FontManager.Instance.WslCaptionFontStyle;
          _fontWeightComboBox.SelectedItem = FontManager.Instance.WslCaptionFontWeight;
          break;

        case SmallCaption:
          currentFontFamily = FontManager.Instance.WslSmallCaptionFontFamily;
          if (!FontManager.Instance.ApprovedProportionalFontFamilyNames.Contains(currentFontFamily))
          {
            _fontFamilyComboBox.Items.Add(currentFontFamily);
          }
          _fontFamilyComboBox.SelectedItem = currentFontFamily;
          AcclFontSize = FontManager.Instance.WslSmallCaptionFontSize;
          _fontStyleComboBox.SelectedItem = FontManager.Instance.WslSmallCaptionFontStyle;
          _fontWeightComboBox.SelectedItem = FontManager.Instance.WslSmallCaptionFontWeight;
          break;

        case Menu:
          currentFontFamily = FontManager.Instance.WslMenuFontFamily;
          if (!FontManager.Instance.ApprovedProportionalFontFamilyNames.Contains(currentFontFamily))
          {
            _fontFamilyComboBox.Items.Add(currentFontFamily);
          }
          _fontFamilyComboBox.SelectedItem = currentFontFamily;
          AcclFontSize = FontManager.Instance.WslMenuFontSize;
          _fontStyleComboBox.SelectedItem = FontManager.Instance.WslMenuFontStyle;
          _fontWeightComboBox.SelectedItem = FontManager.Instance.WslMenuFontWeight;
          break;

        case Message:
          currentFontFamily = FontManager.Instance.WslMessageFontFamily;
          if (!FontManager.Instance.ApprovedProportionalFontFamilyNames.Contains(currentFontFamily))
          {
            _fontFamilyComboBox.Items.Add(currentFontFamily);
          }
          _fontFamilyComboBox.SelectedItem = currentFontFamily;
          AcclFontSize = FontManager.Instance.WslMessageFontSize;
          _fontStyleComboBox.SelectedItem = FontManager.Instance.WslMessageFontStyle;
          _fontWeightComboBox.SelectedItem = FontManager.Instance.WslMessageFontWeight;
          break;

        case Status:
          currentFontFamily = FontManager.Instance.WslStatusFontFamily;
          if (!FontManager.Instance.ApprovedProportionalFontFamilyNames.Contains(currentFontFamily))
          {
            _fontFamilyComboBox.Items.Add(currentFontFamily);
          }
          _fontFamilyComboBox.SelectedItem = currentFontFamily;
          AcclFontSize = FontManager.Instance.WslStatusFontSize;
          _fontStyleComboBox.SelectedItem = FontManager.Instance.WslStatusFontStyle;
          _fontWeightComboBox.SelectedItem = FontManager.Instance.WslStatusFontWeight;
          break;

        default:
          throw new InvalidOperationException("Font type not recognized: " + fontType);
      }
    }

    private void CheckBox_Click(object sender, RoutedEventArgs e)
    {
      bool setting = !(_useSystemFontsCheckBox.IsChecked ?? false);
      bool notifyChanged = _fontFamilyComboBox.IsEnabled != setting;
      _fontTypeComboBox.IsEnabled = setting;
      _fontFamilyComboBox.IsEnabled = setting;
      _fontSizeTextBox.IsEnabled = setting;
      _fontStyleComboBox.IsEnabled = setting;
      _fontWeightComboBox.IsEnabled = setting;
      if (notifyChanged)
        ConfigureSettingsForSelectedFontType();
    }

    private void FontTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      ConfigureSettingsForSelectedFontType();
    }

    private void FontFamilyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      var fontFamily = (FontFamily)_fontFamilyComboBox.SelectedItem;

      // Don't set the FontManager properties if using System fonts (or if fontFamily is null which
      // happens when the FontFamily combobox is cleared when the FontType changes).
      if ((fontFamily != null) && !(_useSystemFontsCheckBox.IsChecked ?? false))
      {
        // Load the other fields with the current value for this font type
        var fontType = (string)_fontTypeComboBox.SelectedItem;
        switch (fontType)
        {
          case Caption:
            FontManager.Instance.WslCaptionFontFamily = fontFamily;
            break;

          case SmallCaption:
            FontManager.Instance.WslSmallCaptionFontFamily = fontFamily;
            break;

          case Menu:
            FontManager.Instance.WslMenuFontFamily = fontFamily;
            break;

          case Message:
            FontManager.Instance.WslMessageFontFamily = fontFamily;
            break;

          case Status:
            FontManager.Instance.WslStatusFontFamily = fontFamily;
            break;

          default:
            throw new InvalidOperationException("Font family not recognized: " + fontFamily);
        }
      }

      //OnPropertyChanged(nameof(IsDefaultFontFamily));
    }

    public bool IsDefaultFontFamily
    {
      get
      {
        var fontFamily = (FontFamily)_fontFamilyComboBox.SelectedItem;
        return fontFamily.Equals(FontManager.Instance.DefaultWslFontFamily);
      }
    }

    private void FontStyleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      var fontStyle = (FontStyle)_fontStyleComboBox.SelectedItem;
      // Don't set the FontManager properties if using System fonts.
      if (!(_useSystemFontsCheckBox.IsChecked ?? false))
      {
        // Load the other fields with the current value for this font type
        var fontType = (string)_fontTypeComboBox.SelectedItem;
        switch (fontType)
        {
          case Caption:
            FontManager.Instance.WslCaptionFontStyle = fontStyle;
            break;

          case SmallCaption:
            FontManager.Instance.WslSmallCaptionFontStyle = fontStyle;
            break;

          case Menu:
            FontManager.Instance.WslMenuFontStyle = fontStyle;
            break;

          case Message:
            FontManager.Instance.WslMessageFontStyle = fontStyle;
            break;

          case Status:
            FontManager.Instance.WslStatusFontStyle = fontStyle;
            break;

          default:
            throw new InvalidOperationException("Font style not recognized: " + fontStyle);
        }
      }

      //OnPropertyChanged(nameof(IsDefaultFontStyle));
    }

    public bool IsDefaultFontStyle
    {
      get
      {
        var fontStyle = (FontStyle)_fontStyleComboBox.SelectedItem;
        return fontStyle == FontManager.Instance.DefaultWslFontStyle;
      }
    }

    private void FontWeightComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      // Don't set the FontManager properties if using System fonts.
      if (!(_useSystemFontsCheckBox.IsChecked ?? false))
      {
        // Load the other fields with the current value for this font type
        var fontWeight = (FontWeight)_fontWeightComboBox.SelectedItem;
        var fontType = (string)_fontTypeComboBox.SelectedItem;
        switch (fontType)
        {
          case Caption:
            FontManager.Instance.WslCaptionFontWeight = fontWeight;
            break;

          case SmallCaption:
            FontManager.Instance.WslSmallCaptionFontWeight = fontWeight;
            break;

          case Menu:
            FontManager.Instance.WslMenuFontWeight = fontWeight;
            break;

          case Message:
            FontManager.Instance.WslMessageFontWeight = fontWeight;
            break;

          case Status:
            FontManager.Instance.WslStatusFontWeight = fontWeight;
            break;

          default:
            throw new InvalidOperationException("Font weight not recognized: " + fontWeight);
        }
      }

      //OnPropertyChanged(nameof(IsDefaultFontWeight));
    }
    public bool IsDefaultFontWeight
    {
      get
      {
        var fontWeight = (FontWeight)_fontWeightComboBox.SelectedItem;
        return fontWeight == FontManager.Instance.DefaultWslFontWeight;
      }
    }

    private void ColorSchemeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      if (ColorSchemeCombo.SelectedIndex != -1)
      {
        //Make sure that this color scheme (and anything it depends on) are setup properly
        string name = ColorSchemeCombo.SelectedItem as string;

        if (!string.IsNullOrEmpty(name))
        {
          SkinManager.Instance.ColorSkinFragment = name;
          //Since there is a chance that failure (small) or a denied skin (more likely) could have happened don't assume success, query for it
          ColorSchemeCombo.SelectedItem = SkinManager.Instance.ColorSkinFragment;

          ThemeManager.BeginUpdate();
          try
          {
            SetActiproColorSchemeAccordingToWSL();
          }
          finally
          {
            ThemeManager.EndUpdate();
          }
          //SkinFragments_UpdateUI(sender, e);
        }
      }
    }

    public static void SetActiproColorSchemeAccordingToWSL()
    {
      if (SkinManager.Instance.ColorSkinFragment == "Caranu Light")
        ThemeManager.CurrentTheme = ThemeName.MetroLight.ToString(); //ActiProThemeNames.BistraLight;
      else
        ThemeManager.CurrentTheme = ThemeName.MetroDark.ToString(); //ActiProThemeNames.BistraDark;
    }

    private void UseKioskModeCheckBox_Click(object sender, RoutedEventArgs e)
    {
      UXManager.ToggleAmbientSkin("Kiosk Mode", _useKioskModeCheckBox.IsChecked ?? false);
      UXManager.ToggleAmbientSkin("Custom Resize Borders", true);
    }
  }
}
