using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Picture
    {
        public int Id { get; set; }
        public Byte[] PictureBinary { get; set; }
        public string MimeType { get; set; }
    }
}
