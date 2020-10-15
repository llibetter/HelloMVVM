using HelloMVVM.Commands;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMVVM.ViewModels
{
    class MainWindowViewModel:NotificationObject
    {
        private double  input1;
        public  double Input1
        {
            get { return input1; }
            set {
                if (input1 == value) return;
                input1 = value;
                this.RaisePropertyChanged(nameof(Input1));
            }
        }

        private double input2;
        public double Input2
        {
            get { return input2; }
            set
            {
                if (input2 == value) return;
                input2 = value;
                this.RaisePropertyChanged(nameof(Input2));
            }
        }

        private double result;
        public double Result
        {
            get { return result; }
            set
            {
                if (result == value) return;
                result = value;
                this.RaisePropertyChanged(nameof(Result));
            }
        }


        public DelegateCommand AddButton { get; set; }

        public void Add(object obj)
        {
            Result = Input1 + Input2;
        }

        public DelegateCommand SaveButton { get; set; }

        public void Save(object obj)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }



        public MainWindowViewModel()
        {
            AddButton = new DelegateCommand();
            AddButton.ExecuteAction += Add;

            SaveButton = new DelegateCommand();
            SaveButton.ExecuteAction += Save;
        }

    }
}
