using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Currency_Converter_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //These lines of code sets the preferred size which the app launchs.
            ApplicationView.PreferredLaunchViewSize = new Size(400, 700);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }
        //Each block of code is enclosed in a region tag for more readability.
        #region Convert_Button
        //The following block of code is executed when the convert
        //button is clicked to convert the corresponding currency.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            #region Accepts-Amount
            //This line of code accepts the value entered by the user and converts
            //it to double value and checks if its a null value or if a value was 
            //actually entered.
            double amount2 = 0.00;
            

            if ((amount.Text == ""))
            {
                //This line of code returns the default value of amount2 if the user 
                //doesn't enter any value.
                amount2 = amount2;
            }
            else { 
                //This line of code converts the value gotten from the user from string to
                //a double value
                amount2 = double.Parse(amount.Text);
            }
            #endregion

            #region Countires-string
            //This line of code converts the chosen country in the first combo box named 
            // firstcombo to string and assings the values to the corresponding string values


            //This line of code assigns the value of the 1st combo box item in
            //the first combo box named firstcombo to text1
            string text1 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 2nd combo box item in
            //the first combo box named firstcombo to text2
            string text2 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 3rd combo box item in
            //the first combo box named firstcombo to text3
            string text3 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 4th combo box item in
            //the first combo box named firstcombo to text4
            string text4 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 5th combo box item in
            //the first combo box named firstcombo to text5
            string text5 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 6th combo box item in
            //the first combo box named firstcombo to text6
            string text6 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 7th combo box item in
            //the first combo box named firstcombo to text7
            string text7 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 8th combo box item in
            //the first combo box named firstcombo to text8
            string text8 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 9th combo box item in
            //the first combo box named firstcombo to text9
            string text9 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 10th combo box item in
            //the first combo box named firstcombo to text10
            string text10 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 11th combo box item in
            //the first combo box named firstcombo to text11
            string text11 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 12th combo box item in
            //the first combo box named firstcombo to text12
            string text12 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 13th combo box item in
            //the first combo box named firstcombo to text13
            string text13 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 14th combo box item in
            //the second combo box named secondcombo to text14
            string text14 = ((ComboBoxItem)secondcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 15th combo box item in
            //the second combo box named secondcombo to text15
            string text15 = ((ComboBoxItem)secondcombo.SelectedItem).Name.ToString();
            //This line of code assigns the value of the 16th combo box item in
            //the second combo box named secondcombo to text16
            string text16 = ((ComboBoxItem)secondcombo.SelectedItem).Name.ToString();
            #endregion

            #region Check_country_selected
            //This block of code assigns the country with currency values from which is to 
            //be converted, to the array choice.
            string[] choice = new string[13];
            choice[0] = text1;
            choice[1] = text2;
            choice[2] = text3;
            choice[3] = text4;
            choice[4] = text5;
            choice[5] = text6;
            choice[6] = text7;
            choice[7] = text8;
            choice[8] = text9;
            choice[9] = text10;
            choice[10] = text11;
            choice[11] = text12;
            choice[12] = text13;

            //This block of code assigns the country with currency values which will be
            //converted to. To the array choice2.
            string[] choice2 = new string[3];
            choice2[0] = text14;
            choice2[1] = text15;
            choice2[2] = text16;

            //these are string values to which values will be assigned.
            string text = "";
            string textsec = "";

            //These line of code detects the country selected by the user from which
            //its currency will be converted.
            string text66 = ((ComboBoxItem)firstcombo.SelectedItem).Name.ToString();

            //These line of code detects the country selected by the user to which
            //the value will be converted to.
            string text77 = ((ComboBoxItem)secondcombo.SelectedItem).Name.ToString();

            //this block of code loops through the list of countries from 
            //which the currency value is to be converted and detects the country
            //selected by user and assigns it to the string value text.
            foreach (var item in choice)
            {
                if (item == text66)
                {
                    text = item;
                    break;
                }
            }


            //this block of code loops through the list of countries to 
            //which the currency value is to be converted to and detects the country
            //selected by user and assigns it to the string value textsec.
            foreach (var item in choice2)
            {
                if (item == text77)
                {
                    textsec = item;
                    break;
                }
            }

            //the values gooten from the loops above are assigned
            //to the values below respectively.
            string Mtext = text;
            string Mtext2 = textsec;

            #endregion

            #region Conerts_Nigerian:Naira
            //This block of code converts Nigerian Naira to the corresponding chosen currency
            //and assigns the the value as string/text to textblock named Result to be displayed.

            //This block of if statement runs if the user chooses Nigeria as
            //the country from which to convert and USA as country to convert to.
            if ((Mtext == "Nig") && (Mtext2 == "usd"))
            {
                double result = amount2 * 0.0028;
                Result.Text = "₦" + amount2 + " = $" + result.ToString();
            }

            //This block of if statement runs if the user chooses Nigeria as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "Nig") && (Mtext2 == "pnd"))
            {
                double result = amount2 * 0.0021;
                Result.Text = "₦" + amount2 + " = £" + result.ToString();
            }

            //This block of if statement runs if the user chooses Nigeria as
            //the country from which to convert and Euro as country to convert to.
            if ((Mtext == "Nig") && (Mtext2 == "Euro"))
            {
                double result = amount2 * 0.0023;
                Result.Text = "₦" + amount2 + " = €" + result.ToString();
            }
            #endregion

            #region Conerts_Ghana:Cedi
            //This block of code converts Ghana Cedi to the corresponding chosen currency
            //and assigns the the value as string/text to textblock named Result to be displayed.

            //This block of if statement runs if the user chooses Ghana as
            //the country from which to convert and USA as country to convert to.
            if ((Mtext == "gh1") && (Mtext2 == "usd"))
            {
                double result = amount2 * 0.20;
                Result.Text = "GH¢" + amount2 + " = $" + result.ToString();
            }

            //This block of if statement runs if the user chooses Ghana as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "gh1") && (Mtext2 == "pnd"))
            {
                double result = amount2 * 0.15;
                Result.Text = "GH¢" + amount2 + " = £" + result.ToString();
            }

            //This block of if statement runs if the user chooses Ghana as
            //the country from which to convert and Euro as country to convert to.
            if ((Mtext == "gh1") && (Mtext2 == "Euro"))
            {
                double result = amount2 * 0.17;
                Result.Text = "GH¢" + amount2 + " = €" + result.ToString();
            }
            #endregion

            #region Conerts_South-African:rand
            //This block of code converts South African Rand to the corresponding chosen currency
            //and assigns the the value as string/text to textblock named Result to be displayed.

            //This block of if statement runs if the user chooses South Africa as
            //the country from which to convert and USA as country to convert to.
            if ((Mtext == "sar") && (Mtext2 == "usd"))
            {
                double result = amount2 * 0.071;
                Result.Text = "R" + amount2 + " = $" + result.ToString();
            }

            //This block of if statement runs if the user chooses South Africa as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "sar") && (Mtext2 == "pnd"))
            {
                double result = amount2 * 0.054;
                Result.Text = "R" + amount2 + " = £" + result.ToString();
            }

            //This block of if statement runs if the user chooses South Africa as
            //the country from which to convert and Euro as country to convert to.
            if ((Mtext == "sar") && (Mtext2 == "Euro"))
            {
                double result = amount2 * 0.060;
                Result.Text = "R" + amount2 + " = €" + result.ToString();
            }
            #endregion

            #region Conerts_China: Renminbi
            //This block of code converts Chineese Renminbi to the corresponding chosen currency
            //and assigns the the value as string/text to textblock named Result to be displayed.

            //This block of if statement runs if the user chooses China as
            //the country from which to convert and USA as country to convert to.
            if ((Mtext == "chin") && (Mtext2 == "usd"))
            {
                double result = amount2 * 0.15;
                Result.Text = "¥" + amount2 + " = $" + result.ToString();
            }

            //This block of if statement runs if the user chooses China as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "chin") && (Mtext2 == "pnd"))
            {
                double result = amount2 * 0.11;
                Result.Text = "¥" + amount2 + " = £" + result.ToString();
            }

            //This block of if statement runs if the user chooses China as
            //the country from which to convert and Euro as country to convert to.
            if ((Mtext == "chin") && (Mtext2 == "Euro"))
            {
                double result = amount2 * 0.12;
                Result.Text = "¥" + amount2 + " = €" + result.ToString();
            }
            #endregion

            #region Conerts_Grecee: Drachmas
            //This block of code converts Grecee Drachmas to the corresponding chosen currency
            //and assigns the the value as string/text to textblock named Result to be displayed.

            //This block of if statement runs if the user chooses Greece as
            //the country from which to convert and USA as country to convert to.
            if ((Mtext == "grece") && (Mtext2 == "usd"))
            {
                double result = amount2 * 0.071;
                Result.Text = "Dp" + amount2 + " = $" + result.ToString();
            }

            //This block of if statement runs if the user chooses Greece as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "grece") && (Mtext2 == "pnd"))
            {
                double result = amount2 * 0.054;
                Result.Text = "Dp" + amount2 + " = £" + result.ToString();
            }

            //This block of if statement runs if the user chooses Greece as
            //the country from which to convert and Euro as country to convert to.
            if ((Mtext == "grece") && (Mtext2 == "Euro"))
            {
                double result = amount2 * 0.060;
                Result.Text = "Dp" + amount2 + " = €" + result.ToString();
            }
            #endregion

            #region Conerts_Ethiopia: Birr
            //This block of code converts Ethiopia Birr to the corresponding chosen currency
            //and assigns the the value as string/text to textblock named Result to be displayed.

            //This block of if statement runs if the user chooses Ethiopia as
            //the country from which to convert and USA as country to convert to.
            if ((Mtext == "ethio") && (Mtext2 == "usd"))
            {
                double result = amount2 * 0.036;
                Result.Text = "ብር" + amount2 + " = $" + result.ToString();
            }

            //This block of if statement runs if the user chooses Ethiopia as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "ethio") && (Mtext2 == "pnd"))
            {
                double result = amount2 * 0.027;
                Result.Text = "ብር" + amount2 + " = £" + result.ToString();
            }

            //This block of if statement runs if the user chooses Ethiopia as
            //the country from which to convert and Euro as country to convert to.
            if ((Mtext == "ethio") && (Mtext2 == "Euro"))
            {
                double result = amount2 * 0.030;
                Result.Text = "ብር" + amount2 + " = €" + result.ToString();
            }
            #endregion

            #region Conerts_Canada: CA Dollar
            //This block of code converts Canada: CA Dollar to the corresponding chosen currency
            //and assigns the the value as string/text to textblock named Result to be displayed.

            //This block of if statement runs if the user chooses Canada as
            //the country from which to convert and USA as country to convert to.
            if ((Mtext == "ca") && (Mtext2 == "usd"))
            {
                double result = amount2 * 0.77;
                Result.Text = "C$" + amount2 + " = $" + result.ToString();
            }

            //This block of if statement runs if the user chooses Canada as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "ca") && (Mtext2 == "pnd"))
            {
                double result = amount2 * 0.77;
                Result.Text = "C$" + amount2 + " = £" + result.ToString();
            }

            //This block of if statement runs if the user chooses Canada as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "ca") && (Mtext2 == "Euro"))
            {
                double result = amount2 * 0.65;
                Result.Text = "C$" + amount2 + " = €" + result.ToString();
            }
            #endregion

            #region Conerts_Cyprus: Cypriot Pounds
            //This block of code converts Cyprus Cypriot Pounds to the corresponding chosen currency
            //and assigns the the value as string/text to textblock named Result to be displayed.

            //This block of if statement runs if the user chooses Cyprus as
            //the country from which to convert and USA as country to convert to.
            if ((Mtext == "cyp") && (Mtext2 == "usd"))
            {
                double result = amount2 * 0.77;
                Result.Text = "CYP" + amount2 + " = $" + result.ToString();
            }

            //This block of if statement runs if the user chooses Cyprus as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "cyp") && (Mtext2 == "pnd"))
            {
                double result = amount2 * 0.77;
                Result.Text = "CYP" + amount2 + " = £" + result.ToString();
            }

            //This block of if statement runs if the user chooses Cyprus as
            //the country from which to convert and Euro as country to convert to.
            if ((Mtext == "cyp") && (Mtext2 == "Euro"))
            {
                double result = amount2 * 0.65;
                Result.Text = "CYP" + amount2 + " = €" + result.ToString();
            }
            #endregion

            #region Conerts_Malasia: Ringgit
            //This block of code converts Malasia Ringgit to the corresponding chosen currency
            //and assigns the the value as string/text to textblock named Result to be displayed.

            //This block of if statement runs if the user chooses Malasia as
            //the country from which to convert and USA as country to convert to.
            if ((Mtext == "mal") && (Mtext2 == "usd"))
            {
                double result = amount2 * 0.24;
                Result.Text = "MYR" + amount2 + " = $" + result.ToString();
            }

            //This block of if statement runs if the user chooses Malasia as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "mal") && (Mtext2 == "pnd"))
            {
                double result = amount2 * 0.18;
                Result.Text = "MYR" + amount2 + " = £" + result.ToString();
            }

            //This block of if statement runs if the user chooses Malasia as
            //the country from which to convert and Euro as country to convert to.
            if ((Mtext == "mal") && (Mtext2 == "Euro"))
            {
                double result = amount2 * 0.21;
                Result.Text = "MYR" + amount2 + " = €" + result.ToString();
            }
            #endregion

            #region Conerts_Mexico: Peso
            //This block of code converts Mexico Peso to the corresponding chosen currency
            //and assigns the the value as string/text to textblock named Result to be displayed.

            //This block of if statement runs if the user chooses Mexico as
            //the country from which to convert and USA as country to convert to.
            if ((Mtext == "mex") && (Mtext2 == "usd"))
            {
                double result = amount2 * 0.053;
                Result.Text = "Mex$" + amount2 + " = $" + result.ToString();
            }

            //This block of if statement runs if the user chooses Mexico as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "mex") && (Mtext2 == "pnd"))
            {
                double result = amount2 * 0.040;
                Result.Text = "Mex$" + amount2 + " = £" + result.ToString();
            }

            //This block of if statement runs if the user chooses Mexico as
            //the country from which to convert and Euro as country to convert to.
            if ((Mtext == "mex") && (Mtext2 == "Euro"))
            {
                double result = amount2 * 0.045;
                Result.Text = "Mex$" + amount2 + " = €" + result.ToString();
            }
            #endregion

            #region Conerts_Saudi Arabia: Riyal
            //This block of code converts Saudi Arabia Riyal to the corresponding chosen currency
            //and assigns the the value as string/text to textblock named Result to be displayed.

            //This block of if statement runs if the user chooses Saudi Arabia as
            //the country from which to convert and USA as country to convert to.
            if ((Mtext == "saudi") && (Mtext2 == "usd"))
            {
                double result = amount2 * 0.27;
                Result.Text = "ر.س" + amount2 + " = $" + result.ToString();
            }

            //This block of if statement runs if the user chooses Saudi Arabia as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "saudi") && (Mtext2 == "pnd"))
            {
                double result = amount2 * 0.20;
                Result.Text = "ر.س" + amount2 + " = £" + result.ToString();
            }

            //This block of if statement runs if the user chooses Saudi Arabia as
            //the country from which to convert and Euro as country to convert to.
            if ((Mtext == "saudi") && (Mtext2 == "Euro"))
            {
                double result = amount2 * 0.23;
                Result.Text = "ر.س" + amount2 + " = €" + result.ToString();
            }
            #endregion

            #region Conerts_Malawi: Kwacha
            //This block of code converts Malawi Kwacha to the corresponding chosen currency
            //and assigns the the value as string/text to textblock named Result to be displayed.

            //This block of if statement runs if the user chooses Malawi as
            //the country from which to convert and USA as country to convert to.
            if ((Mtext == "malaw") && (Mtext2 == "usd"))
            {
                double result = amount2 * 0.0014;
                Result.Text = "MK" + amount2 + " = $" + result.ToString();
            }

            //This block of if statement runs if the user chooses Malawi as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "malaw") && (Mtext2 == "pnd"))
            {
                double result = amount2 * 0.0010;
                Result.Text = "MK" + amount2 + " = £" + result.ToString();
            }

            //This block of if statement runs if the user chooses Togo as
            //the country from which to convert and Euro as country to convert to.
            if ((Mtext == "malaw") && (Mtext2 == "Euro"))
            {
                double result = amount2 * 0.0012;
                Result.Text = "MK" + amount2 + " = €" + result.ToString();
            }
            #endregion

            #region Conerts_Togo: CFA Franc
            //This block of code converts Togo CFA Franc to the corresponding chosen currency
            //and assigns the the value as string/text to textblock named Result to be displayed.

            //This block of if statement runs if the user chooses Togo as
            //the country from which to convert and USA as country to convert to.
            if ((Mtext == "tog") && (Mtext2 == "usd"))
            {
                double result = amount2 * 0.0014;
                Result.Text = "CFA" + amount2 + " = $" + result.ToString();
            }

            //This block of if statement runs if the user chooses Togo as
            //the country from which to convert and British pounds as country to convert to.
            if ((Mtext == "tog") && (Mtext2 == "pnd"))
            {
                double result = amount2 * 0.0010;
                Result.Text = "CFA" + amount2 + " = £" + result.ToString();
            }

            //This block of if statement runs if the user chooses Togo as
            //the country from which to convert and Euro as country to convert to.
            if ((Mtext == "tog") && (Mtext2 == "Euro"))
            {
                double result = amount2 * 0.0012;
                Result.Text = "CFA" + amount2 + " = €" + result.ToString();
            }
                #endregion

        }
        #endregion

        #region Refresh_Button
        //The following block of code is executed when the Refresh
        //button is clicked to Refresh the app.
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //This line of code empties the amount text box and displays the
            //placeholder text when ever the refresh button is clicked
            amount.Text = "";

            //This line of code empties the first combo box named firstcombo and displays the
            //placeholder text when ever the refresh button is clicked
            firstcombo.SelectedItem = null;

            //This line of code empties the second combo box named secondcombo and displays the
            //placeholder text when ever the refresh button is clicked
            secondcombo.SelectedItem = null;

            //This line of code empties the first Result textblock
            //when ever the refresh button is clicked
            Result.Text = "";
        }
        #endregion
    }
}
