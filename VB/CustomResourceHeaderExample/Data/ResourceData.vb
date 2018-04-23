Imports System
Imports System.Collections.ObjectModel
Imports System.Windows.Media.Imaging

Namespace CustomResourceHeaderExample.Data
    Public Class ResourceData
        Public Sub CreateResources()
            Dim allResources As New ObservableCollection(Of MyResource)()
            Dim resId As Integer = 0
            Dim resNames() As String = { "Lincoln Bartlett", "Amelia Harper", "Stu Pizaro", "Sandra Johnson", "Victor Norris" }
            Dim resCount As Integer = resNames.Length
            For i As Integer = 0 To resCount - 1
                Dim resource As MyResource = MyResource.Create()
                resource.Id = resId
                resId += 1
                resource.Name = resNames(i)
                resource.IsVisible = True
                Dim imageName As String = String.Format("Images/{0}.png", resource.Name.Replace(" ", ""))
                resource.ResourceImage = New BitmapImage(New Uri(String.Format("pack://application:,,,/CustomResourceHeaderExample;component/{0}", imageName)))
                resource.ResourceImage.Freeze()
                allResources.Add(resource)
            Next i
            Resources = allResources
        End Sub

        Private privateResources As ObservableCollection(Of MyResource)
        Public Property Resources() As ObservableCollection(Of MyResource)
            Get
                Return privateResources
            End Get
            Private Set(ByVal value As ObservableCollection(Of MyResource))
                privateResources = value
            End Set
        End Property

        Public Sub New()
            CreateResources()
        End Sub
    End Class
End Namespace
