using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.DOM
{
    public sealed class DomNavigator
    {
        private /*nsIDOMNavigator x*/nsISupports _navigator;

        internal DomNavigator(/*nsIDOMNavigator */nsISupports navigator)
        {
            _navigator = navigator;
        }

        public string AppCodeName
        {
            get { /*return nsString.Get(_navigator.GetAppCodeNameAttribute); */throw new NotImplementedException(); }
        }

        public string AppName
        {
            get { /*return nsString.Get(_navigator.GetAppNameAttribute);*/throw new NotImplementedException(); }
        }

        public string AppVersion
        {
            get { /*return nsString.Get(_navigator.GetAppVersionAttribute);*/ throw new NotImplementedException(); }
        }

        public string BuildID
        {
            get { /*return nsString.Get(_navigator.GetBuildIDAttribute);*/ throw new NotImplementedException(); }
        }

        public string DoNotTrack
        {
            get { /*return nsString.Get(_navigator.GetDoNotTrackAttribute);*/ throw new NotImplementedException(); }
        }

        public string Language
        {
            get { /*return nsString.Get(_navigator.GetLanguageAttribute);*/ throw new NotImplementedException(); }
        }

        public string Oscpu
        {
            get { /*return nsString.Get(_navigator.GetOscpuAttribute);*/throw new NotImplementedException(); }
        }

        public string Platform
        {
            get { /*return nsString.Get(_navigator.GetPlatformAttribute);*/ throw new NotImplementedException(); }
        }

        //_navigator.GetPluginsAttribute(  );

        public string Product
        {
            get { /*return nsString.Get(_navigator.GetProductAttribute);*/throw new NotImplementedException(); }
        }

        public string ProductSub
        {
            get { /*return nsString.Get(_navigator.GetProductSubAttribute);*/throw new NotImplementedException(); }
        }

        public string UserAgent
        {
            get { /*return nsString.Get(_navigator.GetUserAgentAttribute);*/throw new NotImplementedException(); }
        }

        public string Vendor
        {
            get { /*return nsString.Get(_navigator.GetVendorAttribute);*/throw new NotImplementedException(); }
        }

        public string GetVendorSub
        {
            get { /*return nsString.Get(_navigator.GetVendorSubAttribute);*/throw new NotImplementedException(); }
        }
    }
}