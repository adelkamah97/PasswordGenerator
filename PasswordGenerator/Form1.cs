namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        
        string minuscules = "abcdefghijklmnopqrstuvwxyz";       
        string chiffres = "0123456789";
        string caracteresSpeciaux = "#&+-";
        string alphabet;
        string alphabet1;
        string alphabet2;
        string alphabet3;
        string alphabet4;
        string motDePasse = "";
        Random rand = new Random();

        private void gnrtbtn_Click(object sender, EventArgs e)
            
        {
            if (Upper.Checked)
            {
                string majuscules = minuscules.ToUpper();
                alphabet1 = majuscules;
            }
            else
            {
                alphabet1="";

            }
            if (Lower.Checked)
            {
                
                alphabet2= minuscules;
            }
            else
            {
                alphabet2 = "";
            }
            if (Num.Checked)
            {
                
                alphabet3= chiffres;
            }
            else
            {
                alphabet3 = "";
            }
            if (Sym.Checked)
            {
                
                alphabet4 = caracteresSpeciaux;
            }
            else
            {
                alphabet4 = "";
            }


            alphabet =alphabet1+alphabet2+alphabet3+alphabet4;

            
            

            try
            {


                int longeurMotDePasse = int.Parse(pswlen.Text);

                try
                {
                    int longeurAlphabet = alphabet.Length;
               
                    motDePasse = "";
                    for (int i = 0; i < longeurMotDePasse; i++)
                    {
                        int index = rand.Next(0, longeurAlphabet);
                        motDePasse += alphabet[index];
                        
                    }
                        textBox1.Text = motDePasse;                  
                }
                catch
                {
                    MessageBox.Show("You have to select an option ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("You have to write your password length");
            }


            

        }

        private void Copybtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("Your password has been copied");
            
        }
    }
}