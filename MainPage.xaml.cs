namespace diceRoller
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Random random = new Random();

            int roll = random.Next(1, 7);

            switch (roll)
            {
                case 1:
                    DiceImg.Source = "dice1.png";
                    break;
                case 2:
                    DiceImg.Source = "dice2.png";
                    break;
                case 3:
                    DiceImg.Source = "dice3.png";
                    break;
                case 4:
                    DiceImg.Source = "dice4.png";
                    break;
                case 5:
                    DiceImg.Source = "dice5.png";
                    break;
                case 6:
                    DiceImg.Source = "dice6.png";
                    break;



            }
        }

    }
}
