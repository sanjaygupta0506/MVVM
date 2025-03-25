using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.SecuritySample
{
  public class SecurityControl
  {
    public string ContainerName { get; set; }
    public string ElementIdentifier { get; set; }
    public string Mode { get; set; }
    public string[] Roles { get; set; }
    private string _RolesAsString = string.Empty;

    public string RolesAsString
    {
      get { return _RolesAsString; }
      set
      {
        _RolesAsString = value;
        Roles = _RolesAsString.Split(',');
      }
    }
  }

}
