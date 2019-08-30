using System;
using System.Collections.Generic;

namespace PasswordManager {
    class Program {
        static void Main(string[] args) {

            var passwordManager = new Dictionary<string, string>();
            passwordManager.Add("1maxtrain.com", "Ohio123");
            passwordManager.Add("2maxtrain.com", "Kentucky123");
            passwordManager.Add("3maxtrain.com", "Indiana123");
            passwordManager.Add("4maxtrain.com", "California123");
            passwordManager.Add("5maxtrain.com", "Alaska123");
            passwordManager.Add("6maxtrain.com", "Florida123");
            passwordManager.Add("7maxtrain.com", "Atlanta123");
            passwordManager.Add("8maxtrain.com", "Illinois123");
            passwordManager.Add("9maxtrain.com", "DC123");
            passwordManager.Add("11maxtrain.com", "Maryland123");
            passwordManager.Add("12maxtrain.com", "Colorado123");
            passwordManager.Add("13maxtrain.com", "Texas123");
            
            var password = passwordManager["1maxtrain.com"];
            Console.WriteLine($"The password for 1maxtrain.com is {password}");
        }
    }
}
