﻿using LibraryData.Models;
using System;
using System.Collections.Generic;

namespace Library.Models.PatronM
{
    public class PatronDetailModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public int LibraryCardId { get; set; }
        public string Address { get; set; }
        public DateTime MemberSince { get; set; }
        public string Telephone { get; set; }
        public string HomeLibraryBranch { get; set; }
        public decimal OverDueFees { get; set; }
        public IEnumerable<Checkout> AssetsCheckedOut { get; set; }
        public IEnumerable<CheckoutsHistory> CheckoutsHistory { get; set; }
        public IEnumerable<Hold> Holds { get; set; }

    }
}
