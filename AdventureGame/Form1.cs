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
using System.Media;
using System.Threading;

namespace AdventureGame
{
    /* Grady Rueffer
     * 152446035
     * Adventure Game
     * 02/11/2022
     */
    public partial class Form1 : Form
    {
        public struct Item
        {
            public String itemName;
            public bool have;
        }

        //Checks if the user should be choosing to play again
        bool playAgain = false;

        //Track current page
        String currentPage = "Start";

        //Track times played, because of reset, never used
        //int timesPlayed = 0;

        //Track the pages traversed 
        int pagesScrolled = 0;

        //Special Event Chance for quick changes
        int specialEventChance = 50;

        Item[] items = new Item[26];

        Random rnd = new Random();

        System.Media.SoundPlayer adventureTheme = new SoundPlayer(Properties.Resources.MedisiaTheme);

        public struct Scene
        {
            //Opening text
            public String opener;

            //Check whether the scene was used
            public bool used;

            //Check whether you have participated in the event and whether it is safe to move
            public bool eventDone;
            public bool safe;

            //Image to display
            public Image display;

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
            public String itemCheck(String inputText, int chance, bool zeroHave, bool oneHave, bool twoHave, bool threeHave, bool fourHave, bool fiveHave, bool sixHave, bool sevenHave, bool eightHave, bool nineHave, bool tenHave, bool elevenHave, bool twelveHave, bool thirteenHave, bool fourteenHave, bool fifteenHave, bool sixteenHave, bool seventeenHave, bool eighteenHave, bool nineteenHave, bool twentyHave, bool twentyoneHave, bool twentytwoHave, bool twentythreeHave, bool twentyfourHave, bool twentyfiveHave)
            {
                System.Media.SoundPlayer itemSound;
                if (inputText.ToLower().Contains("evil rock") && zeroHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.RockSound);
                    if (chance <= evilRockChance)
                    {
                        itemSound.Play();
                        return evilRockMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return evilRockMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("bucket") && oneHave == true && inputText.ToLower().Contains("holy") == false)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.BucketSound);
                    if (chance <= bucketChance)
                    {
                        itemSound.Play();
                        return bucketMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return bucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("holy bucket") && twoHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.HolyBucketSound);
                    if (chance <= holyBucketChance)
                    {
                        itemSound.Play();
                        return holyBucketMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return holyBucketMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("stick") && threeHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.StickSound);
                    if (chance <= stickChance)
                    {
                        itemSound.Play();
                        return stickMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return stickMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("sword") && fourHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.SwordSound);
                    if (chance <= swordChance)
                    {
                        itemSound.Play();
                        return swordMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return swordMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("axe") && fiveHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.AxeSound);
                    if (chance <= axeChance)
                    {
                        itemSound.Play();
                        return axeMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return axeMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("totem") && sixHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.TotemSound);
                    if (chance <= totemChance)
                    {
                        itemSound.Play();
                        return totemMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return totemMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("voodoo doll") && sevenHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.VoodooDollSound);
                    if (chance <= voodooDollChance)
                    {
                        itemSound.Play();
                        return voodooDollMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return voodooDollMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("broomstick") && eightHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.BroomstickSound);
                    if (chance <= broomstickChance)
                    {
                        itemSound.Play();
                        return broomstickMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return broomstickMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("coconut") && nineHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.CoconutSound);
                    if (chance <= coconutChance)
                    {
                        itemSound.Play();
                        return coconutMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return coconutMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("crown of thornes") && tenHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.CrownOfThornesSound);
                    if (chance <= crownOfThornesChance)
                    {
                        itemSound.Play();
                        return crownOfThornesMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return crownOfThornesMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("pandoras box") || inputText.ToLower().Contains("pandora's box") && elevenHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.PandorasBoxSound);
                    if (chance <= pandorasBoxChance)
                    {
                        itemSound.Play();
                        return pandorasBoxMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return pandorasBoxMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("decapitated head") || inputText.ToLower().Contains("head") && twelveHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.HeadSound);
                    if (chance <= decapitatedHeadChance)
                    {
                        itemSound.Play();
                        return decapitatedHeadMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return decapitatedHeadMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("the one ring") || inputText.ToLower().Contains("ring") && thirteenHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.TheOneRingSound);
                    if (chance <= theOneRingChance)
                    {
                        itemSound.Play();
                        return theOneRingMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return theOneRingMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("plane") && fourteenHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.PlaneSound);
                    if (chance <= planeChance)
                    {
                        itemSound.Play();
                        return planeMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return planeMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("power glove") && fifteenHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.PowerGloveSound);
                    if (chance <= powerGloveChance)
                    {
                        itemSound.Play();
                        return powerGloveMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return powerGloveMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("companion cube") && sixteenHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.CompanionCubeSound);
                    if (chance <= companionCubeChance)
                    {
                        itemSound.Play();
                        return companionCubeMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return companionCubeMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("pocket watch") && seventeenHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.PocketWatchSound);
                    if (chance <= pocketWatchChance)
                    {
                        itemSound.Play();
                        return pocketWatchMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return pocketWatchMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("plank") && eighteenHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.PlankSound);
                    if (chance <= plankChance)
                    {
                        itemSound.Play();
                        return plankMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return plankMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("cloth") && nineteenHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.ClothSound);
                    if (chance <= clothChance)
                    {
                        itemSound.Play();
                        return clothMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return clothMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("chain") && twentyHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.ChainSound);
                    if (chance <= chainChance)
                    {
                        itemSound.Play();
                        return chainMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return chainMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("hook") && twentyoneHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.HookSound);
                    if (chance <= hookChance)
                    {
                        itemSound.Play();
                        return hookMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return hookMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("metallic handheld item") && twentytwoHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.GunSound);
                    if (chance <= metalicHandHeldItemChance)
                    {
                        itemSound.Play();
                        return metalicHandHeldItemMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return metalicHandHeldItemMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("slingshot") && twentythreeHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.SlingshotSound);
                    if (chance <= slingshotChance)
                    {
                        itemSound.Play();
                        return slingshotMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return slingshotMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("poison fang") && twentyfourHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.PoisonFangSound);
                    if (chance <= poisonFangChance)
                    {
                        itemSound.Play();
                        return poisonFangMessage;
                    }
                    else
                    {
                        itemSound.Play();
                        return poisonFangMessageBad;
                    }
                }
                else if (inputText.ToLower().Contains("torch") && twentyfiveHave == true)
                {
                    itemSound = new System.Media.SoundPlayer(Properties.Resources.TorchSound);
                    if (chance <= torchChance)
                    {
                        itemSound.Play();
                        return torchMessage;
                    }
                    else
                    {
                        itemSound.Play();
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
            int traverseChance;

            public String actionCheck(String inputText, String unlockItem, int chance)
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
                    if (unlockItem == expectedUnlockItem || expectedUnlockItem == "")
                    {
                        return unlockText;
                    }

                    else if (unlockItem == "")
                    {
                        return "\nWith What?";
                    }

                    else
                    {
                        return "\nIt Does Not Work";
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
                    return "\nYou Cannot Do That";
                }
            }

            public String moveCheck(String inputText, int chance, int pagesScrolled, int specialEventChance)
            {
                if (eventDone == true || safe == true)
                {
                    if (pagesScrolled >= 10 && chance >= (100 - (10 * (pagesScrolled - 9))))
                    {
                        return "Kingdom Gate";
                    }

                    else if (chance >= 100 - specialEventChance)
                    {
                        return "Load Extra Page";
                    }

                    else
                    {
                        return "Load Reg Page";
                    }
                }
                else
                {
                    return "\nYou feel like you can't leave yet";
                }
            }

            public String extraCheck(String inputText, int chance, String currentPage)
            {
                if (inputText.ToLower().Contains("dance"))
                {
                    if (currentPage == "endingChoose")
                    {
                        return "\nYou can't cut loose! Footloose! And are shot in your sunday shoes!\nPlay Again?";
                    }
                    else if (currentPage == "scenesItem[15]")
                    {
                        return "\nThe Obelisk responds by revealing a powerful glove";
                    }
                    else
                    {
                        return "\nYou bust it down..... For absolutely no reason. \nThen again, who needs one?";
                    }
                }
                else if (inputText.ToLower().Contains("suicide"))
                {
                    return "\nYou took that way out. \nPlay Again?";
                }
                else if (inputText.ToLower().Contains("up up down down left right left right b a start"))
                {
                    if (currentPage == "endingChoose")
                    {
                        return "\nAnd they all lived happily ever after. Yay..... \nPlay Again?";
                    }
                    else
                    {
                        return "\nThis is not a game. This is Life.";
                    }
                }
                else
                {
                    return "\nIvalid Input. Please Use Valid Prefixes.";
                }
            }

            public void sceneCreate(
            String evilRockMessageI,
            String evilRockMessageBadI,
            int evilRockChanceI,
            String bucketMessageI,
            String bucketMessageBadI,
            int bucketChanceI,
            String holyBucketMessageI,
            String holyBucketMessageBadI,
            int holyBucketChanceI,
            String stickMessageI,
            String stickMessageBadI,
            int stickChanceI,
            String swordMessageI,
            String swordMessageBadI,
            int swordChanceI,
            String axeMessageI,
            String axeMessageBadI,
            int axeChanceI,
            String totemMessageI,
            String totemMessageBadI,
            int totemChanceI,
            String voodooDollMessageI,
            String voodooDollMessageBadI,
            int voodooDollChanceI,
            String broomstickMessageI,
            String broomstickMessageBadI,
            int broomstickChanceI,
            String coconutMessageI,
            String coconutMessageBadI,
            int coconutChanceI,
            String crownOfThornesMessageI,
            String crownOfThornesMessageBadI,
            int crownOfThornesChanceI,
            String pandorasBoxMessageI,
            String pandorasBoxMessageBadI,
            int pandorasBoxChanceI,
            String decapitatedHeadMessageI,
            String decapitatedHeadMessageBadI,
            int decapitatedHeadChanceI,
            String theOneRingMessageI,
            String theOneRingMessageBadI,
            int theOneRingChanceI,
            String planeMessageI,
            String planeMessageBadI,
            int planeChanceI,
            String powerGloveMessageI,
            String powerGloveMessageBadI,
            int powerGloveChanceI,
            String companionCubeMessageI,
            String companionCubeMessageBadI,
            int companionCubeChanceI,
            String pocketWatchMessageI,
            String pocketWatchMessageBadI,
            int pocketWatchChanceI,
            String plankMessageI,
            String plankMessageBadI,
            int plankChanceI,
            String clothMessageI,
            String clothMessageBadI,
            int clothChanceI,
            String chainMessageI,
            String chainMessageBadI,
            int chainChanceI,
            String hookMessageI,
            String hookMessageBadI,
            int hookChanceI,
            String metalicHandHeldItemMessageI,
            String metalicHandHeldItemMessageBadI,
            int metalicHandHeldItemChanceI,
            String slingshotMessageI,
            String slingshotMessageBadI,
            int slingshotChanceI,
            String poisonFangMessageI,
            String poisonFangMessageBadI,
            int poisonFangChanceI,
            String torchMessageI,
            String torchMessageBadI,
            int torchChanceI,
            String examineTextI,
            String obtainTextI,
            String lookTextI,
            String sayTextI,
            String unlockTextI,
            String expectedUnlockItemI,
            String traverseTextI,
            int traverseChanceI,
            String failedTraverseTextI,
            String openerI,
            bool safeI,
            Image displayI
            )
            {
                evilRockMessage = evilRockMessageI;
                evilRockMessageBad = evilRockMessageBadI;
                evilRockChance = evilRockChanceI;
                bucketMessage = bucketMessageI;
                bucketMessageBad = bucketMessageBadI;
                bucketChance = bucketChanceI;
                holyBucketMessage = holyBucketMessageI;
                holyBucketMessageBad = holyBucketMessageBadI;
                holyBucketChance = holyBucketChanceI;
                stickMessage = stickMessageI;
                stickMessageBad = stickMessageBadI;
                stickChance = stickChanceI;
                swordMessage = swordMessageI;
                swordMessageBad = swordMessageBadI;
                swordChance = swordChanceI;
                axeMessage = axeMessageI;
                axeMessageBad = axeMessageBadI;
                axeChance = axeChanceI;
                totemMessage = totemMessageI;
                totemMessageBad = totemMessageBadI;
                totemChance = totemChanceI;
                voodooDollMessage = voodooDollMessageI;
                voodooDollMessageBad = voodooDollMessageBadI;
                voodooDollChance = voodooDollChanceI;
                broomstickMessage = broomstickMessageI;
                broomstickMessageBad = broomstickMessageBadI;
                broomstickChance = broomstickChanceI;
                coconutMessage = coconutMessageI;
                coconutMessageBad = coconutMessageBadI;
                coconutChance = coconutChanceI;
                crownOfThornesMessage = crownOfThornesMessageI;
                crownOfThornesMessageBad = crownOfThornesMessageBadI;
                crownOfThornesChance = crownOfThornesChanceI;
                pandorasBoxMessage = pandorasBoxMessageI;
                pandorasBoxMessageBad = pandorasBoxMessageBadI;
                pandorasBoxChance = pandorasBoxChanceI;
                decapitatedHeadMessage = decapitatedHeadMessageI;
                decapitatedHeadMessageBad = decapitatedHeadMessageBadI;
                decapitatedHeadChance = decapitatedHeadChanceI;
                theOneRingMessage = theOneRingMessageI;
                theOneRingMessageBad = theOneRingMessageBadI;
                theOneRingChance = theOneRingChanceI;
                planeMessage = planeMessageI;
                planeMessageBad = planeMessageBadI;
                planeChance = planeChanceI;
                powerGloveMessage = powerGloveMessageI;
                powerGloveMessageBad = powerGloveMessageBadI;
                powerGloveChance = powerGloveChanceI;
                companionCubeMessage = companionCubeMessageI;
                companionCubeMessageBad = companionCubeMessageBadI;
                companionCubeChance = companionCubeChanceI;
                pocketWatchMessage = pocketWatchMessageI;
                pocketWatchMessageBad = pocketWatchMessageBadI;
                pocketWatchChance = pocketWatchChanceI;
                plankMessage = plankMessageI;
                plankMessageBad = plankMessageBadI;
                plankChance = plankChanceI;
                clothMessage = clothMessageI;
                clothMessageBad = clothMessageBadI;
                clothChance = clothChanceI;
                chainMessage = chainMessageI;
                chainMessageBad = chainMessageBadI;
                chainChance = chainChanceI;
                hookMessage = hookMessageI;
                hookMessageBad = hookMessageBadI;
                hookChance = hookChanceI;
                metalicHandHeldItemMessage = metalicHandHeldItemMessageI;
                metalicHandHeldItemMessageBad = metalicHandHeldItemMessageBadI;
                metalicHandHeldItemChance = metalicHandHeldItemChanceI;
                slingshotMessage = slingshotMessageI;
                slingshotMessageBad = slingshotMessageBadI;
                slingshotChance = slingshotChanceI;
                poisonFangMessage = poisonFangMessageI;
                poisonFangMessageBad = poisonFangMessageBadI;
                poisonFangChance = poisonFangChanceI;
                torchMessage = torchMessageI;
                torchMessageBad = torchMessageBadI;
                torchChance = torchChanceI;
                examineText = examineTextI;
                obtainText = obtainTextI;
                lookText = lookTextI;
                sayText = sayTextI;
                unlockText = unlockTextI;
                expectedUnlockItem = expectedUnlockItemI;
                traverseText = traverseTextI;
                failedTraverseText = failedTraverseTextI;
                traverseChance = traverseChanceI;
                used = false;
                eventDone = false;
                safe = safeI;
                opener = openerI;
                display = displayI;
            }
        }

        //Sets the regular scenes
        Scene[] scenesReg = new Scene[10];

        //Sets the item obtaining (or extra) scenes
        Scene[] scenesItem = new Scene[26];

        //Sets the ending scenes, due to time constraints, has been changed to text
        //Scene[] scenesEnding = new Scene[26];
        Scene scenesEnding;

        public Form1()
        {
            InitializeComponent();

            adventureTheme.Play();

            medisiaBackdrop.Parent = medisiaBorder;
            medisiaBackdrop.Location = new Point(0, 0);
            medisiaBackdrop.BackgroundImage = Properties.Resources.ForestBackdrop;

            medisiaImageView.Parent = medisiaBackdrop;
            medisiaImageView.Location = new Point(0, 0);

            medisiaImageView.BackgroundImage = Properties.Resources.MedisiaBackdrop;

            textOutput.Text = "Welcome to Medisia \nHere are your controls \nUse: Use your items \nYou begin with a stick, slingshot, torch, plank, and axe \nExamine: Examine the subject \nPick Up: Obtain items \nLook: Look around \nSay: Attempt to speak \nUnlock: Unlock an object \nGo: Move to a new area \nAnd Three Hidden Actions";

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

            items[3].have = true;
            items[23].have = true;
            items[25].have = true;
            items[18].have = true;
            items[5].have = true;

            //Scene 1, Cart Scene
            scenesReg[0].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "You place the bucket on the cart \nThis feels right", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "You place the bucket on the cart \nYou feel brought to tears", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "You give up your stick", //stickMessageI
              "Your stick breaks", //stickMessageBadI
              50, //stickChanceI
              "You lay down your arms", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "You hand down your axe", //axeMessageI
              "You smash the cart", //axeMessageBadI
              50, //axeChanceI
              "You curse the cart", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "The doll floats to the cart \nYou feel relieved", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "It rejects the cart",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "You hear distant horse steps... \nClopping? \nWho knows, but your coconut is carried off... \nBy two swallows?", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That's stuck to your head", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "NOOOOOOOOOOOOOOOO! \n Play Again?", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "You lay the head on the cart \nThe owner would be terrified", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "The whispers tell you not to",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "The plane flies off with the cart in tow", //planeMessageI
              "The plane crushes the cart \nHow did you carry that!?", //planeMessageBadI
              50, //planeChanceI
              "The cart glitches out of existence and so does the glove \nWhy?", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "You leave it on the cart \nYou feel empty inside without your companion cube", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "You leave your pocket watch for the owner \nYou feel happy", //pocketWatchMessageI
              "You drop the pocket watch and it shatters", //pocketWatchMessageBadI
              50, //pocketWatchChanceI
              "You replace an old plank with your plank \n You feel good", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "You wipe down the cart with the cloth \nIt falls apart", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "You place the chain on the cart", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "You place the hook on the cart", //hookMessageI
              "You hook the cart", //hookMessageBadI
              50, //hookChanceI
              "You place the metallic handheld item on the cart", //metalicHandHeldItemMessageI
              "The gun... I MEAN metallic handheld item fires \nIt ricochets and hits you \nYou are dead \nPlay Again", //metalicHandHeldItemMessageBadI
              80, //metalicHandHeldItemChanceI
              "Your prankster days are behind you... \nNOT! You keep your it on your person", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That's... Not Right", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "You place the torch on the cart \nRisky", //torchMessageI
              "You light the cart on fire with the torch \nThe torch burns up", //torchMessageBadI
              50, //torchChanceI
              "It looks to be a cart \nPerhaps it once belonged to a merchant", //examineTextI
              "You cannot take the cart", //obtainTextI
              "You see a clear path around the cart \nMaybe you don't need to be giving", //lookTextI
              "You do realize there's no one around?", //sayTextI
              "You unlock a secret compartment in the cart \nYou find a strange box \nPandoras Box obtained", //unlockTextI
              "", //expectedUnlockItemI
              "You walk past the cart \nPerhaps you deserve what happened to you",//traverseTextI
              100, //traverseChanceI
              "", //failedTraverseTextI
              "You run across an abandoned cart \nYou feel like leaving something behind", //openerI
              false, //safeI
              Properties.Resources.Cart
              );

            //Scene 2, Broken Bridge
            scenesReg[1].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That does nothing", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "You drain the river \n it is now safe to cross", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "You patch the bridge with your stick \nIt is now safe to cross", //stickMessageI
              "Your stick breaks", //stickMessageBadI
              10, //stickChanceI
              "A sword won't help you here", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "You cut down wood to fix the bridge \nThe axe breaks but it is now safe to cross", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "Your vision goes black \nThe bridge is fixed and it is now safe to cross", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "Nothing Happens", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "You fly over the bridge but lose control \nYou crash into a nearby tree \nYou are safe but the broom is broken",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "You hear distant horse steps... \nClopping? \nWho knows, but you and your coconut are carried off... \nBy two swallows? \nYou are safely across the bridge", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That's stuck to your head", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "NOOOOOOOOOOOOOOOO! \n Play Again?", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "What? \nWhat exactly is your plan?", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "A grey creature snags the ring \nYou grab hold but the creature escapes \nYou are safely across the bridge",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "You fly across the bridge in your plane \nYou land safely but the plane is out of gas \nYou are safely across the bridge", //planeMessageI
              "You try to fly across the bridge, but realize you cannot fly a plane \nYou crash and burn \nPlay again?", //planeMessageBadI
              50, //planeChanceI
              "The bridges glitches but is completely fixed \nThe glove disappears but you are safe across the bridge", //powerGloveMessageI
              "The glove disappears and you look weird for trying", //powerGloveMessageBadI
              90, //powerGloveChanceI
              "You try to fix the bridge with your companion cube \nIt sinks into the river", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "You check the time \nSuddenly, the hands move backwards and the bridge is fixed \nIt is safe to cross, but the pocket watch smashes", //pocketWatchMessageI
              "You drop the pocket watch and it shatters", //pocketWatchMessageBadI
              90, //pocketWatchChanceI
              "You fix the bridge with your plank \n It is safe to cross", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "You make a make-shift paraglider and sail across \nYou are safe on the other side", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "You use the chain to hold the bridge together \nYou are safe, but the chain breaks", //chainMessageI
              "The chain snaps under the pressure and you tumble into the river \nPlay Again? ", //chainMessageBadI
              70, //chainChanceI
              "You hook across the bridge gap \nYou are safely across", //hookMessageI
              "Your hook ricochets and breaks", //hookMessageBadI
              75, //hookChanceI
              "You shoot the bridge \nWhy?", //metalicHandHeldItemMessageI
              "You shoot the bridge \nIt ricochets and hits you \nYou die \nPlay Again? ", //metalicHandHeldItemMessageBadI
              80, //metalicHandHeldItemChanceI
              "You somehow launch yourself across with the slingshot \nIt defies all logic, but you're safe", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That's... Not going to work", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "You know what they say about burning bridges \nInstead you use it to fix the bridge \nYou are safely across", //torchMessageI
              "You light the bridge on fire with the torch \nThe torch burns up", //torchMessageBadI
              50, //torchChanceI
              "It's beat down, but maybe you can still cross \nDefinitely a last choice option though, it looks incredibly dangerous", //examineTextI
              "There's absolutely nothing salvagable", //obtainTextI
              "The river extends far past your vision", //lookTextI
              "You do realize there's no one around?", //sayTextI
              "Unlock what?", //unlockTextI
              "", //expectedUnlockItemI
              "You attempt to cross the broken bridge and succeed \nYou are safe! What Luck!",//traverseTextI
              5, //traverseChanceI
              "You fall in the river and drown \nPlay Again?", //failedTraverseTextI
              "A broken bridge blocks your path over a long river", //openerI
              false, //safeI
              Properties.Resources.Bridge
              );

            //To be added at a later date, The following are copied events
            //Scene 3, Wolf
            scenesReg[2].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That does nothing \nYou die \nPlay Again", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "The wolf yields \nYou are safe to move", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "You throw the stick and the wolf moves after it \nIt is safe to run", //stickMessageI
              "Your stick breaks \nYou die \nPlay Again", //stickMessageBadI
              10, //stickChanceI
              "You swing at the wolf \nThe blood splatter indicates it is safe to move", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "You swing at the wolf \nThe blood splatter indicates it is safe to move", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "Your vision goes black \nThe wolf and the totem are gone \nIt's safe to move, I think?", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "The wolf runs away in fright \nThe doll looks at you in a frightening manner \nIt is safe to move", //voodooDollMessageI
              "The wolf runs away in fright \nThe doll looks at you in a frightening manner \nYou die \nPlay Again?", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "The broomstick flies away from you",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "What a lovely Bunch of coconuts! \nAnywho, you're ripped to shreds \nYou die \nPlay Again?", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That's stuck to your head", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "NOOOOOOOOOOOOOOOO! \n Play Again?", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "The wolf takes the decapitated head \nYou can move safely", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "The wolf can no longer see you \nIt's safe to move",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "You fly straight into the wolf \nThe wolf is dead but you die as well \nPlay Again?", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "The wolf takes the glove", //powerGloveMessageI
              "The glove disappears and you look weird for trying", //powerGloveMessageBadI
              90, //powerGloveChanceI
              "You offer up the companion cube and it takes it \nYou coward \nIt is safe to move", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "You check the time \nSuddenly, the hands move backwards and the wolf is gone \nIt is safe to move, but the pocket watch smashes", //pocketWatchMessageI
              "You drop the pocket watch and it shatters", //pocketWatchMessageBadI
              90, //pocketWatchChanceI
              "It only stuns the wolf, but just long enough \nIt is safe to move", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "You try to muzle the wolf, but it fails \nYou die \nPlay Again?", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "You try to muzle the wolf, but it fails \nYou die \nPlay Again?", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "You hook pulls on the vital organs of the wolf \nThis somehow works \nIt is safe to move", //hookMessageI
              "Your hook pulls in the wolf \nYou die \nPlay Again?", //hookMessageBadI
              25, //hookChanceI
              "You shoot the Wolf \nIt's safe to move, there's no more threat", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "You distract the wolf with the slingshot \nNow is the safe time to run", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "You stab the wolf \nIt cries a loud yipe before falling dead \nIt is safe to move", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "You set fire to the wolf and it scampers off \nYou are safe to move", //torchMessageI
              "The light frightens the wolf and sends it into a frenzy \nYou die \nPlay Again?", //torchMessageBadI
              50, //torchChanceI
              "You cannot get around it \nThis is a primal hunter", //examineTextI
              "You get a stick off the ground", //obtainTextI
              "Blood drips from the mouth of the beast", //lookTextI
              "The Wolf doesn't speak elvish", //sayTextI
              "Unlock what?", //unlockTextI
              "", //expectedUnlockItemI
              "",//traverseTextI
              0, //traverseChanceI
              "The wolf tears you to pieces \nYou die \nPlay Again?", //failedTraverseTextI
              "A feral wolf blocks your path \nIt doesn't seem to be letting you by", //openerI
              false, //safeI
              Properties.Resources.Wolf
              );

            //Scene 4, Dragon
            scenesReg[3].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That does nothing \nYou die \nPlay Again", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "The dragon looks onwards with greed \nYou are safe to move, but the holy bucket stays", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That's not sufficient \nYou die \nPlay Again", //stickMessageI
              "Your stick breaks \nYou die \nPlay Again", //stickMessageBadI
              10, //stickChanceI
              "You swing at the dragon \nThe blood splatter indicates it is safe to move", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "You swing at the dragon \nThe blood splatter indicates it is safe to move", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "Your vision goes black \nThe dragon and the totem are gone \nIt's safe, I think", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "The dragon flies away in fright \nThe doll looks at you in a frightening manner \nIt is safe to move", //voodooDollMessageI
              "The dragon flies away in fright \nThe doll looks at you in a frightening manner \nYou die \nPlay Again?", //voodooDollMessageBadI
              50, //voodooDollChanceI
              "The broomstick flies away from you",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "What a lovely Bunch of coconuts! \nAnywho, you're ripped to shreds \nYou die \nPlay Again?", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That's stuck to your head", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "NOOOOOOOOOOOOOOOO! \n Play Again?", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "The dragon takes the decapitated head \nYou can move safely", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "The dragon can no longer see you \nIt's enraged \nIt's safe to move",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "You fly straight into the dragon \nThe dragon is dead but you die as well \nPlay Again?", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "The dragon flambes the glove", //powerGloveMessageI
              "The glove disappears and you look weird for trying", //powerGloveMessageBadI
              90, //powerGloveChanceI
              "You offer up the companion cube and it takes it \nYou coward \nIt is safe to move", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "You check the time \nSuddenly, the hands move backwards and the dragon is gone \nIt is safe to move, but the pocket watch smashes", //pocketWatchMessageI
              "You drop the pocket watch and it shatters", //pocketWatchMessageBadI
              90, //pocketWatchChanceI
              "The dragon burns the plank \nYou die \nPlay Again?", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "The dragon burns the cloth \nYou die \nPlay Again?", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "You bind the dragon \nIt is safe to run", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "You pull the dragon to the ground \nIt is safe to run", //hookMessageI
              "It only angers the dragon \nYou die \nPlay Again?", //hookMessageBadI
              25, //hookChanceI
              "The shot goes through the eyes \nLucky \nIt's safe to leave", //metalicHandHeldItemMessageI
              "It doesn't pierce the scales \nYou die \nPlay Again?", //metalicHandHeldItemMessageBadI
              50, //metalicHandHeldItemChanceI
              "", //slingshotMessageI
              "The shot bounces off the dragon \nOops \nYou die \nPlay Again?", //slingshotMessageBadI
              100, //slingshotChanceI
              "", //poisonFangMessageI
              "It doesn't pierce the scales \nYou die \nPlay Again?", //poisonFangMessageBadI
              0, //poisonFangChanceI
              "", //torchMessageI
              "The fire angers the dragon \nYou die \nPlay Again?", //torchMessageBadI
              0, //torchChanceI
              "You cannot get around it \nThis is a HUGE DRAGON", //examineTextI
              "You get a poison fang off the ground", //obtainTextI
              "Flames plume from the mouth of the beast", //lookTextI
              "There's no reasoning with a dragon", //sayTextI
              "Unlock what?", //unlockTextI
              "", //expectedUnlockItemI
              "",//traverseTextI
              0, //traverseChanceI
              "The dragon tears you to pieces \nYou die \nPlay Again?", //failedTraverseTextI
              "A dragon blocks your path \nIt doesn't seem to be letting you by", //openerI
              false, //safeI
              Properties.Resources.Dragon
              );

            //Scene 5, Black Knight
            scenesReg[4].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That does nothing", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "The knight does not yield \nHe is smited \nIt is safe to pass", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "You better have another arm, as yours finds its way onto the floor \nYou die \nPlay Again", //stickMessageI
              "Your stick breaks", //stickMessageBadI
              10, //stickChanceI
              "You best the knight \nIt is safe to move", //swordMessageI
              "The knight bests you \nYou die \nPlay Again",//swordMessageBadI
              50,//swordChanceI
              "It's not fast enough \nYou die \nPlay Again", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "The knight seizes the totem \nYou die \nPlay Again", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "The knight falls apart \nIt is safe to move", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "You fly past the knight \nThe broom dissappears but it is safe to move",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "You toss the coconut \nThe knight is unconscious \nIt's safe to move", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That's stuck to your head", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "NOOOOOOOOOOOOOOOO! \n Play Again?", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "What? \nWhat exactly is your plan?", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "You slip past the knight and lose the one ring \nHowever, it is safe to move",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "A plane won't help you here", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "The knight laughs \nIt's safe to slip by ", //powerGloveMessageI
              "The glove disappears and you look weird for trying", //powerGloveMessageBadI
              40, //powerGloveChanceI
              "Companionship isn't the solution", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "You check the time \nSuddenly, the hands move backwards and the knight collapses, all that remains is armour \nIt is safe to cross, but the pocket watch smashes", //pocketWatchMessageI
              "You drop the pocket watch and it shatters", //pocketWatchMessageBadI
              90, //pocketWatchChanceI
              "You knock the knight unconscious \nYour might has caused the plank to break \nIt is safe to move", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "You engage the knight in a slapping contest and win! \nGood Show! \nIt is safe to leave", //clothMessageI
              "You engage the knight in a slapping contest and lose \nYou die \nPlay Again?", //clothMessageBadI
              50, //clothChanceI
              "You toss the chain \nYou die \nPlay Again?", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "You hook in the knight for a deep kiss \nEnamoured, you find it safe to slip off into the daylight", //hookMessageI
              "Your hook ricochets and breaks", //hookMessageBadI
              75, //hookChanceI
              "", //metalicHandHeldItemMessageI
              "You shoot the knight \nIt ricochets and hits you \nYou die \nPlay Again? ", //metalicHandHeldItemMessageBadI
              0, //metalicHandHeldItemChanceI
              "You somehow launch yourself at the knight with the slingshot \nYou get implaed on his sword \nYou die \nPlay Again?", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "Dashing like a madman, you plunge the fang into the armour and make a slight dent \nYou die \nPlay Again?", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "You burn the knight on the inside of his armour \nHe runs off in pain \nIt is safe to move", //torchMessageI
              "The knight extinguishes the torch", //torchMessageBadI
              50, //torchChanceI
              "Nothing gets past him", //examineTextI
              "You find a lone stick", //obtainTextI
              "At what? \nThe knight is the only thing blocking your path", //lookTextI
              "None shall pass... \nHe's not much of a talker", //sayTextI
              "Unlock what?", //unlockTextI
              "", //expectedUnlockItemI
              "",//traverseTextI
              0, //traverseChanceI
              "The knight stabs you \nYou die \nPlay Again?", //failedTraverseTextI
              "The black knight blocks your path \nNone shall pass", //openerI
              false, //safeI
              Properties.Resources.BlackKnight
              );

            //Scene 6, Deep Forest
            scenesReg[5].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "You place the bucket on the cart \nThis feels right", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "You place the bucket on the cart \nYou feel brought to tears", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "You give up your stick", //stickMessageI
              "Your stick breaks", //stickMessageBadI
              50, //stickChanceI
              "You lay down your arms", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "You hand down your axe", //axeMessageI
              "You smash the cart", //axeMessageBadI
              50, //axeChanceI
              "You curse the cart", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "The doll floats to the cart \nYou feel relieved", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "It rejects the cart",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "You hear distant horse steps... \nClopping? \nWho knows, but your coconut is carried off... \nBy two swallows?", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That's stuck to your head", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "NOOOOOOOOOOOOOOOO! \n Play Again?", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "You lay the head on the cart \nThe owner would be terrified", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "The whispers tell you not to",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "The plane flies off with the cart in tow", //planeMessageI
              "The plane crushes the cart \nHow did you carry that!?", //planeMessageBadI
              50, //planeChanceI
              "The cart glitches out of existence and so does the glove \nWhy?", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "You leave it on the cart \nYou feel empty inside without your companion cube", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "You leave your pocket watch for the owner \nYou feel happy", //pocketWatchMessageI
              "You drop the pocket watch and it shatters", //pocketWatchMessageBadI
              50, //pocketWatchChanceI
              "You replace an old plank with your plank \n You feel good", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "You wipe down the cart with the cloth \nIt falls apart", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "You place the chain on the cart", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "You place the hook on the cart", //hookMessageI
              "You hook the cart", //hookMessageBadI
              50, //hookChanceI
              "You place the metallic handheld item on the cart", //metalicHandHeldItemMessageI
              "The gun... I MEAN metallic handheld item fires \nIt ricochets and hits you \nYou are dead \nPlay Again", //metalicHandHeldItemMessageBadI
              80, //metalicHandHeldItemChanceI
              "Your prankster days are behind you... \nNOT! You keep your it on your person", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That's... Not Right", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "You place the torch on the cart \nRisky", //torchMessageI
              "You light the cart on fire with the torch \nThe torch burns up", //torchMessageBadI
              50, //torchChanceI
              "It looks to be a cart \nPerhaps it once belonged to a merchant", //examineTextI
              "You cannot take the cart", //obtainTextI
              "You see a clear path around the cart \nMaybe you don't need to be giving", //lookTextI
              "You do realize there's no one around?", //sayTextI
              "You unlock a secret compartment in the cart \nYou find a strange box \nPandoras Box obtained", //unlockTextI
              "", //expectedUnlockItemI
              "You walk past the cart \nPerhaps you deserve what happened to you",//traverseTextI
              100, //traverseChanceI
              "", //failedTraverseTextI
              "You run across an abandoned cart \nYou feel like leaving something behind", //openerI
              false, //safeI
              Properties.Resources.Cart
              //Properties.Resources.DeepForest
              );

            //Scene 7, Wizard
            scenesReg[6].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That does nothing", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "You drain the river \n it is now safe to cross", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "You patch the bridge with your stick \nIt is now safe to cross", //stickMessageI
              "Your stick breaks", //stickMessageBadI
              10, //stickChanceI
              "A sword won't help you here", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "You cut down wood to fix the bridge \nThe axe breaks but it is now safe to cross", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "Your vision goes black \nThe bridge is fixed and it is now safe to cross", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "Nothing Happens", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "You fly over the bridge but lose control \nYou crash into a nearby tree \nYou are safe but the broom is broken",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "You hear distant horse steps... \nClopping? \nWho knows, but you and your coconut are carried off... \nBy two swallows? \nYou are safely across the bridge", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That's stuck to your head", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "NOOOOOOOOOOOOOOOO! \n Play Again?", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "What? \nWhat exactly is your plan?", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "A grey creature snags the ring \nYou grab hold but the creature escapes \nYou are safely across the bridge",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "You fly across the bridge in your plane \nYou land safely but the plane is out of gas \nYou are safely across the bridge", //planeMessageI
              "You try to fly across the bridge, but realize you cannot fly a plane \nYou crash and burn \nPlay again?", //planeMessageBadI
              50, //planeChanceI
              "The bridges glitches but is completely fixed \nThe glove disappears but you are safe across the bridge", //powerGloveMessageI
              "The glove disappears and you look weird for trying", //powerGloveMessageBadI
              90, //powerGloveChanceI
              "You try to fix the bridge with your companion cube \nIt sinks into the river", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "You check the time \nSuddenly, the hands move backwards and the bridge is fixed \nIt is safe to cross, but the pocket watch smashes", //pocketWatchMessageI
              "You drop the pocket watch and it shatters", //pocketWatchMessageBadI
              90, //pocketWatchChanceI
              "You fix the bridge with your plank \n It is safe to cross", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "You make a make-shift paraglider and sail across \nYou are safe on the other side", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "You use the chain to hold the bridge together \nYou are safe, but the chain breaks", //chainMessageI
              "The chain snaps under the pressure and you tumble into the river \nPlay Again? ", //chainMessageBadI
              70, //chainChanceI
              "You hook across the bridge gap \nYou are safely across", //hookMessageI
              "Your hook ricochets and breaks", //hookMessageBadI
              75, //hookChanceI
              "You shoot the bridge \nWhy?", //metalicHandHeldItemMessageI
              "You shoot the bridge \nIt ricochets and hits you \nYou die \nPlay Again? ", //metalicHandHeldItemMessageBadI
              80, //metalicHandHeldItemChanceI
              "You somehow launch yourself across with the slingshot \nIt defies all logic, but you're safe", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That's... Not going to work", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "You know what they say about burning bridges \nInstead you use it to fix the bridge \nYou are safely across", //torchMessageI
              "You light the bridge on fire with the torch \nThe torch burns up", //torchMessageBadI
              50, //torchChanceI
              "It's beat down, but maybe you can still cross \nDefinitely a last choice option though, it looks incredibly dangerous", //examineTextI
              "There's absolutely nothing salvagable", //obtainTextI
              "The river extends far past your vision", //lookTextI
              "You do realize there's no one around?", //sayTextI
              "Unlock what?", //unlockTextI
              "", //expectedUnlockItemI
              "You attempt to cross the broken bridge and succeed \nYou are safe! What Luck!",//traverseTextI
              5, //traverseChanceI
              "You fall in the river and drown \nPlay Again?", //failedTraverseTextI
              "A broken bridge blocks your path over a long river", //openerI
              false, //safeI
              Properties.Resources.Bridge
              //Properties.Resources.Wizard
              );

            //Scene 8, Village
            scenesReg[7].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That does nothing \nYou die \nPlay Again", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "The wolf yields \nYou are safe to move", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "You throw the stick and the wolf moves after it \nIt is safe to run", //stickMessageI
              "Your stick breaks \nYou die \nPlay Again", //stickMessageBadI
              10, //stickChanceI
              "You swing at the wolf \nThe blood splatter indicates it is safe to move", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "You swing at the wolf \nThe blood splatter indicates it is safe to move", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "Your vision goes black \nThe wolf and the totem are gone \nIt's safe to move, I think?", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "The wolf runs away in fright \nThe doll looks at you in a frightening manner \nIt is safe to move", //voodooDollMessageI
              "The wolf runs away in fright \nThe doll looks at you in a frightening manner \nYou die \nPlay Again?", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "The broomstick flies away from you",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "What a lovely Bunch of coconuts! \nAnywho, you're ripped to shreds \nYou die \nPlay Again?", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That's stuck to your head", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "NOOOOOOOOOOOOOOOO! \n Play Again?", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "The wolf takes the decapitated head \nYou can move safely", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "The wolf can no longer see you \nIt's safe to move",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "You fly straight into the wolf \nThe wolf is dead but you die as well \nPlay Again?", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "The wolf takes the glove", //powerGloveMessageI
              "The glove disappears and you look weird for trying", //powerGloveMessageBadI
              90, //powerGloveChanceI
              "You offer up the companion cube and it takes it \nYou coward \nIt is safe to move", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "You check the time \nSuddenly, the hands move backwards and the wolf is gone \nIt is safe to move, but the pocket watch smashes", //pocketWatchMessageI
              "You drop the pocket watch and it shatters", //pocketWatchMessageBadI
              90, //pocketWatchChanceI
              "It only stuns the wolf, but just long enough \nIt is safe to move", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "You try to muzle the wolf, but it fails \nYou die \nPlay Again?", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "You try to muzle the wolf, but it fails \nYou die \nPlay Again?", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "You hook pulls on the vital organs of the wolf \nThis somehow works \nIt is safe to move", //hookMessageI
              "Your hook pulls in the wolf \nYou die \nPlay Again?", //hookMessageBadI
              25, //hookChanceI
              "You shoot the Wolf \nIt's safe to move, there's no more threat", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "You distract the wolf with the slingshot \nNow is the safe time to run", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "You stab the wolf \nIt cries a loud yipe before falling dead \nIt is safe to move", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "You set fire to the wolf and it scampers off \nYou are safe to move", //torchMessageI
              "The light frightens the wolf and sends it into a frenzy \nYou die \nPlay Again?", //torchMessageBadI
              50, //torchChanceI
              "You cannot get around it \nThis is a primal hunter", //examineTextI
              "You get a stick off the ground", //obtainTextI
              "Blood drips from the mouth of the beast", //lookTextI
              "The Wolf doesn't speak elvish", //sayTextI
              "Unlock what?", //unlockTextI
              "", //expectedUnlockItemI
              "",//traverseTextI
              0, //traverseChanceI
              "The wolf tears you to pieces \nYou die \nPlay Again?", //failedTraverseTextI
              "A feral wolf blocks your path \nIt doesn't seem to be letting you by", //openerI
              false, //safeI
              Properties.Resources.Wolf
              //Properties.Resources.Village
              );

            //Scene 9, Mines
            scenesReg[8].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That does nothing \nYou die \nPlay Again", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "The dragon looks onwards with greed \nYou are safe to move, but the holy bucket stays", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That's not sufficient \nYou die \nPlay Again", //stickMessageI
              "Your stick breaks \nYou die \nPlay Again", //stickMessageBadI
              10, //stickChanceI
              "You swing at the dragon \nThe blood splatter indicates it is safe to move", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "You swing at the dragon \nThe blood splatter indicates it is safe to move", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "Your vision goes black \nThe dragon and the totem are gone \nIt's safe, I think", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "The dragon flies away in fright \nThe doll looks at you in a frightening manner \nIt is safe to move", //voodooDollMessageI
              "The dragon flies away in fright \nThe doll looks at you in a frightening manner \nYou die \nPlay Again?", //voodooDollMessageBadI
              50, //voodooDollChanceI
              "The broomstick flies away from you",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "What a lovely Bunch of coconuts! \nAnywho, you're ripped to shreds \nYou die \nPlay Again?", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That's stuck to your head", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "NOOOOOOOOOOOOOOOO! \n Play Again?", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "The dragon takes the decapitated head \nYou can move safely", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "The dragon can no longer see you \nIt's enraged \nIt's safe to move",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "You fly straight into the dragon \nThe dragon is dead but you die as well \nPlay Again?", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "The dragon flambes the glove", //powerGloveMessageI
              "The glove disappears and you look weird for trying", //powerGloveMessageBadI
              90, //powerGloveChanceI
              "You offer up the companion cube and it takes it \nYou coward \nIt is safe to move", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "You check the time \nSuddenly, the hands move backwards and the dragon is gone \nIt is safe to move, but the pocket watch smashes", //pocketWatchMessageI
              "You drop the pocket watch and it shatters", //pocketWatchMessageBadI
              90, //pocketWatchChanceI
              "The dragon burns the plank \nYou die \nPlay Again?", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "The dragon burns the cloth \nYou die \nPlay Again?", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "You bind the dragon \nIt is safe to run", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "You pull the dragon to the ground \nIt is safe to run", //hookMessageI
              "It only angers the dragon \nYou die \nPlay Again?", //hookMessageBadI
              25, //hookChanceI
              "The shot goes through the eyes \nLucky \nIt's safe to leave", //metalicHandHeldItemMessageI
              "It doesn't pierce the scales \nYou die \nPlay Again?", //metalicHandHeldItemMessageBadI
              50, //metalicHandHeldItemChanceI
              "", //slingshotMessageI
              "The shot bounces off the dragon \nOops \nYou die \nPlay Again?", //slingshotMessageBadI
              100, //slingshotChanceI
              "", //poisonFangMessageI
              "It doesn't pierce the scales \nYou die \nPlay Again?", //poisonFangMessageBadI
              0, //poisonFangChanceI
              "", //torchMessageI
              "The fire angers the dragon \nYou die \nPlay Again?", //torchMessageBadI
              0, //torchChanceI
              "You cannot get around it \nThis is a HUGE DRAGON", //examineTextI
              "You get a poison fang off the ground", //obtainTextI
              "Flames plume from the mouth of the beast", //lookTextI
              "There's no reasoning with a dragon", //sayTextI
              "Unlock what?", //unlockTextI
              "", //expectedUnlockItemI
              "",//traverseTextI
              0, //traverseChanceI
              "The dragon tears you to pieces \nYou die \nPlay Again?", //failedTraverseTextI
              "A dragon blocks your path \nIt doesn't seem to be letting you by", //openerI
              false, //safeI
              Properties.Resources.Dragon
              //Properties.Resources.Mines
              );

            //Scene 10, Mountains
            scenesReg[9].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That does nothing", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "The knight does not yield \nHe is smited \nIt is safe to pass", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "You better have another arm, as yours finds its way onto the floor \nYou die \nPlay Again", //stickMessageI
              "Your stick breaks", //stickMessageBadI
              10, //stickChanceI
              "You best the knight \nIt is safe to move", //swordMessageI
              "The knight bests you \nYou die \nPlay Again",//swordMessageBadI
              50,//swordChanceI
              "It's not fast enough \nYou die \nPlay Again", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "The knight seizes the totem \nYou die \nPlay Again", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "The knight falls apart \nIt is safe to move", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "You fly past the knight \nThe broom dissappears but it is safe to move",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "You toss the coconut \nThe knight is unconscious \nIt's safe to move", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That's stuck to your head", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "NOOOOOOOOOOOOOOOO! \n Play Again?", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "What? \nWhat exactly is your plan?", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "You slip past the knight and lose the one ring \nHowever, it is safe to move",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "A plane won't help you here", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "The knight laughs \nIt's safe to slip by ", //powerGloveMessageI
              "The glove disappears and you look weird for trying", //powerGloveMessageBadI
              40, //powerGloveChanceI
              "Companionship isn't the solution", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "You check the time \nSuddenly, the hands move backwards and the knight collapses, all that remains is armour \nIt is safe to cross, but the pocket watch smashes", //pocketWatchMessageI
              "You drop the pocket watch and it shatters", //pocketWatchMessageBadI
              90, //pocketWatchChanceI
              "You knock the knight unconscious \nYour might has caused the plank to break \nIt is safe to move", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "You engage the knight in a slapping contest and win! \nGood Show! \nIt is safe to leave", //clothMessageI
              "You engage the knight in a slapping contest and lose \nYou die \nPlay Again?", //clothMessageBadI
              50, //clothChanceI
              "You toss the chain \nYou die \nPlay Again?", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "You hook in the knight for a deep kiss \nEnamoured, you find it safe to slip off into the daylight", //hookMessageI
              "Your hook ricochets and breaks", //hookMessageBadI
              75, //hookChanceI
              "", //metalicHandHeldItemMessageI
              "You shoot the knight \nIt ricochets and hits you \nYou die \nPlay Again? ", //metalicHandHeldItemMessageBadI
              0, //metalicHandHeldItemChanceI
              "You somehow launch yourself at the knight with the slingshot \nYou get implaed on his sword \nYou die \nPlay Again?", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "Dashing like a madman, you plunge the fang into the armour and make a slight dent \nYou die \nPlay Again?", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "You burn the knight on the inside of his armour \nHe runs off in pain \nIt is safe to move", //torchMessageI
              "The knight extinguishes the torch", //torchMessageBadI
              50, //torchChanceI
              "Nothing gets past him", //examineTextI
              "You find a lone stick", //obtainTextI
              "At what? \nThe knight is the only thing blocking your path", //lookTextI
              "None shall pass... \nHe's not much of a talker", //sayTextI
              "Unlock what?", //unlockTextI
              "", //expectedUnlockItemI
              "",//traverseTextI
              0, //traverseChanceI
              "The knight stabs you \nYou die \nPlay Again?", //failedTraverseTextI
              "The black knight blocks your path \nNone shall pass", //openerI
              false, //safeI
              Properties.Resources.BlackKnight
              //Properties.Resources.Mountains
              );

            //Ending Scene
            scenesEnding.sceneCreate(
              "", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              0, //evilRockChanceI
              "You place the bucket on your head \n The last sound heard is the crunching of metal \nAs the blade seeps into your skull \nYou die \nPlay Again?", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "", //holyBucketMessageI
              "You place the bucket on your head \nThe blade bounces and settles on your head \nNo matter what they try, they can't seperate the bucket from your head \nNeither can they seperate your head from your shoulders \nYou can't see, but you can't lose \nPlay Again?", //holyBucketMessageBadI
              0, //holyBucketChanceI
              "You wave the stick like a wand \nI guess you wanted to look dumb for your execution \nHow thoughtful \nYou die \nPlay Again?", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "You cut the string yourself \nHow thoughtful \nYou die \nPlay Again?", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "You cut the string yourself \nHow thoughtful \nYou die \nPlay Again?", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "Your head gets chopped off but you suddenly grow another \nYou are burned at the stake as a witch \nYou die \nPlay Again?", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "Your stress causes you to pop the head off the doll \nYou hear screams as the king's head pops off \nUnder a new regime, you are cleared of your past wrongdoing \nAlthough you're still unclear about what that is \nPlay Again?", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "Magic or not, the broom is useless \nIt's confiscated and your head is cut clean off \nYou die \nPlay Again?",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "Debate breaks out about how the coconut even got to this land \nThey seem to have forgot your lock \nYou slip out and live in secret until a wooden rabbit enters the kingdom \nSoldiers jump out and ambush the whole kingdom \nYou die \nPlay Again?", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "Well, you're dead... but don't let this get you down \nSome things in life are bad, \nThey can really make you mad, \nOther things just wanna make you swear and curse, \nWhen you're chewing on life's gristle, \nDon't grumble, give a whistle, \nAnd this'll help things turn out for the best, \nAnd..... \nPlay Again?", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "NOOOOOOOOOOOOOOOO! \n Play Again?", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "In an attempt of sheer magic, you replace your head with the decapitated head \nAs per the law, the kingdom is only permitted to cut off one head \nYou are let go \nPlay Again?", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "You turn invisible just in time for the fireworks \nIsn't it your birthday? \nWho Knows? \nWho Cares? \nYou live a new life in a verdant hollow \nPlay Again?",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "The plane flies straight through one of the two tallest buildings in the kingdom \nThousands of screams are heard as bodies fall jump from windows or burn in fire \nTruly  global atrocity and caused by you \nYou deserve the penalty, and they gave it to you \nYou die \nPlay Again?", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "Everyone awaits in anticipation \n Wait... \nWhat... \nWhat happened to my story? \nIt's ALL gone! \nWhatever \nPlay Again I guess?", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "You stare into its eyes as the blade falls \nYou die \nPlay Again?", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "You wave the watch in front of the executioner \nThey enter a blind axe murder rage \nYou find it surprisingly easy to slip out of attention \nPlay Again?", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "You improve the guillotine \nA much cleaner cut \nYou die \nPlay Again?", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "At least you cleaned the blade \nWouldn't want to get infected \nYou die \nPlay Again?", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "You hold the guillotine from falling, tying it up with the chains \nStarvation is slow and painful \nPlay Again?", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "You can teach a man to fish, but not to stop a guillotine \nYou die? \nPlay Again?", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "Your relentless slaughter with the new item coined gun is remembered for years \nThe gallows suit you well \nPlay Again?", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "No Bart Simpsoning here \nAnd this is no cartoon \nPlay Again?", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That's... Not going to work \nYou die \nPlay Again?", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "Oh good, you lit yourself on fire \nNow they won't have to go to the trouble themselves \nPlay Again?", //torchMessageI
              "You light the bridge on fire with the torch \nThe torch burns up", //torchMessageBadI
              100, //torchChanceI
              "You wasted your opportunity \nThere goes your head \nPlay Again?", //examineTextI
              "You wasted your opportunity \nThere goes your head \nPlay Again?", //obtainTextI
              "You wasted your opportunity \nThere goes your head \nPlay Again?", //lookTextI
              "You wasted your opportunity \nThere goes your head \nPlay Again??", //sayTextI
              "You wasted your opportunity \nThere goes your head \nPlay Again?", //unlockTextI
              "", //expectedUnlockItemI
              "You wasted your opportunity \nThere goes your head \nPlay Again?",//traverseTextI
              100, //traverseChanceI
              "You wasted your opportunity \nThere goes your head \nPlay Again?", //failedTraverseTextI
              "You wasted your opportunity \nThere goes your head \nPlay Again?", //openerI
              false, //safeI
              Properties.Resources.Guillotine
              );

            //Item Scenes
            scenesItem[0].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the evil rock", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "You come across a rock covered in a red liquid \nYou feel uneased \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.EvilRock
              );

            scenesItem[1].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the bucket", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "You come across a well with an intact bucket \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Bucket
              );

            scenesItem[2].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the holy bucket", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "The light shines upon a bucket filled with what can only be described as liquid light \nYou feel... Inspired by the holy bucket \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.HolyBucket
              );

            scenesItem[3].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the stick", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A lone stick lies on the ground \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Stick
              );

            scenesItem[4].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the sword", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "You come across a sword lodged in a stone \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Sword
              );

            scenesItem[5].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the axe", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "An axe lies at the side of a tree \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Axe
              );

            scenesItem[6].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the totem", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A wooden carving on a stained altar \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Totem
              );

            scenesItem[7].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the voodoo doll", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A poorly made doll lies against a wall \nClearly it's been tossed \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.VoodooDoll
              );

            scenesItem[8].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the broomstick", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A broom sits in a bike rack \nCurious \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Broom
              );

            scenesItem[9].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the coconut", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "You come across an exotic coconut \nHow on this planet did it get here? \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Coconut
              );

            scenesItem[10].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the crown of thornes", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "You come across a bramble head dressing \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.CrownOfThornes
              );

            scenesItem[11].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain pandoras box", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "You come across a box that seems to echo darkness and chaos \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.PandorasBox
              );

            scenesItem[12].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the decapitated head", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A severed head lies on the ground \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Head
              );

            scenesItem[13].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the one ring", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A ring with unique engravings lies at the side of a stream \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.OneRing
              );

            scenesItem[14].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the plane \nHow?!", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A deserted plane lies in a clearing \nProbably no point in trying to take it \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Plane
              );

            scenesItem[15].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the power glove", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A glove with buttons sits in a trash can \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.PowerGlove
              );

            scenesItem[16].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the companion cube", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A lightly burned cube with a heart lies outside a collapsed doorway \nYou feel happy \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.CompanionCube
              );

            scenesItem[17].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the pocket watch", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "You hear a ticking \nSearching the grass, you uncover an old watch \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.PocketWatch
              );

            scenesItem[18].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the plank", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A clearly removed plank lies on the ground \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Plank
              );

            scenesItem[19].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the cloth", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A cloth hangs from the trees \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Cloth
              );

            scenesItem[20].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the chain", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "You trip and fall over a ball and chain \nThe chain rips off but the ball is immoveable  \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Chain
              );

            scenesItem[21].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the hook", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A burned down fishing shack sits beside a small lake \nAfter scavenging, all you find is a small hook \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Hook
              );

            scenesItem[22].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the metallic handheld object", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A small case contains a shiny item \nIt feels good in your hand, but dangerous \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Gun
              );

            scenesItem[23].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the slingshot", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A pair of shorts hangs from a pole \nThey're clearly child size, but a slingshot sits in the pocket \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Slingshot
              );

            scenesItem[24].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the poison fang", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "The corpse of a skinned viper is played across a tree \nOnly the fang remains \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.PoisonFang
              );

            scenesItem[25].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in \nYou die \nPlay Again?", //evilRockMessageBadI
              1, //evilRockChanceI
              "That has no effect", //bucketMessageI
              "", //bucketMessageBadI
              100, //bucketChanceI
              "That has no effect", //holyBucketMessageI
              "", //holyBucketMessageBadI
              100, //holyBucketChanceI
              "That has no effect", //stickMessageI
              "", //stickMessageBadI
              100, //stickChanceI
              "That has no effect", //swordMessageI
              "",//swordMessageBadI
              100,//swordChanceI
              "That has no effect", //axeMessageI
              "", //axeMessageBadI
              100, //axeChanceI
              "That has no effect", //totemMessageI
              "", //totemMessageBadI
              100, //totemChanceI
              "That has no effect", //voodooDollMessageI
              "", //voodooDollMessageBadI
              100, //voodooDollChanceI
              "That has no effect",//broomstickMessageI
              "", //broomstickMessageBadI
              100, //broomstickChanceI
              "That has no effect", //coconutMessageI
              "", //coconutMessageBadI
              100, //coconutChanceI
              "That has no effect", //crownOfThornesMessageI
              "", //crownOfThornesMessageBadI
              100, //crownOfThornesChanceI
              "That has no effect", //pandorasBoxMessageI
              "",//pandorasBoxMessageBadI
              100, //pandorasBoxChanceI
              "That has no effect", //decapitatedHeadMessageI
              "", //decapitatedHeadMessageBadI
              100, //decapitatedHeadChanceI
              "That has no effect",//theOneRingMessageI
              "", //theOneRingMessageBadI
              100, //theOneRingChanceI
              "That has no effect", //planeMessageI
              "", //planeMessageBadI
              100, //planeChanceI
              "That has no effect", //powerGloveMessageI
              "", //powerGloveMessageBadI
              100, //powerGloveChanceI
              "That has no effect", //companionCubeMessageI
              "", //companionCubeMessageBadI
              100, //companionCubeChanceI
              "That has no effect", //pocketWatchMessageI
              "", //pocketWatchMessageBadI
              100, //pocketWatchChanceI
              "That has no effect", //plankMessageI
              "", //plankMessageBadI
              100, //plankChanceI
              "That has no effect", //clothMessageI
              "", //clothMessageBadI
              100, //clothChanceI
              "That has no effect", //chainMessageI
              "", //chainMessageBadI
              100, //chainChanceI
              "That has no effect", //hookMessageI
              "", //hookMessageBadI
              100, //hookChanceI
              "That has no effect", //metalicHandHeldItemMessageI
              "", //metalicHandHeldItemMessageBadI
              100, //metalicHandHeldItemChanceI
              "That has no effect", //slingshotMessageI
              "", //slingshotMessageBadI
              100, //slingshotChanceI
              "That has no effect", //poisonFangMessageI
              "", //poisonFangMessageBadI
              100, //poisonFangChanceI
              "That has no effect", //torchMessageI
              "", //torchMessageBadI
              100, //torchChanceI
              "That has no effect", //examineTextI
              "You obtain the torch", //obtainTextI
              "That has no effect", //lookTextI
              "That has no effect", //sayTextI
              "That has no effect", //unlockTextI
              "That has no effect", //expectedUnlockItemI
              "That has no effect",//traverseTextI
              100, //traverseChanceI
              "That has no effect", //failedTraverseTextI
              "A wall has a spot for two torches \nA sign reads one if by land, two if by sea \nOnly one remains \nPick it up or go?", //openerI
              true, //safeI
              Properties.Resources.Torch
              );

            textOutput.BackColor = Color.FromArgb(200, textOutput.BackColor);

            uInput.Parent = uInputBack;
            uInput.Location = new Point(0, 0);
            uInputBack.BackColor = Color.FromArgb(200, uInputBack.BackColor);
        }

        private void uInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (playAgain == true)
                {
                    if (uInput.Text.ToLower().Contains("yes"))
                    {
                        Application.Restart();
                        Environment.Exit(0);
                    }

                    else if (uInput.Text.ToLower().Contains("no"))
                    {
                        Environment.Exit(0);
                    }

                    else
                    {
                        textOutput.Text = "Play Again? \nYes or No?";
                    }
                }
                else
                {
                    if (currentPage == "Start")
                    {
                        int firstPage = rnd.Next(0, 9);
                        pagesScrolled++;
                        textOutput.Text = scenesReg[firstPage].opener;
                        medisiaImageView.BackgroundImage = scenesReg[firstPage].display;
                        scenesReg[firstPage].used = true;
                        currentPage = $"scenesReg[{firstPage}]";
                    }

                    else if (currentPage.ToLower().Contains("reg"))
                    {
                        String inputText = uInput.Text;
                        uInput.Text = "";
                        int chance = rnd.Next(0, 101);

                        if (currentPage.ToLower().Contains("reg"))
                        {
                            //Set to 10 as it is one above the limit, will break if erroring out
                            int sceneReading = 10;

                            //Find the Page
                            for (int i = 0; i <= 9; i++)
                            {
                                if (currentPage.ToLower().Contains(Convert.ToString(i)))
                                {
                                    sceneReading = i;
                                }
                            }

                            //Check for use
                            if (inputText.ToLower().Contains("use"))
                            {
                                String response = scenesReg[sceneReading].itemCheck(inputText, chance, items[0].have, items[1].have, items[2].have, items[3].have, items[4].have, items[5].have, items[6].have, items[7].have, items[8].have, items[9].have, items[10].have, items[11].have, items[12].have, items[13].have, items[14].have, items[15].have, items[16].have, items[17].have, items[18].have, items[19].have, items[20].have, items[21].have, items[22].have, items[23].have, items[24].have, items[25].have);

                                adventureTheme.Stop();
                                themeOperator.Start();

                                for (int i = 0; i <= 25; i++)
                                {
                                    if (response.ToLower().Contains(items[i].itemName))
                                    {
                                        if (items[i].have == true)
                                        {
                                            items[i].have = false;
                                            scenesReg[sceneReading].eventDone = true;
                                        }
                                        else
                                        {
                                            items[i].have = true;
                                        }
                                    }
                                }

                                if (response.ToLower().Contains("safe"))
                                {
                                    scenesReg[sceneReading].safe = true;
                                }

                                textOutput.Text += $"\n{response}";

                                if (response.ToLower().Contains("die") || response.ToLower().Contains("again"))
                                {
                                    playAgain = true;
                                    adventureTheme.Stop();
                                    System.Media.SoundPlayer trombone = new SoundPlayer(Properties.Resources.TromboneSound);
                                    trombone.Play();
                                }
                            }

                            //Check examine
                            else if (inputText.ToLower().Contains("examine") || inputText.ToLower().Contains("grab") || inputText.ToLower().Contains("take") || inputText.ToLower().Contains("pick up") || inputText.ToLower().Contains("look") || inputText.ToLower().Contains("say") || inputText.ToLower().Contains("unlock") || inputText.ToLower().Contains("traverse"))
                            {
                                String unlockItem = "";
                                for (int i = 0; i <= 25; i++)
                                {
                                    if (inputText.ToLower().Contains(items[i].itemName))
                                    {
                                        unlockItem = items[i].itemName;
                                    }
                                }

                                String response = scenesReg[sceneReading].actionCheck(inputText, unlockItem, chance);

                                for (int i = 0; i <= 25; i++)
                                {
                                    if (response.ToLower().Contains(items[i].itemName))
                                    {
                                        items[i].have = true;
                                    }
                                }

                                textOutput.Text += $"\n{response}";

                                if (response.ToLower().Contains("die") || response.ToLower().Contains("again"))
                                {
                                    playAgain = true;
                                    adventureTheme.Stop();
                                    System.Media.SoundPlayer trombone = new SoundPlayer(Properties.Resources.TromboneSound);
                                    trombone.Play();
                                }
                            }

                            //Move Check
                            else if (inputText.ToLower().Contains("go") || inputText.ToLower().Contains("move"))
                            {
                                String moveResult = scenesReg[sceneReading].moveCheck(inputText, chance, pagesScrolled, specialEventChance);

                                adventureTheme.Stop();
                                themeOperator.Start();
                                System.Media.SoundPlayer footsteps = new SoundPlayer(Properties.Resources.FootstepsSound);

                                bool nextPageReceived = false;

                                if (moveResult == "Kingdom Gate")
                                {
                                    textOutput.Text = "You reach the kingdom gate and are knocked out by a guard \nYou wake up in a guillotine";
                                    currentPage = "scenesEnding";
                                }

                                else if (moveResult == "Load Extra Page")
                                {
                                    while (nextPageReceived == false)
                                    {
                                        int randomItemPage = rnd.Next(0, 26);

                                        if (scenesItem[randomItemPage].used == false)
                                        {
                                            currentPage = $"scenesItem[{randomItemPage}]";
                                            nextPageReceived = true;
                                        }
                                    }

                                    for (int i = 0; i <= 25; i++)
                                    {
                                        if (currentPage.ToLower().Contains(Convert.ToString(i)))
                                        {
                                            sceneReading = i;
                                        }
                                    }

                                    textOutput.Text = scenesItem[sceneReading].opener;
                                    medisiaImageView.BackgroundImage = scenesItem[sceneReading].display;

                                    pagesScrolled++;
                                    scenesItem[sceneReading].used = true;
                                }

                                else if (moveResult == "Load Reg Page")
                                {
                                    while (nextPageReceived == false)
                                    {
                                        int randomRegPage = rnd.Next(0, 9);

                                        if (scenesReg[randomRegPage].used == false)
                                        {
                                            currentPage = $"scenesReg[{randomRegPage}]";
                                            nextPageReceived = true;
                                        }
                                    }

                                    for (int i = 0; i <= 9; i++)
                                    {
                                        if (currentPage.ToLower().Contains(Convert.ToString(i)))
                                        {
                                            sceneReading = i;
                                        }
                                    }

                                    textOutput.Text = scenesReg[sceneReading].opener;
                                    medisiaImageView.BackgroundImage = scenesReg[sceneReading].display;

                                    pagesScrolled++;
                                    scenesReg[sceneReading].used = true;
                                }
                                footsteps.Play();
                            }

                            else if (inputText.ToLower().Contains("dance") || inputText.ToLower().Contains("suicide") || inputText.ToLower().Contains("up up down down left right left right b a start"))
                            {
                                String response = scenesReg[sceneReading].extraCheck(inputText, chance, currentPage);

                                for (int i = 0; i <= 25; i++)
                                {
                                    if (response.ToLower().Contains(items[i].itemName))
                                    {
                                        items[i].have = true;
                                    }
                                }

                                textOutput.Text += response;
                            }
                        }
                    }

                    else if (currentPage.ToLower().Contains("item"))
                    {
                        String inputText = uInput.Text;
                        uInput.Text = "";
                        int chance = rnd.Next(0, 101);

                        if (currentPage.ToLower().Contains("item"))
                        {
                            //Set to 10 as it is one above the limit, will break if erroring out
                            int sceneReading = 26;

                            //Find the Page
                            for (int i = 0; i <= 25; i++)
                            {
                                if (currentPage.ToLower().Contains(Convert.ToString(i)))
                                {
                                    sceneReading = i;
                                }
                            }

                            //Check for use
                            if (inputText.ToLower().Contains("use"))
                            {
                                adventureTheme.Stop();
                                themeOperator.Start();

                                String response = scenesItem[sceneReading].itemCheck(inputText, chance, items[0].have, items[1].have, items[2].have, items[3].have, items[4].have, items[5].have, items[6].have, items[7].have, items[8].have, items[9].have, items[10].have, items[11].have, items[12].have, items[13].have, items[14].have, items[15].have, items[16].have, items[17].have, items[18].have, items[19].have, items[20].have, items[21].have, items[22].have, items[23].have, items[24].have, items[25].have);

                                for (int i = 0; i <= 25; i++)
                                {
                                    if (response.ToLower().Contains(items[i].itemName))
                                    {
                                        if (items[i].have == true)
                                        {
                                            items[i].have = false;
                                            scenesItem[sceneReading].eventDone = true;
                                        }
                                        else
                                        {
                                            items[i].have = true;
                                        }
                                    }
                                }

                                if (response.ToLower().Contains("safe"))
                                {
                                    scenesItem[sceneReading].safe = true;
                                }

                                textOutput.Text += $"\n{response}";

                                if (response.ToLower().Contains("die") || response.ToLower().Contains("again"))
                                {
                                    playAgain = true;
                                    adventureTheme.Stop();
                                    System.Media.SoundPlayer trombone = new SoundPlayer(Properties.Resources.TromboneSound);
                                    trombone.Play();
                                }
                            }

                            //Check examine
                            else if (inputText.ToLower().Contains("examine") || inputText.ToLower().Contains("grab") || inputText.ToLower().Contains("take") || inputText.ToLower().Contains("pick up") || inputText.ToLower().Contains("look") || inputText.ToLower().Contains("say") || inputText.ToLower().Contains("unlock") || inputText.ToLower().Contains("traverse"))
                            {
                                String unlockItem = "";
                                for (int i = 0; i <= 25; i++)
                                {
                                    if (inputText.ToLower().Contains(items[i].itemName))
                                    {
                                        unlockItem = items[i].itemName;
                                    }
                                }

                                String response = scenesItem[sceneReading].actionCheck(inputText, unlockItem, chance);

                                for (int i = 0; i <= 25; i++)
                                {
                                    if (response.ToLower().Contains(items[i].itemName))
                                    {
                                        items[i].have = true;
                                    }
                                }

                                textOutput.Text += $"\n{response}";

                                if (response.ToLower().Contains("die") || response.ToLower().Contains("again"))
                                {
                                    playAgain = true;
                                    adventureTheme.Stop();
                                    System.Media.SoundPlayer trombone = new SoundPlayer(Properties.Resources.TromboneSound);
                                    trombone.Play();
                                }
                            }

                            //Move Check
                            else if (inputText.ToLower().Contains("go") || inputText.ToLower().Contains("move"))
                            {
                                String moveResult = scenesItem[sceneReading].moveCheck(inputText, chance, pagesScrolled, specialEventChance);

                                adventureTheme.Stop();
                                themeOperator.Start();
                                System.Media.SoundPlayer footsteps = new SoundPlayer(Properties.Resources.FootstepsSound);

                                bool nextPageReceived = false;

                                if (moveResult == "Kingdom Gate")
                                {
                                    textOutput.Text = "You reach the kingdom gate and are knocked out by a guard \nYou wake up in a guillotine";
                                    currentPage = "scenesEnding";
                                }

                                else if (moveResult == "Load Extra Page")
                                {
                                    while (nextPageReceived == false)
                                    {
                                        int randomItemPage = rnd.Next(0, 26);

                                        if (scenesItem[randomItemPage].used == false)
                                        {
                                            currentPage = $"scenesItem[{randomItemPage}]";
                                            nextPageReceived = true;
                                        }
                                    }

                                    for (int i = 0; i <= 25; i++)
                                    {
                                        if (currentPage.ToLower().Contains(Convert.ToString(i)))
                                        {
                                            sceneReading = i;
                                        }
                                    }

                                    textOutput.Text = scenesItem[sceneReading].opener;
                                    medisiaImageView.BackgroundImage = scenesItem[sceneReading].display;

                                    pagesScrolled++;
                                    scenesItem[sceneReading].used = true;
                                }

                                else if (moveResult == "Load Reg Page")
                                {
                                    while (nextPageReceived == false)
                                    {
                                        int randomRegPage = rnd.Next(0, 9);

                                        if (scenesReg[randomRegPage].used == false)
                                        {
                                            currentPage = $"scenesReg[{randomRegPage}]";
                                            nextPageReceived = true;
                                        }
                                    }

                                    for (int i = 0; i <= 9; i++)
                                    {
                                        if (currentPage.ToLower().Contains(Convert.ToString(i)))
                                        {
                                            sceneReading = i;
                                        }
                                    }

                                    textOutput.Text = scenesReg[sceneReading].opener;
                                    medisiaImageView.BackgroundImage = scenesReg[sceneReading].display;

                                    pagesScrolled++;
                                    scenesReg[sceneReading].used = true;
                                }
                                footsteps.Play();
                            }

                            else if (inputText.ToLower().Contains("dance") || inputText.ToLower().Contains("suicide") || inputText.ToLower().Contains("up up down down left right left right b a start"))
                            {
                                String response = scenesItem[sceneReading].extraCheck(inputText, chance, currentPage);

                                for (int i = 0; i <= 25; i++)
                                {
                                    if (response.ToLower().Contains(items[i].itemName))
                                    {
                                        items[i].have = true;
                                    }
                                }

                                if (response.ToLower().Contains("again"))
                                {
                                    playAgain = true;
                                    adventureTheme.Stop();
                                    System.Media.SoundPlayer trombone = new SoundPlayer(Properties.Resources.TromboneSound);
                                    trombone.Play();
                                }

                                textOutput.Text += response;
                            }
                        }
                    }

                    else if (currentPage.ToLower().Contains("ending"))
                    {
                        String inputText = uInput.Text;
                        uInput.Text = "";
                        int chance = rnd.Next(0, 101);

                        if (inputText.ToLower().Contains("use"))
                        {
                            String response = scenesEnding.itemCheck(inputText, chance, items[0].have, items[1].have, items[2].have, items[3].have, items[4].have, items[5].have, items[6].have, items[7].have, items[8].have, items[9].have, items[10].have, items[11].have, items[12].have, items[13].have, items[14].have, items[15].have, items[16].have, items[17].have, items[18].have, items[19].have, items[20].have, items[21].have, items[22].have, items[23].have, items[24].have, items[25].have);

                            for (int i = 0; i <= 25; i++)
                            {
                                if (response.ToLower().Contains(items[i].itemName))
                                {
                                    if (items[i].have == true)
                                    {
                                        items[i].have = false;
                                        scenesEnding.eventDone = true;
                                    }
                                    else
                                    {
                                        items[i].have = true;
                                    }
                                }
                            }

                            if (response.ToLower().Contains("safe"))
                            {
                                scenesEnding.safe = true;
                            }

                            textOutput.Text += $"\n{response}";

                            if (response.ToLower().Contains("die") || response.ToLower().Contains("again"))
                            {
                                playAgain = true;
                                adventureTheme.Stop();
                                System.Media.SoundPlayer trombone = new SoundPlayer(Properties.Resources.TromboneSound);
                                trombone.Play();
                            }
                        }
                        else
                        {
                            textOutput.Text = "You wasted your opportunity \nThere goes your head \nPlay Again?";
                            playAgain = true;
                        }
                    }

                    //Error finder
                    else
                    {
                        textOutput.Text = "UhOh \nThat's an error alright";
                    }
                }
            }
        }

        private void themeOperator_Tick(object sender, EventArgs e)
        {
            adventureTheme.Play();
            themeOperator.Stop();
        }
    }
}
