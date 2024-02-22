namespace MauiEqSegundoGrau
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_n1.Text);
            double b = Convert.ToDouble(txt_n2.Text);
            double c = Convert.ToDouble(txt_n3.Text);

            double delta = (b * b) - 4 * a * c;

            double resP = 0;
            string msg = "";

            resP = (-b + Math.Sqrt(delta)) / 2 * a;
            double resN = (-b - (Math.Sqrt(delta))) / 2 * a;

            msg = $"O resultado Positivo é: " + resP;
            string msg2 = $", O resultado Negativo é: " + resN;

            if (delta < 0)
            {
                DisplayAlert("Maui", "Não há resposta pois delta é negativo", "Fechar");
            }
            else
            {
                DisplayAlert("Maui", msg + msg2, "Fechar");
            }

        }

    }

}
