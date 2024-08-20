namespace Task_Management_Application
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }
        private async void onCreateTaskClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateTaskPage());
        }

        private async void onViewTaskClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TaskStatusPage());
        }
    }
}