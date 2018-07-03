using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
    public class Listings
    {
        private string _title;
        private string _description;
        private string _contactName;
        private string _contactEmail;
        private string _contactPhone;
        private static List<Listings> _jobListings = new List<Listings>() { };


        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string newTitle)
        {
            _title = newTitle;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }

        public string GetContactName()
        {
            return _contactName;
        }

        public void SetContactName(string newContactName)
        {
            _contactName = newContactName;
        }

        public string GetContactEmail()
        {
            return _contactEmail;
        }

        public void SetContactEmail(string newContactEmail)
        {
            _contactEmail = newContactEmail;
        }

        public string GetContactPhone()
        {
            return _contactPhone;
        }

        public void SetContactPhone(string newContactPhone)
        {
            _contactPhone = newContactPhone;
        }

        public void UpdateList() 
        {
            _jobListings.Add(this);
        }

        public List<Listings> GetList() 
        {
            return _jobListings;
        }
    }
}
