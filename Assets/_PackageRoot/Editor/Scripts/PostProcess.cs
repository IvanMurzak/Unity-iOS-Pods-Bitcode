using System.IO;
using UnityEditor;
using UnityEditor.Callbacks;

public class iOSPodsBitcodePostProcess
{
    [PostProcessBuildAttribute(45)] //must be between 40 and 50 to ensure that it's not overriden by Podfile generation (40) and that it's added before "pod install" (50)
    private static void PostProcessBuild_iOS(BuildTarget target, string buildPath)
    {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        const string PodfileEnding = "post_install do |installer|\r\n  installer.pods_project.targets.each do |target|\r\n    target.build_configurations.each do |config|\r\n      config.build_settings['ENABLE_BITCODE'] = '{0}'\r\n    end\r\n  end\r\nend";
#pragma warning restore CS0219 // Variable is assigned but its value is never used

        if (target == BuildTarget.iOS)
        {
            using (StreamWriter sw = File.AppendText(buildPath + "/Podfile"))
            {
#if PODS_BITCODE_NO                
                sw.WriteLine(string.Format(PodfileEnding, "NO"));
#elif PODS_BITCODE_YES
                sw.WriteLine(string.Format(PodfileEnding, "YES"));
#endif
            }
        }
    }
}