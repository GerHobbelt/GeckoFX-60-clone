using System;
using System.Collections.Generic;

namespace Gecko
{
    /// <summary>
    /// Represents a list of media types.
    /// </summary>
    public class GeckoMediaList : IEnumerable<string>
    {
        internal GeckoMediaList(/* nsIDOMMediaList */nsISupports mediaList)
        {
            this.MediaList = mediaList;
        }

        private /* nsIDOMMediaList */nsISupports MediaList;

        /// <summary>
        /// Gets the number of mediums in the list.
        /// </summary>
        public int Count
        {
            get { /*return (int) MediaList.GetLengthAttribute();*/throw new NotImplementedException(); }
        }

        /// <summary>
        /// Returns the medium at the given index in the list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new ArgumentOutOfRangeException("index");
#if PORTFF60
                var retval = new nsAString();
                MediaList.Item((uint) index, retval);
                return retval.ToString();
#endif
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Appends the specified medium to the list.
        /// </summary>
        /// <param name="medium"></param>
        public void AppendMedium(string medium)
        {
            //MediaList.AppendMedium(new nsAString(medium));
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified medium from the list.
        /// </summary>
        /// <param name="medium"></param>
        public void DeleteMedium(string medium)
        {
            //MediaList.DeleteMedium(new nsAString(medium));
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets the complete list of mediums as a single string.
        /// </summary>
        public string MediaText
        {
            get { /*return nsString.Get(MediaList.GetMediaTextAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(MediaList.SetMediaTextAttribute, value);*/throw new NotImplementedException(); }
        }

        public override string ToString()
        {
            return MediaText;
        }

        #region IEnumerable<string> Members

        public IEnumerator<string> GetEnumerator()
        {
            int length = this.Count;
            for (int i = 0; i < length; i++)
            {
                yield return this[i];
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (string str in this)
                yield return str;
        }

        #endregion
    }
}