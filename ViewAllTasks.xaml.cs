namespace Task_Management_Application;

public partial class ViewAllTasks : ContentPage
{
	public ViewAllTasks()
	{
		InitializeComponent();
	}

    private async void onViewTaskClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TaskStatusPage());
    }
}