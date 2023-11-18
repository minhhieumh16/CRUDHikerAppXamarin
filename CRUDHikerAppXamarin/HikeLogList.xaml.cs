using CRUDHikerAppXamarin.ViewModels;

namespace CRUDHikerAppXamarin;

public partial class HikeLogList : ContentPage
{
	public HikeLogList(HikeLogViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}