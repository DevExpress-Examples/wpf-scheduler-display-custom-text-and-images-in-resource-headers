using DevExpress.Mvvm.POCO;
using System.Windows.Media;

namespace CustomResourceHeaderExample.Data
{
    public class MyResource
    {
        public static MyResource Create()
        {
            return ViewModelSource.Create(() => new MyResource());
        }
        protected MyResource() { }

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual ImageSource ResourceImage { get; set; }
        public virtual bool IsVisible { get; set; }
    }
}
