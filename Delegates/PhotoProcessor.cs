namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path,PhotoFilterHandler filterHandler)
        {
            var photo = Photo.load(path);
            filterHandler(photo);
            photo.Save();

        }
    }
}