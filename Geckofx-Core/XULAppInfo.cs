using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko
{
    /// <summary>
    /// Implements nsIXULAppInfo for geckofx.
    /// Object "@mozilla.org/xre/app-info;1" in XULRunner embedded in geckofx only implements nsIXULRuntime, but not nsIXULAppInfo.
    /// This can cause a few issues, such as AddonManager refuses to start, which in turn affects remote debugging and about:plugins.
    /// So we replace the original "@mozilla.org/xre/app-info;1" with an instance of XULAppInfo, which implements nsIXULAppInfo's 
    /// methods, and delegate nsIXULRuntime's methods to the original object.
    /// 
    /// P.S., To start AddonManager, run
    ///   Components.utils.import("resource://gre/modules/AddonManager.jsm");
    ///   AddonManagerPrivate.startup();
    /// in some chrome JS code.
    /// </summary>
    [Guid("8E4AABE2-B832-4cff-B213-2174DE2B839F")]
    [ContractID(XULAppInfoFactory.ContractID)]
    internal class XULAppInfoFactory
        : GenericOneClassNsFactory<XULAppInfoFactory, XULAppInfo>
    {
        public const string ContractID = Contracts.XulRuntime;

        public static void Init()
        {
            // This doesn't work yet - crashes C++ -> C# calling  info->GetPlatformBuildID(buildID);
#if false
            XULAppInfo.Init();
            Register();
#endif
        }
    }

    internal class XULAppInfo : nsIXULAppInfo, nsIXULRuntime
    {
        private static nsIXULRuntime backXulRuntime;

        public static void Init()
        {
            backXulRuntime = Xpcom.GetService<nsIXULRuntime>(Contracts.XulRuntime);
        }

        public void GetVendorAttribute(nsACStringBase aVendor)
        {
            aVendor.SetData("Mozilla and geckofx contributors");
        }

        public void GetNameAttribute(nsACStringBase aName)
        {
            aName.SetData("geckofx");
        }

        public void GetIDAttribute(nsACStringBase aID)
        {
            aID.SetData("unknown_id");
        }

        public void GetVersionAttribute(nsACStringBase aVersion)
        {
            aVersion.SetData("60");
        }

        public void GetAppBuildIDAttribute(nsACStringBase aAppBuildID)
        {
            aAppBuildID.SetData("unknown_id");
        }

        public void GetPlatformVersionAttribute(nsACStringBase aPlatformVersion)
        {
            aPlatformVersion.SetData("60");
        }

        //public void GetPlatformBuildIDAttribute(nsACStringBase aPlatformBuildID)
        public void GetPlatformBuildIDAttribute(IntPtr ptr)
        {
            //aPlatformBuildID.SetData("0");
        }

        public void GetUANameAttribute(nsACStringBase aUAName)
        {
            aUAName.SetData("geckofx");
        }

        public bool GetInSafeModeAttribute()
        {
            return backXulRuntime.GetInSafeModeAttribute();
        }

        public bool GetLogConsoleErrorsAttribute()
        {
            return backXulRuntime.GetLogConsoleErrorsAttribute();
        }

        public void SetLogConsoleErrorsAttribute(bool aLogConsoleErrors)
        {
            backXulRuntime.SetLogConsoleErrorsAttribute(aLogConsoleErrors);
        }

        public void GetOSAttribute(nsAUTF8StringBase aOS)
        {
            backXulRuntime.GetOSAttribute(aOS);
        }

        public void GetXPCOMABIAttribute(nsAUTF8StringBase aXPCOMABI)
        {
            backXulRuntime.GetXPCOMABIAttribute(aXPCOMABI);
        }

        public void GetWidgetToolkitAttribute(nsAUTF8StringBase aWidgetToolkit)
        {
            backXulRuntime.GetWidgetToolkitAttribute(aWidgetToolkit);
        }

        public uint GetProcessTypeAttribute()
        {
            return backXulRuntime.GetProcessTypeAttribute();
        }

        public uint GetProcessIDAttribute()
        {
            return backXulRuntime.GetProcessIDAttribute();
        }

        public bool GetBrowserTabsRemoteAutostartAttribute()
        {
            return backXulRuntime.GetBrowserTabsRemoteAutostartAttribute();
        }

        public bool GetAccessibilityEnabledAttribute()
        {
            return backXulRuntime.GetAccessibilityEnabledAttribute();
        }

        public bool GetAccessibilityIsBlacklistedForE10SAttribute()
        {
            return false;
        }

        public bool GetIs64BitAttribute()
        {
            return backXulRuntime.GetIs64BitAttribute();
        }

        public void InvalidateCachesOnRestart()
        {
            backXulRuntime.InvalidateCachesOnRestart();
        }

        public void EnsureContentProcess()
        {
            backXulRuntime.EnsureContentProcess();
        }

        public long GetReplacedLockTimeAttribute()
        {
            return backXulRuntime.GetReplacedLockTimeAttribute();
        }

        public void GetLastRunCrashIDAttribute(nsAStringBase aLastRunCrashID)
        {
            //backXulRuntime.GetLastRunCrashIDAttribute(aLastRunCrashID);
            throw new NotImplementedException();
        }

        public bool GetIsReleaseBuildAttribute()
        {
            //return backXulRuntime.GetIsReleaseBuildAttribute();
            throw new NotImplementedException();
        }

        public bool GetIsOfficialBrandingAttribute()
        {
            return backXulRuntime.GetIsOfficialBrandingAttribute();
        }

        public void GetDefaultUpdateChannelAttribute(nsAUTF8StringBase aDefaultUpdateChannel)
        {
            backXulRuntime.GetDefaultUpdateChannelAttribute(aDefaultUpdateChannel);
        }

        public void GetDistributionIDAttribute(nsAUTF8StringBase aDistributionID)
        {
            backXulRuntime.GetDistributionIDAttribute(aDistributionID);
        }

        public bool GetIsOfficialAttribute()
        {
            //return backXulRuntime.GetIsOfficialAttribute();
            throw new NotImplementedException();
        }

        void nsIPlatformInfo.GetPlatformBuildIDAttribute(nsACStringBase aPlatformBuildID)
        {
            throw new NotImplementedException();
        }

        void nsIXULAppInfo.GetPlatformBuildIDAttribute(nsACStringBase aPlatformBuildID)
        {
            throw new NotImplementedException();
        }

        public ulong GetUniqueProcessIDAttribute()
        {
            throw new NotImplementedException();
        }

        public void GetRemoteTypeAttribute(nsAStringBase aRemoteType)
        {
            throw new NotImplementedException();
        }

        public uint GetMaxWebProcessCountAttribute()
        {
            throw new NotImplementedException();
        }

        public bool GetAccessibleHandlerUsedAttribute()
        {
            throw new NotImplementedException();
        }

        public void GetAccessibilityInstantiatorAttribute(nsAStringBase aAccessibilityInstantiator)
        {
            throw new NotImplementedException();
        }

        public bool GetShouldBlockIncompatJawsAttribute()
        {
            throw new NotImplementedException();
        }

        public bool GetIsReleaseOrBetaAttribute()
        {
            throw new NotImplementedException();
        }

        public bool GetWindowsDLLBlocklistStatusAttribute()
        {
            throw new NotImplementedException();
        }
    }
}
