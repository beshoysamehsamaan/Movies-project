using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Optimization;


public class BundleConfig
{
    private enum BundleType
    {
        SCRIPT = 0,
        STYLE = 1
    }
    private static void AddBundle(BundleCollection bundles, BundleType type, string directoryPath, string bundlePath)
    {
        string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + directoryPath, "*." + (type == BundleType.STYLE ? "css" : "js"));
        files = files.Select(File => Path.GetFileName(File).Insert(0, "~/" + directoryPath + "/")).ToArray();
        //System.Diagnostics.Debug.WriteLine("[" + directoryPath + "] in [" + bundlePath + "] bundle");
        foreach (string f in files) System.Diagnostics.Debug.WriteLine("[" + f + "] is being in included from [" + directoryPath + "] in [" + bundlePath + "] bundle");
        Bundle bundle = type == BundleType.STYLE ? (Bundle)(new StyleBundle(bundlePath.Replace("//", "/").Replace('\\', '/'))) : (Bundle)(new ScriptBundle(bundlePath.Replace("//","/").Replace('\\','/')));
        bundle.Include(files);
        bundles.Add(bundle);
    }
    public static void RegisterBundles(BundleCollection bundles)
    {
        String assetsDirectoryPath = "Assets/";
        /*Start Css Bundles*/
        //**Start Globals**//
        String cssDirectoryPath = String.Concat(assetsDirectoryPath, "css/");
        String cssBundlesPrefix = "~/Bundles/css/";
        //**End   Globals**//

        //**Start Bootstrap**//
        String bootstrapCssDirectoryName = "bootstrap";

        string bootstrapFullCssDirectoryName = "full";
        string bootstrapFullCssDirectoryPath = String.Concat(cssDirectoryPath, bootstrapCssDirectoryName, "/", bootstrapFullCssDirectoryName);
        string bootstrapFullCssBundleName = String.Concat(cssBundlesPrefix, bootstrapCssDirectoryName, "/", bootstrapFullCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, bootstrapFullCssDirectoryPath, bootstrapFullCssBundleName);
        string bootstrapMinCssDirectoryName = "min";
        string bootstrapMinCssDirectoryPath = String.Concat(cssDirectoryPath, bootstrapCssDirectoryName, "/", bootstrapMinCssDirectoryName);
        string bootstrapMinCssBundleName = String.Concat(cssBundlesPrefix, bootstrapCssDirectoryName, "/", bootstrapMinCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, bootstrapMinCssDirectoryPath, bootstrapMinCssBundleName);
        //**End   Bootstrap**//

        //**Start Colorlib**//
        String colorlibCssDirectoryName = "colorlib";
        string colorlibCssDirectoryPath = String.Concat(cssDirectoryPath, colorlibCssDirectoryName);
        string colorlibCssBundleName = String.Concat(cssBundlesPrefix, colorlibCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, colorlibCssDirectoryPath, colorlibCssBundleName);
        //**End   Colorlib**//

        //**Start Propeller**//
        String propellerCssDirectoryName = "propeller";

        String propellerComponentsCssDirectoryName = "components";
        string propellerComponentsCssDirectoryPath = String.Concat(cssDirectoryPath, propellerCssDirectoryName, "/", propellerComponentsCssDirectoryName , "/");
        string propellerAccordionCssDirectoryName = "accordion";
        string propellerAccordionCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, propellerAccordionCssDirectoryName);
        string propellerAccordionCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerAccordionCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerAccordionCssDirectoryPath, propellerAccordionCssBundleName);
        string propellerAlertCssDirectoryName = "alert";
        string propellerAlertCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerAlertCssDirectoryName);
        string propellerAlertCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerAlertCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerAlertCssDirectoryPath, propellerAlertCssBundleName);
        string propellerBadgeCssDirectoryName = "badge";
        string propellerBadgeCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerBadgeCssDirectoryName);
        string propellerBadgeCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerBadgeCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerBadgeCssDirectoryPath, propellerBadgeCssBundleName);
        string propellerButtonCssDirectoryName = "button";
        string propellerButtonCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerButtonCssDirectoryName);
        string propellerButtonCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerButtonCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerButtonCssDirectoryPath, propellerButtonCssBundleName);
        string propellerCardCssDirectoryName = "card";
        string propellerCardCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerCardCssDirectoryName);
        string propellerCardCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerCardCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerCardCssDirectoryPath, propellerCardCssBundleName);
        string propellerCheckboxCssDirectoryName = "checkbox";
        string propellerCheckboxCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerCheckboxCssDirectoryName);
        string propellerCheckboxCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerCheckboxCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerCheckboxCssDirectoryPath, propellerCheckboxCssBundleName);
        string propellerCustomScrollbarCssDirectoryName = "custom-scrollbar";
        string propellerCustomScrollbarCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerCustomScrollbarCssDirectoryName);
        string propellerCustomScrollbarCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerCustomScrollbarCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerCustomScrollbarCssDirectoryPath, propellerCustomScrollbarCssBundleName);
        string propellerDataTableCssDirectoryName = "data-table";
        string propellerDataTableCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerDataTableCssDirectoryName);
        string propellerDataTableCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerDataTableCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerDataTableCssDirectoryPath, propellerDataTableCssBundleName);
        string propellerDateTimePickerCssDirectoryName = "datetimepicker";
        string propellerDateTimePickerCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerDateTimePickerCssDirectoryName);
        string propellerDateTimePickerCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerDateTimePickerCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerDateTimePickerCssDirectoryPath, propellerDateTimePickerCssBundleName);
        string propellerDropDownCssDirectoryName = "dropdown";
        string propellerDropDownCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerDropDownCssDirectoryName);
        string propellerDropDownCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerDropDownCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerDropDownCssDirectoryPath, propellerDropDownCssBundleName);
        string propellerFileUploadCssDirectoryName = "file-upload";
        string propellerFileUploadCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerFileUploadCssDirectoryName);
        string propellerFileUploadCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerFileUploadCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerFileUploadCssDirectoryPath, propellerFileUploadCssBundleName);
        string propellerFloatingActionButtonCssDirectoryName = "floating-action-button";
        string propellerFloatingActionButtonCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerFloatingActionButtonCssDirectoryName);
        string propellerFloatingActionButtonCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerFloatingActionButtonCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerFloatingActionButtonCssDirectoryPath, propellerFloatingActionButtonCssBundleName);
        string propellerFormCssDirectoryName = "form";
        string propellerFormCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerFormCssDirectoryName);
        string propellerFormCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerFormCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerFormCssDirectoryPath, propellerFormCssBundleName);
        string propellerListCssDirectoryName = "list";
        string propellerListCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerListCssDirectoryName);
        string propellerListCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerListCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerListCssDirectoryPath, propellerListCssBundleName);
        string propellerModalCssDirectoryName = "modal";
        string propellerModalCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerModalCssDirectoryName);
        string propellerModalCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerModalCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerModalCssDirectoryPath, propellerModalCssBundleName);
        string propellerNavbarCssDirectoryName = "navbar";
        string propellerNavbarCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerNavbarCssDirectoryName);
        string propellerNavbarCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerNavbarCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerNavbarCssDirectoryPath, propellerNavbarCssBundleName);
        string propellerPaginationCssDirectoryName = "pagination";
        string propellerPaginationCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerPaginationCssDirectoryName);
        string propellerPaginationCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerPaginationCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerPaginationCssDirectoryPath, propellerPaginationCssBundleName);
        string propellerPopoverCssDirectoryName = "popover";
        string propellerPopoverCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerPopoverCssDirectoryName);
        string propellerPopoverCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerPopoverCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerPopoverCssDirectoryPath, propellerPopoverCssBundleName);
        string propellerProgressbarCssDirectoryName = "progressbar";
        string propellerProgressbarCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerProgressbarCssDirectoryName);
        string propellerProgressbarCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerProgressbarCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerProgressbarCssDirectoryPath, propellerProgressbarCssBundleName);
        string propellerRadioCssDirectoryName = "radio";
        string propellerRadioCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerRadioCssDirectoryName);
        string propellerRadioCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerRadioCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerRadioCssDirectoryPath, propellerRadioCssBundleName);
        string propellerRangeSliderCssDirectoryName = "range-slider";
        string propellerRangeSliderCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerRangeSliderCssDirectoryName);
        string propellerRangeSliderCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerRangeSliderCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerRangeSliderCssDirectoryPath, propellerRangeSliderCssBundleName);
        string propellerSelect2CssDirectoryName = "select2";
        string propellerSelect2CssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerSelect2CssDirectoryName);
        string propellerSelect2CssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerSelect2CssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerSelect2CssDirectoryPath, propellerSelect2CssBundleName);
        string propellerSidebarCssDirectoryName = "sidebar";
        string propellerSidebarCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerSidebarCssDirectoryName);
        string propellerSidebarCssBundleName = String.Concat(cssBundlesPrefix, propellerComponentsCssDirectoryPath, "/", propellerSidebarCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerSidebarCssDirectoryPath, propellerSidebarCssBundleName);
        string propellerTabCssDirectoryName = "tab";
        string propellerTabCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerTabCssDirectoryName);
        string propellerTabCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerTabCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerTabCssDirectoryPath, propellerTabCssBundleName);
        string propellerTableCssDirectoryName = "table";
        string propellerTableCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerTableCssDirectoryName);
        string propellerTableCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerTableCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerTableCssDirectoryPath, propellerTableCssBundleName);
        string propellerTextfieldCssDirectoryName = "textfield";
        string propellerTextfieldCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerTextfieldCssDirectoryName);
        string propellerTextfieldCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerTextfieldCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerTextfieldCssDirectoryPath, propellerTextfieldCssBundleName);
        string propellerToggleSwitchCssDirectoryName = "toggle-switch";
        string propellerToggleSwitchCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerToggleSwitchCssDirectoryName);
        string propellerToggleSwitchCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerToggleSwitchCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerToggleSwitchCssDirectoryPath, propellerToggleSwitchCssBundleName);
        string propellerTooltipCssDirectoryName = "tooltip";
        string propellerTooltipCssDirectoryPath = String.Concat(propellerComponentsCssDirectoryPath, "/", propellerTooltipCssDirectoryName);
        string propellerTooltipCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName,"/", propellerComponentsCssDirectoryName, "/", propellerTooltipCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerTooltipCssDirectoryPath, propellerTooltipCssBundleName);

        String propellerSharedCssDirectoryName = "shared";
        String propellerSharedCssFilesDirectoryName = "propeller";
        String propellerSharedCssFilesDirectoryPath = String.Concat(cssDirectoryPath,propellerCssDirectoryName,"/",propellerSharedCssDirectoryName,"/", propellerSharedCssFilesDirectoryName);
        string propellerFullCssDirectoryName = "full";
        string propellerFullCssDirectoryPath = String.Concat(propellerSharedCssFilesDirectoryPath,"/", propellerFullCssDirectoryName);
        string propellerFullCssBundleName = String.Concat(cssBundlesPrefix,propellerCssDirectoryName , "/",propellerSharedCssDirectoryName, "/", propellerSharedCssFilesDirectoryName, "/", propellerFullCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerFullCssDirectoryPath, propellerFullCssBundleName);
        string propellerMinCssDirectoryName = "min";
        string propellerMinCssDirectoryPath = String.Concat(propellerSharedCssFilesDirectoryPath, "/", propellerMinCssDirectoryName);
        string propellerMinCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName, "/", propellerSharedCssDirectoryName, "/", propellerSharedCssFilesDirectoryName, "/", propellerMinCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerMinCssDirectoryPath, propellerMinCssBundleName);
        String propellerGlobalCssDirectoryName = "global";
        String propellerGlobalCssDirectoryPath = String.Concat(cssDirectoryPath, propellerCssDirectoryName, "/", propellerSharedCssDirectoryName, "/", propellerGlobalCssDirectoryName);
        string propellerGlobalCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName, "/", propellerSharedCssDirectoryName, "/", propellerGlobalCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerGlobalCssDirectoryPath, propellerGlobalCssBundleName);
        String propellerRippleEffectCssDirectoryName = "ripple-effect";
        String propellerRippleEffectCssDirectoryPath = String.Concat(cssDirectoryPath, propellerCssDirectoryName, "/", propellerSharedCssDirectoryName, "/", propellerRippleEffectCssDirectoryName);
        string propellerRippleEffectCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName, "/", propellerSharedCssDirectoryName, "/", propellerRippleEffectCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerRippleEffectCssDirectoryPath, propellerRippleEffectCssBundleName);

        String propellerStyleCssDirectoryName = "style";
        String propellerStyleCssDirectoryPath = String.Concat(cssDirectoryPath, propellerCssDirectoryName, "/", propellerStyleCssDirectoryName);
        string propellerIconsCssDirectoryName = "icons";
        string propellerIconsCssDirectoryPath = String.Concat(propellerStyleCssDirectoryPath, "/", propellerIconsCssDirectoryName);
        string propellerIconsCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName, "/", propellerStyleCssDirectoryName, "/", propellerIconsCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerIconsCssDirectoryPath, propellerIconsCssBundleName);
        string propellerShadowCssDirectoryName = "shadow";
        string propellerShadowCssDirectoryPath = String.Concat(propellerStyleCssDirectoryPath, "/", propellerShadowCssDirectoryName);
        string propellerShadowCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName, "/", propellerStyleCssDirectoryName, "/", propellerShadowCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerShadowCssDirectoryPath, propellerShadowCssBundleName);
        string propellerTypographyCssDirectoryName = "typography";
        string propellerTypographyCssDirectoryPath = String.Concat(propellerStyleCssDirectoryPath, "/", propellerTypographyCssDirectoryName);
        string propellerTypographyCssBundleName = String.Concat(cssBundlesPrefix, propellerCssDirectoryName, "/", propellerStyleCssDirectoryName, "/", propellerTypographyCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, propellerTypographyCssDirectoryPath, propellerTypographyCssBundleName);
        //**End   Propeller**//

        //**End   Wheelnav**//
        String wheelNavCssDirectoryName = "wheelnav";
        String wheelNavCssDirectoryPath = String.Concat(cssDirectoryPath, wheelNavCssDirectoryName);
        String wheelNavCssBundleName = String.Concat(cssBundlesPrefix, wheelNavCssDirectoryName);
        AddBundle(bundles, BundleType.STYLE, wheelNavCssDirectoryPath, wheelNavCssBundleName);
        //**End   Wheelnav**//
        /*End   Css Bundles*/


        /*Start Js Bundles*/
        //**Start Globals**//
        String jsDirectoryPath = String.Concat(assetsDirectoryPath, "js/");
        String jsBundlesPrefix = "~/Bundles/js/";
        //**End   Globals**//

        //**Start Bootstrap**//
        String bootstrapJsDirectoryName = "bootstrap";

        string bootstrapFullJsDirectoryName = "full";
        string bootstrapFullJsDirectoryPath = String.Concat(jsDirectoryPath, bootstrapJsDirectoryName, "/", bootstrapFullJsDirectoryName);
        string bootstrapFullJsBundleName = String.Concat(jsBundlesPrefix, bootstrapJsDirectoryName, "/", bootstrapFullJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, bootstrapFullJsDirectoryPath, bootstrapFullJsBundleName);
        string bootstrapMinJsDirectoryName = "min";
        string bootstrapMinJsDirectoryPath = String.Concat(jsDirectoryPath, bootstrapJsDirectoryName, "/", bootstrapMinJsDirectoryName);
        string bootstrapMinJsBundleName = String.Concat(jsBundlesPrefix, bootstrapJsDirectoryName, "/", bootstrapMinJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, bootstrapMinJsDirectoryPath, bootstrapMinJsBundleName);
        //**End   Bootstrap**//

        //**Start JQuery**//
        String jqueryJsDirectoryName = "jquery";

        string jqueryFullJsDirectoryName = "full";
        string jqueryFullJsDirectoryPath = String.Concat(jsDirectoryPath, jqueryJsDirectoryName, "/", jqueryFullJsDirectoryName);
        string jqueryFullJsBundleName = String.Concat(jsBundlesPrefix, jqueryJsDirectoryName, "/", jqueryFullJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, jqueryFullJsDirectoryPath, jqueryFullJsBundleName);
        string jqueryMinJsDirectoryName = "min";
        string jqueryMinJsDirectoryPath = String.Concat(jsDirectoryPath, jqueryJsDirectoryName, "/", jqueryMinJsDirectoryName);
        string jqueryMinJsBundleName = String.Concat(jsBundlesPrefix, jqueryJsDirectoryName, "/", jqueryMinJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, jqueryMinJsDirectoryPath, jqueryMinJsBundleName);
        //**End   JQuery**//

        //**Start Colorlib**//
        String colorlibJsDirectoryName = "colorlib";
        string colorlibJsDirectoryPath = String.Concat(jsDirectoryPath, colorlibJsDirectoryName);
        string colorlibJsBundleName = String.Concat(jsBundlesPrefix, colorlibJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, colorlibJsDirectoryPath, colorlibJsBundleName);
        //**End   Colorlib**//

        //**Start Propeller**//
        String propellerJsDirectoryName = "propeller";

        String propellerComponentsJsDirectoryName = "components";
        string propellerComponentsJsDirectoryPath = String.Concat(jsDirectoryPath, propellerJsDirectoryName, "/", propellerComponentsJsDirectoryName, "/");
        string propellerAccordionJsDirectoryName = "accordion";
        string propellerAccordionJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, propellerAccordionJsDirectoryName);
        string propellerAccordionJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerAccordionJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerAccordionJsDirectoryPath, propellerAccordionJsBundleName);
        string propellerAlertJsDirectoryName = "alert";
        string propellerAlertJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerAlertJsDirectoryName);
        string propellerAlertJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerAlertJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerAlertJsDirectoryPath, propellerAlertJsBundleName);
        string propellerBadgeJsDirectoryName = "badge";
        string propellerBadgeJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerBadgeJsDirectoryName);
        string propellerBadgeJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerBadgeJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerBadgeJsDirectoryPath, propellerBadgeJsBundleName);
        string propellerButtonJsDirectoryName = "button";
        string propellerButtonJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerButtonJsDirectoryName);
        string propellerButtonJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerButtonJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerButtonJsDirectoryPath, propellerButtonJsBundleName);
        string propellerCardJsDirectoryName = "card";
        string propellerCardJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerCardJsDirectoryName);
        string propellerCardJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerCardJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerCardJsDirectoryPath, propellerCardJsBundleName);
        string propellerCheckboxJsDirectoryName = "checkbox";
        string propellerCheckboxJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerCheckboxJsDirectoryName);
        string propellerCheckboxJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerCheckboxJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerCheckboxJsDirectoryPath, propellerCheckboxJsBundleName);
        string propellerCustomScrollbarJsDirectoryName = "custom-scrollbar";
        string propellerCustomScrollbarJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerCustomScrollbarJsDirectoryName);
        string propellerCustomScrollbarJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerCustomScrollbarJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerCustomScrollbarJsDirectoryPath, propellerCustomScrollbarJsBundleName);
        string propellerDataTableJsDirectoryName = "data-table";
        string propellerDataTableJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerDataTableJsDirectoryName);
        string propellerDataTableJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerDataTableJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerDataTableJsDirectoryPath, propellerDataTableJsBundleName);
        string propellerDateTimePickerJsDirectoryName = "datetimepicker";
        string propellerDateTimePickerJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerDateTimePickerJsDirectoryName);
        string propellerDateTimePickerJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerDateTimePickerJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerDateTimePickerJsDirectoryPath, propellerDateTimePickerJsBundleName);
        string propellerDropDownJsDirectoryName = "dropdown";
        string propellerDropDownJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerDropDownJsDirectoryName);
        string propellerDropDownJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerDropDownJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerDropDownJsDirectoryPath, propellerDropDownJsBundleName);
        string propellerFileUploadJsDirectoryName = "file-upload";
        string propellerFileUploadJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerFileUploadJsDirectoryName);
        string propellerFileUploadJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerFileUploadJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerFileUploadJsDirectoryPath, propellerFileUploadJsBundleName);
        string propellerFloatingActionButtonJsDirectoryName = "floating-action-button";
        string propellerFloatingActionButtonJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerFloatingActionButtonJsDirectoryName);
        string propellerFloatingActionButtonJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerFloatingActionButtonJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerFloatingActionButtonJsDirectoryPath, propellerFloatingActionButtonJsBundleName);
        string propellerFormJsDirectoryName = "form";
        string propellerFormJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerFormJsDirectoryName);
        string propellerFormJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerFormJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerFormJsDirectoryPath, propellerFormJsBundleName);
        string propellerListJsDirectoryName = "list";
        string propellerListJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerListJsDirectoryName);
        string propellerListJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerListJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerListJsDirectoryPath, propellerListJsBundleName);
        string propellerModalJsDirectoryName = "modal";
        string propellerModalJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerModalJsDirectoryName);
        string propellerModalJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerModalJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerModalJsDirectoryPath, propellerModalJsBundleName);
        string propellerNavbarJsDirectoryName = "navbar";
        string propellerNavbarJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerNavbarJsDirectoryName);
        string propellerNavbarJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerNavbarJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerNavbarJsDirectoryPath, propellerNavbarJsBundleName);
        string propellerPaginationJsDirectoryName = "pagination";
        string propellerPaginationJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerPaginationJsDirectoryName);
        string propellerPaginationJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerPaginationJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerPaginationJsDirectoryPath, propellerPaginationJsBundleName);
        string propellerPopoverJsDirectoryName = "popover";
        string propellerPopoverJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerPopoverJsDirectoryName);
        string propellerPopoverJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerPopoverJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerPopoverJsDirectoryPath, propellerPopoverJsBundleName);
        string propellerProgressbarJsDirectoryName = "progressbar";
        string propellerProgressbarJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerProgressbarJsDirectoryName);
        string propellerProgressbarJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerProgressbarJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerProgressbarJsDirectoryPath, propellerProgressbarJsBundleName);
        string propellerRadioJsDirectoryName = "radio";
        string propellerRadioJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerRadioJsDirectoryName);
        string propellerRadioJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerRadioJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerRadioJsDirectoryPath, propellerRadioJsBundleName);
        string propellerRangeSliderJsDirectoryName = "range-slider";
        string propellerRangeSliderJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerRangeSliderJsDirectoryName);
        string propellerRangeSliderJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerRangeSliderJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerRangeSliderJsDirectoryPath, propellerRangeSliderJsBundleName);
        string propellerSelect2JsDirectoryName = "select2";
        string propellerSelect2JsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerSelect2JsDirectoryName);
        string propellerSelect2JsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerSelect2JsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerSelect2JsDirectoryPath, propellerSelect2JsBundleName);
        string propellerSidebarJsDirectoryName = "sidebar";
        string propellerSidebarJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerSidebarJsDirectoryName);
        string propellerSidebarJsBundleName = String.Concat(jsBundlesPrefix, propellerComponentsJsDirectoryPath, "/", propellerSidebarJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerSidebarJsDirectoryPath, propellerSidebarJsBundleName);
        string propellerTabJsDirectoryName = "tab";
        string propellerTabJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerTabJsDirectoryName);
        string propellerTabJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerTabJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerTabJsDirectoryPath, propellerTabJsBundleName);
        string propellerTableJsDirectoryName = "table";
        string propellerTableJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerTableJsDirectoryName);
        string propellerTableJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerTableJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerTableJsDirectoryPath, propellerTableJsBundleName);
        string propellerTextfieldJsDirectoryName = "textfield";
        string propellerTextfieldJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerTextfieldJsDirectoryName);
        string propellerTextfieldJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerTextfieldJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerTextfieldJsDirectoryPath, propellerTextfieldJsBundleName);
        string propellerToggleSwitchJsDirectoryName = "toggle-switch";
        string propellerToggleSwitchJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerToggleSwitchJsDirectoryName);
        string propellerToggleSwitchJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerToggleSwitchJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerToggleSwitchJsDirectoryPath, propellerToggleSwitchJsBundleName);
        string propellerTooltipJsDirectoryName = "tooltip";
        string propellerTooltipJsDirectoryPath = String.Concat(propellerComponentsJsDirectoryPath, "/", propellerTooltipJsDirectoryName);
        string propellerTooltipJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName,"/", propellerComponentsJsDirectoryName, "/", propellerTooltipJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerTooltipJsDirectoryPath, propellerTooltipJsBundleName);
        String propellerSharedJsDirectoryName = "shared";
        String propellerSharedJsFilesDirectoryName = "propeller";
        String propellerSharedJsFilesDirectoryPath = String.Concat(jsDirectoryPath, propellerJsDirectoryName, "/", propellerSharedJsDirectoryName, "/", propellerSharedJsFilesDirectoryName);
        string propellerFullJsDirectoryName = "full";
        string propellerFullJsDirectoryPath = String.Concat(propellerSharedJsFilesDirectoryPath, "/", propellerFullJsDirectoryName);
        string propellerFullJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName, "/", propellerSharedJsDirectoryName, "/", propellerSharedJsFilesDirectoryName, "/", propellerFullJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerFullJsDirectoryPath, propellerFullJsBundleName);
        string propellerMinJsDirectoryName = "min";
        string propellerMinJsDirectoryPath = String.Concat(propellerSharedJsFilesDirectoryPath, "/", propellerMinJsDirectoryName);
        string propellerMinJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName, "/", propellerSharedJsDirectoryName, "/", propellerSharedJsFilesDirectoryName, "/", propellerMinJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerMinJsDirectoryPath, propellerMinJsBundleName);
        String propellerGlobalJsDirectoryName = "global";
        String propellerGlobalJsDirectoryPath = String.Concat(jsDirectoryPath, propellerJsDirectoryName, "/", propellerSharedJsDirectoryName, "/", propellerGlobalJsDirectoryName);
        string propellerGlobalJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName, "/", propellerSharedJsDirectoryName, "/", propellerGlobalJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerGlobalJsDirectoryPath, propellerGlobalJsBundleName);
        String propellerRippleEffectJsDirectoryName = "ripple-effect";
        String propellerRippleEffectJsDirectoryPath = String.Concat(jsDirectoryPath, propellerJsDirectoryName, "/", propellerSharedJsDirectoryName, "/", propellerRippleEffectJsDirectoryName);
        string propellerRippleEffectJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName, "/", propellerSharedJsDirectoryName, "/", propellerRippleEffectJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerRippleEffectJsDirectoryPath, propellerRippleEffectJsBundleName);
        String propellerStyleJsDirectoryName = "style";
        String propellerStyleJsDirectoryPath = String.Concat(jsDirectoryPath, propellerJsDirectoryName, "/", propellerStyleJsDirectoryName);
        string propellerIconsJsDirectoryName = "icons";
        string propellerIconsJsDirectoryPath = String.Concat(propellerStyleJsDirectoryPath, "/", propellerIconsJsDirectoryName);
        string propellerIconsJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName, "/", propellerStyleJsDirectoryName, "/", propellerIconsJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerIconsJsDirectoryPath, propellerIconsJsBundleName);
        string propellerShadowJsDirectoryName = "shadow";
        string propellerShadowJsDirectoryPath = String.Concat(propellerStyleJsDirectoryPath, "/", propellerShadowJsDirectoryName);
        string propellerShadowJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName, "/", propellerStyleJsDirectoryName, "/", propellerShadowJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerShadowJsDirectoryPath, propellerShadowJsBundleName);
        string propellerTypographyJsDirectoryName = "typography";
        string propellerTypographyJsDirectoryPath = String.Concat(propellerStyleJsDirectoryPath, "/", propellerTypographyJsDirectoryName);
        string propellerTypographyJsBundleName = String.Concat(jsBundlesPrefix, propellerJsDirectoryName, "/", propellerStyleJsDirectoryName, "/", propellerTypographyJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, propellerTypographyJsDirectoryPath, propellerTypographyJsBundleName);
        //**End   Propeller**//

        //**End   Wheelnav**//
        String wheelNavJsDirectoryName = "wheelnav";
        String wheelNavJsDirectoryPath = String.Concat(jsDirectoryPath, wheelNavJsDirectoryName);
        String wheelNavJsBundleName = String.Concat(jsBundlesPrefix, wheelNavJsDirectoryName);
        AddBundle(bundles, BundleType.SCRIPT, wheelNavJsDirectoryPath, wheelNavJsBundleName);
        //**End   Wheelnav**//
        /*End   Js Bundles*/
    }
}