using System;
using System.Runtime.InteropServices;
using Gecko.Interop;

namespace Gecko.DOM
{
    public sealed class DomEventTarget
    {
        private readonly mozIDOMWindowProxy _window;
        private ComPtr<nsIDOMEventTarget> _target;

        private DomEventTarget(mozIDOMWindowProxy window, nsIDOMEventTarget target)
        {
            _window = window;
            _target = new ComPtr<nsIDOMEventTarget>(target);
        }

        public static DomEventTarget Create(mozIDOMWindowProxy window, nsIDOMEventTarget target)
        {
            return new DomEventTarget((mozIDOMWindowProxy)window, target);
        }

        public nsIDOMEventTarget NativeObject
        {
            get { return _target.Instance; }
        }

        public GeckoElement CastToGeckoElement()
        {
            var domElement = Xpcom.QueryInterface<nsIDOMElement>(_target.Instance);

            return domElement.Wrap(_window, GeckoElement.CreateDomElementWrapper);
        }


        public void DispatchEvent(DomEventArgs @event)
        {
            _target.Instance.DispatchEvent(@event.DomEvent);
        }

        public void AddEventListener(string type, nsIDOMEventListener listener, bool useCapture, bool wantUntrusted,
            int argc)
        {
            using (var nType = new nsAString(type))
            {
                _target.Instance.AddEventListener(nType, listener, useCapture, wantUntrusted, argc);
            }
        }

        public void RemoveEventListener(string type, nsIDOMEventListener listener, bool useCapture)
        {
            using (var nType = new nsAString(type))
                try
                {
                    _target.Instance.RemoveEventListener(nType, listener, useCapture);
                }
                catch(InvalidComObjectException)
                {
                    // Ignore
                }
        }

        /// <summary>
        /// Returns the nsPIDOMEventTarget object which should be used as the target
        /// of DOMEvents.
        /// Usually |this| is returned, but for example global object returns
        /// the outer object.
        /// </summary>
        public DomEventTarget TargetForDOMEvent
        {
            get { return _target.Instance.GetTargetForDOMEvent().Wrap((mozIDOMWindowProxy)_target.Instance.GetTargetForDOMEvent(), Create); }
        }

        /// <summary>
        /// Returns the nsPIDOMEventTarget object which should be used as the target
        /// of the event and when constructing event target chain.
        /// Usually |this| is returned, but for example global object returns
        /// the inner object.
        /// </summary>
        public DomEventTarget TargetForEventTargetChain
        {
            get { return _target.Instance.GetTargetForEventTargetChain().Wrap((mozIDOMWindowProxy)_target.Instance.GetTargetForDOMEvent(), Create); }
        }
    }
}