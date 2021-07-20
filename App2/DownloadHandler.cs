// Copyright © 2021 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
using System;
using App2;

namespace CefSharp.Example.Handlers
{
    /// <summary>
    /// Class used to handle file downloads.
    /// The methods of this class will called on the CEF UI thread. 
    /// </summary>
    public class DownloadHandler : IDownloadHandler
    {
        public event EventHandler<DownloadItem> OnBeforeDownloadFired;
        static DowLoadStatus dowLoadStatus = new DowLoadStatus();
        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;
        static DownloadItem _dowloaditem = new DownloadItem();
        
        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            OnBeforeDownloadFired?.Invoke(this, downloadItem);
            if (downloadItem.IsValid)
            {
                dowLoadStatus.DownloadBar.Value = 0;
                dowLoadStatus.NameFile.Text = downloadItem.SuggestedFileName;
                _dowloaditem = downloadItem;
            }
            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    callback.Continue(downloadItem.SuggestedFileName, showDialog: true);
                }
            }
        }

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            OnDownloadUpdatedFired?.Invoke(this, downloadItem);
            if (downloadItem.IsValid)
            {
                dowLoadStatus.DownloadBar.Value = downloadItem.PercentComplete;
            }
        }
    }
}
