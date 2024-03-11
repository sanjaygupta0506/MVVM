/*
 *  (c) Copyright Alex Kolesnichenko, 2005.
 *
 *  You can use this code as you want to, but do not remove this copyright notice.
 *
 */
using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Globalization;
using System.Windows.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
//using Keysight.PCIeAnalysis.Services;

namespace Keysight.PCIeAnalysis
{

  /// <summary>
  /// This converter is used in conjunction with a style to create a
  /// list of radio buttons to be used in conjunction with a enum
  /// property. This converter is needed so that the human readable
  /// display string is shown in the list of radio buttons rather than the
  /// enumeration string.
  /// </summary>
  public class RadioButtonListEnumConverter : IValueConverter
  {

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      KeyValuePair<Enum, string>? kvp = value as KeyValuePair<Enum, string>?;
      if (kvp != null)
      {
        string val = kvp.Value.Value;
        return val;
      }
      return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }

  }

  /// <summary>
  /// This converter is used in conjunction with a style to create a
  /// list of radio buttons to be used in conjunction with a enum
  /// property. This converter is needed so that the human readable
  /// display string is shown in the list of radio buttons rather than the
  /// enumeration string.
  ///
  /// This extended version of the Converter works with the EnumChoice class
  /// which added isEnable behavior so that certain enumerated choices could
  /// be disabled as per license requirements.
  /// </summary>
  public class RadioButtonListEnumConverterEx : IValueConverter
  {

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      EnumChoice ec = value as EnumChoice;
      if (ec != null)
      {
        return ec.Value;
      }
      return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }

  }

  /// <summary>
  /// Provides a description for an enumerated type.
  /// </summary>
  [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field, AllowMultiple = false)]
  public sealed class EnumDescriptionAttribute : Attribute
  {
    private string description;

    /// <summary>
    /// Gets the description stored in this attribute.
    /// </summary>
    /// <value>The description stored in the attribute.</value>
    public string Description
    {
      get
      {
        return this.description;
      }
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="EnumDescriptionAttribute"/> class.
    /// </summary>
    /// <param name="description">The description to store in this attribute.</param>
    public EnumDescriptionAttribute(string description)
    : base()
    {
      this.description = description;
    }
  }

  /// <summary>
  /// Provides a description for an enumerated type.
  /// </summary>
  [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field, AllowMultiple = false)]
  public sealed class EnumLabModeOnlyAttribute : Attribute
  {
    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="EnumLabModeOnlyAttribute"/> class.
    /// </summary>
    public EnumLabModeOnlyAttribute()
    :
      base()
    {
    }
  }

  /// <summary>
  /// This Class is used to augment bound enumerations functionality to have
  /// an isEnabled property.  In the legacy way, the KeyValuePair class was used
  /// instead of this one. In essence, this class wraps up the KeyValuePair an in
  /// addition adds the IsEnabled property.  Other than this additional property
  /// everything really works the same way.
  /// </summary>
  public class EnumChoice : INotifyPropertyChanged
  {

    public EnumChoice(KeyValuePair<Enum, string> choice)
    {
      m_EnumChoiceName = choice;
    }

    public Enum Key
    {
      get
      {
        return m_EnumChoiceName.Key;
      }
    }

    public string Value
    {
      get
      {
        return m_EnumChoiceName.Value;
      }
    }
    KeyValuePair<Enum, string> m_EnumChoiceName;

    private bool _isEnabled = true;

    public bool IsEnabled
    {
      get
      {
        return _isEnabled;
      }
      set
      {
        _isEnabled = value;
        this.OnPropertyChanged("IsEnabled");
      }

    }

    private System.Windows.Visibility _Visibility = System.Windows.Visibility.Visible;

    public System.Windows.Visibility Visibility
    {
      get
      {
        return _Visibility;
      }
      set
      {
        _Visibility = value;
        this.OnPropertyChanged("Visibility");
      }

    }
    #region INotifyPropertyChanged Members

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged != null)
        this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion // INotifyPropertyChanged Members

  }



#if false // fds not used
  public class EnumModel
  {
    //   private IList m_EnumChoices;
    private ICollection<object> m_EnumChoices;

    public EnumModel()
    {
      m_EnumChoices = new ObservableCollection<object>();
    }

    //    public IList EnumChoices
    public ICollection<object> EnumChoices
    {
      get
      {
        return m_EnumChoices;
      }
      set
      {
        m_EnumChoices = value;
      }
    }

    public void SetEnabled(Enum choice, bool bIsEnabled)
    {
      foreach (object obj in m_EnumChoices)
      {
        EnumChoice tmdc = obj as EnumChoice;
        //  for some reason == does not work!!!      if (tmdc.Key == choice)
        if (tmdc.Key.Equals(choice))
        {
          tmdc.IsEnabled = bIsEnabled;
        }
      }
    }
  }
#endif


  /// <summary>
  /// Provides a static utility object of methods and properties to interact with enumerated types.
  /// </summary>
  public static class EnumHelper
  {
    /// <summary>
    /// Gets the <see cref="DescriptionAttribute"/> of an <see cref="Enum"/> type value.
    /// </summary>
    /// <param name="value">The <see cref="Enum"/> type value.</param>
    /// <returns>A string containing the text of the <see cref="DescriptionAttribute"/>.</returns>
    public static string GetDescription(Enum value)
    {
      if (value == null)
      {
        throw new ArgumentNullException("value");
      }

      string description = value.ToString();
      FieldInfo fieldInfo = value.GetType().GetField(description);

      if (fieldInfo != null)
      {
        EnumDescriptionAttribute[] attributes =
          (EnumDescriptionAttribute[]) fieldInfo.GetCustomAttributes(typeof (EnumDescriptionAttribute), false);

        if (attributes != null && attributes.Length > 0)
        {
          description = attributes[0].Description;
        }
      }
      return description;
    }

    /// <summary>
    /// </summary>
    /// <param name="value">The <see cref="Enum"/> type value.</param>
    /// <returns>True if enum can be added to the list</returns>
    public static Boolean AddToList(Enum value)
    {
      if (value == null)
      {
        throw new ArgumentNullException("value");
      }

      Boolean                    bAdd = true;
      string                     description = value.ToString();
      FieldInfo                  fieldInfo = value.GetType().GetField(description);
      EnumLabModeOnlyAttribute[] attributes = (EnumLabModeOnlyAttribute[])fieldInfo.GetCustomAttributes(typeof(EnumLabModeOnlyAttribute), false);

      //if ((attributes != null) && (attributes.Length > 0))
      //{
      //  bAdd = LogicSystem.IsLabEnvironment();
      //}

      return bAdd;
    }

    /// <summary>
    /// Converts the <see cref="Enum"/> type to an <see cref="IList"/> compatible object.
    /// </summary>
    /// <param name="type">The <see cref="Enum"/> type.</param>
    /// <returns>An <see cref="IList"/> containing the enumerated type value and description.</returns>
    public static IList ToList(Type type)
    {
      if (type == null)
      {
        throw new ArgumentNullException("type");
      }

      ArrayList list = new ArrayList();
      Array enumValues = Enum.GetValues(type);

      foreach (Enum value in enumValues)
      {
        if (AddToList( value ) == true)
        {
          list.Add(new KeyValuePair<Enum, string>(value, GetDescription(value)));
        }
      }

      return list;
    }

    /// <summary>
    /// Converts the <see cref="Enum"/> type to an <see cref="IList"/> compatible object.
    /// </summary>
    /// <param name="type">The <see cref="Enum"/> type.</param>
    /// <returns>An <see cref="IList"/> containing the enumerated type value and description.</returns>
    public static IList ToListEx(Type type)
    {
      if (type == null)
      {
        throw new ArgumentNullException("type");
      }

      ArrayList list = new ArrayList();
      Array enumValues = Enum.GetValues(type);

      foreach (Enum value in enumValues)
      {
        if (AddToList( value ) == true)
        {
          list.Add(new EnumChoice(new KeyValuePair<Enum, string>(value, GetDescription(value))));
        }
      }

      return list;
    }

    public static ICollectionView ToListEx2(Type type)
    {
      if (type == null)
      {
        throw new ArgumentNullException("type");
      }

      ArrayList list = new ArrayList();

      Array enumValues = Enum.GetValues(type);

      foreach (Enum value in enumValues)
      {
        if (AddToList(value) == true)
        {
          list.Add(new EnumChoice(new KeyValuePair<Enum, string>(value, GetDescription(value))));
        }
      }

      var cvs = new CollectionViewSource();
      cvs.Source = list;
      cvs.View.Refresh();
      cvs.View.MoveCurrentTo(list[0]);

      return cvs.View;
    }

    /// <summary>
    /// Converts the <see cref="Enum"/> type to an <see cref="IList"/> compatible object with custom strings.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="customStrings"></param>
    /// <returns></returns>
    public static IList ToListExCustomNames(Type type, List<string> customStrings)
    {
      if (type == null)
      {
        throw new ArgumentNullException("type");
      }

      ArrayList list = new ArrayList();
      Array enumValues = Enum.GetValues(type);

      if (customStrings.Count == enumValues.Length)
      {

        int i = 0;
        foreach (Enum value in enumValues)
        {
          if (AddToList(value) == true)
          {
            list.Add(new EnumChoice(new KeyValuePair<Enum, string>(value, customStrings[i])));

            i++;
          }
        }

        return list;
      }
      return ToListEx(type);
    }

    /// <summary>
    /// This method sets the IsEnabled property of an enumerated choice to a specified value.
    /// </summary>
    /// <param name="list"></param>
    /// <param name="eValue"></param>
    /// <param name="bIsEnabled"></param>
    public static void SetEnabled(IList list, Enum eValue, bool bIsEnabled)
    {
      if (list == null)
      {
        return;
      }
//      System.Diagnostics.Debug.Assert(list != null);

      foreach (object obj in list)
      {
        EnumChoice ec = obj as EnumChoice;
        if (ec != null)
        {
          if (ec.Key.Equals(eValue))
          {
            ec.IsEnabled = bIsEnabled;
          }
        }
      }
    }

    /// <summary>
    /// This method sets the IsVisible property of an enumerated choice to a specified value.
    /// </summary>
    /// <param name="list"></param>
    /// <param name="eValue"></param>
    /// <param name="bIsVisible"></param>
    public static void SetVisible(IList list, Enum eValue, bool bIsVisible)
    {
      if (list == null)
      {
        return;
      }
//      System.Diagnostics.Debug.Assert(list != null);

      foreach (object obj in list)
      {
        EnumChoice ec = obj as EnumChoice;
        if (ec != null)
        {
          if (ec.Key.Equals(eValue))
          {
            ec.Visibility = bIsVisible ? System.Windows.Visibility.Visible : System.Windows.Visibility.Collapsed;
          }
        }
      }
    }

#if false // not currently being used
    public static void SetEnabledOnAndAfter(IList list, Enum eValue, bool bIsEnabled)
    {
      bool bMatch = false;
      foreach (object obj in list)
      {
        EnumChoice ec = obj as EnumChoice;
        if (ec != null)
        {
          if (ec.Key.Equals(eValue) || bMatch)
          {
            bMatch = true;
            ec.IsEnabled = bIsEnabled;
          }
        }
      }
    }
#endif

    /// <summary>
    /// This method sets the IsEnabled property for all enumerated choices
    /// after this specified "cut off" enumerated choice that is passed in
    /// as the eValue parameter.
    /// </summary>
    /// <param name="list"></param>
    /// <param name="eValue"></param>
    /// <param name="bIsEnabled"></param>
    public static void SetEnabledAfter(IList list, Enum eValue, bool bIsEnabled)
    {
      if (list == null)
      {
        return;
      }
//      System.Diagnostics.Debug.Assert(list != null);

      bool bMatch = false;
      foreach (object obj in list)
      {
        EnumChoice ec = obj as EnumChoice;
        if (ec != null)
        {
          if (ec.Key.Equals(eValue) || bMatch)
          {
            if (bMatch == false)
            {
              ec.IsEnabled = !bIsEnabled;
              bMatch = true;
            }
            else
            {
              ec.IsEnabled = bIsEnabled;
            }
          }
          else
          {
            ec.IsEnabled = !bIsEnabled;
          }
        }
      }
    }

    /// <summary>
    /// This method sets the Visibility property for all enumerated choices
    /// after this specified "cut off" enumerated choice that is passed in
    /// as the eValue parameter.
    /// </summary>
    /// <param name="list"></param>
    /// <param name="eValue"></param>
    /// <param name="bIsEnabled"></param>
    public static void SetInvisibleAfter(IList list, Enum eValue)
    {
      if (list == null)
      {
        return;
      }

      bool bFoundLimit = false;
      foreach (object obj in list)
      {
        EnumChoice ec = obj as EnumChoice;
        if (ec != null)
        {
          ec.Visibility = bFoundLimit ? System.Windows.Visibility.Collapsed : System.Windows.Visibility.Visible;

          if (ec.Key.Equals(eValue))
          {
            bFoundLimit = true;
          }
        }
      }
    }

    /// <summary>
    /// This method sets the IsEnabled property for the entire enumerated
    /// list.
    /// </summary>
    /// <param name="list"></param>
    /// <param name="bIsEnabled"></param>
    public static void SetEnabledAll(IList list, bool bIsEnabled)
    {
      if (list == null)
      {
        return;
      }
  //    System.Diagnostics.Debug.Assert(list != null);

      foreach (object obj in list)
      {
        EnumChoice ec = obj as EnumChoice;
        if (ec != null)
        {
          ec.IsEnabled = bIsEnabled;
        }
      }
    }

    public static IList GetEnumStrings(Type type)
    {
      if (type == null)
      {
        throw new ArgumentNullException("type");
      }

      ArrayList list = new ArrayList();
      Array enumValues = Enum.GetValues(type);

      foreach (Enum value in enumValues)
      {
        list.Add(GetDescription(value));
      }

      return list;
    }

    /// <summary>
    /// Creates a ContextMenu from an Enumeration
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static ContextMenu CreateContextMenuFromEnum(Type type)
    {
      if (type == null)
      {
        throw new ArgumentNullException("type");
      }

      Array enumValues = Enum.GetValues(type);

      ContextMenu cm = new ContextMenu();
      foreach (Enum value in enumValues)
      {
        MenuItem mi = new MenuItem();
        mi.Header = GetDescription(value);
        mi.Tag = value;
        cm.Items.Add(mi);
      }

      return cm;
    }

    /// <summary>
    /// This method returns the "selected" choices for an enum based on the passed in enum value.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="eValue"></param>
    /// <returns></returns>
    public static List<string> SelectedChoices(Type type, Enum eValue)
    {
      List<string> returnString = new List<string>();

      if (type == null)
      {
        throw new ArgumentNullException("type");
      }
      ContextMenu cm = new ContextMenu();

      ArrayList list = new ArrayList();
      Array enumValues = Enum.GetValues(type);


      foreach (Enum value in enumValues)
      {
        if (((int)(object)value & (int)(object)eValue) > 0)
        {
          returnString.Add(Enum.GetName(type,value));
        }
      }

      return returnString;
    }


  }
}
