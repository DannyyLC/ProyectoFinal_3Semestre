namespace IntroductionView
{
    public partial class Portada : Form
    {
        private int indx;
        public Portada()
        {
            InitializeComponent();
            indx = 0;
            this.pictureBoxIntegrantes.BackgroundImage = IntroductionView.Properties.Resources.danielTemp;
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            indx++;

            if (indx > 4)
            {
                indx = 0;
            }

            switch (indx)
            {
                case 0:
                    this.pictureBoxIntegrantes.BackgroundImage = IntroductionView.Properties.Resources.danielTemp;
                    break;
                case 1:
                    this.pictureBoxIntegrantes.BackgroundImage = IntroductionView.Properties.Resources.samuel;
                    break;
                case 2:
                    this.pictureBoxIntegrantes.BackgroundImage = IntroductionView.Properties.Resources.juan;
                    break;
                case 3:
                    this.pictureBoxIntegrantes.BackgroundImage = IntroductionView.Properties.Resources.carlos;
                    break;
                case 4:
                    this.pictureBoxIntegrantes.BackgroundImage = IntroductionView.Properties.Resources.ib;
                    break;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}