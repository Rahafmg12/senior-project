namespace padel_champ;

public partial class StadiumsPage : ContentPage
{
    List<Button> buttonsCollection;
    List<ImageButton> imageButtons;
    public StadiumsPage()
	{
		InitializeComponent();
        buttonsCollection = new List<Button> { b1, b2, b4, b5, b6, b7, b8, b9, b10 };
        imageButtons = new List<ImageButton> { b11, b12, b14, b15, b16, b17, b18, b19, b20 };
    }


    void SearchButton_Clicked(object sender, EventArgs e)
    {
        string searchText = searchEditor.Text.ToLower(); // ?????? ??? ???? ??????? ?? ???? ????? ??????? ??? ???? ?????

        // ?????? ?? ???? ?????? ??????? ???? ?? ????? ??????? ??????/????? ??????? ????? ??? ???????
        foreach (var button in buttonsCollection)
        {
            if (button.Text.ToLower().Contains(searchText))
            {
                button.IsVisible = true;

                if (button.IsVisible == true)
                {
                    foreach (var imageButton in imageButtons)
                    {
                        imageButton.IsVisible = true;
                    }
                }


            }




            else
            {
                button.IsVisible = false;

                foreach (var imageButton in imageButtons)
                {
                    imageButton.IsVisible = false;
                }
            }








        }


    }





    private async void OpenMap(string location)
    {
        // URL ???? ????? ????? Google ?? ?????? ??????
        string url = $"https://www.google.com/maps/search/?api=1&query={location}";

        // ??? ?????? ?? ??????? ?????????
        await Launcher.OpenAsync(url);
    }




    private void Button_Clicked_1(object sender, EventArgs e)
    {
        OpenMap("Padel In Jeddah | ???? ?? ???");
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        OpenMap("Padel Cube");
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        OpenMap("Padel Cube");
    }


    private void Button_Clicked_4(object sender, EventArgs e)
    {
        OpenMap("Padel Royale ???? ?????");
    }


    private void Button_Clicked_5(object sender, EventArgs e)
    {
        OpenMap("PW Padel World | ???? ?????");
    }


    private void Button_Clicked_6(object sender, EventArgs e)
    {
        OpenMap("Just Padel | ??? ????");
    }


    private void Button_Clicked_7(object sender, EventArgs e)
    {
        OpenMap("Padelhood");
    }


    private void Button_Clicked_8(object sender, EventArgs e)
    {
        OpenMap("The Padel Place Jed");
    }


    private void Button_Clicked_9(object sender, EventArgs e)
    {
        OpenMap("Deem Padel");
    }


    private void Button_Clicked_10(object sender, EventArgs e)
    {
        OpenMap("PAD-L");
    }

    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {

    }

    private async void ImageButton_Clicked_2(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Reservation());
    }

    private async void ImageButton_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Rac());

    }

    private async void ImageButton_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Game());

    }




    private async void b1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Reservation());
    }


    private async void b2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Reservation());
    }


    private async void b3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Reservation());
    }


    private async void b4_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Reservation());
    }


    private async void b5_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Reservation());
    }


    private async void b6_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Reservation());
    }


    private async void b7_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Reservation());
    }


    private async void b8_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Reservation());
    }


    private async void b9_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Reservation());
    }


    private async void b10_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Reservation());
    }

}