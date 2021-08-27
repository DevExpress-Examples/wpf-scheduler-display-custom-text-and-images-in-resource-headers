<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655856/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T603619)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyResource.cs](./CS/CustomResourceHeaderExample/Data/MyResource.cs) (VB: [MyResource.vb](./VB/CustomResourceHeaderExample/Data/MyResource.vb))
* [ResourceData.cs](./CS/CustomResourceHeaderExample/Data/ResourceData.cs) (VB: [ResourceData.vb](./VB/CustomResourceHeaderExample/Data/ResourceData.vb))
* [MainWindow.xaml](./CS/CustomResourceHeaderExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomResourceHeaderExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomResourceHeaderExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomResourceHeaderExample/MainWindow.xaml.vb))
* [MainViewModel.cs](./CS/CustomResourceHeaderExample/ViewModels/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/CustomResourceHeaderExample/ViewModels/MainViewModel.vb))
<!-- default file list end -->
# How to customize resource headers to display custom text and images 


To display an image or text in the resource header, create a custom template and assign it to the <a href="http://help.devexpress.com/#WPF/DevExpressXpfSchedulingViewBase_ResourceHeaderContentTemplatetopic">ViewBase.ResourceHeaderContentTemplate</a> property. <br>The <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfSchedulingResourceItemtopic">ResourceItem</a> object has no property that contains an associated image, so use <a href="http://help.devexpress.com/#WPF/CustomDocument119962">custom fields</a> to obtain an image when necessary.<br>The resulting application is shown below.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-resource-headers-to-display-custom-text-and-images-t603619/17.2.3+/media/56dddaff-fb22-4d7b-a86c-5aec44761374.png">

<br/>


