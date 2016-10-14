﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reindawn.Repository;
using Reindawn.Service;

namespace Reindawn.Code
{
    public static class EnumExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectList(this Enum enumValue)
        {
            return from Enum e in Enum.GetValues(enumValue.GetType())
                   select new SelectListItem
                   {
                       Selected = e.Equals(enumValue),
                       Text = e.ToDescription(),
                       Value = e.ToString()
                   };
        }

        public static IEnumerable<SelectListItem> ToAccountSelectList(this IEnumerable<SelectListItem> items)
        {
            AccountService accountService = new AccountService(new UnitOfWork());
            return from SelectListItem i in items
                   select new SelectListItem
                   {
                       Text = string.Format("{0} | {1}", accountService.Find(new Guid(i.Value)).No, i.Text),
                       Value = i.Value
                   };
        }

        public static string ToDescription(this Enum value)
        {
            var attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}