using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CRUDHikerAppXamarin.Models;
using CRUDHikerAppXamarin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDHikerAppXamarin.ViewModels
{
    public partial class AddHikeLogViewModel : ObservableObject
    {
        private readonly IHikeLogService _hikeLogService;
        public AddHikeLogViewModel(IHikeLogService hikeLogService)
        {
            _hikeLogService = hikeLogService;
            HikeLogDetails = new HikeLog();
        }

        [ObservableProperty]
        public HikeLog hikeLogDetails;

        [RelayCommand]
        public async void AddHikeLog()
        {
            var response = await _hikeLogService.AddHikeLog(hikeLogDetails);
            if(response > 0)
            {
                await Shell.Current.DisplayAlert("Record Added", "Hike Log Details Successfully Submited", "OK");
            } else
            {
                await Shell.Current.DisplayAlert("Not Added", "Something went wrong with Hike Log Details", "OK");
            }
        }
    }
}
