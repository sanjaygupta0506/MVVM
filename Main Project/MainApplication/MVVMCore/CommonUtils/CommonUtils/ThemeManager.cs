// Ignore Spelling: Utils Keysight Colour Forground

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Drawing;
using Keysight.Ccl.Wsl.UI.Managers;
using System.Windows;

namespace MainApplication.CommonUtils
{
    public static class ThemeMgr
    {
        #region Caranu Theme Manager 

        #region Constants

        private const double fontSizeSmall = 10;
        private const double fontSizeMedium = 14;

        #endregion

        #region Common

        private static bool IsDark;
        private static readonly System.Windows.Media.Brush lightThemeBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#FFFFFF")); //White    
        private static readonly System.Windows.Media.Brush darkThemeBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#1B1B1F"));  //Caranu Dark    
        private static readonly System.Windows.Media.Brush lightThemeForgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#000000"));  //Black
        private static readonly System.Windows.Media.Brush darkThemeForgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#FFFFFF"));   //White

        private static readonly System.Drawing.Color darkThemeBackgroundColourWindow = System.Drawing.Color.Black;
        private static readonly System.Drawing.Color lightThemeBackgroundColourWindow = System.Drawing.Color.White;
        private static readonly System.Drawing.Color darkThemeForeroundColourWindow = System.Drawing.Color.White;
        private static readonly System.Drawing.Color lightThemeForeroundColourWindow = System.Drawing.Color.Black;

        private static readonly System.Windows.Media.Brush gridHeaderLightThemeBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#D1D7E8"));
        private static readonly System.Windows.Media.Brush gridHeaderDarkThemeBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#25252B"));

        private static readonly System.Windows.Media.Brush packetTimesGridLightThemeForegroundColor = System.Windows.Media.Brushes.Blue;
        private static readonly System.Windows.Media.Brush packetTimesGridDarkThemeForegroundColor = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#15A8FF"));

      
       
        #endregion

        #region Scroll Bar Colour - KIS

        private static readonly System.Drawing.Color darkThemeNormalBackgroundColour = System.Drawing.Color.FromArgb(126,133,145);  //Normal Caranu Dark
        private static readonly System.Drawing.Color darkThemeHoverBackgroundColour = System.Drawing.Color.FromArgb(188,194,204);  //Normal Caranu Dark
        private static readonly System.Drawing.Color darkThemeActiveBackgroundColour = System.Drawing.Color.White;  //Normal Caranu Dark
        private static readonly System.Drawing.Color darkThemeReverseBackgroundColour = System.Drawing.Color.FromArgb(42,42,48);  //Normal Caranu Dark

        private static readonly System.Drawing.Color lightThemeNormalBackgroundColour = System.Drawing.Color.FromArgb(126,137,158); //Normal Caranu Light 
        private static readonly System.Drawing.Color lightThemeHoverBackgroundColour = System.Drawing.Color.FromArgb(67, 74, 89); //Hover Caranu Light
        private static readonly System.Drawing.Color lightThemeActiveBackgroundColour = System.Drawing.Color.Black; //Active Caranu Light
        private static readonly System.Drawing.Color lightThemeReverseBackgroundColour = System.Drawing.Color.FromArgb(215,221,237); //Reverse Caranu Light

        #endregion

        #region Packet Viewer, Lane Pane Grid Header - KIS

        private static readonly System.Drawing.Color darkThemeGridHeaderBackgroundColour = System.Drawing.Color.FromArgb(255, 37, 37, 43);
        private static readonly System.Drawing.Color lightThemeGridHeaderBackgroundColour = System.Drawing.Color.FromArgb(255, 215, 221, 237);


        #endregion

        #region Context Menu Background - KIS

        private static readonly System.Drawing.Color darkThemeContextMenuNormalBackgroundColour = System.Drawing.Color.FromArgb(255, 37, 37, 43);  //Normal Caranu Dark
        private static readonly System.Drawing.Color lightThemeContextMenuNormalBackgroundColour = System.Drawing.Color.FromArgb(255, 240, 243, 250);
        private static readonly System.Drawing.Color darkThemeContextMenuHoverBackgroundColour = System.Drawing.Color.FromArgb(26,188,194,204);  //Dark Hover Caranu Dark
        private static readonly System.Drawing.Color lightThemeContextMenuHoverBackgroundColour = System.Drawing.Color.FromArgb(26,44,95,199);  //Light Hover Caranu Dark

        private static readonly System.Drawing.Color darkThemeContextMenuNormalForgroundColour = System.Drawing.Color.FromArgb(184, 255, 255, 255);  //Normal Caranu Dark
        private static readonly System.Drawing.Color lightThemeContextMenuNormalForgroundColour = System.Drawing.Color.FromArgb(184, 0, 0, 0);
        private static readonly System.Drawing.Color darkThemeContextMenuHoverForgroundColour = System.Drawing.Color.FromArgb(255, 255, 255, 255);  //Normal Caranu Dark
        private static readonly System.Drawing.Color lightThemeContextMenuHoverForgroundColour = System.Drawing.Color.FromArgb(255, 0, 0, 0);  //Normal Caranu Dark

        #endregion

        #region Button - KIS

        private static readonly System.Windows.Media.Brush darkThemeButtonNormalBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#2E2E36")); //White    
        private static readonly System.Windows.Media.Brush lightThemeButtonNormalBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#DDE3F0"));  //Caranu Dark 
        private static readonly System.Windows.Media.Brush darkThemeButtonHoverBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#4B4C54")); //Dark Hover    
        private static readonly System.Windows.Media.Brush lightThemeButtonHoverBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#E9EFF9"));  //Light Hover

        #endregion

        #region Toggle Button - KIS

        private static readonly System.Windows.Media.Brush darkThemeToggleButtonNormalBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#2F2F37")); //dark Theme Toggle Button Normal BackgroundColour
        private static readonly System.Windows.Media.Brush lightThemeToggleButtonNormalBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#DFE4F1"));  //light Theme Toggle Button Normal BackgroundColour

        private static readonly System.Windows.Media.Brush darkThemeToggleButtonOnBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#2B51AB")); //dark Theme Toggle Button On BackgroundColour   
        private static readonly System.Windows.Media.Brush lightThemeToggleButtonOnBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#ABC9FF"));  //light Theme Toggle Button On BackgroundColour

        private static readonly System.Windows.Media.Brush darkThemeToggleButtonNormalHoverBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#42424A")); //dark Theme Toggle Button Normal BackgroundColour
        private static readonly System.Windows.Media.Brush lightThemeToggleButtonNormalHoverBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#DAE8FF"));  //light Theme Toggle Button Normal BackgroundColour


        private static readonly System.Windows.Media.Brush darkThemeToggleButtonOnHoverBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#346EE3")); //dark Theme Toggle Button On Hover BackgroundColour   
        private static readonly System.Windows.Media.Brush lightThemeToggleButtonOnHoverBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#CFE0FF"));  //light Theme Toggle Button On Hover BackgroundColour
        #endregion

        #region Tab - KIS

        private static readonly System.Windows.Media.Brush darkThemeTabNormalBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#2E2E36")); //Normal Dark   
        private static readonly System.Windows.Media.Brush darkThemeTabHoverBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#BCC2CC")); //Hover Dark    
        private static readonly System.Windows.Media.Brush darkThemeTabActiveBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#3E3E46")); //Active Dark    

        private static readonly System.Windows.Media.Brush lightThemeTabNormalBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#DDE3F0"));  //Normal Light
        private static readonly System.Windows.Media.Brush lightThemeTabHoverBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#2C5FC7"));  //Hover Light
        private static readonly System.Windows.Media.Brush lightThemeTabActiveBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#F0F3FA"));  //Active Light

        private static readonly System.Windows.Media.Brush darkThemeTabNormalForegroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#BFBFC1")); //Normal Dark  
        private static readonly System.Windows.Media.Brush lightThemeTabNormalForegroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#474747")); //Normal Dark  

        #endregion

        #region Toolbar Window

        private static readonly System.Windows.Media.Brush darkThemeToolBarBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#3E3E46")); //Dark   
        private static readonly System.Windows.Media.Brush lightThemeToolbarBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#E6EBF5")); //Light
        #endregion

        #region Seprator Window

        private static readonly System.Windows.Media.Brush darkThemeSepratorBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#000000")); //Dark   
        private static readonly System.Windows.Media.Brush lightThemeSepratorBackgroundColour = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#8E9AAD")); //Light
        #endregion

        #region Packet Viewer, Lane Pane Alternative Row - KIS

        private static readonly System.Drawing.Color darkThemeGridAlterRowBackgroundColour = System.Drawing.Color.FromArgb(10, 188, 194, 204);
        private static readonly System.Drawing.Color lightThemeGridAlterRowBackgroundColour = System.Drawing.Color.FromArgb(15, 67, 74, 89);

        #endregion

        #region Font Properties

        private static double m_fontSmall = fontSizeSmall;
        private static double m_fontMedium = fontSizeMedium;
        private static System.Windows.Media.FontFamily m_fontName = new System.Windows.Media.FontFamily("Roboto");

        #endregion

        //<-------------------------------------------------------------------------------------------------------------------------------->//

        #region Media Brush
        public static System.Windows.Media.Color BrushColor
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return System.Windows.Media.Color.FromArgb(255, 10, 10, 10);
                }
                else
                {
                    return System.Windows.Media.Color.FromArgb(255, 245, 253, 255);
                }
            }
        }
        public static System.Windows.Media.Brush ThemeBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeBackgroundColour;
                }
                else
                {
                    return lightThemeBackgroundColour;
                }
            }
            set { }
        }
        public static System.Windows.Media.Brush ThemeForgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeForgroundColour;
                }
                else
                {
                    return lightThemeForgroundColour;
                }
            }
            set { }
        }
        public static System.Windows.Media.Brush GridHeaderThemeBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return gridHeaderDarkThemeBackgroundColour;
                }
                else
                {
                    return gridHeaderLightThemeBackgroundColour;
                }
            }
            set { }
        }

        public static System.Windows.Media.Brush PacketTimesGridThemeForegroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return packetTimesGridDarkThemeForegroundColor;
                }
                else
                {
                    return packetTimesGridLightThemeForegroundColor;
                }
            }
            set { }
        }

        #endregion

        #region Drawing Color

        #region Common

        public static System.Drawing.Color CaranuThemeBackgroundDrawingColour
        {
            get
            {
                System.Windows.Media.Color mediaColor;

                System.Drawing.Color currentColor = System.Drawing.Color.White;

                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    mediaColor = ((System.Windows.Media.SolidColorBrush)darkThemeBackgroundColour).Color;
                    currentColor = System.Drawing.Color.FromArgb(mediaColor.A, mediaColor.R, mediaColor.G, mediaColor.B);
                }
                return currentColor;
            }
        }
        public static System.Drawing.Color CaranuThemeForgroundDrawingColour
        {
            get
            {
                System.Drawing.Color currentColor = System.Drawing.Color.Black;
                System.Windows.Media.Color mediaColor;

                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    mediaColor = ((System.Windows.Media.SolidColorBrush)darkThemeForgroundColour).Color;
                    currentColor = System.Drawing.Color.FromArgb(mediaColor.A, mediaColor.R, mediaColor.G, mediaColor.B);
                }
                return currentColor;
            }
        }
        public static System.Drawing.Color ThemeBackgroundColourWindow
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeBackgroundColourWindow;
                }
                else
                {
                    return lightThemeBackgroundColourWindow;
                }
            }
            set { }
        }
        public static System.Drawing.Color ThemeForeoundColourWindow
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeForeroundColourWindow;
                }
                else
                {
                    return lightThemeForeroundColourWindow;
                }
            }
            set { }
        }

        #endregion

        #region Scroll Bar

        public static System.Drawing.Color ThemeScrollBarNormalBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeNormalBackgroundColour;
                }
                else
                {
                    return lightThemeNormalBackgroundColour;
                }
            }
            set { }
        }
        public static System.Drawing.Color ThemeScrollBarHoverBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeHoverBackgroundColour;
                }
                else
                {
                    return lightThemeHoverBackgroundColour;
                }
            }
            set { }
        }
        public static System.Drawing.Color ThemeScrollBarActiveBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeActiveBackgroundColour;
                }
                else
                {
                    return lightThemeActiveBackgroundColour;
                }
            }
            set { }
        }
        public static System.Drawing.Color ThemeScrollBarReverseBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeReverseBackgroundColour;
                }
                else
                {
                    return lightThemeReverseBackgroundColour;
                }
            }
            set { }
        }

        #endregion

        #region Context menu

        public static System.Drawing.Color ThemeContextMenuNormalBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeContextMenuNormalBackgroundColour;
                }
                else
                {
                    return lightThemeContextMenuNormalBackgroundColour;
                }
            }
            set { }
        }
        public static System.Drawing.Color ThemeContextMenuHoverBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeContextMenuHoverBackgroundColour;
                }
                else
                {
                    return lightThemeContextMenuHoverBackgroundColour;
                }
            }
            set { }
        }
        public static System.Drawing.Color ThemeContextMenuNormalForegroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeContextMenuNormalForgroundColour;
                }
                else
                {
                    return lightThemeContextMenuNormalForgroundColour;
                }
            }
            set { }
        }
        public static System.Drawing.Color ThemeContextMenuHoverForegroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeContextMenuHoverForgroundColour;
                }
                else
                {
                    return lightThemeContextMenuHoverForgroundColour;
                }
            }
            set { }
        }

        #endregion

        #region Header -KIS

        public static System.Drawing.Color GridHeaderBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeGridHeaderBackgroundColour;
                }
                else
                {
                    return lightThemeGridHeaderBackgroundColour;
                }
            }
            set { }
        }
        #endregion

        #region Grid

        public static System.Drawing.Color GridAlterRowBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeGridAlterRowBackgroundColour;
                }
                else
                {
                    return lightThemeGridAlterRowBackgroundColour;
                }
            }
            set { }
        }

        #endregion

        #endregion

        #region Media Brush

        #region Button -KIS

        public static System.Windows.Media.Brush CaranuThemeButtonBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeButtonNormalBackgroundColour;
                }
                else
                {
                    return lightThemeButtonNormalBackgroundColour;
                }
            }
            set { }
        }

        public static System.Windows.Media.Brush CaranuThemeButtonHoverBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeButtonHoverBackgroundColour;
                }
                else
                {
                    return lightThemeButtonHoverBackgroundColour;
                }
            }
            set { }
        }

        // On Toggle Button
        public static System.Windows.Media.Brush CaranuThemeToggleButtonOnBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeToggleButtonOnBackgroundColour;
                }
                else
                {
                    return lightThemeToggleButtonOnBackgroundColour;
                }
            }
            set { }
        }

        public static System.Windows.Media.Brush CaranuThemeToggleButtonNormalBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeToggleButtonNormalBackgroundColour;
                }
                else
                {
                    return lightThemeToggleButtonNormalBackgroundColour;
                }
            }
            set { }
        }

        public static System.Windows.Media.Brush CaranuThemeToggleButtonOnHoverBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeToggleButtonOnHoverBackgroundColour;
                }
                else
                {
                    return lightThemeToggleButtonOnHoverBackgroundColour;
                }
            }
            set { }
        }

        public static System.Windows.Media.Brush CaranuThemeToggleButtonNormalHoverBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeToggleButtonNormalHoverBackgroundColour;
                }
                else
                {
                    return lightThemeToggleButtonNormalHoverBackgroundColour;
                }
            }
            set { }
        }

        #endregion

        #region Tab Menu

        public static System.Windows.Media.Brush CaranuThemeTabBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeTabNormalBackgroundColour;
                }
                else
                {
                    return lightThemeTabNormalBackgroundColour;
                }
            }
            set { }
        }

        public static System.Windows.Media.Brush CaranuThemeTabForegroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeTabNormalForegroundColour;
                }
                else
                {
                    return lightThemeTabNormalForegroundColour;
                }
            }
            set { }
        }

        #endregion

        #region Main Toolbar
        public static System.Windows.Media.Brush CaranuThemeToolbarBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeToolBarBackgroundColour;
                }
                else
                {
                    return lightThemeToolbarBackgroundColour;
                }
            }
            set { }
        }
        #endregion

        #region Seprator
        public static System.Windows.Media.Brush CaranuThemeSepratorBackgroundColour
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return darkThemeSepratorBackgroundColour;
                }
                else
                {
                    return lightThemeSepratorBackgroundColour;
                }
            }
            set { }
        }
        #endregion

        #region Font Properties
        public static double FontSizeMedium
        {
            get
            {
                return m_fontMedium;
            }
            set
            {
                if (m_fontMedium != value)
                {
                    m_fontMedium = value;
                }
            }
        }

        public static double FontSizeSmall
        {
            get
            {
                return m_fontSmall;
            }
            set
            {
                if (m_fontSmall != value)
                {
                    m_fontSmall = value;
                }
            }
        }

        public static System.Windows.Media.FontFamily FontName
        {
            get
            {
                return m_fontName;
            }
            set
            {
                if (m_fontName != value)
                {
                    m_fontName = value;
                }
            }
        }

        #endregion

        #endregion

        #region Current Theme

        public static String CurrentTheme
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    IsDark = true;
                    return "Caranu Dark";
                }
                else
                {
                    IsDark = false;
                    return "Caranu Light";
                }
            }
            set { }
        }

        public static bool IsCurrentTheme
        {
            get
            {
                if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set { }
        }

        #endregion

        #region Common
        public static bool calculatorPosition { get; set; }

        // CORVETTE:NEW - Common Pseudo code for caranu dark and light theme
       

        #endregion

        #endregion //Caranu Theme utility functions
    }
}
