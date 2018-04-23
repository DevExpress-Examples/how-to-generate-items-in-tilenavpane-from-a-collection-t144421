using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication30
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
        }
    }

    public class ViewModel
    {
        public ObservableCollection<Category> Categories
        {
            get;
            set;
        }
        public ViewModel()
        {
            Categories = new ObservableCollection<Category>();
            Category category = new Category() { CategoryName = "Cat1" };
            Item item = new Item() { ItemName = "Cat1Item1" };

            category.Items = new ObservableCollection<Item>();
            item.SubItems = new ObservableCollection<SubItem>();
            item.SubItems.Add(new SubItem() { SubItemName = "Cat1Item1SbItem1" });
            item.SubItems.Add(new SubItem() { SubItemName = "Cat1Item1SbItem2" });
            item.SubItems.Add(new SubItem() { SubItemName = "Cat1Item1SbItem3" });
            category.Items.Add(item);

            item = new Item() { ItemName = "Cat1Item2" }; ;
            item.SubItems = new ObservableCollection<SubItem>();
            item.SubItems.Add(new SubItem() { SubItemName = "Cat1Item2SbItem1" });
            item.SubItems.Add(new SubItem() { SubItemName = "Cat1Item2SbItem2" });
            item.SubItems.Add(new SubItem() { SubItemName = "Cat1Item2SbItem3" });
            category.Items.Add(item);
            this.Categories.Add(category);

            category = new Category() { CategoryName = "Cat2" };
            category.Items = new ObservableCollection<Item>();

            item = new Item() { ItemName = "Cat2Item1" }; ;
            item.SubItems = new ObservableCollection<SubItem>();
            item.SubItems.Add(new SubItem() { SubItemName = "Cat2Item1SbItem1" });
            item.SubItems.Add(new SubItem() { SubItemName = "Cat2Item1SbItem2" });
            item.SubItems.Add(new SubItem() { SubItemName = "Cat2Item1SbItem3" });
            category.Items.Add(item);

            item = new Item() { ItemName = "Cat2Item2" }; ;
            item.SubItems = new ObservableCollection<SubItem>();
            item.SubItems.Add(new SubItem() { SubItemName = "Cat2Item2SbItem1" });
            item.SubItems.Add(new SubItem() { SubItemName = "Cat2Item2SbItem2" });
            item.SubItems.Add(new SubItem() { SubItemName = "Cat2Item2SbItem3" });
            category.Items.Add(item);
            this.Categories.Add(category);

        }
    }

    public class Category
    {
        public string CategoryName
        {
            get;
            set;
        }
        public ObservableCollection<Item> Items
        {
            get;
            set;
        }
    }

    public class Item
    {
        public string ItemName
        {
            get;
            set;
        }
        public ObservableCollection<SubItem> SubItems
        {
            get;
            set;
        }
    }

    public class SubItem
    {
        public string SubItemName
        {
            get;
            set;
        }
    }
}
