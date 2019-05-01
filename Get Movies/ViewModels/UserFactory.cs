using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Get_Movies.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using Get_Movies.Models;

namespace Get_Movies.ViewModels
{
    public static class UserFactory
    {

        public static GeneralUser Build(String userType, int? user_id)
        {
            switch (userType)
            {
                case "Blacklist":
                    return new Blacklist() { User_Id = user_id }.Search(true, true).FirstOrDefault();

                case "Admin":
                    Debug.WriteLine("LOL: ");
                    return new Admin() { User_Id = user_id }.Search(true, true).FirstOrDefault();

                case "Casual":

                    return new Casual() { User_Id = user_id }.Search(true, true).FirstOrDefault();

                case "Premium":

                    return new Premium() { User_Id = user_id }.Search(true, true).FirstOrDefault();

              //  default:
                   // return new Blacklist() { User_Id = user_id }.Search(true, true).FirstOrDefault();

            }
            return null;
        }


    }
}