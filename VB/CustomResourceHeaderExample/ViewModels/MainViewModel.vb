Imports CustomResourceHeaderExample.Data
Imports System.Collections.ObjectModel

Namespace CustomResourceHeaderExample.ViewModels
    Public Class MainViewModel
        Private ReadOnly data As ResourceData

        Protected Sub New()
            data = New ResourceData()
        End Sub
        Public Overridable ReadOnly Property MainResources() As ObservableCollection(Of MyResource)
            Get
                Return data.Resources
            End Get
        End Property
    End Class
End Namespace
