using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Market
{
    class DataManager
    {
        public static List<User> Users = new List<User>();
        public static List<Post> Posts = new List<Post>();
        public static List<Purchase> Purchases = new List<Purchase>();
        public static List<Like> Likes = new List<Like>();
        public static List<Message> Messages = new List<Message>();
        public static User LoginUser;
        static DataManager()
        {
            LoginUser = null;
            LoadData();
        }
        public static void LoadData()
        {
            
            try
            {
                string usersOutput = File.ReadAllText(@"Users.xml");
                XElement usersXElement = XElement.Parse(usersOutput);
                Users = (from item in usersXElement.Descendants("user")
                         select new User()
                         {
                             ID = int.Parse(item.Element("id").Value),
                             PW = int.Parse(item.Element("pw").Value),
                             Name = item.Element("name").Value,
                             Addr = item.Element("addr").Value
                         }).ToList<User>();

                string postsOutput = File.ReadAllText(@"Posts.xml");
                XElement postsXElement = XElement.Parse(postsOutput);
                Posts = (from item in postsXElement.Descendants("post")
                         select new Post()
                         {
                             ID = int.Parse(item.Element("id").Value),
                             Title = item.Element("title").Value,
                             Content = item.Element("content").Value,
                             Imageurl = item.Element("imageurl").Value,
                             Price = item.Element("price").Value,
                             Stock = int.Parse(item.Element("stock").Value)
                         }).ToList<Post>();

                string purchasesOutput = File.ReadAllText(@"Purchases.xml");
                XElement purchasesXElement = XElement.Parse(purchasesOutput);
                Purchases = (from item in purchasesXElement.Descendants("purchase")
                             select new Purchase()
                             {
                                 ID = int.Parse(item.Element("id").Value),
                                 UID = int.Parse(item.Element("uid").Value),
                                 PID = int.Parse(item.Element("pid").Value)

                             }).ToList<Purchase>();

                string likesOutput = File.ReadAllText(@"Likes.xml");
                XElement likesXElement = XElement.Parse(likesOutput);
                Likes = (from item in likesXElement.Descendants("like")
                         select new Like()
                         {
                             ID = int.Parse(item.Element("id").Value),
                             UID = int.Parse(item.Element("uid").Value),
                             PID = int.Parse(item.Element("pid").Value)

                         }).ToList<Like>();

                string messagesOutput = File.ReadAllText(@"Messages.xml");
                XElement messagesXElement = XElement.Parse(messagesOutput);
                Messages = (from item in messagesXElement.Descendants("message")
                            select new Message()
                            {
                                ID = int.Parse(item.Element("id").Value),
                                SenderID = int.Parse(item.Element("senderid").Value),
                                ReceiverID = int.Parse(item.Element("receiverid").Value),
                                PID = int.Parse(item.Element("pid").Value),
                                Title = item.Element("title").Value,
                                Content = item.Element("content").Value,
                                Time = item.Element("time").Value
                            }).ToList<Message>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        public static void Save()
        {
            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach (var item in Users)
            {
                usersOutput += "<user>\n";
                usersOutput += "  <id>" + item.ID + "</id>\n";
                usersOutput += "  <pw>" + item.PW + "</pw>\n";
                usersOutput += "  <name>" + item.Name + "</name>\n";
                usersOutput += "  <addr>" + item.Addr + "</addr>\n";
                usersOutput += "</user>\n";
            }
            usersOutput += "</users>";

            string postsOutput = "";
            postsOutput += "<posts>\n";
            foreach (var item in Posts)
            {
                postsOutput += "<post>\n";
                postsOutput += "  <id>" + item.ID + "</id>\n";
                postsOutput += "  <title>" + item.Title + "</title>\n";
                postsOutput += "  <price>" + item.Price + "</price>\n";
                postsOutput += "  <content>" + item.Content + "</content>\n";
                postsOutput += "  <imageurl>" + item.Imageurl + "</imageurl>\n";
                postsOutput += "  <stock>" + item.Stock + "</stock>\n";
                postsOutput += "</post>\n";
            }
            postsOutput += "</posts>";

            string purchasesOutput = "";
            purchasesOutput += "<purchases>\n";
            foreach (var item in Purchases)
            {
                purchasesOutput += "<purchase>\n";
                purchasesOutput += "  <id>" + item.ID + "</id>\n";
                purchasesOutput += "  <uid>" + item.UID + "</uid>\n";
                purchasesOutput += "  <pid>" + item.PID + "</pid>\n";
                purchasesOutput += "</purchase>\n";
            }
            purchasesOutput += "</purchases>";

            string likesOutput = "";
            likesOutput += "<likes>\n";
            foreach (var item in Likes)
            {
                likesOutput += "<like>\n";
                likesOutput += "  <id>" + item.ID + "</id>\n";
                likesOutput += "  <uid>" + item.UID + "</uid>\n";
                likesOutput += "  <pid>" + item.PID + "</pid>\n";
                likesOutput += "</like>\n";
            }
            likesOutput += "</likes>";

            string messagesOutput = "";
            messagesOutput += "<messages>\n";
            foreach (var item in Messages)
            {
                messagesOutput += "<message>\n";
                messagesOutput += "  <id>" + item.ID + "</id>\n";
                messagesOutput += "  <senderid>" + item.SenderID + "</senderid>\n";
                messagesOutput += "  <receiverid>" + item.ReceiverID + "</receiverid>\n";
                messagesOutput += "  <pid>" + item.PID + "</pid>\n";
                messagesOutput += "  <title>" + item.Title + "</title>\n";
                messagesOutput += "  <content>" + item.Content + "</content>\n";
                messagesOutput += "  <time>" + item.Time + "</time>\n";
                messagesOutput += "</message>\n";
            }
            messagesOutput += "</messages>";

            // 저장
            File.WriteAllText(@"Posts.xml", postsOutput);
            File.WriteAllText(@"Users.xml", usersOutput);
            File.WriteAllText(@"Purchases.xml", purchasesOutput);
            File.WriteAllText(@"Likes.xml", likesOutput);
            File.WriteAllText(@"Messages.xml", messagesOutput);
        }
    }

}
