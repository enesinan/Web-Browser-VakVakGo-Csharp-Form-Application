using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnetForm.WebBrowser2
{
    public partial class VakVakGo : Form
    {
        public VakVakGo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate (textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://news.ycombinator.com/");
            
        }

        private void barcelonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.theguardian.com/uk/sport");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void nYSportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.nytimes.com/section/sports");
        }

        private void realMadridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.skysports.com/");
        }

        private void bBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.bbc.co.uk/");
        }

        private void nBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://abcnews.go.com/");
        }

        private void skynewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://news.sky.com/");
        }

        private void shideleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.technewsworld.com/");
        }

        private void webrazziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://techcrunch.com/");
        }

        private void techStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://techstartups.com/");
        }

        private void finansKurDunyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.bloomberg.com/");
        }

        private void forexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.forex.com/en-uk/");
        }

        private void worldFinanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.worldfinance.com/news");
        }

        private void amazonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.amazon.com/");
        }

        private void ebayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.ebay.com/");
        }

        private void walmartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.walmart.com/");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/");
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://twitter.com/");
        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.instagram.com/");
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://github.com/");
        }

        private void craiglistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.craigslist.org/about/sites");
        }

        private void stackoverFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://stackoverflow.com/");
        }

        private void turkishAirlinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.turkishairlines.com/en-us/");
        }

        private void vOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.voanews.com/");
        }

        private void britishCounsilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://learnenglish.britishcouncil.org/");
        }

        private void netflixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.netflix.com/");
        }

        private void spotifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.spotify.com/");
        }

        private void flightRadarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.flightradar24.com/51,-2/8");
        }

        private void vengeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://venge.io/");
        }

        private void miniRoyale2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://miniroyale2.io/");
        }

        private void agarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://agar.io/#ffa");
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you need help... github.com/enes-dev");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = webBrowser1.StatusText;
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
           
        }
    }
}
