using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
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

        int currentPage = 0;

        int timesPlayed = 0;

        int pagesScrolled = 0;

        bool inVoid = false;

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
            int pandorasBoxChance;
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
            int hookChance;
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
            int torchChance;

            //Check the input and return the item message
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
                else if (inputText.ToLower().Contains("sword"))
                {
                    if (chance <= swordChance)
                    {
                        return swordMessage;
                    }
                    else
                    {
                        return swordMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("axe"))
                {
                    if (chance <= axeChance)
                    {
                        return axeMessage;
                    }
                    else
                    {
                        return axeMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("totem"))
                {
                    if (chance <= totemChance)
                    {
                        return totemMessage;
                    }
                    else
                    {
                        return totemMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("voodoo doll"))
                {
                    if (chance <= voodooDollChance)
                    {
                        return voodooDollMessage;
                    }
                    else
                    {
                        return voodooDollMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("broomstick"))
                {
                    if (chance <= broomstickChance)
                    {
                        return broomstickMessage;
                    }
                    else
                    {
                        return broomstickMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("coconut"))
                {
                    if (chance <= coconutChance)
                    {
                        return coconutMessage;
                    }
                    else
                    {
                        return coconutMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("crown of thornes"))
                {
                    if (chance <= crownOfThornesChance)
                    {
                        return crownOfThornesMessage;
                    }
                    else
                    {
                        return crownOfThornesMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("pandoras box") || inputText.ToLower().Contains("pandora's box"))
                {
                    if (chance <= pandorasBoxChance)
                    {
                        return pandorasBoxMessage;
                    }
                    else
                    {
                        return pandorasBoxMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("decapitated head") || inputText.ToLower().Contains("head"))
                {
                    if (chance <= decapitatedHeadChance)
                    {
                        return decapitatedHeadMessage;
                    }
                    else
                    {
                        return decapitatedHeadMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("the one ring") || inputText.ToLower().Contains("ring"))
                {
                    if (chance <= theOneRingChance)
                    {
                        return theOneRingMessage;
                    }
                    else
                    {
                        return theOneRingMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("plane"))
                {
                    if (chance <= planeChance)
                    {
                        return planeMessage;
                    }
                    else
                    {
                        return planeMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("power glove"))
                {
                    if (chance <= powerGloveChance)
                    {
                        return powerGloveMessage;
                    }
                    else
                    {
                        return powerGloveMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("companion cube"))
                {
                    if (chance <= companionCubeChance)
                    {
                        return companionCubeMessage;
                    }
                    else
                    {
                        return companionCubeMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("pocket watch"))
                {
                    if (chance <= pocketWatchChance)
                    {
                        return pocketWatchMessage;
                    }
                    else
                    {
                        return pocketWatchMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("plank"))
                {
                    if (chance <= plankChance)
                    {
                        return plankMessage;
                    }
                    else
                    {
                        return plankMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("cloth"))
                {
                    if (chance <= clothChance)
                    {
                        return clothMessage;
                    }
                    else
                    {
                        return clothMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("chain"))
                {
                    if (chance <= chainChance)
                    {
                        return chainMessage;
                    }
                    else
                    {
                        return chainMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("hook"))
                {
                    if (chance <= hookChance)
                    {
                        return hookMessage;
                    }
                    else
                    {
                        return hookMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("metallic handheld item"))
                {
                    if (chance <= metalicHandHeldItemChance)
                    {
                        return metalicHandHeldItemMessage;
                    }
                    else
                    {
                        return metalicHandHeldItemMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("slingshot"))
                {
                    if (chance <= slingshotChance)
                    {
                        return slingshotMessage;
                    }
                    else
                    {
                        return slingshotMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("poison fang"))
                {
                    if (chance <= poisonFangChance)
                    {
                        return poisonFangMessage;
                    }
                    else
                    {
                        return poisonFangMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("torch"))
                {
                    if (chance <= torchChance)
                    {
                        return torchMessage;
                    }
                    else
                    {
                        return torchMessageBad;
                    }
                }

                else
                {
                    return "You do not have this Item";
                }
            }


            String examineText;
            String obtainText;
            String lookText;
            String sayText;
            String unlockText;
            String expectedUnlockItem;
            String traverseText;
            String failedTraverseText;
            public String actionCheck(String inputText, String unlockItem, int traverseChance, int chance)
            {
                if (inputText.ToLower().Contains("examine"))
                {
                    return examineText;
                }

                else if (inputText.ToLower().Contains("pick up") || inputText.ToLower().Contains("grab") || inputText.ToLower().Contains("take"))
                {
                    return obtainText;
                }

                else if (inputText.ToLower().Contains("look"))
                {
                    return lookText;
                }

                else if (inputText.ToLower().Contains("say"))
                {
                    return sayText;
                }

                else if (inputText.ToLower().Contains("unlock"))
                {
                    if (unlockItem == expectedUnlockItem)
                    {
                        return unlockText;
                    }

                    else if (unlockItem == "")
                    {
                        return "With What?";
                    }

                    else
                    {
                        return "It Does Not Work";
                    }
                }

                else if (inputText.ToLower().Contains("traverse"))
                {
                    if (chance > traverseChance)
                    {
                        return traverseText;
                    }
                    else
                    {
                        return failedTraverseText;
                    }
                }

                else
                {
                    return "You Cannot Do That";
                }
            }

            public String moveCheck(String inputText, int chance, int pagesScrolled, int specialEventChance, bool inVoid)
            {
                if (pagesScrolled > 20 && chance >= (100 - (10 * (pagesScrolled - 20))))
                {
                    return "Load Kingdom Page 1";
                }
                else if (chance >= 100 - specialEventChance)
                {
                    return "Load Extra Page";
                }
                else if (inVoid == false)
                {
                    return "Load Basic Page";
                }
                else
                {
                    return "You have nowhere to go";
                }
            }

            public String extraCheck(String inputText, int chance, int currentPage)
            {
                if (inputText.ToLower().Contains("dance"))
                {
                    if (currentPage == 53)
                    {
                        return "You can't cut loose! Footloose! And are shot in your sunday shoes!\nPlay Again?";
                    }
                    else if (currentPage == 30)
                    {
                        return "The Obelisk responds by revealing a powerful glove";
                    }
                    else
                    {
                        return "You bust it down..... For absolutely no reason. \nThen again, who needs one?";
                    }
                }
                else if (inputText.ToLower().Contains("suicide"))
                {
                    return "You took that way out. \nPlay Again?";
                }
                else if (inputText.ToLower().Contains("up up down down left right left right b a start"))
                {
                    if (currentPage == 53)
                    {
                        return "And they all lived happily ever after. Yay..... \nPlay Again?";
                    }
                    else
                    {
                        return "This is not a game. This is Life.";
                    }
                }
                else
                {
                    return "Ivalid Input. Please Use Valid Prefixes.";
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
                int chance = rnd.Next(0, 101);
                if (uInput.Text.ToLower().Contains("use"))
                {
                    if (uInput.Text.ToLower().Contains("evil rock") && items[0].have == true)
                    {
                        //String response = page.itemCheck(uInput.Text, chance);
                        //textOutput.Text += $"\n{response}";
                    }
                }

                else if (uInput.Text.ToLower().Contains("use"))
                {

                }
            }
        }
    }
}
