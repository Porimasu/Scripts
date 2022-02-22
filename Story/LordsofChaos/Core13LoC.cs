using System.Runtime.InteropServices;
using RBot;

public class Core13LoC
{
    public ScriptInterface Bot => ScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreStory Story = new CoreStory();

    public void Complete13LOC(bool withExtras = false)
    {
        if (Core.IsMember)
        {
            Prologue();
            Escherion();
            Vath();
            Kitsune();
            Wolfwing();
            Kimberly();
            Ledgermayne();
            Tibicenas();
            KhasaandaHorc();
            Iadoa();
            Lionfang();
            Xiang();
            Alteon();
        }
        Hero();
        if (withExtras)
        {
            KhasaandaTroll(true);
            Extra();
        }
    }

    public void Prologue()
    {

        if (Story.isCompletedBefore(6219))
            return;

        //Map: Battleudnera
        // if (!Story.QuestProgression(183))                                                  // Enter the gates
        // {
        //     Core.EnsureAccept(183);            // Enter the gates
        //     Core.KillMonster("battleundera", "Enter", "Spawn", "Skeletal Fire Mage", "Defeated Fire Mage", 4);
        //     Core.EnsureComplete(183);
        // }
        Story.KillQuest(183, "battleundera", "Skeletal Fire Mage");
        //Map: SwordhavenUndead
        Story.KillQuest(176, "swordhavenundead", "Skeletal Soldier");                                                // Undead Assault
        Story.KillQuest(177, "swordhavenundead", "Skeletal Ice Mage");                                               // Skull Crusher Mountain
        Story.KillQuest(178, "swordhavenundead", "Undead Giant");                                                    // The Undead Giant
        //Map: CastleUndead
        Story.MapItemQuest(179, "castleundead", 38, 5);                                                              // Talk to the Knights
        Story.KillQuest(180, "castleundead", "*");                                         // Defend the Throne
        if (!Story.QuestProgression(196))                                                    // The Arrival of Drakath cutscene
        {
            Core.Join("castleundead", "King2", "Center");
            Core.Join("Shadowfall");
            Core.SendPackets("%xt%zm%updateQuest%73922%43%1%");
            Bot.SendPacket($"%xt%zm%updateQuest%188220%41%{(Core.HeroAlignment > 1 ? 1 : Core.HeroAlignment)}%");
            Bot.Sleep(2000);
            Core.Join("shadowfall");
            Bot.Sleep(2000);
            Story.ChainQuest(195);
            Story.KillQuest(196, "chaoscrypt", "Chaorrupted Armor");                          // Recover Sepulchure's Cursed Armor!
        }
        //Map: ChaosCrypt
        //Map: Prison
        Story.MapItemQuest(6216, "prison", 39, 5);                                        // Unlife Insurance
        Story.BuyQuest(6216, "prison", 1559, "Unlife Insurance Bond");
        //Map: Various
        Story.MapItemQuest(6217, "chaoscrypt", 5662);                                                                // Enter the Crypt
        Story.KillQuest(6218, "chaoscrypt", "Chaorrupted Knight");                                                   // Rescue the Knights
        Story.KillQuest(6219, "forestchaos", new[] { "Chaorrupted Wolf", "Chaorrupted Bear" });  // Forest of Chaos
    }

    public void Escherion()
    {

        if (Story.isCompletedBefore(272))
            return;

        //Map: Mobius
        Story.KillQuest(245, "mobius", "Chaos Sp-Eye");                                  // Winged Spies
        Story.MapItemQuest(246, "mobius", 42, 5);                                        // Chaos Prisoners
        Story.KillQuest(247, "mobius", "Fire Imp");            // IMP-possible Task
        Story.MapItemQuest(260, "mobius", 44);                 // You Can't Miss It
        Story.KillQuest(248, "mobius", "Cyclops Raider");                                // Far Sighted
        Story.KillQuest(249, "mobius", "Slugfit");                                       // Slugfest
        //Map: Faerie
        Story.KillQuest(250, "faerie", "Chainsaw Sneevil");                              // Chain Reaction
        Story.MapItemQuest(251, "faerie", 43, 7);                                        // Epic Drops
        Story.KillQuest(252, "faerie", "Chainsaw Sneevil");    // Jarring Theft
        Story.KillQuest(255, "faerie", "Cyclops Warlord");                               // Tree Hugger
        Story.KillQuest(256, "faerie", "Aracara");                                       // The Second Piece
        //Map: Cornelis
        Story.KillQuest(257, "cornelis", "Gargoyle");          // Ruined Ruins
        Story.MapItemQuest(261, "cornelis", 45);               // Energize!
        Story.KillQuest(258, "cornelis", "Gargoyle");          // Blueish Glow
        Story.MapItemQuest(262, "cornelis", 46);               // Quickdraw
        Story.KillQuest(259, "cornelis", "Stone Golem");       // Arm Yourself
        Story.MapItemQuest(263, "cornelis", 47);               // You've Been Framed
        //Map: Mobius
        Story.MapItemQuest(266, "mobius", 48);                                           // Some Assembly Required
        //Map: Cornelis
        Story.MapItemQuest(267, "mobius", 49);                 // Teleporter Report
        Story.KillQuest(264, "mobius", "Cyclops Raider");                                // Disguise!
        Story.KillQuest(265, "faerie", "Chainsaw Sneevil");    // To-go box
        //Map: Relativity
        Story.KillQuest(268, "relativity", "Cyclops Raider");                            // Find the Key! (Part One)
        Story.KillQuest(269, "relativity", "Fire Imp");                                  // Find the Key! (Part Two)
        Story.KillQuest(270, "relativity", "Head Gargoyle");                             // Find the Key! (Part Three)
        //Map: Hydra
        Story.MapItemQuest(271, "hydra", 50);                                            // The Lake Hydra
        Story.MapItemQuest(271, "hydra", 51);
        Story.MapItemQuest(271, "hydra", 52);
        //Map: Escherion
        if (!Story.QuestProgression(272))  // Escherion
        {
            Core.EnsureAccept(272);
            Core.KillEscherion();
            Core.EnsureComplete(272);
        }
    }

    public void Vath()
    {

        if (Story.isCompletedBefore(363))
            return;

        //Map: Pines
        Story.MapItemQuest(319, "tavern", 56, 7);                                                                            // Adorable Sisters
        Story.KillQuest(320, "pines", "Pine Grizzly");                                                                       // Warm and Furry
        Story.KillQuest(321, "pines", "Red Shell Turtle");                                                                   // Shell Rock
        Story.KillQuest(322, "pines", "Twistedtooth");                                             // Bear Facts
        Story.KillQuest(324, "pines", "Red Shell Turtle");                                                                   // The Spittoon Saloon
        Story.KillQuest(325, "pines", "Pine Grizzly");                                                                       // Bear it all!
        Story.KillQuest(326, "pines", "Leatherwing");                                                                        // Leather Feathers
        if (!Core.CheckInventory("Snowbeard's Gold"))                                                                       // Follow your Nose!
            Story.KillQuest(327, "pines", "Pine Troll");
        if (!Story.QuestProgression(323))                                                          // Give Snowbeard His Gold
            Core.EnsureComplete(323);
        //Map: Dwarfhold
        Story.MapItemQuest(344, "dwarfhold", 60);                                                  // Bad Memory
        Story.KillQuest(331, "mountainpath", "Ore Balboa");                                                                  // Squeeze Water from Stone
        Story.KillQuest(332, "mountainpath", "Vultragon");                                                                   // Carrion Carrying On
        Story.KillQuest(333, "dwarfhold", "Chaos Drow");                                                                     // Bagged Lunch
        Story.KillQuest(334, "dwarfhold", "Glow Worm");                                                                      // Radiant Lamps
        Story.KillQuest(335, "dwarfhold", "Albino Bat");                                                                     // Having a Blast
        Story.KillQuest(336, "dwarfhold", "Chaotic Draconian");                                                              // Secret Weapons
        Story.MapItemQuest(337, "dwarfhold", 59, 7);                                                                         // Rock Star
        Story.KillQuest(338, "dwarfhold", "Chaos Drow");                                                                     // All that Glitters
        Story.KillQuest(339, "dwarfhold", "Chaotic Draconian");                                                              // Gemeralds
        Story.KillQuest(340, "dwarfhold", "Albino Bat");                                                                     // Talc to Me
        if (!Story.QuestProgression(343))                                                          // Upper City Gates
        {
            Core.Join("dwarfhold", "rdoor", "Right");
            Core.EnsureComplete(343);
            Bot.Sleep(2500);
        }
        Story.KillQuest(341, "dwarfhold", "Amadeus");                                              // Rock me Amadeus
        //Map: UpperCity
        Story.MapItemQuest(346, "uppercity", 61);                                                                            // Disapoofed
        Story.KillQuest(347, "uppercity", "Drow Assassin");                                                                  // Hoodwinked
        Story.KillQuest(348, "uppercity", "Chaotic Draconian");                                                              // Claws for the Cause
        Story.KillQuest(349, "uppercity", "Chaos Egg");                                                                      // Scrambled Eggs
        Story.KillQuest(350, "uppercity", "Terradactyl");                                                                    // The King's Wings
        Story.KillQuest(351, "uppercity", "Rhino Beetle");                                                                   // Bugging Out
        Story.KillQuest(352, "uppercity", "Cave Lizard");
        Story.KillQuest(353, "dwarfprison", new[] { "Balboa", "Albino Bat", "Chaos Drow" });                                                                    // Lizard Gizzard
        if (!Story.QuestProgression(354))                                                                                    // Like Butter
        {
            Core.AddDrop("Thermite");

            Core.Join("vath");                                                                                                 //Confront Vath
            Core.Jump("CutCap", "Left");
            Bot.Sleep(2500);
            Story.UpdateQuest(354);

            if (!Core.CheckInventory("Thermite"))
            {
                Core.EnsureAccept(353);
                Core.HuntMonster("dwarfprison", "Balboa", "Balboa Core", 4);
                Core.HuntMonster("dwarfprison", "Albino Bat", "Rusted Claw", 3);
                Core.HuntMonster("dwarfprison", "Chaos Drow", "Magnesium Flare");
                Core.EnsureComplete(353);
            }
            Core.Join("dwarfprison", "Enter", "Right");
            Core.EnsureComplete(354);
        }
        Story.KillQuest(355, "dwarfprison", "Warden Elfis");                                       // Jailhouse Rock
        Story.KillQuest(356, "dwarfprison", new[] { "Albino Bat", "Balboa", "Chaos Drow" });       // Explosives 101

        if (!Story.QuestProgression(357))                                                          // Big Bada-Boom
        {
            Core.EnsureAccept(356);
            if (!Core.CheckInventory("Tee-En-Tee"))
            {
                Core.HuntMonster("dwarfprison", "Albino Bat", "Nitrate Elements", 3);
                Core.HuntMonster("dwarfprison", "Chaos Drow", "Drow Shoelaces", 3);
                Core.HuntMonster("dwarfprison", "Balboa", "Flint Stone", 2);
                Core.EnsureComplete(356);
            }
            Core.Join("dwarfprison");
            Story.ChainQuest(357);
        }
        //Map: Roc
        Story.MapItemQuest(362, "roc", 62);                                                              // Defeat Rock Roc
        //Map: Stalagbite
        Story.MapItemQuest(363, "stalagbite", 63);                                                       // Facing Vath
    }

    public void Kitsune()
    {

        if (Story.isCompletedBefore(488))
            return;

        //Turtle Power
        Story.KillQuest(380, "yokaiboat", "Kappa Ninja");
        Story.MapItemQuest(380, "yokaiboat", 64);

        //Setting Sail to Yokai
        if (!Story.QuestProgression(381))
        {
            Core.EnsureAccept(381);
            Core.KillMonster("yokaiboat", "r4", "Spawn", "*", "Sail Permit");
            Core.EnsureComplete(381);
        }

        //Dragon Koi Tournament
        Story.KillQuest(382, "dragonkoi", "Ryoku");

        //Dog Days
        // Story.KillQuest("hachiko", "Samurai Nopperabo");
        // Story.KillQuest("hachiko", "Ninja Nopperabo");
        if (!Story.QuestProgression(402))
        {
            Core.EnsureAccept(402);
            Core.HuntMonster("hachiko", "Samurai Nopperabo", "Samurai Questioned", 5);
            Core.HuntMonster("hachiko", "Ninja Nopperabo", "Ninja Questioned", 5);
            Core.EnsureComplete(402);
        }

        //Faceless Threat - i think it has to be this cell? it wasnt getting the item from the rest
        if (!Story.QuestProgression(403))
        {
            Core.EnsureAccept(403);
            Core.KillMonster("hachiko", "Ox", "Center", "Samurai Nopperabo", "Note from DT");
            Core.EnsureComplete(403);
        }

        //Zodiac Puzzle Key
        if (!Story.QuestProgression(405))
        {
            Core.EnsureAccept(405);
            Core.KillMonster("hachiko", "Tiger", "Center", "Samurai Nopperabo", "Rat-Ox-Tiger Piece");
            Core.KillMonster("hachiko", "Snake", "Center", "Ninja Nopperabo", "Rabbit-Dragon-Snake piece");
            Core.KillMonster("hachiko", "Horse", "Center", "Samurai Nopperabo", "Horse-Sheep-Monkey piece");
            Core.KillMonster("hachiko", "Pig", "Center", "Ninja Nopperabo", "Rooster-Dog-Pig Piece");
            Core.EnsureComplete(405);
        }

        //Rescue!
        Story.KillQuest(406, "hachiko", "Dai Tengu");

        //Jinmenju Tree
        Story.MapItemQuest(466, "bamboo", 90);

        //Yokai Bandits
        Story.KillQuest(467, "bamboo", new[] { "Tanuki", "Tanuki" });

        //The Fiery Fiend
        Story.KillQuest(468, "bamboo", "SoulTaker");

        //Dumpster Diving
        Story.MapItemQuest(469, "junkyard", 91);

        //Reduce, Respawn, Recycle
        if (!Story.QuestProgression(470))
        {
            Core.EnsureAccept(470);
            Core.KillMonster("Junkyard", "Enter", "Spawn", 3847, "Wild Kara-Kasa", 5);
            Core.KillMonster("Junkyard", "Enter", "Spawn", 3848, "Wild Bakezouri", 1);
            Core.KillMonster("Junkyard", "r2", "Right", 3845, "Wild Bura-Bura", 4);
            Core.KillMonster("Junkyard", "r2", "Right", 3849, "Wild Biwa-Bokuboku", 3);
            Core.KillMonster("Junkyard", "r3", "Down", 3850, "Wild Koto-Furunushi", 2);
            Core.EnsureComplete(470);
        }
        // Story.KillQuest(470, "junkyard", new[] { "Tsukumo-Gami", "Tsukumo-Gami", "Tsukumo-Gami", "Tsukumo-Gami" });

        //The Hunt for the Hag
        Story.KillQuest(471, "junkyard", "Onibaba");

        //Su-she
        Story.KillQuest(473, "yokairiver", new[] { "Funa-Yurei", "Funa-Yurei", "Funa-Yurei" });

        //Kappa Cuisine
        if (!Story.QuestProgression(474))
        {
            Core.EnsureAccept(474);
            Core.KillMonster("yokairiver", "r4", "Left", "Kappa Ninja", "Dried Nori Leaf", 6);
            Core.KillMonster("yokairiver", "r4", "Left", "Kappa Ninja", "Sumeshi Bundle", 3);
            Core.KillMonster("yokairiver", "r4", "Left", "Kappa Ninja", "Fresh Cucumber", 1);
            Core.GetMapItem(92, 1, "yokairiver");
            Core.EnsureComplete(474);
        }

        //Hisssssy fit
        Story.KillQuest(476, "yokairiver", "Nure Onna");

        //The Purrrfect Crime
        Story.KillQuest(477, "yokaigrave", "Skello Kitty");

        //The Face Off
        Story.KillQuest(478, "yokaigrave", new[] { "Ninja Nopperabo", "Samurai Nopperabo" });

        //Confront Neko Mata
        Story.KillQuest(479, "yokaigrave", "Neko Mata");

        //Defeat O-dokuro
        Story.KillQuest(481, "odokuro", "O-dokuro");

        //Defeat O-Dokuro's Head
        Story.KillQuest(484, "yokaiwar", "O-Dokuro's Head");

        //Defeat Kitsune
        Story.KillQuest(488, "kitsune", "kitsune");
    }

    public void Wolfwing()
    {

        if (Story.isCompletedBefore(598))
            return;

        //Map: DarkoviaGrave
        Story.MapItemQuest(494, "darkoviagrave", 97);                                                    // Grave Mission
        Story.KillQuest(495, "darkoviagrave", "Skeletal Fire Mage");                                     // Lending a Helping Hand
        Story.KillQuest(496, "darkoviagrave", "Rattlebones");                                            // Bone Appetit
        Story.KillQuest(497, "darkoviagrave", "Albino Bat");                                             // Batting Cage
        Story.KillQuest(498, "darkoviagrave", "Blightfang");                   // His Bark is worse than his Blight
        //Map: GreenguardEast/West
        if (!Story.QuestProgression(516))          // Can I axe you something?
        {
            if (!Core.CheckInventory("Red's Big Wolf Slaying Axe"))
            {
                Core.AddDrop("Red's Big Wolf Slaying Axe");
                Core.EnsureAccept(515);
                Core.HuntMonster("greenguardeast", "Spider", "Spider Documentation");
                Core.HuntMonster("greenguardeast", "Wolf", "Wolf Documentation");
                Core.HuntMonster("greenguardwest", "Slime", "Slime Documentation");
                Core.HuntMonster("greenguardwest", "Frogzard", "Frogzard Documentation");
                Core.HuntMonster("greenguardwest", "Big Bad Boar", "Wereboar Documentation");
                Core.EnsureComplete(515);
                Bot.Wait.ForPickup("Red's Big Wolf Slaying Axe");

                if (!Story.QuestProgression(514, GetReward: false))                    // Lil' Red
                    Core.EnsureComplete(514);

                Story.KillQuest(516, "darkoviaforest", "Dire Wolf");
            }
        }
        //Map: DarkoviaForest                                            // A Dire Situation
        Story.KillQuest(517, "darkoviaforest", new[] { "Blood Maggot", "Blood Maggot", "Blood Maggot" });  // Blood, Sweat, and Tears
        Story.KillQuest(518, "darkoviaforest", "Lich of the Stone");                                     // What a Lich!
                                                                                                         //Map: Safiria
        Story.KillQuest(519, "safiria", "Blood Maggot");                                                 // Feeding Grounds
        Story.KillQuest(520, "safiria", "Albino Bat");                                                   //Going Batty
        Story.KillQuest(521, "safiria", "Chaos Lycan");                                                  //Lycan Knights
        Story.KillQuest(522, "safiria", "Twisted Paw");                        //Twisted Paw
                                                                               //Map: Lycan
        Story.KillQuest(534, "lycan", "Dire Wolf");                                                      // A Gift Of Meat
        Story.KillQuest(535, "lycan", new[] { "Lycan", "Lycan Knight" });                                  // No Respect
        Story.KillQuest(536, "lycan", "Chaos Vampire Knight");                                           // Vampire Knights
        if (!Core.QuestProgression(537))
        {
            Core.EnsureAccept(537);
            Story.HuntMonster("lycan", "Sanguine", "Sanguine's Mask");                                                          // Sanguine     
            Core.EnsureComplete(537);
        }

        if (!Story.QuestProgression(564))                                                                   // Search and Report
        {
            Core.EnsureAccept(546);
            Core.KillMonster("lycanwar", "Boss", "Left", "Edvard");
            Bot.Sleep(5000);
            Story.MapItemQuest(564, "chaoscave", 107);
        }

        //Map: ChaosCave                                                                                
        Story.KillQuest(565, "chaoscave", "Werepyre");                                                  // The Key is the Key

        if (!Story.QuestProgression(566))
        {
            Core.EnsureAccept(566);
            Core.KillMonster("chaoscave", "r3", "Left", "Werepyre", "Secret Words");                   // Secret Words
            Core.EnsureComplete(566);
        }

        if (!Story.QuestProgression(567))
        {
            Story.UpdateQuest(567);
            Core.EnsureAccept(567);
            Core.KillMonster("chaoscave", "r5", "Left", "Dracowerepyre", "Dracowerepyre Defeated");
            Core.EnsureComplete(567);
            Story.UpdateQuest(597);
        }
        // Dracowerepyre
        //Map: Wolfwing                                                                         // Wolfwing
        if (!Story.QuestProgression(597))
        {
            if (Core.HeroAlignment != 1)
                Bot.SendPacket($"%xt%zm%updateQuest%{Bot.Map.RoomID}%41%1%");
            Story.ChainQuest(597);
        }
    }

    public void Kimberly()
    {
        if (Story.isCompletedBefore(710))
            return;

        //Stairway to Heaven
        Story.KillQuest(648, "stairway", new[] { "Rock Lobster", "Grateful Undead" });

        //Rolling Stones
        Story.KillQuest(649, "stairway", "Rock Lobster");

        //Light My Fire
        Story.KillQuest(650, "stairway", "Grateful Undead");

        //Knockin' on Haven's Door
        Story.KillQuest(651, "stairway", new[] { "Elwood Bruise", "Jake Bruise" });

        //Staying Alive
        Story.KillQuest(658, "beehive", "Stinger");

        //Killer Queen
        Story.KillQuest(659, "beehive", "Killer Queen Bee");

        //Satisfaction
        if (!Story.QuestProgression(660))
        {
            Core.EnsureAccept(660);
            Core.HuntMonster("beehive", "Lord Ovthedance", "No Shoes!");
            Core.EnsureComplete(660);
        }

        //Dance with Great Godfather of Souls
        if (!Story.QuestProgression(661))
        {
            Core.EnsureAccept(661);
            Core.Join("beehive");
            Core.SendPackets("%xt%zm%tryQuestComplete%30004%661%-1%false%wvz%");
        }

        //Bad Moon Rising
        Story.KillQuest(675, "orchestra", "Mozard");

        //Burning Down The House
        if (!Story.QuestProgression(676))
        {
            Core.EnsureAccept(676);
            Core.KillMonster("orchestra", "R4", "Down", "*", "Cannon Powder");
            Core.EnsureComplete(676);
        }

        //Superstition
        Story.KillQuest(677, "orchestra", "Mozard");

        //Soul Man
        Story.KillQuest(678, "orchestra", "Faust");

        //Great gig in the Sky
        Story.KillQuest(4827, "stairway", new[] { "Rock Lobster", "Grateful Undead" });


        //Mythsong War Cutscene
        Story.ChainQuest(707);

        //Pony Gary Yellow
        Story.KillQuest(709, "palooza", "Pony Gary Yellow");

        //Kimberly
        Story.KillQuest(710, "palooza", "Kimberly");
    }

    public void Ledgermayne()
    {

        if (Story.isCompletedBefore(847))
            return;

        //Observing the Observatory
        Story.MapItemQuest(805, "arcangrove", 139);
        //Ewa the Treekeeper
        Story.MapItemQuest(806, "cloister", 142);

        //Bear Necessities of LifeRoot
        Story.MapItemQuest(807, "cloister", 140);

        //Acorny Quest
        Story.KillQuest(808, "cloister", "Acornent");

        //Ravenloss
        Story.KillQuest(809, "cloister", "Karasu");

        //It's A Bough-t Time
        Story.BuyQuest(810, "arcangrove", 211, "Mana Potion");
        Story.MapItemQuest(810, "cloister", 141, 3);

        //Wendigo Whereabouts
        Story.KillQuest(811, "cloister", "Wendigo");

        //Find Paddy Lump
        Story.MapItemQuest(813, "mudluk", 143);

        //Toothy Smiles
        Story.KillQuest(814, "mudluk", "Swamp Lurker");

        //Slimy Cyrus
        Story.KillQuest(815, "mudluk", "Swamp Lurker");

        //Lord Of The Fleas
        Story.KillQuest(816, "arcangrove", "Gorillaphant");

        //Not The Best Idea
        Story.KillQuest(817, "mudluk", "Swamp Frogdrake");

        //Gates and Guardians
        Story.KillQuest(818, "mudluk", "Tiger Leech");

        //Water You Waiting For--Find Nisse
        Story.MapItemQuest(825, "natatorium", 144);

        //Dive Right In
        Story.MapItemQuest(826, "natatorium", 145, 12);

        //Seafood Diet
        Story.KillQuest(827, "natatorium", "Anglerfish");

        //Mercenaries
        Story.KillQuest(828, "natatorium", "Merdraconian");

        //Synchronized Slaying
        if (!Story.QuestProgression(829))
        {
            Core.EnsureAccept(829);
            Core.HuntMonster("arcangrove", "Seed Spitter", "Brain Coral", 5);
            Core.HuntMonster("cloister", "Acornent", "Staghorns", 4);
            Core.HuntMonster("cloister", "Karasu", "Sea Fan", 3);
            Core.HuntMonster("cloister", "Wendigo", "Sea Whip");
            Core.HuntMonster("mudluk", "Swamp Frogdrake|Swamp Lurker", "Anemones", 6);
            Core.EnsureComplete(829);
        }

        //The Deep End
        Story.KillQuest(830, "natatorium", "Nessie");

        //Find Umbra, the Master Shaman
        Story.MapItemQuest(831, "gilead", 146);

        //The Root of Elementals
        if (!Story.QuestProgression(832))
        {
            Core.EnsureAccept(832);
            Core.HuntMonster("gilead", "Earth Elemental", "Dregs Essence", 5);
            Core.HuntMonster("arcangrove", "Seed Spitter", "Spitter Spirit", 4);
            Core.EnsureComplete(832);
        }

        //Eupotamic Elementals
        if (!Story.QuestProgression(833))
        {
            Core.EnsureAccept(833);
            Core.HuntMonster("gilead", "Water Elemental", "Aqueous Essence", 5);
            Core.HuntMonster("natatorium", "Merdraconian", "MerCore", 6);
            Core.EnsureComplete(833);
        }

        //Breaking Wind Elementals
        if (!Story.QuestProgression(834))
        {
            Core.EnsureAccept(834);
            Core.HuntMonster("gilead", "Wind Elemental", "Welkin Essence", 5);
            Core.HuntMonster("cloister", "Karasu", "Karasu Soul", 8);
            Core.EnsureComplete(834);
        }

        //Fight Fire With Fire Salamanders
        if (!Story.QuestProgression(835))
        {
            Core.EnsureAccept(835);
            Core.HuntMonster("gilead", "Fire Elemental", "Pyre Essence", 5);
            Core.HuntMonster("mudluk", "Swamp Frogdrake", "Fire Salamander", 5);
            Core.EnsureComplete(835);
        }

        //Guardian of the Gilead Wrap
        Story.KillQuest(836, "gilead", "Mana Elemental");

        //Find Felsic the Magma Golem
        Story.MapItemQuest(838, "mafic", 147);

        //Liquid Hot Magma Maggots
        Story.KillQuest(839, "mafic", "Volcanic Maggot");

        //Scorched Serpents
        Story.KillQuest(840, "mafic", "Scoria Serpent");

        //Playing With Living Fire
        Story.KillQuest(841, "mafic", "Living Fire");

        //Kindling Relationship
        Story.KillQuest(842, "mafic", "Mafic Dragon");

        //Obey Your Thirst for Adventure
        Story.KillQuest(843, "elemental", "Mana Imp");

        //Captain Falcons
        Story.KillQuest(844, "elemental", "Mana Falcon");

        //Big, bad, and Baddest Bosses
        if (!Story.QuestProgression(845))
        {
            Core.EnsureAccept(845);
            Core.HuntMonster("mafic", "Mafic Dragon", "Astral Orb of Mafic");
            Core.HuntMonster("cloister", "Wendigo", "Astral Orb of the Cloister");
            Core.HuntMonster("mudluk", "Tiger Leech", "Astral Orb of Mudluk");
            Core.HuntMonster("natatorium", "Nessie", "Astral Orb of Natatorium");
            Core.HuntMonster("gilead", "Mana Elemental", "Astral Orb of Gilead");
            Core.EnsureComplete(845);
        }
        //The Great Mana Golem
        Story.KillQuest(846, "elemental", "Mana Golem");
        //Chaos Lord Ledgermayne
        Story.KillQuest(847, "ledgermayne", "Ledgermayne");
    }


    public void Tibicenas()
    {

        if (Story.isCompletedBefore(1005))
            return;

        //Sandport and Starboard
        Story.MapItemQuest(930, "sandport", 251);

        //Shark Diving
        Story.KillQuest(931, "sandport", "Sandshark");

        //Thieving Cut Throats
        Story.KillQuest(932, "sandport", "Tomb Robber");

        //Lost and Found
        Story.KillQuest(933, "sandport", "Tomb Robber");

        //Sell-Sword Sell-Outs
        if (!Story.QuestProgression(934))
        {
            Core.EnsureAccept(934);
            Core.Join("sandport", "r6", "Right");
            Bot.Player.Kill("*");
            Core.Jump("r5", "Right");
            Bot.Player.Kill("*");
            Bot.Player.Kill("*");
            Bot.Player.Kill("*");
            if (Bot.Quests.CanComplete(934))
                Core.EnsureComplete(934);
        }

        //Sacred Scarabs
        Story.KillQuest(967, "pyramid", "Golden Scarab");

        //A Noob is Guard
        Story.KillQuest(968, "pyramid", "Anubis Deathguard");

        //Bandaged Aids
        Story.KillQuest(969, "pyramid", "Mummy");

        //Keys to the Royal Chamber
        Story.KillQuest(970, "pyramid", "Golden Scarab");

        //Confront Duat
        Story.MapItemQuest(971, "pyramid", 304);

        //They've Gone Dark
        Story.KillQuest(972, "wanders", "Kalestri Worshiper");

        //Bad Doggies
        Story.KillQuest(973, "wanders", "Kalestri Hound");

        //Essentially Evil
        Story.KillQuest(974, "wanders", "Kalestri Hound");

        //Loose Threads
        Story.KillQuest(975, "wanders", "Lotus Spider");

        //Seek The Treasure
        Story.MapItemQuest(976, "wanders", 306);

        //Dreamsand
        Story.KillQuest(977, "wanders", "Lotus Spider");

        //I Dream Of...
        if (!Story.QuestProgression(978))
        {
            Core.EnsureAccept(978);
            Core.Join("wanders", "Boss", "Left");
            Bot.Sleep(1500);
            Bot.Player.UseSkill(0);
            Core.KillMonster("wanders", "Boss", "Left", "Sek-Duat", "Sek-Duat Defeated");
            Core.EnsureComplete(978);
        }

        //Sandsational Castle
        Story.MapItemQuest(995, "sandcastle", 361);

        //Furry Fury
        Story.KillQuest(996, "sandcastle", "War Hyena");

        //Keeping Secrets Under Wraps
        Story.KillQuest(997, "sandcastle", "War Mummy");

        //Gem Jam
        Story.KillQuest(998, "sandcastle", "War Hyena");

        //Enter the Sphinx
        Story.KillQuest(999, "sandcastle", "Chaos Sphinx");

        //Unlamented Lamia
        Story.KillQuest(1000, "djinn", "Lamia");

        //E-vase-ive Measures
        Story.KillQuest(1001, "sandsea", "Desert Vase");

        //Tri-hump-hant Camels
        Story.KillQuest(1002, "sandsea", "Bupers Camel");

        //I Don't Mean to Harp On It...
        Story.KillQuest(1003, "djinn", "Harpy");

        //In-djinn-ious Solution
        Story.MapItemQuest(1004, "djinn", 370, 5);

        //Chaos Lord Tibicenas
        Story.KillQuest(1005, "djinn", "Tibicenas");

    }

    public void KhasaandaHorc(bool bypassCheck = false)
    {
        if (!bypassCheck)
        {
            if (Story.isCompletedBefore(1473))
                return;
        }



        //Troll Stink!
        if (!Story.QuestProgression(1232))
        {
            Core.EnsureAccept(1232);
            Core.HuntMonster("crossroads", "Chinchilizard", "Scaly Skin Scrub", 7);
            Core.HuntMonster("bloodtusk", "Trollola Plant", "Perfumed Trollola Flower", 10);
            Story.MapItemQuest(1232, "bloodtusk", 523);
        }

        //It Not Time Yet
        if (!Story.QuestProgression(1233))
        {
            Core.EnsureAccept(1233);
            Core.HuntMonster("crossroads", "Lemurphant", "Lemurphant Stones", 5);
            Core.HuntMonster("crossroads", "Koalion", "Golden Down-fur", 5);
            Core.EnsureComplete(1233);
        }

        //Mountain Protection
        if (!Story.QuestProgression(1234))
        {
            Core.EnsureAccept(1234);
            Core.HuntMonster("bloodtusk", "Crystal-Rock", "Polished Rocks", 3);
            Core.HuntMonster("crossroads", "Lemurphant", "Lemurphant Ivory", 5);
            Core.HuntMonster("crossroads", "Chinchilizard", "Liz-Leather Thongs", 5);
            Story.MapItemQuest(1234, "crossroads", 525);
        }

        //Clear Mind, Cleanse Spirit
        if (!Story.QuestProgression(1235))
        {
            Core.EnsureAccept(1235);
            Core.HuntMonster("bloodtusk", "Trollola Plant", "Trollola Plant Resin", 4);
            Core.HuntMonster("crossroads", "Lemurphant", "Lemurphant Musk", 5);
            Core.HuntMonster("crossroads", "Koalion", "Fur for Firestarting", 5);
            Story.MapItemQuest(1235, "crossroads", 521, 10);
        }

        //She Who Asks
        Story.ChainQuest(1236);

        //Be Horc Inside
        if (!Story.QuestProgression(1237))
        {
            Core.EnsureAccept(1237);
            Core.HuntMonster("crossroads", "Koalion", "Koalion Claw", 5);
            Core.HuntMonster("crossroads", "Koalion", "Skin of the Mountain", 10);
            Core.HuntMonster("crossroads", "Lemurphant", "Lemurphant Tusks", 5);
            Story.MapItemQuest(1237, "crossroads", 524, 5);
            Story.MapItemQuest(1237, "crossroads", 522, 10);
            Core.EnsureComplete(1237);
        }

        //She Who Answers 2 - cutscene
        //if(!Story.QuestProgression(1241))
        //{
        Story.ChainQuest(1241);
        //}

        //Chaos Enrages the Horcs
        // if(!Story.QuestProgression(1273))
        //{
        Story.ChainQuest(1273);
        //}

        //Into, Under the Mountain
        Story.MapItemQuest(1280, "ravinetemple", 553);

        //Has the Land Been Tainted?
        Story.MapItemQuest(1281, "ravinetemple", 554, 5);
        Story.MapItemQuest(1281, "ravinetemple", 555, 10);
        Story.MapItemQuest(1281, "ravinetemple", 556, 10);

        //Tears of the Mountain
        Story.KillQuest(1282, "ravinetemple", "*");

        //Defend the UnderMountain
        Story.KillQuest(1283, "ravinetemple", "*");
        Story.MapItemQuest(1283, "ravinetemple", 557, 10);

        //Alliance Defiance
        Story.KillQuest(1284, "ravinetemple", "*");

        //Scout and Return
        Story.MapItemQuest(1375, "alliance", 679);
        Story.MapItemQuest(1375, "alliance", 680);

        //Good and Evil Not Always Right
        if (!Story.QuestProgression(1376))
        {
            Core.EnsureAccept(1376);
            Core.HuntMonster("alliance", "Good Soldier", "Good Soldier Vanquished", 10);
            Core.HuntMonster("alliance", "Evil Soldier", "Evil Soldier Vanquished", 10);
            Core.EnsureComplete(1376);
        }

        //Trapping Savage Soldiers
        Story.MapItemQuest(1377, "alliance", 675, 10);

        //Find What is Hidden Inside
        Story.MapItemQuest(1378, "alliance", 676);

        //Chaorruption Rejection
        Story.KillQuest(1379, "alliance", "Chaorrupted Evil Soldier|Chaorrupted Good Soldier");

        //Alliance Subdued
        //Story.KillQuest(1380, "alliance", new[] { "General Cynari", "General Tibias" });
        if (!Story.QuestProgression(1380))
        {
            Core.EnsureAccept(1380);
            Core.HuntMonster("alliance", "General Cynari", "Cynari Defeated!");
            Core.HuntMonster("alliance", "General Tibias", "Tibias Defeated!");
            Core.EnsureComplete(1380);
        }

        //Cleanse the Chaorruption
        Story.KillQuest(1424, "ancienttemple", "Chaotic Vulture");

        //Chaorruption Cure?
        Story.KillQuest(1425, "ancienttemple", "Chaotic Vulture");
        Story.MapItemQuest(1425, "ancienttemple", 706, 7);

        //Guardian Salvation
        Story.KillQuest(1426, "ancienttemple", "Chaos Troll Spirit");

        //Poison for a Purpose
        Story.KillQuest(1427, "ancienttemple", "Serpentress");

        //The Heart of the Temple Awaits
        Story.MapItemQuest(1428, "ancienttemple", 707);

        //Wounds in Stones and Beasts
        Story.MapItemQuest(1456, "orecavern", 717);

        //Light in Underhome
        Story.KillQuest(1457, "orecavern", "Crashroom");
        Story.MapItemQuest(1457, "orecavern", 719, 5);

        //Truth is its Own Light
        Story.MapItemQuest(1458, "orecavern", 718, 5);

        //Horcs Know Mercy
        Story.KillQuest(1459, "orecavern", "Chaorrupted Evil Soldier");

        //Battle the Baas!
        Story.KillQuest(1460, "orecavern", "Naga Baas");

        //Know the Nexus
        Story.MapItemQuest(1469, "dreamnexus", 734);
        Story.MapItemQuest(1469, "dreamnexus", 735);
        Story.MapItemQuest(1469, "dreamnexus", 736);
        Story.MapItemQuest(1469, "dreamnexus", 737);

        //Secure a Route Home
        if (!Story.QuestProgression(1470))
        {
            Core.EnsureAccept(1470);
            Core.HuntMonster("dreamnexus", "Dark Wyvern", "Wyvern Scales", 5);
            Core.HuntMonster("dreamnexus", "Dark Wyvern", "Wyvern Claws", 5);
            Core.HuntMonster("dreamnexus", "Aether Serpent", "Serpent Fangs", 5);
            Core.HuntMonster("dreamnexus", "Aether Serpent", "Serpent Hair", 5);
            Core.EnsureComplete(1470);
        }

        //DreamDancers' Orbs
        Story.MapItemQuest(1471, "dreamnexus", 738, 10);
        Story.MapItemQuest(1471, "dreamnexus", 739, 11);

        //Master the Flames 
        Story.KillQuest(1472, "dreamnexus", new[] { "Solar Phoenix", "Solar Phoenix" });
        // if (!Story.QuestProgression(1472))
        // {
        //     Core.EnsureAccept(1472);
        // Core.HuntMonster("dreamnexus", "Solar Phoenix", "Phoenix Tear", 5);
        // Core.HuntMonster("dreamnexus", "Solar Phoenix", "Phoenix Blood", 5);
        //     Core.EnsureComplete(1472);
        // }

        //Choose: Khasaanda Confrontation?
        Story.KillQuest(1473, "dreamnexus", "Khasaanda");

    }

    public void KhasaandaTroll(bool bypassCheck = false)
    {
        if (Story.isCompletedBefore(1468))
            return;

        //Horc Stink! 
        if (!Story.QuestProgression(1226))
        {
            Core.EnsureAccept(1226);
            Core.HuntMonster("crossroads", "Chinchilizard", "Scaly Skin Scrub", 7);
            Core.HuntMonster("bloodtusk", "Trollola Plant", "Perfumed Trollola Flower", 10);
            Story.MapItemQuest(1226, "bloodtusk", 523);
        }

        //The Time Grows Closer
        Story.KillQuest(1227, "crossroads", new[] { "Koalion", "Lemurphant" });

        //Like Calls to Like
        if (!Story.QuestProgression(1228))
        {
            Core.EnsureAccept(1228);
            Core.HuntMonster("bloodtusk", "Crystal-Rock", "Mountain Crystal", 3);
            Core.HuntMonster("crossroads", "Chinchilizard", "Liz-Leather Thongs", 5);
            Core.HuntMonster("crossroads", "Lemurphant", "Lemurphant Ivory", 5);
            Story.MapItemQuest(1228, "crossroads", 525);
        }

        //Incense Makes Sense
        if (!Story.QuestProgression(1229))
        {
            Core.EnsureAccept(1229);
            Core.HuntMonster("crossroads", "Lemurphant", "Lemurphant Musk", 5);
            Core.HuntMonster("bloodtusk", "Trollola Plant", "Trollola Plant Resin", 4);
            Core.HuntMonster("crossroads", "Koalion", "Fur for Firestarting", 5);
            Story.MapItemQuest(1229, "crossroads", 521, 10);
        }

        //She Who asks 1
        if (!Story.QuestProgression(1230))
        {
            Story.ChainQuest(1230);
        }

        //The Troll Inside
        if (!Story.QuestProgression(1231))
        {
            Core.EnsureAccept(1231);
            Core.HuntMonster("crossroads", "Lemurphant", "Lemurphant Tusks", 5);
            Core.HuntMonster("crossroads", "Koalion", "Koalion Claw", 5);
            Core.HuntMonster("bloodtusk", "Crystal-Rock", "Singing Crystals", 10);
            Story.MapItemQuest(1231, "crossroads", 522, 5);
            Story.MapItemQuest(1231, "crossroads", 524, 10);
        }

        //Eclipse - cutscene
        if (!Story.QuestProgression(1240))
        {
            Core.EnsureAccept(1240);
            Core.Join("crossroads");
            Bot.Sleep(2000);
            Core.Join("crossroads");
            Core.Jump("CutE", "Left");
            Bot.Sleep(2000);
            Core.EnsureComplete(1240);
        }

        //Chaos scars the Trolls

        Story.ChainQuest(1272);

        //Guarded Secrets, Hidden Treasures
        Story.MapItemQuest(1274, "ravinetemple", 553);

        //Evidence of Chaos
        Story.MapItemQuest(1275, "ravinetemple", 554, 5);
        Story.MapItemQuest(1275, "ravinetemple", 555, 10);
        Story.MapItemQuest(1275, "ravinetemple", 556, 10);

        //Learn More of the Ore
        Story.KillQuest(1276, "ravinetemple", "*");

        //Too Little, Too Late. Still Needed
        Story.KillQuest(1277, "ravinetemple", "*");
        Story.MapItemQuest(1277, "ravinetemple", 557, 10);
        Story.MapItemQuest(1277, "ravinetemple", 557, 10);

        //Alliance Defiance
        Story.KillQuest(1278, "ravinetemple", "*");

        //The Headquartes of Good and Evil
        Story.MapItemQuest(1369, "alliance", 679);
        Story.MapItemQuest(1369, "alliance", 680);

        //Treat Nullification, Good and Bad
        Story.KillQuest(1370, "alliance", new[] { "Good Soldier", "Evil Soldier" });

        //Trap the Keepers
        Story.MapItemQuest(1371, "alliance", 675, 10);

        //Find What is Hidden Inside
        Story.MapItemQuest(1372, "alliance", 676);

        //Chaorruption Annihilation
        Story.KillQuest(1373, "alliance", "Chaorrupted Evil Soldier|Chaorrupted Good Soldier");

        //Alliance Demotion
        Story.KillQuest(1374, "alliance", new[] { "General Cynari", "General Tibias" });

        //Contain the Chaorruption
        Story.KillQuest(1419, "ancienttemple", "Chaotic Vulture|Chaotic Horcboar");

        //Ancient Ointment
        Story.KillQuest(1420, "ancienttemple", "Chaotic Vulture|Chaotic Horcboar");
        Story.MapItemQuest(1420, "ancienttemple", 706, 7);

        //Anoint the Ancients
        Story.KillQuest(1421, "ancienttemple", "Chaos Troll Spirit|Chaos Horc Spirit");

        //Serpents Do No Harm
        Story.KillQuest(1422, "ancienttemple", "Serpentress");

        //Though Nature Bars the Way
        Story.MapItemQuest(1423, "ancienttemple", 707);

        //Descent Into Darkness
        Story.MapItemQuest(1451, "orecavern", 717);

        //Out of the Darkness
        Story.KillQuest(1452, "orecavern", "Crashroom");
        Story.MapItemQuest(1452, "orecavern", 719, 5);

        //Shine a Light on Deception
        Story.MapItemQuest(1453, "orecaveern", 718, 5);

        //Save Yourself, Save the Soldiers
        Story.KillQuest(1454, "orecavern", "Chaorrupted Evil Soldier|Chaorrupted Good Soldier");

        //Battle the Baas!
        Story.KillQuest(1455, "orecavern", "Naga Baas");

        //Know the Nexus
        Story.MapItemQuest(1464, "dreamnexus", 734);
        Story.MapItemQuest(1464, "dreamnexus", 735);
        Story.MapItemQuest(1464, "dreamnexus", 736);
        Story.MapItemQuest(1464, "dreamnexus", 737);

        //Secure a Route Home
        if (!Story.QuestProgression(1465))
        {
            Core.EnsureAccept(1465);
            Core.HuntMonster("dreamnexus", "Dark Wyvern", "Wyvern Scales", 2);
            Core.HuntMonster("dreamnexus", "Dark Wyvern", "Wyvern Claws", 2);
            Core.HuntMonster("dreamnexus", "Aether Serpent", "Serpent Fangs", 2);
            Core.HuntMonster("dreamnexus", "Aether Serpent", "Serpent Hair", 2);
            Core.EnsureComplete(1465);
        }

        //DreamDancers' Orbs
        Story.MapItemQuest(1466, "dreamnexus", 738, 10);
        Story.MapItemQuest(1466, "dreamnexus", 739, 11);

        //Master the Flames
        Story.KillQuest(1467, "dreamnexus", new[] { "Solar Phoenix", "Solar Phoenix" });

        //Choose: Khasaanda Confrontation?
        Story.KillQuest(1468, "dreamnexus", "Khasaanda");
    }

    public void Iadoa()
    {

        if (Story.isCompletedBefore(2519))
            return;

        //Time to Learn the Truth
        Story.MapItemQuest(2239, "thespan", 1358);
        Story.MapItemQuest(2239, "thespan", 1359);
        Story.MapItemQuest(2239, "thespan", 1360);
        Story.MapItemQuest(2239, "thespan", 1361);
        Story.MapItemQuest(2239, "thespan", 1362);
        Story.MapItemQuest(2239, "thespan", 1363);

        //Gain Access to Doors
        Story.KillQuest(2240, "timelibrary", new[] { "Sneak", "Tog", "Shadowscythe" });

        //Adventures and Quests
        if (!Story.QuestProgression(2241))
        {
            Core.EnsureAccept(2241);
            Core.HuntMonster("timelibrary", "Moglin Ghost", "Necromancy in AQ Knowledge");
            Core.HuntMonster("timelibrary", "Undead Knight", "Tales of Planet-Peril Page", 6);
            Story.MapItemQuest(2241, "timelibrary", 1365, 3);
        }

        //A Fable of Dragons
        if (!Story.QuestProgression(2242))
        {
            Core.EnsureAccept(2242);
            Core.HuntMonster("timelibrary", "Tog", "Elemental Orb Knowledge", 8);
            Core.HuntMonster("timelibrary", "Tog", "\"Draconic Prophecy\" Page", 6);
            Story.MapItemQuest(2242, "timelibrary", 1366, 2);
        }

        //Mechas and Quests
        if (!Story.QuestProgression(2243))
        {
            Core.EnsureAccept(2243);
            Core.HuntMonster("timelibrary", "Shadowscythe", "Shadowscythe Combat Strategy", 7);
            Core.HuntMonster("timelibrary", "Training Globe", "Galactic Hypertron Engines: A Primer");
            Story.MapItemQuest(2243, "timelibrary", 1367);
        }

        //After the Chaos
        Story.KillQuest(2244, "timelibrary", new[] { "Queen's Lieutenant", "Queen's Recruit", "Queen's Knight" });
        if (!Story.QuestProgression(2244))
        {
            Core.EnsureAccept(2244);
            Core.HuntMonster("timelibrary", "Queen's Knight", "Princess Freed… but for what?", 2);
            Core.HuntMonster("timelibrary", "Queen's Knight", "The Future is Now", 3);
            Core.HuntMonster("timelibrary", "Queen's Knight", "Past Failures Brought Us Here", 2);
            Story.MapItemQuest(2244, "timelibrary", 1368);
        }

        //Trust is Not Ephemeral
        Story.KillQuest(2253, "timevoid", "Ephemerite");

        //In a Split Exasecond
        if (!Story.QuestProgression(2254))
        {
            Core.EnsureAccept(2254);
            Core.HuntMonster("timevoid", "Time-Travel Fairy", "Exaglass", 4);
            Core.HuntMonster("timevoid", "Time-Travel Fairy", "Fairy Plasma", 8);
            Story.MapItemQuest(2254, "timevoid", 1438, 16);
        }

        //Time to Prove Yourself
        Story.KillQuest(2255, "timevoid", new[] { "Time-Travel Fairy", "Ephemerite" });
        Story.MapItemQuest(2255, "timevoid", 1439, 15);

        //Fill the Empty Hours
        Story.KillQuest(2256, "timevoid", new[] { "Void Phoenix", "Time-Travel Fairy" });

        //Clock of the Long Now
        Story.MapItemQuest(2257, "timevoid", 1440);
        Story.MapItemQuest(2257, "timevoid", 1441);
        Story.MapItemQuest(2257, "timevoid", 1442);
        Story.MapItemQuest(2257, "timevoid", 1443);

        //Unending Avatar
        if (!Story.QuestProgression(2258))
        {
            Core.EnsureAccept(2258);
            Core.HuntMonster("timevoid", "Unending Avatar", "Avatar Slain");
            Core.EnsureComplete(2258);
        }

        //Construct Your Reality
        Story.MapItemQuest(2376, "aqlesson", 1467);

        //Reach the Temple
        Story.KillQuest(2377, "aqlesson", "Ninja ");

        //Not All Hope is Lost
        Story.MapItemQuest(2378, "aqlesson", 1468, 8);
        Story.MapItemQuest(2378, "aqlesson", 1469);

        //Bolster the Elements
        if (!Story.QuestProgression(2379))
        {
            Core.EnsureAccept(2379);
            Core.HuntMonster("aqlesson", "Eternite Ore", "TimeSpark Acquired", 3);
            Core.HuntMonster("aqlesson", "Water Elemental", "Tears of Joy Acquired", 3);
            Story.MapItemQuest(2379, "aqlesson", 1470, 3);
            Story.MapItemQuest(2379, "aqlesson", 1471, 3);
        }

        //Maintain Elemental Strength
        Story.KillQuest(2380, "aqlesson", new[] { "Ice Elemental", "Fire Elemental" });
        Story.MapItemQuest(2380, "aqlesson", 1473, 3);
        Story.MapItemQuest(2380, "aqlesson", 1472, 3);

        //Rescue the Innocent
        Story.KillQuest(2381, "aqlesson", "Void Dragon");

        //Get Fired Up... or Shatter!
        Story.KillQuest(2382, "aqlesson", "Firezard");

        //Enemies on Ice
        Story.KillQuest(2383, "aqlesson", "Ice Elemental");

        //Tek-nical Forging Skill
        Story.MapItemQuest(2384, "thespan", 1474);

        //Akriloth Assault
        Story.KillQuest(2385, "aqlesson", "Akriloth");

        //Proto-Chaos Beast Battle!
        Story.KillQuest(2386, "aqlesson", "Carnax");

        //Elemental Orb Awareness
        Story.MapItemQuest(2470, "dflesson", 1549, 8);

        //Fight Chaos with Fire!
        if (!Story.QuestProgression(2471))
        {
            Core.EnsureAccept(2471);
            Core.HuntMonster("dflesson", "Fire Elemental", "Slain Flame Elemental", 8);
            Core.HuntMonster("dflesson", "Fire Elemental", "Chaos Gemerald", 4);
            Core.EnsureComplete(2471);
        }

        //Save Aria
        if (!Story.QuestProgression(2472))
        {
            Core.EnsureAccept(2472);
            Core.HuntMonster("dflesson", "Lava Slime", "Slain Slime", 5);
            Core.HuntMonster("dflesson", "Fire Elemental", "Slain Elemental", 6);
            Core.HuntMonster("dflesson", "Fire Elemental", "Blue Clue");
            Core.EnsureComplete(2472);
        }

        //Find the Time to Travel
        if (!Story.QuestProgression(2473))
        {
            Core.EnsureAccept(2473);
            Core.HuntMonster("dflesson", "Tog", "Life AND the Universe", 4);
            Core.HuntMonster("dflesson", "Agitated Orb", "Everything", 5);
            Core.HuntMonster("dflesson", "Agitated Orb", "Hoopy Frood's Towel", 3);
            Core.EnsureComplete(2473);
        }

        //Dragon Egg... or Junk?
        Story.KillQuest(2474, "dflesson", "Vultragon");

        //Dracolich Fortress Detected
        Story.KillQuest(2475, "dflesson", "Chaos Sp-Eye");

        //Bone up on the Boss
        Story.KillQuest(2476, "dflesson", "Chaorrupted Evil Soldier");

        //Defend the Town!
        Story.KillQuest(2477, "dflesson", new[] { "Lava Golem", "Fire Elemental" });

        //ChickenCows, Bacon, and Battle!
        Story.KillQuest(2478, "dflesson", new[] { "Chaotic Chicken", "Chaotic Horcboar" });

        //The 2nd Proto-Chaos Beast
        Story.KillQuest(2479, "dflesson", "Fluffy the Dracolich");

        //Board the Ship to Your Future
        Story.MapItemQuest(2504, "mqlesson", 1580);

        //Heal the Chaos Lord
        Story.KillQuest(2505, "mqlesson", "Asteroid");

        //Shadowscythe Detection Beacons
        Story.MapItemQuest(2506, "mqlesson", 1581, 5);

        //Test Potential Traitors
        Story.KillQuest(2507, "mqlesson", "MystRaven Student");

        //Defeat Training Globes
        Story.KillQuest(2508, "mqlesson", "Training Globe");

        //Take Flight into the Future
        Story.KillQuest(2509, "mqlesson", "MystRaven Student");

        //Secrets of the Universe
        Story.KillQuest(2510, "mqlesson", "Chaos Shadowscythe");

        //Mysterious!
        Story.KillQuest(2511, "mqlesson", new[] { "Chaos Shadowscythe", "Chaos Shadowscythe" });
        if (!Story.QuestProgression(2511))
        {
            Core.EnsureAccept(2511);
            Core.HuntMonster("mqlesson", "Chaos Shadowscythe", "Truth Glasses");
            Core.HuntMonster("mqlesson", "Chaos Shadowscythe", "Darkness Destroyed", 13);
            Core.EnsureComplete(2511);
        }

        //The 3rd Proto-Chaos Beast
        Story.KillQuest(2512, "mqlesson", "Dragonoid");

        //Chaos Waits and Watches
        Story.KillQuest(2513, "deepchaos", "Chaotic Merdrac");

        //The Lure of Chaosanity
        Story.KillQuest(2515, "deepchaos", "Chaos Angler");

        //Music of Nightmares
        Story.MapItemQuest(2516, "deepchaos", 1582, 3);

        //Chaos Beast Kathool
        Story.KillQuest(2517, "deepchaos", "Kathool");

        //Starry, Starry Night
        Story.KillQuest(2518, "timespace", "Astral Ephemerite");

        if (!Core.CheckInventory("Dragonoid of Hours"))
            Core.HuntMonster("mqlesson", "Dragonoid", "Dragonoid of Hours", isTemp: false);

        //Chaos Lord Iadoa
        Story.KillQuest(2519, "timespace", "Chaos Lord Iadoa");
    }

    public void Lionfang()
    {


        if (Story.isCompletedBefore(2814))
            return;

        //Final Rest
        Story.KillQuest(2612, "blackhorn", "Restless Undead");

        //Disturbing The Peace
        Story.MapItemQuest(2613, "blackhorn", 1615, 10);

        //Sampling Silk
        Story.KillQuest(2614, "blackhorn", "Tomb Spider");

        //Fire Is The Thing
        Story.KillQuest(2615, "blackhorn", new[] { "Restless Undead", "Tomb Spider" });
        Story.MapItemQuest(2615, "blackhorn", 1616);

        //The Wall Comes Down
        Story.MapItemQuest(2616, "blackhorn", 1617);

        //The Bonefeeder
        Story.KillQuest(2617, "blackhorn", "Bonefeeder Spider");

        //What Lies Beyond?
        Story.MapItemQuest(2618, "blackhorn", 1618);

        //Toxic
        Story.KillQuest(2619, "blackhorn", "Tomb Spider");

        //Very Toxic
        Story.KillQuest(2620, "blackhorn", "Restless Undead");

        //Really, VERY VERY TOXIC!
        Story.MapItemQuest(2621, "blackhorn", 1619);

        //Lion Hunting
        Story.MapItemQuest(2622, "onslaughttower", 1620);
        Story.MapItemQuest(2622, "onslaughttower", 1621);
        Story.MapItemQuest(2622, "onslaughttower", 1622);
        Story.MapItemQuest(2622, "onslaughttower", 1623);

        //Secret Of The Death Fog
        Story.KillQuest(2623, "onslaughttower", "Golden Caster|Golden Warrior|Golden Cavalry");

        //The Key To Survival
        Story.KillQuest(2624, "onslaughttower", "Golden Caster|Golden Warrior|Golden Cavalry");

        //The Tools
        Story.MapItemQuest(2625, "onslaughttower", 1624, 8);

        //The Talent
        Story.MapItemQuest(2626, "onslaughttower", 1625);

        //The Local Locale
        Story.MapItemQuest(2627, "onslaughttower", 1626, 4);

        //Who Holds The Key?
        Story.KillQuest(2628, "onslaughttower", "Golden Caster|Golden Warrior|Golden Cavalry");

        //Leave No Rug Unturned
        Story.MapItemQuest(2629, "onslaughttower", 1627);

        //Tame The Lion
        Story.KillQuest(2630, "onslaughttower", "Maximillian Lionfang");

        //Take Up The Cause
        Story.KillQuest(2666, "falguard", "Chaonslaught Caster|Chaonslaught Warrior|Chaonslaught Cavalry");

        //Well Kept Secrets
        Story.MapItemQuest(2667, "falguard", 1628, 6);

        //Feeding On The Fallen
        Story.KillQuest(2668, "falguard", new[] { "Chaonslaught Warrior", "Chaonslaught Cavalry" });

        //Special Delivery
        Story.MapItemQuest(2669, "falguard", 1629);

        //Precious Scraps
        Story.KillQuest(2670, "falguard", "Chaonslaught Warrior|Chaonslaught Cavalry");

        //Restocking
        Story.MapItemQuest(2671, "falguard", 1630);

        //An Innside Job
        Story.MapItemQuest(2672, "falguard", 1631);

        //Streets Run Red
        Story.KillQuest(2673, "falguard", "Chaonslaught Caster");

        //Open the Temple
        Story.MapItemQuest(2674, "falguard", 1632);

        //The Open Temple
        Story.KillQuest(2675, "falguard", "Primarch");

        //Remains
        Story.KillQuest(2720, "deathpits", "Rotting Darkblood");

        //Thriving In Rot
        Story.MapItemQuest(2721, "deathpits", 1691, 5);

        //Rotting Ribs
        Story.KillQuest(2722, "deathpits", "Rotting Darkblood");

        //A Perfect Skull
        Story.KillQuest(2723, "deathpits", "Rotting Darkblood");

        //Deeper Into Death
        Story.KillQuest(2724, "deathpits", "Ghastly Darkblood");

        //Precise Placement
        Story.KillQuest(2725, "deathpits", "Ghastly Darkblood");

        //Painted Protection
        Story.MapItemQuest(2726, "deathpits", 1692, 6);

        //They Sense You
        Story.KillQuest(2727, "deathpits", "Rotting Darkblood");

        //They Hate You
        Story.KillQuest(2728, "deathpits", "Ghastly Darkblood");

        //The Sundered
        Story.KillQuest(2729, "deathpits", "Sundered Darkblood");

        //Rotstone
        Story.MapItemQuest(2730, "deathpits", 1693, 9);

        //Honor The Dead
        Story.KillQuest(2731, "deathpits", new[] { "Sundered Darkblood", "Ghastly Darkblood", "Rotting Darkblood" });

        //Ties to Life
        Story.MapItemQuest(2732, "deathpits", 1694, 12);

        //Destroy Wrathful Vestis and Secure The Tears
        Story.KillQuest(2740, "deathpits", "Wrathful Vestis");
        Story.MapItemQuest(2740, "deathpits", 1695, 1);

        //Surveillance for Sir Valence
        Story.MapItemQuest(2792, "venomvaults", 1724);

        //Well Planned Getaway
        Story.KillQuest(2793, "venomvaults", "Chaonslaught Warrior");

        //Secrets Of The Mad Prince
        Story.MapItemQuest(2794, "venomvaults", 1725);

        //Potion of Cleansing
        Story.MapItemQuest(2796, "venomvaults", 1726);

        //You've Been Noticed
        Story.KillQuest(2797, "venomvaults", "Chaonslaught Caster");

        //Thorny Situations
        Story.MapItemQuest(2798, "venomvaults", 1727, 5);

        //Other Ingredients
        Story.KillQuest(2799, "venomvaults", "Chaonslaught Caster");

        //Time For Supplies
        Story.KillQuest(2800, "venomvaults", "Chaonslaught Warrior");

        //Cooking Without Fire
        Story.KillQuest(2801, "venomvaults", "Chaonslaught Caster|Chaonslaught Warrior");

        //Introduction
        Story.MapItemQuest(2802, "venomvaults", 1728, 3);

        //Courtyard Key
        Story.KillQuest(2803, "venomvaults", "Chaonslaught Caster|Chaonslaught Warrior");

        //Take Out The Chaos Manticore!
        Story.KillQuest(2804, "venomvaults", "Manticore");

        //Shocking Footwear
        Story.MapItemQuest(2805, "stormtemple", 1729, 4);

        //New Shoes
        Story.KillQuest(2806, "stormtemple", "Chaonslaught Warrior");

        //Mouth Of The Lion
        Story.KillQuest(2807, "stormtemple", "Chaonslaught Caster|Chaonslaught Warrior|Chaonslaught Cavalry");

        //Storm the Storm Temple
        Story.KillQuest(2808, "stormtemple", "Chaonslaught Caster|Chaonslaught Warrior|Chaonslaught Cavalry");

        //A High Minded Matter
        Story.MapItemQuest(2809, "stormtemple", 1730, 3);

        //Storm Bottles
        Story.KillQuest(2810, "stormtemple", "Chaonslaught Caster");

        //Breaching Defenses
        Story.MapItemQuest(2811, "stormtemple", 1731);

        //Chaos Lightning Rods
        Story.KillQuest(2812, "MastormtemplepName", "Chaonslaught Cavalry");

        //Barrier Buster
        Story.MapItemQuest(2813, "stormtemple", 1732);

        //Face Chaos Lord Lionfang!
        Story.KillQuest(2814, "stormtemple", "Chaos Lord Lionfang");
    }

    public void Xiang()
    {
        if (Story.isCompletedBefore(3189))
            return;

        Core.AddDrop("Perfect Prism", "Unchaorrupted Sample", "Harpy Feather");

        //Bright Idea
        Story.MapItemQuest(2909, "battleoff", 1779);

        //Spare Parts
        Story.MapItemQuest(2910, "battleoff", 1780, 8);

        //Power It Uo
        Story.KillQuest(2911, "battleoff", "Evil Moglin");

        //Filthy Creatures
        Story.KillQuest(2912, "battleoff", "Evil Moglin");

        //Wave After Wave
        Story.KillQuest(2913, "brightfall", "Undead Minion");

        //Take out Their Firepower
        Story.KillQuest(2914, "brightfall", "Undead Mage");

        //Help Where It is Needed
        Story.MapItemQuest(2915, "brightfall", 1781, 6);

        //Bring A Ward To A Swordfight
        Story.MapItemQuest(2916, "brightfall", 1782, 8);

        //Cut Off The Head
        Story.KillQuest(2917, "brightfall", "Painadin Overlord");

        //Rearm The Legion of Light
        Core.Join("overworld");
        Story.ChainQuest(2918);

        //Speak to Dage The Good
        Story.KillQuest(2919, "overworld", "Undead Minion");

        //Free Their Souls
        Story.KillQuest(2920, "overworld", "Undead Minion");

        //One Ring
        Story.KillQuest(2921, "overworld", "Undead Minion");

        //Severing Ties
        Story.KillQuest(2922, "overworld", "Undead Mage");

        //Legion's Lifesblood
        Story.MapItemQuest(2923, "overworld", 1800, 6);

        //Legion's Purpose
        Story.KillQuest(2924, "overworld", "Undead Bruiser");

        //What's His Endgame
        Story.KillQuest(2925, "overworld", "Undead Bruiser");

        //A Stopping Block
        Story.KillQuest(2926, "overworld", "Undead Minion|Undead Mage|Undead Bruiser");

        //Boost Morale
        Story.MapItemQuest(2927, "overworld", 1801, 8);

        //Alteon's Folly
        Story.KillQuest(2928, "overworld", "Undead Minion|Undead Mage|Undead Bruiser");

        //DoomFire
        Story.KillQuest(2929, "overworld", "Undead Minion|Undead Mage|Undead Bruiser");

        //Spoiled Souls
        Story.KillQuest(2930, "overworld", "Undead Minion|Undead Mage|Undead Bruiser");

        //Purity of Bone
        Story.MapItemQuest(2931, "overworld", 1802, 10);

        //Undead Artix Returns!
        Story.KillQuest(2932, "overworld", "Undead Artix");

        //I Can't Touch This
        Story.KillQuest(3166, "reddeath", "Fire Leech|Grim Widow|Reddeath Moglin|Swamp Wraith");

        //Nope, Still a Ghost
        Story.KillQuest(3167, "reddeath", "Reddeath Moglin");
        Story.MapItemQuest(3167, "reddeath", 2178);
        Story.MapItemQuest(3167, "reddeath", 2179);

        //First We Need a Beacon...
        Story.MapItemQuest(3168, "reddeath", 2180);

        //Light It Up
        Story.KillQuest(3169, "reddeath", "Fire Leech");

        //...Next We need a Trap
        Story.KillQuest(3170, "reddeath", "Grim Widow");

        //For Spirits, Not People
        Story.KillQuest(3171, "reddeath", "Swamp Wraith");

        //Still To Fragile
        Story.KillQuest(3172, "reddeath", "Swamp Wraith");

        //Craft a Better Defense
        Story.MapItemQuest(3183, "battleontown", 2203);

        if (!Story.QuestProgression(3187))
        {
            Core.AddDrop("Perfect Prism", "Unchaorrupted Sample", "Harpy Feather");
            Core.EnsureAccept(3187);

            //Reflect the Damage
            Story.KillQuest(3184, "earthstorm", "Shard Spinner");
            while (!Core.CheckInventory("Perfect Prism"))
            {
                Core.EnsureAccept(3184);
                Core.HuntMonster("earthstorm", "Shard Spinner", "Reflective Fragment", 5);
                Core.EnsureComplete(3184);
                Bot.Wait.ForDrop("Perfect Prism");
            }

            //Pure Chaos
            Story.KillQuest(3185, "bloodtuskwar", "Chaotic Horcboar");
            while (!Core.CheckInventory("Unchaorrupted Sample"))
            {
                Core.EnsureAccept(3185);
                Core.HuntMonster("bloodtuskwar", "Chaotic Horcboar", "Vials of Blood", 5);
                Core.EnsureComplete(3185);
                Bot.Wait.ForDrop("Unchaorrupted Sample");
            }

            //Enemies of a Feather Flock Together
            Story.KillQuest(3186, "bloodtuskwar", "Chaos Tigriff");
            while (!Core.CheckInventory("Harpy Feather"))
            {
                Core.EnsureAccept(3186);
                Core.HuntMonster("bloodtuskwar", "Chaos Tigriff", "Feathers", 5);
                Core.EnsureComplete(3186);
                Bot.Wait.ForDrop("Harpy Feather");
            }

            //Ward Off the Beast
            Core.Join("mirrorportal");
            Core.EnsureComplete(3187);
        }

        //Horror Takes Flight
        Story.KillQuest(3188, "mirrorportal", "Chaos Harpy");

        //Good, Evil and Chaos Battle!]
        if (!Story.QuestProgression(3189))
        {
            if (Core.CheckInventory("Void Highlord"))
            {
                Bot.Skills.StartAdvanced("Void Highlord", true, RBot.Skills.ClassUseMode.Def);
                Story.KillQuest(3189, "mirrorportal", "Chaos Lord Xiang");
            }
            else
            if (Core.CheckInventory("Healer"))
            {
                Bot.Skills.StartAdvanced("Healer", true, RBot.Skills.ClassUseMode.Base);
                Story.KillQuest(3189, "mirrorportal", "Chaos Lord Xiang");
            }
            else
                Story.KillQuest(3189, "mirrorportal", "Chaos Lord Xiang");
        }
    }

    public void Alteon()
    {
        if (Story.isCompletedBefore(3160))
            return;

        //Bandit Bounty
        Story.KillQuest(3077, "archives", "Chaos Bandit");

        //Thwarting the Spies
        Story.KillQuest(3078, "archives", "Camouflaged Sp-Eye");

        //Fight Chaos With Clerics
        Story.KillQuest(3079, "archives", new[] { "Chaos Bandit", "Camouflaged Sp-Eye" });

        //Locate the Source
        Story.KillQuest(3080, "archives", "Chaos Bandit|Camouflaged Sp-Eye");
        Story.MapItemQuest(3080, "archives", 1937);

        //Plagued Rats
        Story.KillQuest(3081, "archives", "Chaos Rat");

        //Nope, Nope, Nope!
        Story.KillQuest(3082, "archives", "Chaos Spider");

        //Still More Research To Be Done!
        Story.KillQuest(3083, "archives", new[] { "Chaos Spider", "Chaos Rat" });

        //That's One Big Sludgebeast.
        Story.KillQuest(3084, "archives", "Sludgelord");

        //Back to Jail With You!
        Story.KillQuest(3094, "armory", "Chaorrupted Prisoner");

        //We May Need A Militia
        Story.KillQuest(3095, "armory", "Chaorrupted Prisoner");
        Story.MapItemQuest(3095, "armory", 1956, 4);

        //An Ounce Of Prevention
        Story.KillQuest(3096, "armory", "Chaos Drifter");

        //Axe Them To Leave! / Freeze 'Em Out! / Burn 'Em Up!
        Story.KillQuest(3096, "armory", "Chaorrupted Prisoner");

        //Freeze 'Em Out!
        Story.KillQuest(3090, "armory", "Chaos Mage");

        //Burn 'Em Up!
        Story.KillQuest(3091, "armory", "Chaos Mage");

        //Under Siege
        Story.MapItemQuest(3092, "armory", 1957);

        //No, NOW We're Under Siege
        Story.KillQuest(3093, "armory", "Chaos General");

        //Chaos Not Invited
        Story.KillQuest(3120, "ceremony", "Chaos Invader");

        //Better Letter Go!
        Story.MapItemQuest(3121, "yulgar", 2108);
        Story.MapItemQuest(3121, "yulgar", 2109);
        Story.MapItemQuest(3121, "yulgar", 2110);
        Story.MapItemQuest(3121, "archives", 2111);
        Story.MapItemQuest(3121, "swordhaven", 2112);
        Story.MapItemQuest(3121, "swordhaven", 2113);
        Story.MapItemQuest(3121, "swordhaven", 2114);
        Story.MapItemQuest(3121, "swordhaven", 2115);

        //Decor Rater
        Story.MapItemQuest(3122, "swordhaven", 2116, 8);

        //Cold Feet, Warm Heart
        Story.KillQuest(3123, "mafic", "Living Fire");

        //Chaos STILL Not Invited
        Story.KillQuest(3124, "ceremony", "Chaos Invader");

        //Protect the Princesses
        Story.MapItemQuest(3125, "ceremony", 2118, 6);

        //Seal the Chapel
        Story.MapItemQuest(3126, "ceremony", 2119);
        Story.KillQuest(3126, "ceremony", "Chaos Invader");

        //Chaos Kills!
        Story.KillQuest(3127, "ceremony", "Chaos Justicar");

        //Endless Aisle of Chaos
        Story.MapItemQuest(3133, "chaosaltar", 2127, 12);

        //Save the Princess... Again!
        Story.KillQuest(3134, "chaosaltar", "Princess Thrall");

        //Chaos Dragon Confrontation
        Story.KillQuest(3158, "castleroof", "Chaos Dragon");

        //To Catch a King
        Story.MapItemQuest(3159, "swordhavenfalls", 2158);

        //Chaos Lord Alteon
        Story.KillQuest(3160, "swordhavenfalls", "Chaos Lord Alteon");
    }

    public void Hero()
    {
        Core.BuyItem(Bot.Map.Name, 993, "Lore's Champion Daggers");
        if (Core.CheckInventory("Lore's Champion Daggers", toInv: false))
        {
            Bot.Sleep(Core.ActionDelay);
            Core.ToBank("Lore's Champion Daggers");
            Core.Logger($"Chapter: \"Chaos Lord {Bot.Player.Username}\" already complete. Skipping");
            return;
        }

        if (!Core.IsMember)
        {
            Prologue();
            Escherion();
            Vath();
            Kitsune();
            Wolfwing();
            Kimberly();
            Ledgermayne();
            Tibicenas();
            KhasaandaHorc();
            Iadoa();
            Lionfang();
            Xiang();
            Alteon();
        }

        //12 Lords of Chaos
        Story.ChainQuest(3578);

        // Prologue: Good vs Evil
        Story.ChainQuest(3579);

        // 1st Lord of Chaos
        Story.ChainQuest(3580);

        // 3rd Lord of Chaos
        Story.ChainQuest(3581);

        // 4th Lord of Chaos
        Story.ChainQuest(3582);

        // 5th Lord of Chaos
        Story.ChainQuest(3583);

        // 6th Lord of Chaos
        Story.ChainQuest(3584);

        // 7th Lord of Chaos
        Story.ChainQuest(3585);

        // 8th Lord of Chaos
        Story.ChainQuest(3586);

        // 9th Lord of Chaos
        Story.ChainQuest(3587);

        // 10th Lord of Chaos
        Story.ChainQuest(3588);

        // 11th Lord of Chaos
        Story.ChainQuest(3589);

        // 2nd Lord of Chaos
        Story.ChainQuest(3590);

        // 12th Lord of Chaos
        Story.ChainQuest(3591);

        // Mountain Top Reached
        Story.ChainQuest(3764);

        // Drakath Faced
        Story.MapItemQuest(3765, "mountdoomskull", 2726);

        // Who is the 13th Lord of Chaos?
        Story.ChainQuest(3766);

        // World War Lore!
        Story.ChainQuest(3779);

        // Battle for Chaos in Willowcreek!
        Story.KillQuest(3781, "newfinale", "Chaos Healer");

        // Defeat the Chaos Challenger
        Story.KillQuest(3788, "newfinale", "Chaos Challenger");

        // Battle for Chaos in Doomwood!
        Story.KillQuest(3783, "newfinale", "Chaotic Virago|Chaorrupted Healer|");

        // Beat Chaorrupted Lycan Hunter
        Story.KillQuest(3789, "newfinale", "Chaorrupted Lycan Hunter");

        // Battle for Chaos in Darkovia!
        Story.KillQuest(3785, "newfinale", "Shadow Slayer|Chaorrupted Healer|Mana Blaster");

        // Defeat the Memory of Vampires
        Story.KillQuest(3790, "newfinale", "Memory of Vampires");

        // Battle for Chaos in the Lair!
        Story.KillQuest(3787, "newfinale", "Chaotic Virago|Chaos Draconian|Chaos Crystal");

        // 1st Chaos Beast
        Story.ChainQuest(3608);

        // 2nd Chaos Beast
        Story.ChainQuest(3618);

        // 3rd Chaos Beast
        Story.ChainQuest(3609);

        // 4th Chaos Beast
        Story.ChainQuest(3610);

        // 5th Chaos Beast
        Story.ChainQuest(3611);

        // 6th Chaos Beast
        Story.ChainQuest(3612);

        // 7th Chaos Beast
        Story.ChainQuest(3613);

        // 8th Chaos Beast
        Story.ChainQuest(3614);

        // 9th Chaos Beast
        Story.ChainQuest(3615);

        // 10th Chaos Beast
        Story.ChainQuest(3616);

        // 11th Chaos Beast
        Story.ChainQuest(3617);

        // 12th Chaos Beast
        Story.ChainQuest(3619);

        //The Chaos Beast is called forth.
        Story.ChainQuest(3791);

        // Time to save Battleon!
        Story.ChainQuest(3792);

        // Battle for Chaos in Battleon!
        Story.KillQuest(3794, "newfinale", "Alliance Soldier");

        //Become a Chaos Lord
        Core.Join("newfinale", "NPC2", "Left");
        Core.SendPackets("%xt%zm%setAchievement%15075%ia1%20%1%");

        // Battle the Champion of Chaos!
        Story.MapItemQuest(3795, "drakathfight", 2894);

        // REUSE
        Story.KillQuest(3620, "shadowrise", "Broken Bones|Darkness Elemental|Dry Ice Mage");

        // Search for Death's Lair
        Story.MapItemQuest(3796, "shadowrise", 2895);

        // Arrive in Shadowattack
        Story.ChainQuest(3797);

        // Find your way to Death's lair
        Story.MapItemQuest(3798, "shadowattack", 2896);

        // Beat Death!
        Story.KillQuest(3799, "shadowattack", "Death");

        // Enter Confrontation
        Core.Join("confrontation");
        Story.ChainQuest(3875);

        // Defeat Drakath!
        if (!Story.QuestProgression(3876))
        {
            Core.EnsureAccept(3876);
            Core.KillMonster("finalbattle", "r1", "Right", "Drakath", "Drakath Defeated");
            Core.EnsureComplete(3876);
        }

        // Defeat Drakath... again!
        if (!Story.QuestProgression(3877))
        {
            Core.EnsureAccept(3877);
            Core.KillMonster("finalbattle", "r1", "Right", "Drakath", "Drakath Defeated");
            Core.EnsureComplete(3877);
        }

        // Defeat Drakath!
        if (!Story.QuestProgression(3878))
        {
            Core.EnsureAccept(3878);
            Core.KillMonster("finalbattle", "r9", "Right", "Drakath", "Drakath Defeated");
            Core.EnsureComplete(3878);
        }

        // Defeat the 12 Lords of Chaos!
        Story.KillQuest(3879, "chaosrealm", "Alteon");

        // Defeat the 13th Lord of Chaos
        Story.KillQuest(3880, "chaoslord", "*");

        // The Final Showdown!
        Story.KillQuest(3881, "finalshowdown", "Prince Drakath");

        Core.Relogin();
        Core.BuyItem(Bot.Map.Name, 948, "Lore's Champion Daggers");
        Bot.Sleep(Core.ActionDelay);
        Core.ToBank("Lore's Champion Daggers");
    }

    public void Extra()
    {
        if (Story.QuestProgression(3824))
            return;

        //Arrive in DreadHaven
        Story.ChainQuest(3812);

        //Kill SlugWrath in Dreadhaven
        Story.ChainQuest(3813);

        //Kill Bandit Drakath in Dreadhaven
        Story.ChainQuest(3814);

        //Up the Mountain
        Story.KillQuest(3815, "falcontower", "Lady Knight|Sir Knight");

        //Higher Up
        Story.KillQuest(3816, "falcontower", "Lady Knight|Sir Knight");

        //Even Higher
        Story.KillQuest(3817, "falcontower", "Lady Knight|Sir Knight");

        //Falconreach Tower
        Story.KillQuest(3818, "falcontower", "Lady Knight|Sir Knight");

        //Climb the Tower
        Story.KillQuest(3819, "falcontower", "Lady Knight|Sir Knight");

        //To the Dragonlord
        Story.KillQuest(3820, "falcontower", "Lady Knight|Sir Knight");

        //Defeat the Dragonlord
        Story.KillQuest(3821, "falcontower", "DragonLord");

        //Defeat Dragon Drakath
        Story.KillQuest(3822, "falcontower", "Dragon Drakath");

        //Defeat Sepulchure
        Story.KillQuest(3823, "falcontower", "Sepulchure");

        //Defeat Alteon
        Story.KillQuest(3824, "falcontower", "Alteon");
    }

}