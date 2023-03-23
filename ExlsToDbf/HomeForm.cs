using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExlsToDbf
{
    public partial class HomeForm : Form
    {
        private Button? currentButton;
        private Random random;
        private int tempIndex;

        public HomeForm()
        {
            InitializeComponent();
            random= new Random();
            tempIndex = -1;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                if(!(currentButton?.Equals(sender as Button)) ?? true)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font(
                        "Microsoft Sand Serif", 
                        12.5F, 
                        FontStyle.Regular,
                        GraphicsUnit.Point,
                        ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previusBtn in panelMenu.Controls)
            {
                if(previusBtn.GetType() == typeof(Button)) 
                {
                    previusBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previusBtn.ForeColor = Color.Gainsboro;
                    previusBtn.Font = new Font(
                        "Microsoft Sand Serif",
                        10F,
                        FontStyle.Regular,
                        GraphicsUnit.Point,
                        ((byte)(0)));
                }
            }
        }

        private void btnMenuXls_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnMenuDbf_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
