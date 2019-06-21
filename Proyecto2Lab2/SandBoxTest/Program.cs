using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace Testing
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("889439064:AAHD64nG3A-GR5YP3tDHg33aDT7ny9TxQY4");


        static void Main(string[] args)
        {



            DoIt();

        }


        public static void DoIt()
        {
            try
            {

                Console.WriteLine("Select object");
                Console.WriteLine("1. Customer");
                Console.WriteLine("2. Direction");
                Console.WriteLine("3. Communication Method");


                Console.WriteLine("Choose an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("***************************");
                        Console.WriteLine("*****     Customer   *******");
                        Console.WriteLine("***************************");

                        Client();
                        break;

                    case "2":
                        Console.WriteLine("***************************");
                        Console.WriteLine("*****  Direction   *****");
                        Console.WriteLine("***************************");

                        Direction();

                        break;
                    case "3":
                        Console.WriteLine("***************************");
                        Console.WriteLine("***** Contact Method  *****");
                        Console.WriteLine("***************************");

                        ContactMethod();

                        break;




                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("***************************");
                Console.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("***************************");
            }
            finally
            {
                Console.WriteLine("Back to main menu? Y/N");
                var moreActions = Console.ReadLine();

                if (moreActions.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                    DoIt();
            }















        }

        public static void Client()
        {

            try
            {
                var mng = new CustomerManagement();
                var customer = new Customer();

                Console.WriteLine("Customers CRUD options");
                Console.WriteLine("1.CREATE");
                Console.WriteLine("2.RETRIEVE ALL");
                Console.WriteLine("3.RETRIEVE BY ID");
                Console.WriteLine("4.UPDATE");
                Console.WriteLine("5.DELETE");

                Console.WriteLine("Choose an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("***************************");
                        Console.WriteLine("*****     CREATE    *******");
                        Console.WriteLine("***************************");
                        Console.WriteLine("Type the id, name, last_name, date_of_birth, gender and state separated by comma");
                        var info = Console.ReadLine();
                        var infoArray = info.Split(',');

                        customer = new Customer(infoArray);
                        mng.Create(customer);

                        Console.WriteLine("Customer was created");

                        break;

                    case "2":
                        Console.WriteLine("***************************");
                        Console.WriteLine("*****  RETRIEVE ALL   *****");
                        Console.WriteLine("***************************");

                        var lstCustomers = mng.RetrieveAll();
                        var count = 0;

                        foreach (var c in lstCustomers)
                        {
                            count++;
                            Console.WriteLine(count + " ==> " + c.GetEntityInformation());
                        }

                        break;
                    case "3":
                        Console.WriteLine("Type the customer id:");
                        customer.Id = Console.ReadLine();
                        customer = mng.RetrieveById(customer);

                        if (customer != null)
                        {
                            Console.WriteLine(" ==> " + customer.GetEntityInformation());
                        }

                        break;
                    case "4":
                        Console.WriteLine("***************************");
                        Console.WriteLine("******  UPDATE  **    *****");
                        Console.WriteLine("***************************");

                        Console.WriteLine("Type the customer id:");
                        customer.Id = Console.ReadLine();
                        customer = mng.RetrieveById(customer);

                        if (customer != null)
                        {
                            Console.WriteLine(" ==> " + customer.GetEntityInformation());
                            Console.WriteLine("Type a new name, actual value is " + customer.Name);
                            customer.Name = Console.ReadLine();
                            Console.WriteLine("Type a new last name, actual value is " + customer.LastName);
                            customer.LastName = Console.ReadLine();
                            Console.WriteLine("Type a new date of birth, actual value is " + customer.DateOfBirth);
                            var newDate = Console.ReadLine();
                            customer.DateOfBirth = DateTime.TryParse(newDate, out DateTime dateOfBirth) ? dateOfBirth : customer.DateOfBirth;

                            Console.WriteLine("Type a new gender, actual value is " + customer.Sex);
                            customer.Sex = Console.ReadLine();
                            Console.WriteLine("Type a new state, actual value is " + customer.State);
                            customer.State = Console.ReadLine();

                            mng.Update(customer);
                            Console.WriteLine("Customer was updated");
                        }
                        else
                        {
                            throw new Exception("Customer not registered");
                        }

                        break;

                    case "5":
                        Console.WriteLine("Type the customer id:");
                        customer.Id = Console.ReadLine();
                        customer = mng.RetrieveById(customer);

                        if (customer != null)
                        {
                            Console.WriteLine(" ==> " + customer.GetEntityInformation());

                            Console.WriteLine("Delete? Y/N");
                            var delete = Console.ReadLine();

                            if (delete.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                            {
                                mng.Delete(customer);
                                Console.WriteLine("Customer was deleted");
                            }
                        }
                        else
                        {
                            throw new Exception("Customer not registered");
                        }

                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("***************************");
                Console.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("***************************");
            }
            finally
            {
                Console.WriteLine("Continue with clients? Y/N");
                var moreActions = Console.ReadLine();

                if (moreActions.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                    Client();
            }


        }

        public static void Direction()
        {

            try
            {
                var mng = new DirectionManagement();
                var direction = new Direction();

                Console.WriteLine("Directions CRUD options");
                Console.WriteLine("1.CREATE");
                Console.WriteLine("2.RETRIEVE ALL");
                Console.WriteLine("3.RETRIEVE BY ID");
                Console.WriteLine("4.UPDATE");
                Console.WriteLine("5.DELETE");

                Console.WriteLine("Choose an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":



                        Console.WriteLine("***************************");
                        Console.WriteLine("*****     CREATE    *******");
                        Console.WriteLine("***************************");
                        Console.WriteLine("Type the province, canton, distrito, details, type and ownerID separated by comma");
                        var info = Console.ReadLine();
                        var infoArray = info.Split(',');

                        direction = new Direction(infoArray);
                        mng.Create(direction);

                        Console.WriteLine("Direction was created");

                        break;

                    case "2":
                        Console.WriteLine("***************************");
                        Console.WriteLine("*****  RETRIEVE ALL   *****");
                        Console.WriteLine("***************************");

                        var lstDirections = mng.RetrieveAll();
                        var count = 0;

                        foreach (var c in lstDirections)
                        {
                            count++;
                            Console.WriteLine(count + " ==> " + c.GetEntityInformation());
                        }

                        break;
                    case "3":
                        Console.WriteLine("Type the customer id:");
                        direction.OwnerId = Console.ReadLine();
                        direction = mng.RetrieveById(direction);

                        if (direction != null)
                        {
                            Console.WriteLine(" ==> " + direction.GetEntityInformation());
                        }

                        break;
                    case "4":
                        Console.WriteLine("***************************");
                        Console.WriteLine("******  UPDATE  **    *****");
                        Console.WriteLine("***************************");

                        Console.WriteLine("Type the customer id:");
                        direction.OwnerId = Console.ReadLine();
                        direction = mng.RetrieveById(direction);

                        if (direction != null)
                        {

                            //province, canton, distrito, details, type and ownerID
                            Console.WriteLine(" ==> " + direction.GetEntityInformation());
                            Console.WriteLine("Type a new province, actual value is " + direction.Province);
                            direction.Province = Console.ReadLine();
                            Console.WriteLine("Type a new canton, actual value is " + direction.Canton);
                            direction.Canton = Console.ReadLine();
                            Console.WriteLine("Type a new distrito, actual value is " + direction.Distrito);
                            direction.Distrito = Console.ReadLine();
                            Console.WriteLine("Type a new details, actual value is " + direction.Details);
                            direction.Details = Console.ReadLine();
                            Console.WriteLine("Type a new type, actual value is " + direction.Type);
                            direction.Type = Console.ReadLine();


                            mng.Update(direction);
                            Console.WriteLine("Direction was updated");
                        }
                        else
                        {
                            throw new Exception("Direction not registered");
                        }

                        break;

                    case "5":
                        Console.WriteLine("Type the direction's owner id:");
                        direction.OwnerId = Console.ReadLine();
                        direction = mng.RetrieveById(direction);

                        if (direction != null)
                        {
                            Console.WriteLine(" ==> " + direction.GetEntityInformation());

                            Console.WriteLine("Delete? Y/N");
                            var delete = Console.ReadLine();

                            if (delete.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                            {
                                mng.Delete(direction);
                                Console.WriteLine("Direction was deleted");
                            }
                        }
                        else
                        {
                            throw new Exception("Direction not registered");
                        }

                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("***************************");
                Console.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("***************************");
            }
            finally
            {
                Console.WriteLine("Continue with directions? Y/N");
                var moreActions = Console.ReadLine();

                if (moreActions.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                    Direction();
            }


        }

        public static void ContactMethod()
        {
            Console.WriteLine("Please send a message with the word 'start' to start the bot");

            Bot.OnMessage += BotContactMethod;
            //Bot.OnMessageEdited += BotContactMethod;

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();



        }

        public static void BotContactMethod(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {

            var mng = new ContactMethodManagement();
            ContactMethod cm;
            string[] inputArray;

            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {



                if (e.Message.Text.ToLower().Contains("update"))
                {
                    inputArray = e.Message.Text.Split(':');
                    string userData = inputArray[1];
                    string[] userDataArray = userData.Split(',');

                    

                    cm = new ContactMethod();
                    cm.OwnerId = userDataArray[0];


                    cm.Type = userDataArray[1];
                    cm.Value = userDataArray[2];
                    cm.Description = userDataArray[3];
                    cm.INDPublicidad = userDataArray[4];


                    mng.Update(cm);



                }




                if (e.Message.Text.ToLower().Contains("find"))
                {
                    inputArray = e.Message.Text.Split(':');
                    string userData = inputArray[1];


                    cm = new ContactMethod();
                    cm.OwnerId = userData;
                    cm = mng.RetrieveById(cm);
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, " ==> " + cm.GetEntityInformation());
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, @"Contact Method was updated");





                }

                if (e.Message.Text.ToLower().Contains("delete"))
                {
                    inputArray = e.Message.Text.Split(':');
                    string userData = inputArray[1];


                    cm = new ContactMethod();
                    cm.OwnerId = userData;
                    cm = mng.RetrieveById(cm);
                    mng.Delete(cm);
     
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, @"Contact Method was deleted");





                }




                if (e.Message.Text.ToLower().Contains("create"))
                {


                    inputArray = e.Message.Text.Split(':');
                    string userData = inputArray[1];
                    string[] userDataArray = userData.Split(',');

                    if (userDataArray.Length > 1)
                    {
                        cm = new ContactMethod(userDataArray);


                        mng.Create(cm);


                        Bot.SendTextMessageAsync(e.Message.Chat.Id, @"Contact Method was created");
                        return;
                    }
                }

                switch (e.Message.Text.ToLower())
                {

                    case ("start"):

                        Bot.SendTextMessageAsync(e.Message.Chat.Id, @"Directions CRUD options
    1.CREATE
2. RETREIVE ALL
3. RETREIVE ID
4. UPDATE
5. DELETE!
Choose an option");
                        //Console.WriteLine(e.Message.Text);

                        break;

                    case ("1"):

                        Bot.SendTextMessageAsync(e.Message.Chat.Id, @"*****     CREATE    *******
Insert the following Create:type, value, description, indpublicdad, and ownerid separated by comma");



                        //userInput = e.Message.Text;
                        //var infoArray = userInput.Split(',');




                        break;

                    case ("2"):

                        Bot.SendTextMessageAsync(e.Message.Chat.Id, @"*****   RETRIEVE ALL  *******");

                        var lstContactMethods = mng.RetrieveAll();
                        var count = 0;

                        foreach (var c in lstContactMethods)
                        {
                            count++;
                            //Console.WriteLine(count + " ==> " + c.GetEntityInformation());
                            Bot.SendTextMessageAsync(e.Message.Chat.Id, count + " ==> " + c.GetEntityInformation());
                        }



                        break;

                    case ("3"):

                        Bot.SendTextMessageAsync(e.Message.Chat.Id, @"*****   RETRIEVE BY ID  *******");
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, @"*****   Type the followind Find:'user id'  *******");

                        break;

                    case ("4"):

                        Bot.SendTextMessageAsync(e.Message.Chat.Id, @"*****   UPDATE BY ID  *******");
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, @"*****   Type the customer Update:'user id, new type, new value, new description and  new indpublicdadseparated by comma  *******");

                        break;

                    case ("5"):
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, @"*****   DELETE BY ID  *******");
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, @"*****   Type the customer Delete:'user id' *******");


                        break;


                }

            }





        }





    }

}