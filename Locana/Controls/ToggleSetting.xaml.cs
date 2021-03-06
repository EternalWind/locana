using Locana.DataModel;
using System;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Locana.Controls
{
    public sealed partial class ToggleSetting : UserControl
    {
        public ToggleSetting(AppSettingData<bool> data)
        {
            this.InitializeComponent();
            if (data == null)
            {
                throw new ArgumentNullException("AppSettingData must not be null");
            }
            this.DataContext = data;
        }
    }
}
