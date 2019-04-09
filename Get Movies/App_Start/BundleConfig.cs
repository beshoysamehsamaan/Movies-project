using System.IO;
using System.Linq;
using System.Web;
using System.Web.Optimization;


public class BundleConfig
{
    private enum BundleType
    {
      SCRIPT = 0,
      STYLE  = 1
    }
    private static void AddBundle(BundleCollection bundles,BundleType type,string directoryPath,string bundlePath)
    {
        string[] files = Directory.GetFiles(System.AppDomain.CurrentDomain.BaseDirectory + directoryPath, "*."+(type==BundleType.STYLE?"css":"js"));
        //foreach(string f in files)System.Diagnostics.Debug.WriteLine("["+f+"] is being in included from [" + directoryPath + "] in [" + bundlePath + "] bundle" );
        files = files.Select(File => Path.GetFileName(File).Insert(0, "~/" + directoryPath + "/")).ToArray();
        Bundle bundle = type == BundleType.STYLE ? (Bundle)(new StyleBundle(bundlePath)) : (Bundle)(new ScriptBundle(bundlePath));
        bundle.Include(files);
        bundles.Add(bundle);
    }
    public static void RegisterBundles(BundleCollection bundles)
    {
        string cssDirectoryPath = "Assets/css";
        string cssBundlePath    = "~/bundles/css";
        AddBundle(bundles, BundleType.STYLE, cssDirectoryPath, cssBundlePath);

        string jsDirectoryPath  = "Assets/js";
        string jsBundlePath     = "~/bundles/js";
        AddBundle(bundles, BundleType.SCRIPT, jsDirectoryPath, jsBundlePath);

        BundleTable.EnableOptimizations = true;
    }
}