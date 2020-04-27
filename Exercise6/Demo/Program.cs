using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoAlbum;

namespace Demo
{
    class Program
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll",
        EntryPoint = "GetConsoleWindow", SetLastError = true)]
        private static extern IntPtr GetConsoleHandle();

        public static ImageAlbum ReadFile(string fileName)
        {
            ImageAlbum list = new ImageAlbum();
            string s;
            using (StreamReader r = new StreamReader(
            new FileStream(fileName, FileMode.Open)))
            {
                try
                {
                    while ((s = r.ReadLine()) != null)
                    {
                        Photo element = new Photo(s);
                        list.Add(element);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read.");
                    Console.WriteLine(e.ToString());
                    throw;
                }
            }
            return list;
        }
        public static void WriteFile(string fileName, ImageAlbum list)
        {
            using (StreamWriter w = new StreamWriter(
            new FileStream(fileName, FileMode.Create)))
            {
                try
                {
                    foreach (Photo element in list)
                        w.WriteLine(element);
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be written.");
                    Console.WriteLine(e.ToString());
                    throw;
                }
            }
        }

        static void Main(string[] args)
        {
            // Create and initialize a new Collection<Photo>.
           ImageAlbum album = new ImageAlbum();
           // Add album as a subscriber of themChanged event.
           album.Changed += new Program().ChangedHandler;
           // Add elements to the collection.
           album.Add(
           new Photo(@"C:\Users\adida\Desktop\images\f1.jpg"));
           album.Add(
           new Photo(@"C:\Users\adida\Desktop\images\f2.jpg"));
           album.Add(
           new Photo(@"C:\Users\adida\Desktop\images\f3.jpg"));
           album.Add(
           new Photo(@"C:\Users\adida\Desktop\images\f4.jpg"));
         
           WriteFile("result.txt", album);
           

            // Display the contents of the collection using foreach.
            Console.WriteLine("Contents of the collection (using foreach): "
            + "<Enter>");
            Console.ReadKey();
            Display1(album);
            // Display the contents of the collection using the enumerator.
            Console.WriteLine("Contents of the collection (using enumerator): "
            + "<Enter>");
            DrawRectangle(50, 320, 140, 160);
            Console.ReadKey();
            Display2(album);
            // Display the contents of the collection using the Count property
            // and the Item property.
            Console.WriteLine("Initial contents of the collection "
            + "(using Count and Item): <Enter>");
            DrawRectangle(50, 320, 140, 160);
            Console.ReadKey();
            Display3(album);            Photo photo;
            // Search the collection with Contains and IndexOf.
            photo = new
            Photo(@"C:\Users\adida\Desktop\images\f2.jpg");
            Console.WriteLine("Contains({0}): {1}", photo.FileName,
            album.Contains(photo));
            DrawPhoto(photo, 50, 320, 140, 160);
            Console.WriteLine("IndexOf({0}): {1}", photo.FileName,
            album.IndexOf(photo));
            Console.ReadKey();
            // Insert an element into the collection at index 3.
            photo = new
            Photo(@"C:\Users\adida\Desktop\images\h1.jpg");
            Console.WriteLine("Insert(3, {0})", photo.FileName);
            DrawPhoto(photo, 50, 320, 140, 160);            album.Insert(3, photo);
            Console.WriteLine(
           "Contents of the collection after inserting h1.jpg at index 3:<Enter>");
            DrawRectangle(50, 320, 140, 160);
            Console.ReadKey();
            Display1(album);
            // Get an element using the index.
            Console.WriteLine("album[3]: {0}", album[3].FileName);
            DrawRectangle(50, 320, 140, 160);
            DrawPhoto(album[3], 50, 320, 140, 160);
            // Set an element using the index.
            photo = new
            Photo(@"C:\Users\adida\Desktop\images\h2.jpg");
            Console.WriteLine("albbum[4] = {0}", photo.FileName);
            DrawPhoto(photo, 50, 320, 140, 160);            Console.WriteLine("Contents of the collection after setting "
 + "h2.jpg at index 4: <Enter>");
            DrawRectangle(50, 320, 140, 160);
            Console.ReadKey();
            album[4] = photo;
            Display1(album);
            // Remove an element from the collection.
            photo = new
            Photo(@"C:\Users\adida\Desktop\images\f2.jpg");
            Console.WriteLine("Remove({0})", photo.FileName);            Console.WriteLine("Contents of the collection after removing "
 + "f2.jpg:<Enter>");
            DrawRectangle(50, 320, 140, 160);
            Console.ReadKey();
            album.Remove(photo);
            Display1(album);            Console.WriteLine("RemoveAt(0)");
            Console.WriteLine("Contents of the collection after removing "
            + "at 0: <Enter>");
            DrawRectangle(50, 320, 140, 160);
            Console.ReadKey();
            album.RemoveAt(0);
            Display1(album);            Console.WriteLine("Clear");
            Console.WriteLine("Contents of the collection after "
            + "clearing: <Enter>");
            DrawRectangle(50, 320, 140, 160);
            Console.ReadKey();
            album.Clear();
            Display1(album);
        }
        private void ChangedHandler(object source, PhotosChangedEventArgs e)
        {
            if (e.ChangeType == ChangeType.Replaced)
            {
                Console.WriteLine("{0} was replaced with {1}",
                e.ChangedItem.FileName, e.ReplacedWith.FileName);
            }
            else if (e.ChangeType == ChangeType.Cleared)
            {
                Console.WriteLine("The photo list was cleared.");
            }
            else
            {
                Console.WriteLine("{0} was {1}.", e.ChangedItem.FileName,
                e.ChangeType);
            }
        }
        public static void DrawPhoto(Photo photo, int x, int y, int width, int height)
        {
            var handler = GetConsoleHandle();
            using (var graphics = Graphics.FromHwnd(handler))
            {
                var image = photo.Image;
                graphics.DrawImage(image, x, y, width, height);
            }
            Console.ReadKey();
        }        public static void DrawRectangle(int x, int y, int width, int height)
        {
            var handler = GetConsoleHandle();
            using (var graphics = Graphics.FromHwnd(handler))
            {
                SolidBrush brush = new SolidBrush(Color.Black);
                graphics.FillRectangle(brush, x, y, width, height);
            }
        }        private static void Display1(ImageAlbum myCol)
        {
            foreach (Photo photo in myCol)
            {
                DrawPhoto(photo, 50, 320, 140, 160);
            }
        }        public static void Display2(ImageAlbum myCol)
        {
            System.Collections.IEnumerator myEnumerator =
            myCol.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                Photo photo = (Photo)myEnumerator.Current;
                DrawPhoto(photo, 50, 320, 140, 160);
            }
        }        public static void Display3(ImageAlbum myCol)
        {
            for (int i = 0; i < myCol.Count; i++)
            {
                DrawPhoto(myCol[i], 50, 320, 140, 160);
            }
        }
    }
}
