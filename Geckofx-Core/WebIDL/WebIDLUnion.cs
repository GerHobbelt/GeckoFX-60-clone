using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.WebIDL
{
    public class WebIDLUnionBase
    {
        protected List<object> _items = new List<object>();

        protected WebIDLUnionBase(params object[] items)
        {
            Add(items);
        }

        private void Add(params object[] items)
        {
            _items.AddRange(items);
        }        

        public object First => _items[0];

        private object GetDefaultValue(object o)
        {
            if (o == null)
                return null;

            var t = o.GetType();
            if (t.IsValueType)
                return Activator.CreateInstance(t);

            return null;
        }

        public bool IsNull()
        {
            return _items.All(x => x == null || x.Equals(GetDefaultValue(x)));
        }

        public bool IsBool()
        {
            var item = _items.FirstOrDefault(x => x is bool);
            return item != null;
        }

        public bool ToBool()
        {
            var item = _items.FirstOrDefault(x => x is bool);
            return item != null && (bool) item;
        }

        public bool IsComObject()
        {
            var item = _items.FirstOrDefault(x => x is nsISupports);
            return item != null;
        }

        public nsISupports ToComObject()
        {            
            var item = (nsISupports)_items.FirstOrDefault(x => x is nsISupports);
            return item;
        }

        public object Get(int index)
        {
            return _items[index];
        }
    }

    public class WebIDLUnion<T> : WebIDLUnionBase
    {
        public WebIDLUnion(T t1) : base(t1) { }
    }

    public class WebIDLUnion<T1, T2> : WebIDLUnionBase
    {
        public WebIDLUnion(T1 t1, T2 t2) : base(t1, t2) { }
    }

    public class WebIDLUnion<T1, T2, T3> : WebIDLUnionBase
    {
        public WebIDLUnion(T1 t1, T2 t2, T3 t3) : base(t1, t2, t3) { }
    }

    public class WebIDLUnion<T1, T2, T3, T4> : WebIDLUnionBase
    {
        public WebIDLUnion(T1 t1, T2 t2, T3 t3, T4 t4) : base(t1, t2, t3, t4) { }
    }

    public class WebIDLUnion<T1, T2, T3, T4, T5> : WebIDLUnionBase
    {
        public WebIDLUnion(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) : base(t1, t2, t3, t4, t5) { }
    }

    public class WebIDLUnion<T1, T2, T3, T4, T5, T6> : WebIDLUnionBase
    {
        public WebIDLUnion(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) : base(t1, t2, t3, t4, t5, t6) { }
    }

    public class WebIDLUnion<T1, T2, T3, T4, T5, T6, T7> : WebIDLUnionBase
    {
        public WebIDLUnion(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) : base(t1, t2, t3, t4, t5, t6, t7) { }
    }

    public class WebIDLUnion<T1, T2, T3, T4, T5, T6, T7, T8> : WebIDLUnionBase
    {
        public WebIDLUnion(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) : base(t1, t2, t3, t4, t5, t6, t7, t8) { }
    }

    public class WebIDLUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> : WebIDLUnionBase
    {
        public WebIDLUnion(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) : base(t1, t2, t3, t4, t5, t6, t7, t8, t9) { }
    }

    public class WebIDLUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : WebIDLUnionBase
    {
        public WebIDLUnion(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) : base(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) { }
    }
}