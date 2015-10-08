using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class HelperData
    {

        #region Name Data

        #region FirstNames
        public static List<string> lstFirstNames = new List<string>(StringArrays.FirstNames);
        #endregion FirstNames

        #region LastNames
        public static List<string> lstLastNames = new List<string>(StringArrays.LastNames);
        #endregion LastNames

        #endregion Name Data

        #region Address Data

        // US states and territories for populating a drop-down list
        public Dictionary<string, int> States = new Dictionary<string, int>
        {
            {"AA",1},{"AE",2},{"AK",3},{"AL",4},{"AP",5},{"AR",6},{"AS",7},{"AZ",8},{"CA",9},{"CO",10},{"CT",11},{"DC",12},{"DE",13},{"FL",14},{"GA",15},{"GU",16},{"HI",17},{"IA",18},{"ID",19},{"IL",20},{"IN",21},{"KS",22},{"KY",23},{"LA",24},{"MA",25},{"MD",26},{"ME",27},{"MI",28},{"MN",29},{"MO",30},{"MP",31},{"MS",32},{"MT",33},{"NC",34},{"ND",35},{"NE",36},{"NH",37},{"NJ",38},{"NM",39},{"NV",40},{"NY",41},{"OH",42},{"OK",43},{"OR",44},{"PA",45},{"PR",46},{"RI",47},{"SC",48},{"SD",49},{"TN",50},{"TX",51},{"UT",52},{"VA",53},{"VI",54},{"VT",55},{"WA",56},{"WI",57},{"WV",58},{"WY",59}
        };

        #region StreetAddresses

        public static List<string> lstDirection = new List<string>(StringArrays.Directions);

        public static List<string> lstStreet = new List<string>(StringArrays.Streets);

        public static List<string> lstFormat = new List<string>(StringArrays.Formats);

        #endregion StreetAddress

        #region Cities

        public static List<string> lstCities = new List<string>(StringArrays.Cities);

        #endregion Cities

        #region States

        public static List<string> lstStates = new List<string>(StringArrays.States);

        #endregion States

        #endregion Address Data

        #region Demographic Data

        #region Ethnic Group Long Description

        public static List<string> lstEthnicGroupLD = new List<string>(StringArrays.EthnicGroupLD);

        #endregion Ethnic Group LD

        #region Gender Codes

        public static List<string> lstGenderCodes = new List<string>(StringArrays.GenderCodes);

        #endregion Gender Codes

        #region Marital Stati

        public static List<string> lstMaritalStati = new List<string>(StringArrays.MaritalStati);

        #endregion Marital Stati

        #endregion Demographic Data
    }

    internal class StringArrays
    {
        #region Names

        #region Combined
        public static string[] FirstNames =
            {
                "Abihud", "Adrian", "Aelfred", "Aeowynn", "Agamous", "Agatha", "Agonous", "Ainsley", "Alejandro",
                "Alessandra", "Alfonso", "Alfredo", "Aloysius", "Amelia", "Anakin", "Anastasia", "Anders", "Andreas",
                "Annelisse", "Armando", "Athanasius", "Attila", "Augustine",
                "Balthazar", "Bartholomew", "Beltashazzar", "Bob", "Boris", "Bradford", "Breanna", "Bronson", "Bronwynn"
                , "Bruce", "Bruton",
                "Caleb", "Caligula", "Calvin", "Cameron", "Candace", "Captain", "Carissa", "Celeste", "Charisse",
                "Charity", "Chastity", "Chartreuse", "Chauncey", "Chaz", "Chelsea", "Chesterfield", "Cheswick",
                "Chocolate", "Clementine", "Colby", "Colonel", "Constantine", "Coward", "Cut-purse",
                "Dakota", "David", "Demetrius", "Deon", "Desmond", "Django", "Dmitriy",
                "Eaton", "Ebenezer", "Ekaterina", "Eliza", "Elvira", "Elvis", "Enrique", "Erasmus", "Esau", "Esmerelda", "Esteban",
                "Eusebius", "Evegeniya", "Ezekiel",
                "Fabien", "Fabio", "Faisal", "Fatima", "Felix", "Festivus", "Festus", "Finical", "Floyd", "Fortunatus",
                "Franz-Josef", "Fusty",
                "Galileo", "Gamaliel", "Garett", "Gaspar", "Gaston", "Georgette", "Gertrude", "Ghee",
                "Gilgamesh", "Gisela", "Goldie", "Goose", "Greedo", "Greta", "Grimace", "Griselda", "Guadelupe",
                "Gustavo", "Günther",
                "Habakkuk", "Hadassah", "Hades", "Haggai", "Hananiah", "Hezekiah", "Hilkiah", "Hiram", "Horatio",
                "Hosanna",
                "Iago", "Ian", "Ichabod", "Ignatius", "Iliana", "Indiana", "Indira", "Inga", "Ingrid", "Isabeau",
                "Isabella", "Ishmael", "Isolde", "Ivanna",
                "Jack", "Jade", "Jael", "Jagdeesh", "Jamal", "Jamison", "Janelle", "Jarvis", "Jasmine", "Jasper",
                "Jaspreet", "Javier", "Jazz", "Jean-Paul", "Jedediah", "Jefferson", "Jehoshaphat", "Jehu", "Jeremiah",
                "Jermaine", "Jesse", "Jezebel", "Jillian", "Joab", "Jocelyn", "Joelle", "Johann", "Johnny", "Joshua",
                "Joy", "Joyel", "Juan Pablo", "Julianna", "Juliette", "Julius", "June", "Jupiter", "Jürgen", "Justimus",
                "Justo", "Justus",
                "Kakashi", "Kalel", "Karthika", "Kassandra", "Katelyn", "Katja", "Katya", "Kayla", "Kelly", "Kendall",
                "Kennedy", "Keturah", "Kiera",
                "Lando", "Landon", "Laralee", "Lateesha", "Lavender", "Leia", "Liliana", "Lincoln", "Ljubljana",
                "Lucinda", "Lucretia", "Ludmilla", "Ludwig", "Luke", "Lukasz",
                "Mabeline", "Maeve", "Maher-shalal-hash-baz", "Majed", "Manfred", "Mansour", "Marcel", "Margaret",
                "Matthias", "Maverick", "Mei-li", "Melikalikimaka", "Merriwether", "Methuselah", "Minerva", "Miriam",
                "Murderous",
                "Naamah", "Nadab", "Nahaliel", "Nahath", "Nahum", "Natalie", "Natasha", "Nathaniel", "Naveen",
                "Nebuchadnezzar", "Nebuzaradan", "Nehemiah", "Nicodemas", "Nikolina", "Noah", "Noelle",
                "Obadiah", "Obed", "Onesimus", "Ophrah", "Orlando", "Ottavia", "Ovaltine",
                "Paddy", "Padme", "Paola", "Paolo", "Pascal", "Patsy", "Patty", "Patty", "Paulina", "Pavel", "Payson",
                "Penelope", "Penny", "Pete", "Porsha", "Preethi", "Preston", "Prisca", "Priscilla",
                "Quentin", "Quincy", "Quirinius",
                "Raja", "Rajiv", "Randall", "Randy", "Raphael", "Rapunzel", "Raul", "Raymond", "Reba", "Rebekah",
                "Reginald", "Renata", "Rex", "Rhet", "Richard", "Rigo", "Ringo", "Romeo", "Ronaldo", "Rosalind",
                "Rosemary", "Rufus", "Rumpelstiltskin", "Rusty",
                "Sabine", "Sabrina", "Sadie", "Salazar", "Sallyann", "Samantha", "Santina", "Santonio", "Sargeant",
                "Scurvy", "Selena", "Seth", "Shamus", "Shane", "Sherlock", "Sheva", "Sid", "Sidney", "Sisyphus", "Sonny"
                , "Srinivas", "Starveling", "Stavros", "Stratton", "Stuart", "Suzie", "Sven", "Swaggering",
                "Tangus", "Tanner", "Tanya", "Terrance", "Thaddeus", "Thatcher", "Theeling", "Theophilus", "Therousia",
                "Thomas", "Thor", "Trapezius", "Trevor", "Tsipi", "Tsiporah", "Tristan", "Trudy",
                "Uriah", "Ursula", "Uzziah", "Uzziel",
                "Valenzuela", "Valkyrie", "Vashti", "Vitaliy", "Vito", "Vladimir",
                "Wellington", "Winston", "Wyndham",
                "Xavier", "Xerxes", "Xian",
                "Yakob", "Yaroslav", "Yasmine", "Yochanan", "Yohanan", "Yosef", "Yowza", "Yu",
                "Zacchaeus", "Zaccheus", "Zachary", "Zadok", "Zander", "Zarathustra", "Zarephath", "Zebadiah",
                "Zechariah", "Zedekiah", "Zephaniah", "Zerubbabel", "Zhao", "Ziklag", "Zimri", "Zipporah", "Zoe",
                "Zophar", "Zsa Zsa"
            };

        #endregion Combined

        public static string[] LastNames =
            {
                "Abderian", "Abnormous", "Accipitrine", "Accoucheur", "Acosmist", "Acouasm", "Acoucheuse",
                "Acrocephalic", "Adiobalist", "Aeolist", "Aflunters", "Agroof", "Alameda", "Altiloquent", "Alvarez",
                "Anthropoglot", "Applecrisp", "Apostrophe", "Arctophilist", "Armitraj", "Aurophobe", "Avetrol",
                "Bacillophobe", "Bachelor", "Badot", "Baffoon","Baggins", "Baker", "Ballicatter", "Banichek", "Barnes",
                "Barnfather", "Bearclaw", "Belching", "Bleeth", "Boatswain", "Bono", "Boondoggle","Brandybuck","Bratislava",
                "Buttersnaps",
                "Callowitz", "Calrissian", "Canker-Blossom", "Catastrophe", "Chaps", "Chatterly", "Chupacabra",
                "Cityslicker", "Clamorous", "Clandestine", "Clap Yo Handz", "Clarendon", "Cobbler", "Connery",
                "Copperfield", "Cranmer", "Cuttle",
                "De Jong", "De Vries", "Disher", "Doolittle", "Dowager", "Downton", "Dunderton",
                "Eckelstein", "Einstein", "Emmentaler", "Epstein",
                "Farmboy", "Feldspar", "Fett", "Fogbottom", "Fustilarion",
                "Gingersnaps", "Giovanni", "Giovannini", "Gleason", "Grinswide", "Grommit", "Guster", "Guttersnype",
                "Habit", "Hackysack", "Halitosis", "Harmonica", "Hasenpfeffer", "Hauer", "Haversham", "Himmelsteiger",
                "Hollabackatcha", "Holmes", "Holschtein", "Hooligan", "Hornblower",
                "Indahouse", "In-the-Woods",
                "James", "Jingleheimer-Schmidt", "Jones",
                "Kamehameha", "Kim", "Klein", "Klicketyclack", "Klinker", "Knave", "Koesler",
                "Lao", "Latimer", "Lee", "Levitz", "Lithpy",
                "MacIntosh", "Malmquist", "Mayflower", "McGee", "McToc...", "Middleton", "Mongrel", "Monk", "Moody",
                "Mullarky", "Mumford", "Munroe",
                "Narcissus", "Nash", "Nickerbacher", "Nimrod",
                "oaf", "O'Malley", "O'Reilly",
                "Pennywhistle", "Peppercorn", "Pernicious", "Poepjes", "Poppycock",
                "Raintree", "Rampallion", "Rascal", "Rejoice", "Richmond", "Ridley", "Robinson", "Romanoff", "Rotmensen",
                "Sandoval", "Sandwalker", "Scoundrel", "Scrooge", "Scullion", "Shivers", "Singleton", "Skubalon",
                "Skywalker", "Sluggard", "Solo", "Soupdribbler", "Spaans", "Spencer", "Stewart", "Stinkard",
                "Stottelmeyer", "Swashbuckler",
                "Teeger", "Thistleton", "Torvalds", "Triumphant", "Troutslayer",
                "Van Helsing", "Vicious", "Vile", "Von Richtofen",
                "Whistlewhetter", "Whittlebury", "Wildebeest", "Williams", "Winebibber", "Wiseacre", "Witherspoon",
                "Yamamoto", "Yang", "Yazzie", "Yolo",
                "Zamboni", "Zeldenthuis", "Zelotes"

            };

        #endregion Names

        #region Addresses
        public static string[] Directions =
            {
                "North", "South", "East", "West", "N", "S", "E", "W"
            };

        public static string[] Streets =
            {
                "Appaloosa", "Mangrove", "Pontatoc", "Cheshire", "Cardiff", "Hollywood", "Hereford",
                "Kleindale", "Michigan", "Sunset", "Sunrise", "Moonlight", "Wuthering Heights", "Aspen",
                "Cherry Blossom", "Orange Grove", "Midnight", "Secret Passageway", "Crankshaft", "Cloverfield",
                "Moccasin", "Barracuda", "Hedgehog", "Wallaby", "Baskerville", "Pagliacci", "Valkyrie",
                "Tuscaloosa", "Jimminy Cricket", "Thundercats", "Ironside", "Prometheus", "Neptune",
                "Hantavirus", "Nick Nack", "Honeysuckle", "Beanblossom", "Mud Lick", "Coppersmith", "Prairie Dog",
                "Crawley", "Death Trap", "Large Wooden Badger", "Holy Hand Grenade", "Camelot", "Sir Bedevere",
                "Black Knight", "Lobster Trap", "Cheese Shoppe", "Bloody Peasant", "Danger", "Skullduggery",
                "Coconuts", "Indefatigable", "Partisan", "Vorpal Bunny", "Rabbit of Caerbannog", "Balsamic",
                "Thyme", "Rosemary", "Spangled Drongo", "Ruffed Grouse", "Lesser Prairie-Chicken",
                "Arctic Loon", "Flamingo", "Himalayan Snowcock", "Wandering Albatross", "Sooty Shearwater",
                "Blue-Footed Booby", "Magnificaent Frigatebird", "Great Blue Heron", "Blue-Throated Tiger Bittern",
                "Snowy Egret", "White Ibis", "Black-Crowned Night Heron", "Big Year", "Harrier", "Goshawk",
                "Swallow-Tailed Kite", "Hook-Billed Kite", "Kestrel", "Klapperschlange", "Toxic Iguana",
                "Rough-Legged Hawk", "Red-Footed Falcon", "Clapper Rail", "Corn Crake", "Eurasian Coot",
                "Whooping Crane", "European Golden Plover", "Sandpiper", "Whimbrel", "Redshank",
                "Wandering Tattler", "Jack Snipe", "Black Noddy", "Whiskered Tern", "Yellow-Bellied Sapsucker",
                "Scaly-Naped Pigeon", "Snowy Owl", "Whiskered Screech Owl", "Pygmy Owl", "Lingering Lizard",
                "Whip-poor-will", "Gray Nightjar", "Mango", "Eurasian Jackdaw", "Doting Donkey", "Hillbilly",
                "Nutcracker", "Pinyon Jay", "Fish Crow", "Blue-Winged Warbler", "Scarlet Tanager",
                "Swamp Sparrow", "Eurasian Bullfinch", "Spangled Starling", "Bearscat", "Haberdashery",
                "Wistful Wolverine", "Blistering Barnacles", "Bubbling Billabong", "Tea Tree",
                "Bay of Bengal", "Wild Goosechase", "Ugly Duckling", "Nursery Rhyme", "Luau", "Inspiration",
                "Woolly Mammoth", "Sabertoothed Squirrel", "Scarlet Pumpernickel", "Tungsten", "Dynamite"
            };

        public static string[] Formats =
            {
                "Ave", "Avenue", "Rd", "Road", "St", "Street", "Blvd", "Boulevard", "Way", "Trl", "Trail", "Cir",
                "Circle", "Pl", "Place", "Tpke", "Turnpike", "Ct", "Court", "Dr", "Drive", "Expy", "Expressway", "Route"
                , "Rte", "Freeway", "Fwy", "Junction", "Jct", "Lane", "Ln", "Pkwy", "Parkway", "Stra", "Stravenue"
            };

        public static string[] Cities =
            {
                "Clifton", "Bloomingdale", "Bloomington", "Birmingham", "Hartford", "Peoria", "Albany", "Tucson",
                "Sierra Vista",
                "Kingston", "Miami", "Avondale", "Temecula", "Winnipeg", "Whitehorse", "Santa Barbara", "Encino",
                "Newhaven",
                "Billings", "Beaumont", "Smallville", "Bruges", "Steamboat", "Calamine", "Bauxite", "Noodleville",
                "Newmarket",
                "Limedale", "Boring", "Huddleston", "Nut Plantation", "Badgerville", "Hicksville", "Pumpkin Patch",
                "Aurora",
                "Slick Rock", "Bumblebee", "Grasshopper Junction", "Monkey's Eyebrow", "Fraggle Rock", "Edelweiss",
                "Prague",
                "Loafer Springs", "Hambone", "Very Unlikely", "Eureka", "Bagdad", "Rattlesnake Bend", "Horrific Hamlet",
                "Hijinx", "Tigerlilly", "Boomerang Bluff", "Crackerville", "Silver Spur", "Square Butte", "Tomahawk",
                "Banshee Springs", "Dodge City", "Mosquitoville", "Turkey Vulture", "Tulip Town", "Bickering",
                "Gotham City",
                "Badger Bend", "Boondoggle", "Hermits Rest", "Squatterville", "Sleepy Hollow", "Belgravia", "Bangkok",
                "Croydon", "Oxford", "Colchecter", "Gloucester", "Yarmouth", "Manchester", "Chelmsford", "Bodacious",
                "Chichester", "Blackpool", "Venice", "Holland's Landing", "Redding", "Naples", "Tillamook", "Banff",
                "San Gabriel", "San Antonio", "San Fernando", "Santa Cruz", "San Diego", "Berlin", "Prince Rupert",
                "Moscow", "Murietta", "Peach Tree", "New Hampton", "Madras", "Madrid", "Twin Falls", "Athens", "Austin",
                "Happy Acres", "Pitchfork", "Black Cauldron", "Maranatha", "Milwaukee", "Munson", "Abilene", "Houston",
                "Milford", "Battle Creek", "Floodplains", "Fishbarrel", "Beartrap Springs", "Lincoln", "Chico",
                "Peekaboo Prairie",
                "Gypsy Camp", "Abandoned Mine", "Scary Woods", "Creepy Hollow", "Landslide", "Happy Valley", "Jefferson"
                ,
                "Incinerator Springs", "Trinidad", "Inferno Canyon", "Woodland Park", "Ventura", "Hoolihan's Hamlet",
                "Patagonia", "Valhalla", "Sewer City", "Bramblebush", "Golgotha", "Brambleberry", "Kayenta", "Kaibeto",
                "Buxton", "Kickapoo", "Chinle", "Silly City", "Squatting Peaks", "Banker's Burnout", "Hazzard",
                "Metropolis"
            };

        public static string[] States =
            {
                "AA", "AE", "AK", "AL", "AP", "AR", "AS", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "GU", "HI",
                "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MP", "MS", "MT", "NC",
                "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "PR", "RI", "SC", "SD", "TN", "TX",
                "UT", "VA", "VI", "VT", "WA", "WI", "WV", "WY"
            };

        #endregion Addresses

        #region Demographics
        public static string[] EthnicGroupLD =
            {
                "Unknown",
                "Not Specified",
                "Hispanic/Latino",
                "Black/African American",
                "White",
                "American Indian/Alaska Native",
                "Native Hawaiian/Oth Pac Island",
                "Asian"
            };

        public static string[] GenderCodes =
            {
                "U", // 0
                "F", // 1
                "M", // 2
                "X"  // 3
            };

        public static string[] MaritalStati =
            {
                "Unknown",          // 0
                "Single",           // 1
                "Married",          // 2
                "Divorced",         // 3
                "Separated",        // 4
                "Civil Partnership" // 5
            };

        #endregion Demographics

        #region Names

        public static string[] FemaleNames =
            {
                "Adrienne","Aeowynn","Agatha","Arwen",
                "Alessandra","Amelia","Anastasia","Andrea",
                "Angelica","Annelisse",
                "Breanna","Bronwynn","Cameron","Candace","Carissa","Celeste","Charisse",
                "Charity","Chastity","Chelsea","Clementine","Dakota",
                "Ekaterina","Eliza","Elvira","Esmerelda","Evegeniya",
                "Fatima","Galadriel","Georgette", "Gertrude","Gisela","Goldie",
                "Greta","Griselda","Guadelupe","Hadassah", "Hosanna",
                "Iliana", "India", "Indira", "Inga", "Ingrid", "Isabeau",
                "Isabella", "Isolde", "Ivanna",
                "Jade", "Jael", "Janelle", "Jasmine", 
                "Jesse", "Jezebel", "Jillian", "Jocelyn", "Joelle", "Johanna", 
                "Joy", "Joyel", "Julianna", "Juliette", "June",
                "Kassandra", "Katelyn", "Katja", "Katya", "Kayla", "Kelly", "Kendall",
                "Kennedy", "Keturah", "Kiera",
                "Laralee", "Lateesha", "Lavender", "Leia", "Liliana", "Ljubljana",
                "Lucinda", "Lucretia", "Ludmilla", 
                "Mabeline", "Maeve", "Margaret", "Marjorie",
                "Mei-li", "Melikalikimaka", "Minerva", "Miriam",
                "Murderess","Naamah", "Nadab", "Nahaliel", "Natalie", "Natasha", 
                "Nikolina", "Noelle","Ophrah", "Ottavia", 
                "Padme", "Paola", "Patsy", "Patty", "Paulina", 
                "Penelope", "Penny", "Porsha", "Preethi", "Prisca", "Priscilla",
                "Rapunzel", "Reba", "Rebekah",
                "Renata", "Rosalind", "Rosemary","Rosie","Rusty",
                "Sabine", "Sabrina", "Sadie", "Sallyann", "Samantha", "Santina", 
                "Selena", "Sheva", "Sidney", "Suzie", 
                "Tanya", "Terrance", "Theophilia", "Therousia",
                "Thomasina", "Tsipi", "Tsiporah", "Trudy",
                "Ulli", "Ursula", 
                "Valerie", "Vashti", 
                "Winona", "Wyndham",
                "Xena", "Yasmine", 
                "Zarathustra","Zipporah", "Zoe",
                "Zsa Zsa"
            };

        public static string[] MaleNames =
            {
                "Abihud","Adrian","Aelfred","Alejandro",
                "Alfonso","Alfredo","Aloysius","Anakin","Anders","Andreas",
                "Aragorn","Armando","Athanasius","Attila","Augustine",
                "Balthazar","Bartholomew","Beltashazzar","Bob","Boris","Boromir","Bradford","Bronson",
                "Bruce","Bruton",
                "Caleb","Caligula","Calvin","Cameron","Captain","Chauncey","Chesterfield","Cheswick",
                "Colby","Colonel","Constantine","Coward","Cut-purse",
                "David","Demetrius","Desmond","Django","Dmitriy",
                "Eaton","Ebenezer","Elvis","Enrique","Erasmus","Esau","Esteban","Eusebius","Ezekiel",
                "Fabien","Fabio","Faisal","Faramir","Felix","Festus","Floyd","Fortunatus",
                "Franz-Josef","Frodo","Galileo","Gamaliel","Gandalf","Garett", "Gaspar", "Gaston",
                "Gilgamesh","Gustavo", "Günther","Habakkuk","Haggai","Hananiah",
                "Hezekiah", "Hilkiah", "Hiram", "Horatio","Iago", "Ian", "Ichabod", "Ignatius",
                "Indiana","Ishmael",
                "Jack", "Jagdeesh", "Jamal", "Jamison", "Jarvis", "Jasper",
                "Jaspreet", "Javier", "Jazz", "Jean-Paul", "Jedediah", "Jefferson", "Jehoshaphat", "Jehu", "Jeremiah",
                "Jermaine", "Jesse", "Joab", "Joachim", "Johann", "Johnny", "Joshua",
                "Juan Pablo","Julius", "Jupiter", "Jürgen", "Justimus",
                "Justo", "Justus",
                "Kakashi", "Kalel", "Karthika", 
                "Lando", "Landon", "Lincoln", 
                "Ludwig", "Luke", "Lukasz",
                "Maher-shalal-hash-baz", "Majed", "Manfred", "Mansour", "Marcel",
                "Matthias", "Maverick", "Merriwether", "Methuselah", "Murderous",
                "Naamah", "Nadab", "Nahaliel", "Nahath", "Nahum", "Nathaniel", "Naveen",
                "Nebuchadnezzar", "Nebuzaradan", "Nehemiah", "Nicodemas", "Noah", 
                "Obadiah", "Obed", "Onesimus", "Orlando", "Ottavio", "Ovaltine",
                "Paddy", "Paolo", "Pascal", "Patty", "Paulina", "Pavel", "Payson",
                "Pete","Preston", 
                "Quentin", "Quincy", "Quirinius",
                "Raja", "Rajiv", "Randall", "Randy", "Raphael", "Raul", "Raymond", 
                "Reginald", "Rex", "Rhet", "Richard", "Rigo", "Ringo", "Romeo", "Ronaldo", 
                "Rufus", "Rumpelstiltskin", "Rusty",
                "Salazar", "Samwise", "Santonio", "Sargeant",
                "Scurvy", "Seth", "Shamus", "Shane", "Sherlock", "Sid", "Sidney", "Sisyphus", "Sonny", 
                "Srinivas", "Starveling", "Stavros", "Stratton", "Stuart", "Sven", "Swaggering",
                "Tangus", "Tanner", "Terrance", "Thaddeus", "Thatcher", "Theeling", "Theophilus", 
                "Thomas", "Thor", "Trapezius", "Trevor", "Tristan", "Truman",
                "Uriah", "Uzziah", "Uzziel",
                "Vitaliy", "Vito", "Vladimir",
                "Wellington", "Winston", "Wyndham",
                "Xavier", "Xerxes", "Xian",
                "Yakob", "Yaroslav", "Yochanan", "Yohanan", "Yosef", "Yu",
                "Zacchaeus", "Zaccheus", "Zachary", "Zadok", "Zander", "Zarephath", "Zebadiah",
                "Zechariah", "Zedekiah", "Zephaniah", "Zerubbabel", "Zhao", "Ziklag", "Zimri", 
                "Zophar"
            };

        public static string[] UXNames =
            {
                "Agamous","Agonous","Chartreuse","Chaz","Chocolate","Deon","Festivus",
                "Finical","Fusty","Ghee","Goose","Greedo","Grimace","Hades", "Hosanna",
                "Jade", "Jasper","Kennedy","Ovaltine","Pat", "Patsy", "Patty","Rusty","Scurvy",
                "Valkyrie", "Yowza", "Zarathustra", "Zsa Zsa" 
            };

        #endregion Names

        public static string[] TuitionResidency = { "RES", "NR" };
    }
}
