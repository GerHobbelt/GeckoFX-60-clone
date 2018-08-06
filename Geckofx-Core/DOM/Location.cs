using System;
using Gecko.Interop;

namespace Gecko.DOM
{
    public sealed class Location
    {
        private readonly nsISupports _window;
        private ComPtr</* nsIDOMLocation */ nsISupports> _location;

        private Location(nsISupports window,/* nsIDOMLocation */ nsISupports location)
        {
            _window = window;
            _location = new ComPtr</* nsIDOMLocation */ nsISupports>(location);
        }

        public static Location Create(nsISupports window,/* nsIDOMLocation */ nsISupports location)
        {
            return new Location(window, location);
        }

        public string Hash
        {
            get { /*return nsString.Get(_location.Instance.GetHashAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_location.Instance.SetHashAttribute, value);*/throw new NotImplementedException(); }
        }

        public string Host
        {
            get { /*return nsString.Get(_location.Instance.GetHostAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_location.Instance.SetHostAttribute, value);*/throw new NotImplementedException(); }
        }

        public string Hostname
        {
            get { /*return nsString.Get(_location.Instance.GetHostnameAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_location.Instance.GetHostnameAttribute, value);*/throw new NotImplementedException(); }
        }

        public string Href
        {
            get { /*return nsString.Get(_location.Instance.GetHrefAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_location.Instance.SetHrefAttribute, value);*/throw new NotImplementedException(); }
        }

        public string Pathname
        {
            get { /*return nsString.Get(_location.Instance.GetPathnameAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_location.Instance.SetPathnameAttribute, value);*/throw new NotImplementedException(); }
        }

        public string Port
        {
            get { /*return nsString.Get(_location.Instance.GetPortAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_location.Instance.SetPortAttribute, value);*/throw new NotImplementedException(); }
        }

        public string Protocol
        {
            get { /*return nsString.Get(_location.Instance.GetProtocolAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_location.Instance.SetProtocolAttribute, value);*/throw new NotImplementedException(); }
        }

        public string Search
        {
            get { /*return nsString.Get(_location.Instance.GetSearchAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_location.Instance.SetSearchAttribute, value);*/throw new NotImplementedException(); }
        }

        public void Reload(bool forceget)
        {
            //_location.Instance.Reload(forceget);
            throw new NotImplementedException();
        }


        public void Replace(string url)
        {
            //nsString.Set(_location.Instance.Replace, url);
            throw new NotImplementedException();
        }

        public void Assign(string url)
        {
            //nsString.Set(_location.Instance.Assign, url);
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            //return nsString.Get(_location.Instance.ToString);
            throw new NotImplementedException();
        }
    }
}