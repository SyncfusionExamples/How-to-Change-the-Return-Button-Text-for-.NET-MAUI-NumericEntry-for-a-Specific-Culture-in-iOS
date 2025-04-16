namespace NumericEntrySample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as Picker).SelectedIndex;

            switch (index)
            {
                case 0:
                    numeric.ReturnType = ReturnType.Go;
                    break;
                case 1:
                    numeric.ReturnType = ReturnType.Next;
                    break;
                case 2:
                    numeric.ReturnType = ReturnType.Default;
                    break;
                case 3:
                    numeric.ReturnType = ReturnType.Done;
                    break;
                case 4:
                    numeric.ReturnType = ReturnType.Send;
                    break;
                case 5:
                    numeric.ReturnType = ReturnType.Search;
                    break;
            }

        }
    }

}
