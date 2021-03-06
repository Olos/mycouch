﻿using System.Net.Http;
using System.Net.Http.Headers;

namespace MyCouch.Net
{
    public class BytesContent : ByteArrayContent
    {
        public BytesContent(byte[] content, string contentType) : base(content)
        {
            Headers.ContentType = new MediaTypeHeaderValue(contentType);
        }
    }
}