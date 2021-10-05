using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car Added.";
        public static string CarUpdated = "Car Updated.";
        public static string CarDeleted = "Car Deleted.";
        public static string CarNameInvalid = " Car Name Invalid.";
        public static string MaintenanceTime="The system is currently under maintenance.";
        public static string CarListed="Cars listed.";

        public static string CarCountOfBrandError= "You exceeded the number of cars in the brand";
        public static string CarNameAlreadyExists= "There is already another car with this name.";
        public static string BrandLimitExceded= "A new brand cannot be added because the brand limit has been exceeded.";

        public static string CustomerListed;
        public static string CustomerAdded;
        public static string CustomerUpdated;
        public static string CustomerDeleted;

        public static string RentalListed;
        public static string RentalUpdated;
        public static string RentalDeleted;
        public static string RentalAdded;
        public static string CarImageLimitExceeded;
        public static string AuthorizationDenied= "You are not authorized.";

        public static string UserRegistered= "User Registered.";
        public static string UserNotFound="User not found";
        public static string AccessTokenCreated="Access token created.";
        public static string UserAlreadyExists="User Already Exists.";
        public static string SuccessfulLogin="Successful Login.";
        public static string PasswordError= "Password Error.";
        internal static string UserAdded="User Added.";

        internal static string BrandAdded="Brand Added.";
        internal static string BrandDeleted="Brand Deleted.";
        internal static string BrandListed="Brand Listed.";
        internal static string BrandUpdated="Brand Updated.";

        internal static string ColorAdded="Color Added.";
        internal static string ColorDeleted="Color Deleted.";
        internal static string ColorListed="Color Listed.";
        internal static string ColorUpdated="Color Updated.";
    }
}
