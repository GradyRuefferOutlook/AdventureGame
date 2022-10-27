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

        Random rnd = new Random();

        struct Scene
        {
            String evilRockMessage;
            String evilRockMessageBad;
            int evilRockChance;
            String bucketMessage;
            String bucketMessageBad;
            int bucketChance;
            String holyBucketMessage;
            String holyBucketMessageBad;
            int holyBucketChance;
            String stickMessage;
            String stickMessageBad;
            int stickChance;
            String swordMessage;
            String swordMessageBad;
            int swordChance;
            String axeMessage;
            String axeMessageBad;
            int axeChance;
            String totemMessage;
            String totemMessageBad;
            int totemChance;
            String voodooDollMessage;
            String voodooDollMessageBad;
            int voodooDollChance;
            String broomstickMessage;
            String broomstickMessageBad;
            int broomstickChance;
            String coconutMessage;
            String coconutMessageBad;
            int coconutChance;
            String crownOfThornesMessage;
            String crownOfThornesMessageBad;
            int crownOfThornesChance;
            String pandorasBoxMessage;
            String pandorasBoxMessageBad;
            int pandorasBoxkChance;
            String decapitatedHeadMessage;
            String decapitatedHeadMessageBad;
            int decapitatedHeadChance;
            String theOneRingMessage;
            String theOneRingMessageBad;
            int theOneRingChance;
            String planeMessage;
            String planeMessageBad;
            int planeChance;
            String powerGloveMessage;
            String powerGloveMessageBad;
            int powerGloveChance;
            String companionCubeMessage;
            String companionCubeMessageBad;
            int companionCubeChance;
            String pocketWatchMessage;
            String pocketWatchMessageBad;
            int pocketWatchChance;
            String plankMessage;
            String plankMessageBad;
            int plankChance;
            String clothMessage;
            String clothMessageBad;
            int clothChance;
            String chainMessage;
            String chainMessageBad;
            int chainChance;
            String hookMessage;
            String hookMessageBad;
            int hookkChance;
            String metalicHandHeldItemMessage;
            String metalicHandHeldItemMessageBad;
            int metalicHandHeldItemChance;
            String slingshotMessage;
            String slingshotMessageBad;
            int slingshotChance;
            String poisonFangMessage;
            String poisonFangMessageBad;
            int poisonFangChance;
            String torchMessage;
            String torchMessageBad;
            int torchRockChance;
            
            //Check the input and return the message
            public String itemCheck(String inputText, int chance)
            {
                if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= evilRockChance)
                    {
                        return evilRockMessage;
                    }
                    else
                    {
                        return evilRockMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("bucket"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("holy bucket"))
                {
                    if (chance <= holyBucketChance)
                    {
                        return holyBucketMessage;
                    }
                    else
                    {
                        return holyBucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("stick"))
                {
                    if (chance <= stickChance)
                    {
                        return stickMessage;
                    }
                    else
                    {
                        return stickMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("evil rock"))
                {
                    if (chance <= bucketChance)
                    {
                        return bucketMessage;
                    }
                    else
                    {
                        return bucketMessageBad;
                    }
                }


                else
                {
                    return "dummy";
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            Scene[] scenesReg = new Scene[20];

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
            items[22].itemName = "metalic hand held item";
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

        private void uInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textOutput.Text += "\nYou Entered: " + uInput.Text;
                uInput.Text = "";
            }
        }
    }
}
