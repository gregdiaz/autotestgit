using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.pageObjects.Program_Setup
{
    class Usertags
    {
        public string _usertagstab = "userTagsTab";
        public string _serach = "searchUserTag";
        public string _addusertag = "#TopBarContainer > div.col-md-6 > ol > li > a";
        public string _paginatebtn = "#userTagsTable_paginate";
        public string _name = "#userTagForm > div > div > .form-group:nth-child(1) > div >#name";
        public string _tagtype = "#userTagForm > div > div > div:nth-child(2) > div > select";
        public string _inactivebtn = "#userTagForm > div > div > div:nth-child(3) > div > div";
    }
}
