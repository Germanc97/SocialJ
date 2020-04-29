using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SocialJ
{
    public partial class Registrarse : ContentPage
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        async void Button_Clicked_Registrar(object sender, EventArgs e)
        {
            await DisplayAlert("Exito", "Usuario creado satisfactoriamente.", "OK");
            Navigation.RemovePage(this);

            

        }

        async void Button_Clicked_Cancelar(object sender, EventArgs e)
        {
            Navigation.RemovePage(this);
        }
    }
}
