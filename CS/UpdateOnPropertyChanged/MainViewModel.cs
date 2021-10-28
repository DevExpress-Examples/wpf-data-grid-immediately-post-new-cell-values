using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using System.Linq;

namespace UpdateOnPropertyChanged {
    public class Item : BindableBase {
        public int ID {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }
        public string Name {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }

    public class MainViewModel : ViewModelBase {
        public ObservableCollection<Item> Items {
            get { return GetValue<ObservableCollection<Item>>(); }
            set { SetValue(value); }
        }
        public Item SelectedItem {
            get { return GetValue<Item>(); }
            set { SetValue(value); }
        }

        public MainViewModel() {
            Items = GetData();
        }

        static ObservableCollection<Item> GetData() {
            var collection = Enumerable.Range(0, 5).Select(x => new Item { ID = x, Name = "Name" + x });
            return new ObservableCollection<Item>(collection);
        }
    }
}
