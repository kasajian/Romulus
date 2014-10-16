using System;
using System.Collections;
using System.Collections.Generic;

namespace SiteAudit_Analyzer.Data
{
    public class CompositeList : IList
    {
        private readonly List<int> m_chapterStartingIndex = new List<int>();
        private readonly IList<IList> m_chapters = new List<IList>();

        public CompositeList(IEnumerable<IList> chapters)
        {
            Count = 0;
            foreach (var chapter in chapters)
            {
                m_chapters.Add(chapter);
                m_chapterStartingIndex.Add(Count);
                Count += chapter.Count;
            }
        }

        public int Count { get; private set; }

        public virtual object this[int index]
        {
            get
            {
                var chapterIndex = m_chapterStartingIndex.BinarySearch(index);
                if (chapterIndex < 0)
                {
                    chapterIndex = ~chapterIndex - 1;
                }
                return m_chapters[chapterIndex][index - m_chapterStartingIndex[chapterIndex]];
            }

            set { throw new NotImplementedException(); }
        }

        bool IList.IsReadOnly
        {
            get { return true; }
        }

        bool IList.IsFixedSize
        {
            get { return true; }
        }

        #region UnImplementedMethods

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        object ICollection.SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection.IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        int IList.Add(object value)
        {
            throw new NotImplementedException();
        }

        bool IList.Contains(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Clear()
        {
            throw new NotImplementedException();
        }

        int IList.IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        void IList.Remove(object value)
        {
            throw new NotImplementedException();
        }

        void IList.RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}