using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trademark.Common;

namespace Trademark.Common
{
    class Menudrawer
    {
        public string _menudrawer = "#licensemgmtLeftNavigationItem > span.menu-label";
        public string _menudrawerprogram = "#leftnavigation > li.active > ul > li:nth-child(2) > a > span";
        public string _menuorganization = "#leftnavigation > li.active > ul > li:nth-child(3) > a > span";
        public string _menymydocument = "#leftnavigation > li.active > ul > li:nth-child(4) > a > span";
        public string _menuagreement = "#leftnavigation > li.active > ul > li:nth-child(5) > a > span";
        public string _menusales = "#leftnavigation > li.active > ul > li:nth-child(6) > a > span";
        public string _menuinvoicing = "#leftnavigation > li.active > ul > li:nth-child(7) > a > span";
        public string _menuledger = "#leftnavigation > li.active > ul > li:nth-child(8) > a > span";
        public string _menuassets = "#leftnavigation > li.active > ul > li:nth-child(9) > a > span";
        public string _menuform = "#leftnavigation > li.active > ul > li:nth-child(10) > a > span";
        public string _menudrequest = "#leftnavigation > li.active > ul > li:nth-child(11) > a > span";
        public string _menuprequest = "#leftnavigation > li.active > ul > li:nth-child(12) > a > span";
        public string _menurutines = "#leftnavigation > li.active > ul > li:nth-child(13) > a > span";
        public string _menuproducts = "#leftnavigation > li.active > ul > li:nt h-child(15) > a > span";
        public string _menuattributes= "#leftnavigation > li.active > ul > li:nth-child(16) > a > span";
        public string _menuinsurance = "#leftnavigation > li.active > ul > li:nth-child(17) > a > span";
        public string _menuusers = "#leftnavigation > li.active > ul > li:nth-child(18) > a > span";
    }
}
