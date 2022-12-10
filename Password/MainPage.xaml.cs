namespace Password;

public partial class MainPage : ContentPage
{
	private string _pincode = "1337";
	private string _currpin = "";
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCheckBtnClicked(object sender, EventArgs e)
	{
        if (_currpin == _pincode)
            await Shell.Current.GoToAsync("/success");
        else
        {
            currentPass.Text = "Wrong PIN! Try again";
            _currpin = "";
        }
	}

    private void OnRemoveDigitClicked(object sender, EventArgs e)
    {
        if (_currpin.Length != 0)
        {
            _currpin = _currpin.Remove(_currpin.Length - 1);
            currentPass.Text = String.Join("", _currpin.Select(x => x = '*').ToList());
        }
    }

	private void OnNumberBtn1Clicked(object sender, EventArgs e)
	{
		_currpin += "1";
		currentPass.Text = String.Join("", _currpin.Select(x => x = '*').ToList());
	}

    private void OnNumberBtn2Clicked(object sender, EventArgs e)
    {
        _currpin += "2";
        currentPass.Text = String.Join("", _currpin.Select(x => x = '*').ToList());
    }

    private void OnNumberBtn3Clicked(object sender, EventArgs e)
    {
        _currpin += "3";
        currentPass.Text = String.Join("", _currpin.Select(x => x = '*').ToList());
    }

    private void OnNumberBtn4Clicked(object sender, EventArgs e)
    {
        _currpin += "4";
        currentPass.Text = String.Join("", _currpin.Select(x => x = '*').ToList());
    }

    private void OnNumberBtn5Clicked(object sender, EventArgs e)
    {
        _currpin += "5";
        currentPass.Text = String.Join("", _currpin.Select(x => x = '*').ToList());
    }

    private void OnNumberBtn6Clicked(object sender, EventArgs e)
    {
        _currpin += "6";
        currentPass.Text = String.Join("", _currpin.Select(x => x = '*').ToList());
    }

    private void OnNumberBtn7Clicked(object sender, EventArgs e)
    {
        _currpin += "7";
        currentPass.Text = String.Join("", _currpin.Select(x => x = '*').ToList());
    }
    private void OnNumberBtn8Clicked(object sender, EventArgs e)
    {
        _currpin += "8";
        currentPass.Text = String.Join("", _currpin.Select(x => x = '*').ToList());
    }
    private void OnNumberBtn9Clicked(object sender, EventArgs e)
    {
        _currpin += "9";
        currentPass.Text = String.Join("", _currpin.Select(x => x = '*').ToList());
    }
    private void OnNumberBtn0Clicked(object sender, EventArgs e)
    {
        _currpin += "0";
        currentPass.Text = String.Join("", _currpin.Select(x => x = '*').ToList());
    }
}

