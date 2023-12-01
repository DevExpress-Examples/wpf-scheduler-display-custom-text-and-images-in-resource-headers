using System.Windows.Media;

namespace CustomResourceHeaderExample.Data {
    public class MyResource {
        public int Id { get; set; }
        public string Name { get; set; }
        public ImageSource ResourceImage { get; set; }
        public  bool IsVisible { get; set; }
    }
}
