namespace Task_Management_Application
{
    public partial class App : Application
    {
        public static List<TaskItem> Tasks { get; set; } = new List<TaskItem>();

        public App()
        {
            InitializeComponent();
            //Tasks = new List<TaskItem>();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
