namespace fitness_pro_software
{
    public partial class activityPanel : UserControl
    {
        private int userID;
        public activityPanel()
        {
            InitializeComponent();
        }
        public void SetUserID(int userID)
        {
            this.userID = userID;
        }

        private void Activity_panel_big_Load(object sender, EventArgs e)
        {

        }

        private void Walking_btn_Click(object sender, EventArgs e)
        {
            InputForm inputform = new("Walking");
            inputform.SetuserID(this.userID);
            inputform.Show();

        }

        private void Running_btn_Click(object sender, EventArgs e)
        {
            InputForm inputform = new("Running");
            inputform.SetuserID(this.userID);
            inputform.Show();
        }

        private void Yoga_btn_Click(object sender, EventArgs e)
        {
            InputForm inputform = new("Yoga");
            inputform.SetuserID(this.userID);
            inputform.Show();
        }

        private void Dancing_btn_Click(object sender, EventArgs e)
        {
            InputForm inputform = new("Dancing");
            inputform.SetuserID(this.userID);
            inputform.Show();
        }

        private void Cycling_btn_Click(object sender, EventArgs e)
        {
            InputForm inputform = new("Cycling");
            inputform.SetuserID(this.userID);
            inputform.Show();
        }



        private void Button7_Click(object sender, EventArgs e)
        {
            InputForm inputform = new("Swimming");
            inputform.SetuserID(this.userID);
            inputform.Show();
        }


    }
}
