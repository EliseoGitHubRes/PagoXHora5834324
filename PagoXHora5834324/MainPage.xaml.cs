namespace PagoXHora5834324;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		double horasTrabajadas = Convert.ToDouble(HT.Text);
		double pagoXHora = Convert.ToDouble(PxH.Text);

		double totalSueldo = horasTrabajadas * pagoXHora;

		sueldo.Text = "Sueldo a pagar: $" + totalSueldo;
    }
}

