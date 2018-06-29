namespace Gecko
{
    public class DomUIEventArgs
        : DomEventArgs
    {
        private nsIDOMUIEvent _Event;

        internal DomUIEventArgs(nsIDOMUIEvent ev)
            : base((nsIDOMEvent)ev)
        {
            _Event = ev;
        }

        public static DomUIEventArgs Create(nsIDOMUIEvent ev)
        {
            if (ev is nsIDOMMouseEvent)
            {
                return DomMouseEventArgs.Create((nsIDOMMouseEvent) ev);
            }
#if PORTFF60
            else if (ev is nsIDOMKeyEvent)
            {
                return DomKeyEventArgs.Create((nsIDOMKeyEvent) ev);
            }
#endif

            return new DomUIEventArgs(ev);
        }


        public int Detail
        {
            get { return _Event.GetDetailAttribute(); }
        }
    };
}