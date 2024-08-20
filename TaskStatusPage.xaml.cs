namespace Task_Management_Application;

public partial class TaskStatusPage : ContentPage
{
	public TaskStatusPage()
	{
		InitializeComponent();
	}

    private void onHomeButtonClicked(object sender, EventArgs e)
    {
         Navigation.PushAsync(new MainPage());
    }
}