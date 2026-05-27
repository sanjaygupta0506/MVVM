using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace MainApplication.SecuritySample
{


  public class SecurityViewModelBase
  {
    public SecurityViewModelBase()
    {
      ControlsToSecure = new List<SecurityControl>();
      ControlsInContainer = new List<XAMLControlInfo>();
    }

    public List<SecurityControl> ControlsToSecure { get; set; }
    public List<XAMLControlInfo> ControlsInContainer { get; set; }
    public IPrincipal CurrentPrincipal { get; set; }
    public virtual void SecureControls(object element, string containerName)
    {
      XAMLControlInfo ctl = null;
      CurrentPrincipal = Thread.CurrentPrincipal;

      // Get Controls to Secure from Data Store  
      LoadControlsToSecure(containerName);

      // Build List of Controls to be Secured  
      LoadControlsInXAMLContainer(element);

      // Loop through controls  
      foreach (SecurityControl secCtl in ControlsToSecure)
      {
        secCtl.ElementIdentifier = secCtl.ElementIdentifier.ToLower();

        // Search for Name property
        ctl = ControlsInContainer.Find(c => c.ControlName.ToLower() == secCtl.ElementIdentifier);

        if (ctl == null)
        {
          // Search for Tag property
          ctl = ControlsInContainer.Find(c => c.Tag.ToLower() == secCtl.ElementIdentifier);
        }
        if (ctl != null && !string.IsNullOrWhiteSpace(secCtl.Mode))
        {
          // Loop through roles and see if user is NOT in one of the roles      
          // If not, change the state of the control      
          foreach (string role in secCtl.Roles)
          {
            if (CurrentPrincipal.IsInRole(role))
            {
              // They are in a role, so break out of loop          
              break;
            }
            else
            {
              // They are NOT in a role so change the control state
              ChangeState(ctl, secCtl.Mode);

              // Break out of loop because we have already modified the control state          
              break;
            }
          }
        }
      }
    }

    protected virtual void LoadControlsToSecure(string containerName) { }
    protected virtual void LoadControlsInXAMLContainer(object element)
    {
      XAMLControlInfo ctl;
      FrameworkElement fe;

      if (element is DependencyObject dep)
      {
        ctl = new XAMLControlInfo
        {
          TheControl = element,
          ControlType = element.GetType().Name
        };

        // Cast to 'FrameworkElement' so we can get the Name and Tag properties    
        fe = element as FrameworkElement;
        if (fe != null)
        {
          ctl.ControlName = fe.Name;
          if (fe.Tag != null)
          {
            ctl.Tag = fe.Tag.ToString();
          }
        }

        if (ctl.ConsiderForSecurity())
        {
          // Is there a ReadOnly property?
          ctl.HasIsReadOnlyProperty = element.GetType().GetProperty("IsReadOnly") == null ? false : true;

          // Make sure there is not a null in ControlName or Tag
          ctl.ControlName = ctl.ControlName ?? string.Empty;
          ctl.Tag = ctl.Tag ?? string.Empty;

          // Add control to be considered for security
          ControlsInContainer.Add(ctl);
        }

        // Look for Child objects
        foreach (object child in LogicalTreeHelper.GetChildren(dep))
        {
          // Make recursive call
          LoadControlsInXAMLContainer(child);
        }
      }
    }

    protected virtual void ChangeState(XAMLControlInfo control, string mode)
    {
      Control ctl = (Control)control.TheControl;

      switch (mode.ToLower())
      {
        case "disabled":
          ctl.Visibility = Visibility.Visible;
          ctl.IsEnabled = false;
          break;
        case "readonly":
        case "read only":
        case "read-only":
          ctl.Visibility = Visibility.Visible;
          ctl.IsEnabled = true;
          if (control.HasIsReadOnlyProperty)
          {
            // Turn on IsReadOnly property
            ctl.GetType().GetProperty("IsReadOnly").SetValue(control.TheControl, true, null);
          }
          else
          {
            ctl.IsEnabled = false;
          }
          break;
        case "collapsed":
        case "collapse":
          ctl.Visibility = Visibility.Collapsed;
          break;
        case "hidden":
        case "invisible":
          ctl.Visibility = Visibility.Hidden;
          break;
      }
    }


  }

}
