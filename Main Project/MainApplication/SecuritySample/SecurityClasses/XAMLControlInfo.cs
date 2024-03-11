using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.SecuritySample
{
  public class XAMLControlInfo
  {
    public object TheControl { get; set; }
    public string ControlName { get; set; }
    public string Tag { get; set; }
    public string ControlType { get; set; }
    public bool HasIsReadOnlyProperty { get; set; }

    public bool ConsiderForSecurity()
    {
      return !string.IsNullOrEmpty(ControlName) || !string.IsNullOrEmpty(Tag);
    }
  }

}
