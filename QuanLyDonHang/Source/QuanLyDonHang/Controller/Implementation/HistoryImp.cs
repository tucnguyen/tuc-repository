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
    public class HistoryImp : SQLConnection
    {
        private static IQueryable<History> GetQuery(string text = "", string stt = "", int? khaosat = null, int? vanchuyen = null, int? hmtc = null,
            int? lapdat = null, int? xinphep = null, int? hmk = null, DateTime? date = null, string dateType = "", bool deleteFlag = true)
        {
            var sql = from data in dbContext.Histories
                      select data;

            if (!string.IsNullOrEmpty(text))
            {
                text = CommonFunction.GetFilterText(text);
                sql = sql.Where(p => SqlMethods.Like(p.NhaThuoc.CodeMer, text) ||
                    SqlMethods.Like(p.NhaThuoc.PharmacyName, text) ||
                    SqlMethods.Like(p.NhaThuoc.Address, text) ||
                    SqlMethods.Like(p.NhaThuoc.Street, text) ||
                    SqlMethods.Like(p.NhaThuoc.Other, text) ||
                    SqlMethods.Like(p.NhaThuoc.Ward, text) ||
                    SqlMethods.Like(p.NhaThuoc.District, text) ||
                    SqlMethods.Like(p.NhaThuoc.Province, text)
                    );
            }

            if (!String.IsNullOrEmpty(stt))
            {
                int STT = Common.ConvertUtil.ConvertToInt(stt);

                if (STT != 0)
                {
                    sql = sql.Where(p => p.MasterChiPhi.STT == STT);
                }
            }

            if (khaosat != null)
            {
                sql = sql.Where(p => p.MasterChiPhi.IdCatalogueKS == khaosat);
            }

            if (vanchuyen != null)
            {
                sql = sql.Where(p => p.MasterChiPhi.IdCatalogueVC == vanchuyen);
            }

            if (hmtc != null)
            {
                sql = sql.Where(p => p.MasterChiPhi.IdCatalogueHMTC == hmtc);
            }

            if (lapdat != null)
            {
                sql = sql.Where(p => p.MasterChiPhi.IdCatalogueLD == lapdat);
            }

            if (xinphep != null)
            {
                sql = sql.Where(p => p.MasterChiPhi.IdCatalogueXP == xinphep);
            }

            if (hmk != null)
            {
                sql = sql.Where(p => p.MasterChiPhi.IdCatalogueHMK == hmk);
            }

            if (date != null)
            {
                DateTime value = date.Value;

                switch (dateType)
                {
                    case CommonConstants.DEFAULT_TYPE_DAY:
                        sql = sql.Where(p => p.Date.Day == value.Day && p.Date.Month == value.Month && p.Date.Year == value.Year);
                        break;

                    case CommonConstants.DEFAULT_TYPE_WEEK:
                        sql = sql.Where(p => p.Date.DayOfYear >= value.DayOfYear && p.Date.DayOfYear < (value.DayOfYear + 7));
                        break;

                    case CommonConstants.DEFAULT_TYPE_MONTH:
                        sql = sql.Where(p => p.Date.Month == value.Month && p.Date.Year == value.Year);
                        break;

                    case CommonConstants.DEFAULT_TYPE_YEAR:
                        sql = sql.Where(p => p.Date.Year == value.Year);
                        break;
                }
            }

            if (!deleteFlag)
            {
                sql = sql.Where(p => p.DeleteFlag == false);
            }

            return sql;
        }

        public static int GetCount(string text = "", string stt = "", int? khaosat = null, int? vanchuyen = null, int? hmtc = null,
            int? lapdat = null, int? xinphep = null, int? hmk = null, DateTime? date = null, string dateType = "", bool deleteFlag = true)
        {
            return GetQuery(text).Count();
        }

        public static List<History> GetList(string text = "", string stt = "", int? khaosat = null, int? vanchuyen = null, int? hmtc = null,
            int? lapdat = null, int? xinphep = null, int? hmk = null, DateTime? date = null, string dateType = "", bool deleteFlag = true,
            string sortColumn = "", string sortOrder = CommonConstants.SORT_DESCENDING, int skip = 0, int take = 0)
        {
            string sortSQL = string.Empty;

            switch (sortColumn)
            {
                case "Id":
                    sortSQL += "Id " + sortOrder;
                    break;

                default:
                    sortSQL += "Date " + sortOrder;
                    break;
            }

            var sql = GetQuery(text, stt, khaosat, vanchuyen, hmtc, lapdat, xinphep, hmk, date, dateType, deleteFlag).OrderBy(sortSQL);

            if ((skip <= 0 && take <= 0) || (skip < 0 && take > 0) || (skip > 0 && take < 0))
            {
                return sql.ToList();
            }

            return sql.Skip(skip).Take(take).ToList();
        }

        public static List<History> GetListByIdNhaThuocCode(int idNhaThuoc)
        {
            return dbContext.Histories.Where(p => p.IdNhaThuoc == idNhaThuoc && p.DeleteFlag == false).ToList();
        }

        public static List<History> GetListByNhaThuocCode(string text)
        {
            return dbContext.Histories.Where(p => p.NhaThuoc.CodeMer.ToLower() == text.ToLower() && p.DeleteFlag == false).ToList();
        }

        public static History GetById(int id)
        {
            return dbContext.Histories.Where(p => p.Id == id).FirstOrDefault<History>();
        }

        private static bool Insert(History data)
        {
            try
            {
                dbContext.Histories.InsertOnSubmit(data);
                dbContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Insert new data
        /// </summary>
        /// <param name="idUser"></param>
        /// <param name="idNhaThuoc"></param>
        /// <param name="idMasterChiPhi"></param>
        /// <param name="ngayOrder"></param>
        /// <returns>Return id of the new data if success</returns>
        public static int? Insert(int idUser, int idNhaThuoc, int idMasterChiPhi, DateTime? ngayOrder = null)
        {
            int? res = null;

            try
            {
                History data = new History();
                data.IdUser = idUser;
                data.Date = DateTime.Now;
                data.NgayOrder = ngayOrder;
                data.IdNhaThuoc = idNhaThuoc;
                data.IdMasterChiPhi = idMasterChiPhi;

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

        public static bool Delete(History data)
        {
            try
            {
                if (data != null)
                {
                    data.DeleteFlag = true;
                    dbContext.SubmitChanges();
                    return true;
                }
            }
            catch
            {

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
                            History data = GetById(result);

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

        private static bool Update(History data)
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

        public static bool Update(int id, int idUser, int idNhaThuoc, int idMasterChiPhi)
        {
            bool res = false;

            try
            {
                History data = GetById(id);

                if (data != null)
                {
                    data.IdUser = idUser;
                    data.Date = DateTime.Now;
                    data.IdNhaThuoc = idNhaThuoc;
                    data.IdMasterChiPhi = idMasterChiPhi;

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
