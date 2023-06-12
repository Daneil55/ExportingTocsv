using System.Collections.ObjectModel;

namespace ExportingTocsv;

public partial class SavingPage : ContentPage
{
    ObservableCollection<String> list;

    public SavingPage()
	{
		InitializeComponent();
	}
    public string path;
    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();

    //    list = new ObservableCollection<string>()
    //        {
    //            "Task 1", "Task 2", "Task 3", "Task 4", "Task 5",
    //            "Task 6", "Task 7", "Task 8", "Task 9", "Task 10"
    //        };

    //    listView.ItemsSource = list;
    //}
    private void save_Clicked(object sender, EventArgs e)
    {
        if (name.Text == "yes")
        {
            Navigation.PushAsync(new MainPage());
        }
        else
        {
            excel.listPTB1(excel.imagepath, name.Text, secName.Text);
            DisplayAlert("Message","operation successfully complete","close");
            name.Text =string.Empty;
            secName.Text= string.Empty;
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        StackLayout listViewItem = (StackLayout)button.Parent;
        Label label = (Label)listViewItem.Children[0];
        String text = label.Text;
        DisplayAlert("Alert", text + "", "close");

        list.Remove(text);
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        excel.openfiles();
        image.Source = excel.imagepath;
    }
}