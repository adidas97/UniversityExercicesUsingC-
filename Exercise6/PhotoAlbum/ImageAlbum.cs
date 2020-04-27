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
    public class ImageAlbum : Collection<Photo>
    {
        public event EventHandler<PhotosChangedEventArgs> Changed;
        protected override void InsertItem(int index, Photo newItem)
        {
            base.InsertItem(index, newItem);
            EventHandler<PhotosChangedEventArgs> temp = Changed;
            if (temp != null)
            {
                temp(this, new PhotosChangedEventArgs(ChangeType.Added,
                newItem, null));
            }
        }

        protected override void SetItem(int index, Photo newItem)
        {
            Photo replaced = Items[index];
            base.SetItem(index, newItem);
            EventHandler<PhotosChangedEventArgs> temp = Changed;
            if (temp != null)
            {
                temp(this, new PhotosChangedEventArgs(ChangeType.Replaced,
                replaced, newItem));
            }
        }
        protected override void RemoveItem(int index)
        {
            Photo removedItem = Items[index];
            base.RemoveItem(index);
            EventHandler<PhotosChangedEventArgs> temp = Changed;
            if (temp != null)
            {
                temp(this, new PhotosChangedEventArgs(ChangeType.Removed,
                removedItem, null));
            }
        }
        protected override void ClearItems()
        {
            base.ClearItems();
            EventHandler<PhotosChangedEventArgs> temp = Changed;
            if (temp != null)
            {
                temp(this, new PhotosChangedEventArgs(ChangeType.Cleared,
                null, null));
            }
        }
    }
}
