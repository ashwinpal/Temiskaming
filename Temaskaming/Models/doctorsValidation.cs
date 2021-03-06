﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;


namespace FindADoctor.Models
{
    [MetadataType(typeof(doctorsValidation))]
    public partial class doctor
    {

    }


    [Bind(Exclude = "id")]
    public partial class doctorsValidation
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter first name")]
        public string fname { get; set; }


        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please enter last name")]
        public string lname { get; set; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "Please enter title")]
        public string title { get; set; }

        [DisplayName("Department")]
        [Required(ErrorMessage = "Please enter department")]
        public string department { get; set; }

        [DisplayName("Special Role")]
        //[Required(ErrorMessage = "Please enter department")]
        public string role { get; set; }

        [DisplayName("Program")]
        //[Required(ErrorMessage = "Please enter department")]
        public string program { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email")]
        public string email { get; set; }

        [DisplayName("Extension")]
        [Required(ErrorMessage = "Please enter extension")]
        //[RegularExpression("\d{4}", ErrorMessage = "Please enter a four digit extension")]
        public string extension { get; set; }

        [DisplayName("Phone")]
        //[Required(ErrorMessage = "Please enter phone number")]
        //[RegularExpression("\d{4}", ErrorMessage = "Please enter a four digit extension")]
        public string phone { get; set; }

        [DisplayName("Office")]
        //[Required(ErrorMessage = "Please enter department")]
        public string office { get; set; }

        [DisplayName("Office Hour")]
        //[Required(ErrorMessage = "Please enter department")]
        public string office_hr { get; set; }

        [DisplayName("Brief Bio")]
        //[Required(ErrorMessage = "Please enter department")]
        public string bio { get; set; }
    }
}

//[Team2]Temiskaming-Hospital website Dedesign Project @ Humber college
//Feature: Find a doctor
//Author: Jeesoo Kim
// Feb 17, 2015
