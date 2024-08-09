
namespace SampleMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int PageNumber = 0;
        Entry pageEntry;
        public MainPage()
        {
            InitializeComponent();

            pageEntry = new Entry
            {
                WidthRequest = 58,
                FontSize = 16,
                FontAutoScalingEnabled = false,
                MaxLength = 4,
                Keyboard = Keyboard.Numeric,
                HorizontalTextAlignment = TextAlignment.Center,
            };
            pageEntry.BindingContext = this;
            pageEntry.SetBinding(Entry.TextProperty, "PageNumber");
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
