using System;
using System.Collections.Generic;

namespace MainApplication
{
  public static class ApplicationContext
  {
    public static bool ImageType { get; set; }
    public static bool ImageTypeException { get; set; }
    public static bool IsExerciserInitialized { get; set; }
    public static bool ExerciserGUIInitialized { get; set; }
    public static bool IsOfflineMode { get; set; }
    //public static bool UsbFx3Update { get; set; } //To check Wether API of FWUPdate has return
    public static int SessionHandler { get; set; }

    public static bool IsExerciserGuiInitialized { get; set; }
    public static int SelectedSession { get; set; }

    public static int PortHandler { get; set; }

    public static int SessionHandle { get; set; }

    public static bool IsExerciserLaunch { get; set; }
    public static bool IsAnalyzerLaunch { get; set; }
    public static bool IsSessionActive { get; set; }

    public static IntPtr ExHandle { get; set; }
    public static IntPtr AnHandle { get; set; }

    public static int dockingWndHeight { get; set; }

    public static int dockingWndWidth { get; set; }

    public static int cascadingType { get; set; }

    public static bool bDeveloperMode { get; set; }

    //public static bool IsExApplicationModulInSession { get; set; }
    //public static bool IsAnImageApplicationTypeLaunched { get; set; }
    //public static bool IsExImageApplicationTypeLaunched { get; set; }

    public static List<int> lstOpenedModuleID = new List<int>();

    public static int s_selectedExerciserModuelsCount { get; set; }
    public static int s_exerciserInitializedEventCount { get; set; }
    public static int s_analyzerInitializedEventCount { get; set; }
    public static int s_selectedAnalyzerModuelsCount { get; set; }
    public static int s_selectedExerciserHwModuelsCount { get; set; }
    public static int s_selectedExerciserModuleCount { get; set; }
    public static int s_selectedAnalyzerModuleCount { get; set; }
    public static int s_selectedAnalyzerHwModuelsCount { get; set; }

    //BIST - set true if all selected modules have BIST FPGA Image
    public static bool s_BISTOnlyModule { get; set; }

    public static string AlaFilePath { get; set; }
    public static void initializeExerciserGUI()
    {

      if (IsExerciserInitialized == false)
      {
        IsExerciserInitialized = true;
        
      }
    }

    public static string ThemeType { get; set; }

    public static int ExerciserAvailableLicenseCount { get; set; }
    public static int AnalyzerAvailableLicenseCount { get; set; }

    public static bool IsExerciserLicenseValid { get; set; }

    public static bool s_bIsExerciserRASLicenseValid { get; set; }
    public static bool s_bIsAnalyzerLicenseValid { get; set; }

    

    public static bool EnableRandDMode { get; set; }
    public static bool s_bEnableRandDFeature { get; set; }
    //public static int s_gen5TotalExerciserLicenseCount { get; set; }
    //public static int s_gen5AnalyzerCount { get; set; }

    //public static bool s_gen5ExerciserCheckout { get; set; }
    //public static bool s_gen5AnalyzerCheckout { get; set; }



    public static bool IsExerciser { get; set; }
    public static bool IsAnalyzer { get; set; }
    public static bool IsRASLicenseEnabled { get; set; }

    public static bool IsApplicationModuleSessionActive { get; set; }

    private static SelectedWindowType selectedAppWindowType;
    public static SelectedWindowType SelectedAppWindowType
    {
      get => selectedAppWindowType;
      set
      {
        selectedAppWindowType = value;

        if (value == SelectedWindowType.Ex)
        {
          //s_selectedExerciserModuleCount += 1;
          IsAnyExerciserWindowAvailable = true;
          IsAnyAnalyzerWindowAvailable = false;
        }
        if (value == SelectedWindowType.An)
        {
          //s_selectedAnalyzerModuleCount += 1;
          IsAnyAnalyzerWindowAvailable = true;
          IsAnyExerciserWindowAvailable = false;
        }

       
      }
    }

    private static void OnPropertyChanged(string v)
    {
      //throw new NotImplementedException();
    }

    public static bool IsAnyExerciserWindowAvailable {get; set;}

    public static bool IsAnyAnalyzerWindowAvailable { get; set; }

    public static bool IsAnalyzerAlaFileAvailable { get; set; }

    public static bool IsExAnWindowAvailable { get; set; }

    public enum SelectedWindowType
    {
      Ex,
      An,
      ExAn
    }
  }
}
