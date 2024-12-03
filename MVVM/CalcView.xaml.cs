using MAUICalculator.MVVM.ViewModel;

namespace MAUICalculator.MVVM;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();
        BindingContext = new CalcViewModel();
    }
}