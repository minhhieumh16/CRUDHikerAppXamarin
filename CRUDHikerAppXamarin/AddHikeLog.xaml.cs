using CRUDHikerAppXamarin.ViewModels;

namespace CRUDHikerAppXamarin;

public partial class AddHikeLog : ContentPage
{
	public AddHikeLog(AddHikeLogViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}