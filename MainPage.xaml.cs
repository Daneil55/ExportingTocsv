using Microsoft.Maui.Controls;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System.Net;
using System.Net.Mail;


namespace ExportingTocsv;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
        
    }
    public string title { get; set; } = "This value is coming from the instence of this class";
 
    List<List_of_PTB1> lists = new List<List_of_PTB1>(); 
    private void Read_Clicked(object sender, EventArgs e)
    {

        collectionV.ItemsSource = excel.attendenceReader12().Result;
        //lists = excel.attendenceReader12().Result;
        //if (lists != null) 
        //{
        //    for(int i =0; i< lists.Count; i ++)
        //    {
        //        if (lists[i]!=null)
        //        {
        //            Microsoft.Maui.Controls.Button but = (Microsoft.Maui.Controls.Button)sender;
        //            VerticalStackLayout stack = (VerticalStackLayout)but.Parent;
                    
        //            ListView listView = (ListView)but.Parent;
        //           // Microsoft.Maui.Controls.Frame frem = (Microsoft.Maui.Controls.Frame)listView.Children[0];

        //            Grid grid= (Grid)frem.Children[0];
        //            Grid grids = (Grid)grid.Parent;  
        //            Image images= (Image)grids.Children;

        //            byte[] imageAsBytes = lists[i].image;

        //            var stream1 = new MemoryStream(imageAsBytes);
        //            images.Source = ImageSource.FromStream(() => stream1);

        //           //'//' image.Source = ImageSource.FromResource.;

        //        }
            
        //    }
            
        //}

    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        //  textToTrysdfg.Text = entry;

    }
    public bool pr { get; set; } = false;
    public bool ab { get; set; } = false;
    public bool ex { get; set; } = false;

    public bool b { get; set; } = false;
    RadioButton value;
    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Image image_select;
       
        value = (RadioButton)sender;
        Grid ids = (Grid)value.Parent;
        Microsoft.Maui.Controls.Label label = (Microsoft.Maui.Controls.Label)ids.Children[1];
        Microsoft.Maui.Controls.Label labels = (Microsoft.Maui.Controls.Label)ids.Children[2];
        image_select = (Microsoft.Maui.Controls.Image)ids.Children[6];
        DisplayAlert("Alert", label.Text + " " + labels.Text + "", "close");
        if (e.Value)
        {
            excel.listPTB(label.Text, "present");
        }
        radio = (RadioButton)ids.Children[3];
        radio.IsVisible = false;
        radio = (RadioButton)ids.Children[4];
        radio.IsVisible = false;
        radio = (RadioButton)ids.Children[5];
        radio.IsVisible = false;
      
        image_select.IsVisible = true;



        //////////////////////////////////////////////////////////////////////////////////////////////////



    



        }
    List <List_of_PTB> datas= new List <List_of_PTB>();
    RadioButton radio;
    private void RadioButton_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
    {
        Image image_select;
        Image image_de_select;
        value = (RadioButton)sender;
        Grid ids = (Grid)value.Parent;
       
        Microsoft.Maui.Controls.Label label = (Microsoft.Maui.Controls.Label)ids.Children[1];
        Microsoft.Maui.Controls.Label labels = (Microsoft.Maui.Controls.Label)ids.Children[2];
        image_select = (Microsoft.Maui.Controls.Image)ids.Children[6];
        image_de_select = (Microsoft.Maui.Controls.Image)ids.Children[7];

        DisplayAlert("Alert", label.Text +" "+ labels.Text + "","close");

     
        if (e.Value)
        {

            excel.listPTB(label.Text , "absent");
        
        }
        radio = (RadioButton)ids.Children[3];
        radio.IsVisible = false;
        radio = (RadioButton)ids.Children[4];
        radio.IsVisible = false;
        radio = (RadioButton)ids.Children[5];
        radio.IsVisible = false;
        value.IsVisible = false;
        image_de_select.IsVisible = true;
        image_select.IsVisible = false;
        
       
    }
   
    private void RadioButton_CheckedChanged_2(object sender, CheckedChangedEventArgs e)
    {
        Image image_select;
        Image image_de_select;
        value = (RadioButton)sender;
        Grid ids = (Grid)value.Parent;
        Microsoft.Maui.Controls.Label label = (Microsoft.Maui.Controls.Label)ids.Children[1];
        Microsoft.Maui.Controls.Label labels = (Microsoft.Maui.Controls.Label)ids.Children[2];
        image_select = (Microsoft.Maui.Controls.Image)ids.Children[6];
        image_de_select= (Microsoft.Maui.Controls.Image)ids.Children[7];
        DisplayAlert("Alert", label.Text + " " +labels.Text + "", "close");
       
        if (e.Value)
        {
            excel.listPTB(label.Text, "excuse");
        }
        
        radio = (RadioButton)ids.Children[3];
        radio.IsVisible = false;
        radio = (RadioButton)ids.Children[4];
        radio.IsVisible = false;
        radio = (RadioButton)ids.Children[5];
        radio.IsVisible = false;
        value.IsVisible = false;
        image_de_select.IsVisible = true; 
        image_select.IsVisible = false;
    }

    private void Todays_Clicked(object sender, EventArgs e)
    {
        collection1.ItemsSource = excel.attendenceReader().Result;

    }



  

    private void collectionV_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        DisplayAlert("Alert", "_" + e.SelectedItemIndex.ToString(), "can");
    }

    

    private void RadioButton_LayoutChanged(object sender, EventArgs e)
    {
        RadioButton redio = (RadioButton)sender;
        
        

    }

    private void Grid_Loaded(object sender, EventArgs e)
    {

        Grid parent = (Grid)sender;
        lists = excel.attendenceReader12().Result;
        if (lists != null)
        {
            for (int i = 0; i < lists.Count; i++)
            {
                if (lists[i] != null)
                {
                    
                        Image images = (Image)parent.Children[0];
                    if (lists[i].image == null)
                    {
                        images.Source = null;


                    }
                    else
                    {
                        byte[] imageAsBytes = lists[i].image;
                        var stream1 = new MemoryStream(imageAsBytes);

                        images.Source = ImageSource.FromStream(() => stream1);
                        
                        // image.Source = ImageSource.FromResource.;
                        break;
                    }
                    
                }

            }
}

        }
   // SmtpClient smtpClient = new SmtpClient();

    private void email_Clicked(object sender, EventArgs e)
    {

    }
}
