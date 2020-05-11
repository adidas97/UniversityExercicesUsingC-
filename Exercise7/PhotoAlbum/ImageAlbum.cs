using System;
using System.Collections.ObjectModel;

namespace PhotoAlbum
{
    public enum ChangeType
    {
        Added,
        Removed,
        Replaced,
        Cleared
    };
    public class PhotosChangedEventArgs : EventArgs
    {
        public readonly Photo ChangedItem;
        public readonly ChangeType ChangeType;
        public readonly Photo ReplacedWith;
        public PhotosChangedEventArgs(ChangeType change, Photo item,
        Photo replacement)
        {
            ChangeType = change;
            ChangedItem = item;
            ReplacedWith = replacement;
        }
    }
    [Serializable]
    public class ImageAlbum : Collection<Photo>
    {
        [field: NonSerialized]
        public event EventHandler<PhotosChangedEventArgs> Changed;
        private int currentPos = 0;
             
         public int CurrentPosition
        {
            get { return currentPos; }
            set
            {
                if (value <= 0)
                {
                    currentPos = 0;
                }
                else if (value >= this.Count)
                {
                    currentPos = this.Count - 1;
                }
                else
                {
                    currentPos = value;
                }
            }
        }
        public Photo CurrentPhoto
        {
            get
            {
                if (this.Count == 0)
                    return null;
                return this[CurrentPosition];
            }
        }
        public bool CurrentNext()
        {
            if (CurrentPosition + 1 < this.Count)
            {
                CurrentPosition++;
                return true;
            }
            return false;
        }
        public bool CurrentPrev()
        {
            if (CurrentPosition > 0)
            {
                CurrentPosition--;
                return true;
            }
            return false;
        }
    }
}
