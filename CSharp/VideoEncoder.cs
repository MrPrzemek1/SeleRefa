using System;
using System.Threading;

namespace CSharp
{
    internal class VideoEncoder
    {
        public void Encode(Video video)
        {
            System.Console.WriteLine("Video Encoding..");
            Thread.Sleep(2000);
            OnVideoEncoded();
        }
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded!= null)
            {
                VideoEncoded(this,EventArgs.Empty);
            }
        }
    }
}