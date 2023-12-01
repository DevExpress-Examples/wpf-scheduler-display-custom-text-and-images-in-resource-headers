using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace CustomResourceHeaderExample.Data {
    public class ResourceData {
        public static ObservableCollection<MyResource> CreateResources() {
            ObservableCollection<MyResource> allResources = new ObservableCollection<MyResource>();
            int resId = 0;
            string[] resNames = new string[] { "Lincoln Bartlett", "Amelia Harper", "Stu Pizaro", "Sandra Johnson", "Victor Norris" };
            int resCount = resNames.Length;
            for (int i = 0; i < resCount; i++) {
                MyResource resource = new MyResource();
                resource.Id = resId++;
                resource.Name = resNames[i];
                resource.IsVisible = true;
                string imageName = String.Format("Images/{0}.png", resource.Name.Replace(" ", ""));
                resource.ResourceImage = new BitmapImage(new Uri(string.Format("pack://application:,,,/CustomResourceHeaderExample;component/{0}", imageName)));
                resource.ResourceImage.Freeze();
                allResources.Add(resource);
            }
            return allResources;
        }
    }
}
