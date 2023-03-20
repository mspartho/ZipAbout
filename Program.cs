using ZIPABOUT;

namespace Sprint3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            // create 3 users
            CustomerManager.addCustomer("User1", "user1@gmail.com", "userOne");
            CustomerManager.addCustomer("User2", "user2@gmail.com", "userTwo");
            CustomerManager.addCustomer("User3", "user3@gmail.com", "userThree");
            
            // create 3 vehicles 
            VehicleFactory.getVehicle("bike", "1234", "m-1234", 23, 12);
            VehicleFactory.getVehicle("scooter", "2134", "m-2134", 34, 12);
            VehicleFactory.getVehicle("bike", "2345", "m-2345", 45, 12);
            
            // starting the application
            Application.Run(new Login());
        }
    }
}