using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SocialJ
{
    public partial class Principal : ContentPage
    {
        public IList<ofertaTrabajo> Ofertas { get; private set; }

        async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ofertaTrabajo tappedItem = e.Item as ofertaTrabajo;
            bool response = await DisplayAlert("Guardar", "Desea guardar esta oferta de trabajo?", "Si", "No");
            Console.WriteLine("Save data: " + response);

        }

        async void Button_Clicked_CerrarSesion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
            Navigation.RemovePage(this);
        }
        public Principal()
        {
            InitializeComponent();

            Ofertas = new List<ofertaTrabajo>();
            Ofertas.Add(new ofertaTrabajo
            {
                Nombre = "Empleo Psicologo",
                Cargo = "Profesional Psicologia",
                Requisitos = "1 año de experiencia en pedagogia",
                Labores = "Dar clases de psicologia",
                RangoSal = "1,500,000-2,000,000"
            });
            Ofertas.Add(new ofertaTrabajo
            {
                Nombre = "Empleo Ingeniero",
                Cargo = "Ingeniero jefe",
                Requisitos = "1 año de experiencia en plantas de tratamiento de agua, titulo de ingeniero",
                Labores = "Dirigir planta de aguas residuales",
                RangoSal = "3,500,000"
            });
            Ofertas.Add(new ofertaTrabajo
            {
                Nombre = "Empleo Chofer",
                Cargo = "Chofer de camiones",
                Requisitos = "2 años de experiencia manejndo camiones",
                Labores = "Transportar productos de primera necesidad",
                RangoSal = "2,500,000"
            });
            Ofertas.Add(new ofertaTrabajo
            {
                Nombre = "Empleo Recepcionista",
                Cargo = "Recepcionista Hotel",
                Requisitos = "1 año de experiencia trabajando en hoteles o turismo",
                Labores = "Recibir a los huespedes y contestar llamadas",
                RangoSal = "1,200,000-1,800,000"
            });
            Ofertas.Add(new ofertaTrabajo
            {
                Nombre = "Empleo Arquitecto",
                Cargo = "Ariquitecto residente",
                Requisitos = "2 años de experiencia obras",
                Labores = "Arquitecto residente de obra de vivienda",
                RangoSal = "2,500,000"
            });

            

            BindingContext = this;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
        }
    }
}
