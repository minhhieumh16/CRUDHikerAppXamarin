using Microsoft.Toolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDHikerAppXamarin.ViewModels
{
    public partial class HikeLogViewModel : ObservableObject
    {
        [RelayCommand]
        public async void AddUpdateHikeLog()
        {
            await AppShell.Current.GoToAsync(nameof(AddHikeLog));
        }
    }
}
