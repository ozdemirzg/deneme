
namespace BeehiveManagementSystem
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Program
    {
        private static Queen queen = new Queen();
        private static string statusReportText;
        // private DispatcherTimer timer = new DispatcherTimer();

        public static void Main()
        {
            // InitializeComponent();
            statusReportText = queen.StatusReport;
            // timer.Tick += Timer_Tick;
            // timer.Interval = TimeSpan.FromSeconds(1.5);
            // timer.Start();
        }

        private static void Timer_Tick(object sender)
        {
            // WorkShift_Click(this, new RoutedEventArgs());
        }

        private static void WorkShift_Click(object sender)
        {
            // queen.WorkTheNextShift();
            // statusReport.Text = queen.StatusReport;
        }

        private static void AssignJob_Click(string text)
        {
            queen.AssignBee(text);
            statusReportText = queen.StatusReport;
        }
    }
}
