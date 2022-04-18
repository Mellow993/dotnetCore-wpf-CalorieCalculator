using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace CalorieCalculator.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private string _nutriment;
        private int _amount;
        public string Nutriment
        {
            get => _nutriment;
            set
            { 
                if(_nutriment != value && string.IsNullOrWhiteSpace(value))
                {
                    _nutriment = value;
                    OnPropertyChanged(nameof(Nutriment));
                }
            }
        }
        public int Amount
        {
            get => _amount;
            set
            {
                if(value > 0)
                {
                    _amount = value;
                    OnPropertyChanged(nameof(_amount));
                }
            }
        }
        public DateTime Date { get; set; }
        public DelegateCommand AddCommand { get; set; }
        public DelegateCommand RemoveCommand { get; set; }

        internal MainWindowViewModel()
        {
            ShowDATE();
            AddCommand = new DelegateCommand(Add);
            RemoveCommand = new DelegateCommand(Remove);
        }


        private void ShowDATE()
        {
            MessageBox.Show(Date.ToString());
        }

        private void Add()
        {

        }


        private void Remove()
        {

        }

        private void ShowInfo()
        {

        }

    }
}
