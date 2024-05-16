using Microsoft.Maui.Graphics.Text;
using Microsoft.Maui.Graphics;
namespace MyFirstMauiApp;

public class TestPage : ContentPage
{
    int count = 0;
    Label lblCounter;
    public TestPage()
	{
		
        var scrollView= new ScrollView();   
        var stackLayout= new StackLayout();
        scrollView.Content = stackLayout;
        lblCounter = new Label

        {
            Text = "Count: 0",
            FontSize = 22,
           
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Colors.Red, // Use Color.Red here
            BackgroundColor = Colors.Yellow
        };
        stackLayout.Children.Add(lblCounter);
        var btnConter = new Button
        {
            Text = "Click to Count",
            HorizontalOptions= LayoutOptions.Center,
        };
        stackLayout.Children.Add (btnConter);
        btnConter.Clicked += OnClickedEvent;
        this.Content = scrollView;

	}
    private void OnClickedEvent(object sender, EventArgs e)
    {
        count++;
        lblCounter.Text = $"Click Count: {count}";
        SemanticScreenReader.Announce(lblCounter.Text);
       
    }
}