using System;
using System.Windows.Forms;

namespace EkrNet
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if(webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            addressBar.Text = webBrowser.Url.ToString();
            string historyUrl = webBrowser.Url.ToString();
            history.Items.Add(historyUrl);
        }

        private void Navigate(String Address)
        {
            if (String.IsNullOrEmpty(Address)) return;
            if (Address.Equals("about:blank")) return;
            if((!Address.StartsWith("http://")) || (!Address.StartsWith("https://")))
            {
                Address = "https://" + Address + ".com";
            }
            try
            {
                webBrowser.Navigate(new Uri(Address));
            }
            catch (UriFormatException)
            {
                return;
            }
        }

        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Navigate(addressBar.Text);
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string favoriteItem = webBrowser.Url.ToString();
            favorite.Items.Add(favoriteItem);
        }

        private void history_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser.Navigate(history.SelectedItem.ToString());
        }

        private void favorite_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser.Navigate(favorite.SelectedItem.ToString());
        }
    }
}
