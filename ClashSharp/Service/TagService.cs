using ClashSharp.Interface;
using System;

namespace ClashSharp.Service
{
    public class TagService : ITagService
    {
        public string EncodeTag(string tag)
        {
            // make sure our tag starts with a #
            if (tag.StartsWith("#") == false)
            {
                throw new Exception("Tags start with '#'");
            }

            // encode our tag
            return tag.Replace("#", "%23");
        }
    }
}
