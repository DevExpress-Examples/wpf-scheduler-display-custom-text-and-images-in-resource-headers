Imports DevExpress.Mvvm.POCO
Imports System.Windows.Media

Namespace CustomResourceHeaderExample.Data
    Public Class MyResource
        Public Shared Function Create() As MyResource
            Return ViewModelSource.Create(Function() New MyResource())
        End Function
        Protected Sub New()
        End Sub

        Public Overridable Property Id() As Integer
        Public Overridable Property Name() As String
        Public Overridable Property ResourceImage() As ImageSource
        Public Overridable Property IsVisible() As Boolean
    End Class
End Namespace
