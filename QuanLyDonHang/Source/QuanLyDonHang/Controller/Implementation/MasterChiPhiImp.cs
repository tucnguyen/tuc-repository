﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using System.Data.Linq.SqlClient;
using System.Data.Common;
using Controller.Common;
using Model;

namespace Controller.Implementation
{
    public class MasterChiPhiImp : SQLConnection
    {
        private static IQueryable<MasterChiPhi> GetQuery(string text)
        {
            var sql = from data in dbContext.MasterChiPhis
                      select data;

            if (!string.IsNullOrEmpty(text))
            {
                text = CommonFunction.GetFilterText(text);
                sql = sql.Where(p => SqlMethods.Like(p.Catalogue.ItemDescription, text) ||
                    SqlMethods.Like(p.Catalogue1.ItemDescription, text) ||
                    SqlMethods.Like(p.Catalogue2.ItemDescription, text) ||
                    SqlMethods.Like(p.Catalogue3.ItemDescription, text) ||
                    SqlMethods.Like(p.Catalogue4.ItemDescription, text) ||
                    SqlMethods.Like(p.Catalogue5.ItemDescription, text)
                    );
            }

            return sql;
        }

        public static int GetCount(string text = "")
        {
            return GetQuery(text).Count();
        }

        public static List<MasterChiPhi> GetList(string text = "",
            string sortColumn = "", string sortOrder = CommonConstants.SORT_ASCENDING, int skip = 0, int take = 0)
        {
            string sortSQL = string.Empty;

            switch (sortColumn)
            {
                case "Id":
                    sortSQL += "Id " + sortOrder;
                    break;

                default:
                    sortSQL += "Id " + sortOrder;
                    break;
            }

            var sql = GetQuery(text).OrderBy(sortSQL);

            if ((skip <= 0 && take <= 0) || (skip < 0 && take > 0) || (skip > 0 && take < 0))
            {
                return sql.ToList();
            }

            return sql.Skip(skip).Take(take).ToList();
        }

        public static MasterChiPhi GetById(int id)
        {
            return dbContext.MasterChiPhis.Where(p => p.Id == id).FirstOrDefault<MasterChiPhi>();
        }

        public static bool Insert(MasterChiPhi data)
        {
            try
            {
                dbContext.MasterChiPhis.InsertOnSubmit(data);
                dbContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Insert new data
        /// </summary>
        /// <returns>Return id of the new data if success</returns>
        public static int? Insert(int? stt = null, int? idCatalogueKS = null, byte? SLKS = null, int? idCatalogueVC = null, byte? SLVC = null, 
            int? idCatalogueHMTC = null, int? idCatalogueLD = null, int? idCatalogueXP = null, double? ngang = null, double? rong = null,
            byte? SLHMTC = null, string brand1 = "", int? idCatalogueHMK = null, byte? SLHMK = null, string brand2 = "")
        {
            int? res = null;

            try
            {
                MasterChiPhi data = new MasterChiPhi();
                data.STT = stt;
                data.IdCatalogueKS = idCatalogueKS;
                data.IdCatalogueVC = idCatalogueVC;
                data.IdCatalogueHMTC = idCatalogueHMTC;
                data.IdCatalogueLD = idCatalogueLD;
                data.IdCatalogueXP = idCatalogueXP;
                data.Ngang = ngang;
                data.Rong = rong;
                data.SLHMTC = SLHMTC;
                data.Brand1 = brand1;
                data.IdCatalogueHMK = idCatalogueHMK;
                data.SLHMK = SLHMK;
                data.Brand2 = brand2;
                data.SLKS = SLKS;
                data.SLVC = SLVC;

                if (Insert(data))
                {
                    res = data.Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return res;
        }

        public static bool Delete(MasterChiPhi data)
        {
            try
            {
                if (data != null)
                {
                    dbContext.MasterChiPhis.DeleteOnSubmit(data);
                    dbContext.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                CloseConnection(false);
            }

            NewConnection();
            return false;
        }

        public static bool DeleteList(string ids)
        {
            bool isSuccess = true;

            try
            {
                OpenConnection();

                if (!string.IsNullOrEmpty(ids))
                {
                    string[] idArr = ids.Split(new string[] { CommonConstants.DELIMITER_STRING }, StringSplitOptions.RemoveEmptyEntries);
                    int result = 0;

                    foreach (string id in idArr)
                    {
                        if (int.TryParse(id, out result))
                        {
                            MasterChiPhi data = GetById(result);

                            if (!Delete(data))
                            {
                                isSuccess = false;
                                break;
                            }
                        }
                        else
                        {
                            isSuccess = false;
                            break;
                        }
                    }
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {
                isSuccess = false;
            }

            CloseConnection(isSuccess);
            return isSuccess;
        }

        private static bool Update(MasterChiPhi data)
        {
            try
            {
                if (data != null)
                {
                    dbContext.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(int id, int? stt = null, int? idCatalogueKS = null, int? idCatalogueVC = null, int? idCatalogueHMTC = null,
            int? idCatalogueLD = null, int? idCatalogueXP = null, double? ngang = null, double? rong = null,
            byte? SLHMTC = null, string brand1 = "", int? idCatalogueHMK = null, byte? SLHMK = null, string brand2 = "")
        {
            bool res = false;

            try
            {
                MasterChiPhi data = GetById(id);

                if (data != null)
                {
                    data.STT = stt;
                    data.IdCatalogueKS = idCatalogueKS;
                    data.IdCatalogueVC = idCatalogueVC;
                    data.IdCatalogueHMTC = idCatalogueHMTC;
                    data.IdCatalogueLD = idCatalogueLD;
                    data.IdCatalogueXP = idCatalogueXP;
                    data.Ngang = ngang;
                    data.Rong = rong;
                    data.SLHMTC = SLHMTC;
                    data.Brand1 = brand1;
                    data.IdCatalogueHMK = idCatalogueHMK;
                    data.SLHMK = SLHMK;
                    data.Brand2 = brand2;

                    res = Update(data);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return res;
        }
    }
}
