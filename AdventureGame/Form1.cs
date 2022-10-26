using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        public struct Item
        {
            public String itemName;
            public bool have;
        }

        Item[] items = new Item[26];

        struct Scene
        {
           // int sceneNumber
        }

        public Form1()
        {
            InitializeComponent();

            items[0].itemName = "evil rock";
            items[1].itemName = "bucket";
            items[2].itemName = "holy bucket";
            items[3].itemName = "stick";
            items[4].itemName = "sword";
            items[5].itemName = "axe";
            items[6].itemName = "totem";
            items[7].itemName = "voodoo doll";
            items[8].itemName = "broomstick";
            items[9].itemName = "coconut";
            items[10].itemName = "crown of thornes";
            items[11].itemName = "pandoras box";
            items[12].itemName = "decapitated head";
            items[13].itemName = "the one ring";
            items[14].itemName = "plane";
            items[15].itemName = "power glove";
            items[16].itemName = "companion cube";
            items[17].itemName = "pocket watch";
            items[18].itemName = "plank";
            items[19].itemName = "cloth";
            items[20].itemName = "chain";
            items[21].itemName = "hook";
            items[22].itemName = "metalic hand-held item";
            items[23].itemName = "slingshot";
            items[24].itemName = "poison fang";
            items[25].itemName = "torch";

            for (int i = 0; i <= 25; i++)
            {
                items[i].have = false;
            }

            textOutput.BackColor = Color.FromArgb(200, textOutput.BackColor);

            uInput.Parent = uInputBack;
            uInput.Location = new Point(0, 0);
            uInputBack.BackColor = Color.FromArgb(200, uInputBack.BackColor);
        }

        private void uInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e. == Key.Return)
            //{
            //    textBlock1.Text = "You Entered: " + textBox1.Text;
            //}
        }

        private void uInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Text = "You Entered: " + uInput.Text;
                uInput.Text = "";
            }
        }

        //private void uInput_KeyUp(object sender, KeyEvene.tArgs e)
        //{
        //    //if (e.KeyCode == Keys.Enter)
        //    //{
        //    //    textBlock1.Text = "You Entered: " + textBox1.Text;
        //    //}
        //}
    }
}
