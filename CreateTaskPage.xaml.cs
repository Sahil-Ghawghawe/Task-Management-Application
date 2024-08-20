namespace Task_Management_Application;

public partial class CreateTaskPage : ContentPage
{
    public CreateTaskPage()

    {
        InitializeComponent();
    }
    private async void onCreateClicked(object sender, EventArgs e)
    {
        string taskName = taskNameEntry.Text;
        TimeSpan taskTime = taskTimePicker.Time;
      
        try
        {
            if (taskName.Length > 0)
            {

                TaskItem task = new TaskItem { Name = taskName, Time = taskTime };
                
                App.Tasks.Add(task);

                await DisplayAlert("Task Created", $"Task '{taskName}' Scheduled for {taskTime}", "OK");
            }
        }
        catch
        {
            await DisplayAlert("Task Not Created", "Empty Task Cannot be Created.", "OK");
        }
    }
    private void onHomeButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}