Imports CustomResourceHeaderExample.Data
Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace CustomResourceHeaderExample.ViewModels

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Sub New()
            MainResources = ResourceData.CreateResources()
        End Sub

        Public ReadOnly Property MainResources As ObservableCollection(Of MyResource)
    End Class
End Namespace
