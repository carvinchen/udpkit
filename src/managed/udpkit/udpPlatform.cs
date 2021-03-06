﻿/*
* The MIT License (MIT)
* 
* Copyright (c) 2012-2014 Fredrik Holmstrom (fredrik.johan.holmstrom@gmail.com)
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

namespace UdpKit {
    public enum UdpSocketPlatformError {
        None = 0,
        Unknown = 1,
        WouldBlock = 2
    }

    public abstract class UdpPlatform {
        public abstract UdpSocketPlatformError Error { get; }
        public abstract UdpEndPoint EndPoint { get; }
        public abstract long PlatformError { get; }
        public abstract string PlatformErrorString { get; }
        public abstract uint PlatformPrecisionTime { get; }
        public abstract bool Close ();
        public abstract bool Bind (UdpEndPoint endpoing);
        public abstract bool RecvPoll (int timeoutInMs);
        public abstract bool RecvFrom (byte[] buffer, int bufferSize, ref int bytesReceived, ref UdpEndPoint remoteEndpoint);
        public abstract bool SendTo (byte[] buffer, int bytesToSend, UdpEndPoint endpoint, ref int bytesSent);
    }
}