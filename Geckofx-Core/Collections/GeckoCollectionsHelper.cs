using System;

namespace Gecko.Collections
{
    internal static class GeckoCollectionsHelper
    {
        internal static nsIMutableArray CreateArray()
        {
            return Xpcom.CreateInstance<nsIMutableArray>(Contracts.Array);
        }

        internal static T GetElementAs<T>(this nsIArray array, uint index)
        {
            Guid uid = typeof (T).GUID;
            var ptr = array.QueryElementAt(index, ref uid);
            var obj = (T) Xpcom.GetObjectForIUnknown(ptr);
            return obj;
        }
    }
}