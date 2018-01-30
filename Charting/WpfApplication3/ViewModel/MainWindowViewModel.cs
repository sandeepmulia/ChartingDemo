using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication3.Database;
using WpfApplication3.Model;

namespace WpfApplication3
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region "Private Members"
        private ObservableCollection<Commodity> _commodities = new ObservableCollection<Commodity>();
        private ObservableCollection<Commodity> _production = new ObservableCollection<Commodity>();
        private List<int> _years = new List<int>();
        private string _selectedYear = String.Empty;
        #endregion

        #region "Public Properties"
        /// <summary>
        /// Returns the Commodities objects queried from database
        /// Bound to Datagrid
        /// </summary>
        public ObservableCollection<Commodity> Commodities
        {
            get
            {
                return _commodities;
            }

            set
            {
                _commodities = value;
            }
        }

        /// <summary>
        /// Returns the object corresponding to Corn Commodity type objects
        /// </summary>
        public List<Commodity> Corn
        {
            get
            {                
               return _commodities.ToList().FindAll(type => type.CommodityName == "Corn");
            }
        }

        /// <summary>
        /// Returns the object corresponding to Barley Commodity type objects
        /// </summary>
        public List<Commodity> Barley
        {
            get
            {
                return _commodities.ToList().FindAll(type => type.CommodityName == "Barley");
            }
        }
        /// <summary>
        /// Returns the object corresponding to Oats Commodity type objects
        /// </summary>
        public List<Commodity> Oats
        {
            get
            {
                return _commodities.ToList().FindAll(type => type.CommodityName == "Oats");
            }
        }

        /// <summary>
        /// Returns the object corresponding to Production data of the crops
        /// </summary>
        public ObservableCollection<Commodity> ProductionBreakUp
        {
            get
            {
                return _production;
            }

            set
            {
                _production = value;
            }
        }

        /// <summary>
        /// Returns the Years Range to be populated in the combobox
        /// </summary>
        public List<int> Years
        {
            get
            {
                if (_years.Count() == 0)
                {
                    // We don't have data for each year for all the crops, so just build a range
                    //of values
                    var min = _commodities.Min((item) => { return item.HarvestYear;});
                    var max = _commodities.Max((item) => { return item.HarvestYear; });
                    _years.AddRange(Enumerable.Range(min, (max-min+1)));
                }
                return _years;
            }
        }

        /// <summary>
        /// Selected Year in the Combo box
        /// </summary>
        public string SelectedYear
        {
            get
            {
                return _selectedYear;
            }
            set
            {
                _selectedYear = value;
                OnPropertyChanged("SelectedYear");
            }
        }

        /// <summary>
        /// Corn Yield Per Acre list
        /// </summary>
        public List<Commodity> CornYieldPerAcre
        {
            get
            {
                return ProcessedElements("Corn");
            }
        }

        /// <summary>
        /// Barley Yield Per Acre List
        /// </summary>
        public List<Commodity> BarleyYieldPerAcre
        {
            get
            {
                return ProcessedElements("Barley");
            }
        }

        /// <summary>
        /// Oats Yield Per Acre List
        /// </summary>
        public List<Commodity> OatsYieldPerAcre
        {
            get
            {
                return ProcessedElements("Oats");
            }
        }

        #endregion 

        /// <summary>
        /// Main View Model constructor which queries from DB and populates the list
        /// </summary>
        public MainWindowViewModel()
        {
           var dbObjects = DBReader.Instance.ReadFromDatabase();
           dbObjects.ForEach((item) => { _commodities.Add(item); });
           this.PropertyChanged += MainWindowViewModel_PropertyChanged;
        }

        /// <summary>
        /// Property Changed event handler
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">EventArgs</param>
        void MainWindowViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("SelectedYear"))
            {
                _production.Clear();
                var result = _commodities.ToList().FindAll(item => item.Year.Year.ToString() == SelectedYear);
                result.ForEach((item) => _production.Add(item));
            }
        }

        /// <summary>
        /// Helper for Processing elements and building list based on commodityName
        /// </summary>
        /// <param name="commodityName"></param>
        /// <returns></returns>
        public List<Commodity> ProcessedElements(string commodityName)
        {
            var commodityList = new List<Commodity>();
            commodityList.AddRange(_commodities.ToList().FindAll((item) => { return item.CommodityName == commodityName; }));
            return commodityList;
        }
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        #endregion
    }
}
