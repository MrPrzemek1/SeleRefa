﻿using NUnit.Framework;
using OpenQA.Selenium;
using RawaTests.IWebElements;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static RawaTests.Helpers.DriverHelper.DriverHelp;

namespace RawaTests.Model.Base.Buttons
{
    public class NxButton : BaseWebElement, INxButton
    {
        private IWebElement element;
        private IList<IWebElement> listOfButton;
        public int Count => listOfButton.Count;

        public NxButton(IWebElement e) : base(e)
        {
            element = e;
        }

        public NxButton(IList<IWebElement> listOfButton) : base(listOfButton)
        {
            this.listOfButton = listOfButton;
        }
        public override void Click()
        {
            Wait(1);
            element.Click();
        }
        public IWebElement this[int index]
        {
            get
            {
                return listOfButton[index];
            }
            set
            {
                listOfButton[index] = value;
            }
        }
        //public NxButton this[int index]
        //{
        //    get
        //    {
        //        return NxButton[index];
        //    }
        //    set
        //    {
        //        NxButton[index] = value;
        //    }
        //}

        //public IList<IWebElement> this[int index] => listOfButton.ElementAt(index);

    } }
