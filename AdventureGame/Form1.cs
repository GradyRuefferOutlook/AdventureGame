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
    //Note:
    //Unfortunately the number of scenes has been cut from 20 to 10 because, well, it takes a long time to code a single scene
    //The intro scenes have been cut
    public partial class Form1 : Form
    {
        public struct Item
        {
            public String itemName;
            public bool have;
        }

        //Track current page
        String currentPage = "Start";

        //Track times played, because of reset, never used
        int timesPlayed = 0;

        //Track the pages traversed 
        int pagesScrolled = 0;

        Item[] items = new Item[26];

        Random rnd = new Random();

        public struct Scene
        {
            //Opening text
            String opener;

            //Check whether the scene was used
            bool used;

            //Check whether you have participated in the event and whether it is safe to move
            bool eventDone;
            bool safe;

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

            public String moveCheck(String inputText, int chance, int pagesScrolled, int specialEventChance)
            {
                if (eventDone == true)
                {
                    if (pagesScrolled >= 10 && chance >= (100 - (10 * (pagesScrolled - 9))))
                    {
                        return "Load Kingdom Page 1";
                    }
                    else if (chance >= 100 - specialEventChance)
                    {
                        return "Load Extra Page";
                    }
                    else
                    {
                        return "You have nowhere to go";
                    }
                }
                else
                {
                    return "You feel like your job here isn't done";
                }
            }

            public String extraCheck(String inputText, int chance, String currentPage)
            {
                if (inputText.ToLower().Contains("dance"))
                {
                    if (currentPage == "endingChoose")
                    {
                        return "You can't cut loose! Footloose! And are shot in your sunday shoes!\nPlay Again?";
                    }
                    else if (currentPage == "scenesItem[15]")
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
            bool safeI
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
            }

            public void eventConcluded()
            {
                eventDone = true;
            }

            public void sceneUsed()
            {
                used = true;
            }

            public void nowSafe()
            {
                safe = true;
            }
        }

        //Sets the regular scenes
        Scene[] scenesReg = new Scene[10];

        //Sets the item obtaining (or extra) scenes
        Scene[] scenesItem = new Scene[26];

        //Sets the ending scenes
        Scene[] scenesEnding = new Scene[26];

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


            Scene sceneholder = new Scene();
            //Scene 1, Cart Scene
            scenesReg[1].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in", //evilRockMessageBadI
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
              "You replace an old board with your plank \n You feel good", //plankMessageI
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
              true //safeI
              );

            //Scene 2, Broken Bridge
            scenesReg[2].sceneCreate(
              "You reconsider your actions", //evilRockMessageI
              "You bash your head in", //evilRockMessageBadI
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
              "You fix the bridge with your board \n It is safe to cross", //plankMessageI
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
              false //safeI
              );

            //Scene 3, Wolf

            //Scene 4, Dragon

            //Scene 5, Black Knight

            //Scene 6, Deep Forest

            //Scene 7, Wizard

            //Scene 8, Village

            //Scene 9, Mines

            //Scene 10, Mountains

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
