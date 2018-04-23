Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace WpfApplication30
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Me.DataContext = New ViewModel()
        End Sub
    End Class

    Public Class ViewModel
        Public Property Categories() As ObservableCollection(Of Category)
        Public Sub New()
            Categories = New ObservableCollection(Of Category)()
            Dim category As New Category() With {.CategoryName = "Cat1"}
            Dim item As New Item() With {.ItemName = "Cat1Item1"}

            category.Items = New ObservableCollection(Of Item)()
            item.SubItems = New ObservableCollection(Of SubItem)()
            item.SubItems.Add(New SubItem() With {.SubItemName = "Cat1Item1SbItem1"})
            item.SubItems.Add(New SubItem() With {.SubItemName = "Cat1Item1SbItem2"})
            item.SubItems.Add(New SubItem() With {.SubItemName = "Cat1Item1SbItem3"})
            category.Items.Add(item)

            item = New Item() With {.ItemName = "Cat1Item2"}

            item.SubItems = New ObservableCollection(Of SubItem)()
            item.SubItems.Add(New SubItem() With {.SubItemName = "Cat1Item2SbItem1"})
            item.SubItems.Add(New SubItem() With {.SubItemName = "Cat1Item2SbItem2"})
            item.SubItems.Add(New SubItem() With {.SubItemName = "Cat1Item2SbItem3"})
            category.Items.Add(item)
            Me.Categories.Add(category)

            category = New Category() With {.CategoryName = "Cat2"}
            category.Items = New ObservableCollection(Of Item)()

            item = New Item() With {.ItemName = "Cat2Item1"}

            item.SubItems = New ObservableCollection(Of SubItem)()
            item.SubItems.Add(New SubItem() With {.SubItemName = "Cat2Item1SbItem1"})
            item.SubItems.Add(New SubItem() With {.SubItemName = "Cat2Item1SbItem2"})
            item.SubItems.Add(New SubItem() With {.SubItemName = "Cat2Item1SbItem3"})
            category.Items.Add(item)

            item = New Item() With {.ItemName = "Cat2Item2"}

            item.SubItems = New ObservableCollection(Of SubItem)()
            item.SubItems.Add(New SubItem() With {.SubItemName = "Cat2Item2SbItem1"})
            item.SubItems.Add(New SubItem() With {.SubItemName = "Cat2Item2SbItem2"})
            item.SubItems.Add(New SubItem() With {.SubItemName = "Cat2Item2SbItem3"})
            category.Items.Add(item)
            Me.Categories.Add(category)

        End Sub
    End Class

    Public Class Category
        Public Property CategoryName() As String
        Public Property Items() As ObservableCollection(Of Item)
    End Class

    Public Class Item
        Public Property ItemName() As String
        Public Property SubItems() As ObservableCollection(Of SubItem)
    End Class

    Public Class SubItem
        Public Property SubItemName() As String
    End Class
End Namespace
