Imports System
Imports System.Collections.ObjectModel
Imports System.Windows.Media.Imaging

Namespace CustomResourceHeaderExample.Data

    Public Class ResourceData

        Public Shared Function CreateResources() As ObservableCollection(Of MyResource)
            Dim allResources As ObservableCollection(Of MyResource) = New ObservableCollection(Of MyResource)()
            Dim resId As Integer = 0
            Dim resNames As String() = New String() {"Lincoln Bartlett", "Amelia Harper", "Stu Pizaro", "Sandra Johnson", "Victor Norris"}
            Dim resCount As Integer = resNames.Length
            For i As Integer = 0 To resCount - 1
                Dim resource As MyResource = New MyResource()
                resource.Id = Math.Min(Threading.Interlocked.Increment(resId), resId - 1)
                resource.Name = resNames(i)
                resource.IsVisible = True
                Dim imageName As String = String.Format("Images/{0}.png", resource.Name.Replace(" ", ""))
                resource.ResourceImage = New BitmapImage(New Uri(String.Format("pack://application:,,,/CustomResourceHeaderExample;component/{0}", imageName)))
                resource.ResourceImage.Freeze()
                allResources.Add(resource)
            Next

            Return allResources
        End Function
    End Class
End Namespace
