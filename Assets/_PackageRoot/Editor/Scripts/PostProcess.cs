using System.IO;
using UnityEditor;
using UnityEditor.Callbacks;

public class iOSPodsBitcodePostProcess
{
    [PostProcessBuildAttribute(45)] //must be between 40 and 50 to ensure that it's not overriden by Podfile generation (40) and that it's added before "pod install" (50)
    private static void PostProcessBuild_iOS(BuildTarget target, string buildPath)
    {
        if (target == BuildTarget.iOS)
        {
            using (StreamWriter sw = File.AppendText(buildPath + "/Podfile"))
            {
                sw.WriteLine("post_install do |installer|\r\n  installer.pods_project.targets.each do |target|\r\n    target.build_configurations.each do |config|\r\n      config.build_settings['ENABLE_BITCODE'] = 'YES'\r\n    end\r\n  end\r\nend");
            }
        }
    }
}