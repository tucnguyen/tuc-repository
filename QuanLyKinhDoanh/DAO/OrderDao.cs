﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Library;
using DTO;

namespace DAO
{
    public class OrderDao : JsonConnection
    {
        private static readonly string DATA_KEY = "order";
        private static readonly string DATA_ID_KEY = "Id";
        private static readonly string DATA_NAME_KEY = "Name";
        private static readonly string DATA_DELETE_FLAG_KEY = "DeleteFlag";

        public static IEnumerable<JToken> GetQuery(string text, bool deleteFlag = false)
        {
            var res = from p in dbContext[DATA_KEY]
                      select p;

            if (!string.IsNullOrEmpty(text))
            {
                res = res.Where(p => p[DATA_NAME_KEY].Contains(text));
            }

            res = res.Where(p => p[DATA_DELETE_FLAG_KEY].Any(q => q.Equals(deleteFlag)));

            return res;
        }

        public static int GetCount(string text, bool deleteFlag = false)
        {
            return GetQuery(text).Count();
        }

        public static List<Order> GetList(string text, 
            string sortColumn, string sortOrder, int skip, int take, bool deleteFlag = false)
        {
            List<Order> res = new List<Order>();
            var jData = GetQuery(text);
            JArray resSorted = null;

            switch (sortColumn)
            {
                case "Họ và tên":
                    resSorted = new JArray(jData.OrderBy(obj => obj[DATA_NAME_KEY]));
                    break;

                default:
                    resSorted = new JArray(jData.OrderBy(obj => obj[DATA_NAME_KEY]));
                    break;
            }

            if ((skip <= 0 && take <= 0) || (skip < 0 && take > 0) || (skip > 0 && take < 0))
            {
                //keep current list
            }
            else
            {
                jData = resSorted.Skip(skip).Take(take);
            }

            foreach (var item in jData)
            {
                res.Add(item.ToObject<Order>());
            }

            return res;
        }

        public static Order GetById(int id)
        {
            var res = dbContext.Where(p => p[DATA_ID_KEY].Equals(id)).FirstOrDefault();

            if (res != null)
            {
                return res.ToObject<Order>();
            }

            return null;
        }

        public static bool Insert(Order data, User user)
        {
            try
            {
                data.CreatedBy = data.UpdatedBy = user.UserName;
                data.CreatedDate = data.UpdatedDate = DateTime.Now;

                JObject newData = JObject.FromObject(data);
                JObject parent = dbContext[DATA_KEY] as JObject;
                parent.Add(newData);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
