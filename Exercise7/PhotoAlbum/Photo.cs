using System;
using System.Drawing;

namespace PhotoAlbum
{
    [Serializable]
    public class Photo : IEquatable<Photo>
    {
        private string fileName;
        private Bitmap image;

        public Photo(string fileName)
        {
            this.fileName = fileName;
            this.image = null;
        }        public string FileName
        {
            get { return fileName; }
        }
        public Bitmap Image
        {
            get
            {
                if (image == null)
                {
                    image = new Bitmap(fileName, true);
                }
                return image;
            }
        }        public bool Equals(Photo other)
        {
            if (other == null)
                return false;
            if (this.fileName == other.fileName)
                return true;
            else
                return false;
        }        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            Photo photoObj = obj as Photo;
            if (photoObj == null)
                return false;
            else
                return Equals(photoObj);
        }
        public override int GetHashCode()
        {
            return this.FileName.GetHashCode();
        }        public static bool operator ==(Photo photo1, Photo photo2)
        {
            if (((object)photo1) == null || ((object)photo2) == null)
                return Object.Equals(photo1, photo2);
            return photo1.Equals(photo2);
        }
        public static bool operator !=(Photo photo1, Photo photo2)
        {
            if (((object)photo1) == null || ((object)photo2) == null)
                return !Object.Equals(photo1, photo2);
            return !(photo1.Equals(photo2));
        }        public override string ToString()
        {
            return $"{fileName}";
        }
    }
}