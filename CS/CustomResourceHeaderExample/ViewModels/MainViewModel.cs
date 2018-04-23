using CustomResourceHeaderExample.Data;
using System.Collections.ObjectModel;

namespace CustomResourceHeaderExample.ViewModels
{
    public class MainViewModel
    {
        readonly ResourceData data;

        protected MainViewModel()
        {
            data = new ResourceData();
        }
        public virtual ObservableCollection<MyResource> MainResources { get { return data.Resources; } }
    }
}
