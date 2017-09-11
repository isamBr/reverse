using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
        //Reverse function 
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //Click event
        async void ButtonClicked(object sender,EventArgs e)
        {
            Button button = sender as Button;
            try
            {
                string text = MainEntry.Text;
                if (button.Text== "Reverse")
                {
                    if(text.Length>10)
                    {
                        await DisplayAlert(text, "String longer than 10 characters", "Retry");
                        MainEntry.Text = "";
                    }
                    else if(text.Length == 0)
                        {
                            await DisplayAlert(text, "Empty field", "Retry");
                            ResultInput.Text = "";
                        }
                    else if (text.Length == 1)
                    {
                        await DisplayAlert(text, "Enter more than one character to rearrange", "Retry");
                        ResultInput.Text = "";
                    }
                    else 
                    {
                   
                        String outString = Reverse(text);
                        ResultInput.Text = outString;
                        await DisplayAlert(outString, "String rearranged", "Next");
                    }
                

                }
               
            }
            catch (System.IO.IOException)
            {
                
            }
        }
    }
}
