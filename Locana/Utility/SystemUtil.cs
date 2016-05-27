using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.Resources;
using Windows.UI.Core;
using Windows.Storage;
using System;
using System.Threading.Tasks;

namespace Locana.Utility
{
    public static class SystemUtil
    {
        public static string GetStringResource(string key)
        {
            return ResourceLoader.GetForCurrentView().GetString(key);
        }

        public static CoreDispatcher GetCurrentDispatcher()
        {
            return CoreApplication.MainView?.CoreWindow?.Dispatcher;
        }

        public static async Task<StorageFolder> CreateFolderRecursiveAsync(this StorageFolder obj, string path, CreationCollisionOption option)
        {
            path = path.Replace('/', '\\').TrimEnd('\\');
            string[] folderNames = path.Split('\\');

            StorageFolder current = obj;
            foreach (var folderName in folderNames)
            {
                current = await current.CreateFolderAsync(folderName, option);
            }

            return current;
        }
    }
}
