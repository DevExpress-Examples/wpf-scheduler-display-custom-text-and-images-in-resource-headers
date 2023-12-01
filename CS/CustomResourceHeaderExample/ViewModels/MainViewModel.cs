using CustomResourceHeaderExample.Data;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace CustomResourceHeaderExample.ViewModels {
    public class MainViewModel : ViewModelBase {

        public MainViewModel() {
            MainResources = ResourceData.CreateResources();
        }
        public ObservableCollection<MyResource> MainResources { get; }
    }
}
