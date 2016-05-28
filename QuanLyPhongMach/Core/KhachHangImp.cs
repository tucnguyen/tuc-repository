﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Controller.Common;

namespace Core
{
    public class KhachHangImp : Connection
    {
        private static IQueryable<KhachHang> GetQuery(string text)
        {
            IQueryable<KhachHang> query;
            query = dbContext.KhachHangs.Where(p => p.Ten.Contains(text) ||
                p.GhiChu.Contains(text)
                );

            return query;
        }

        public static int GetCount(string text = "")
        {
            return GetQuery(text).Count();
        }

        public static List<KhachHang> GetList(string text = "", int skip = 0, int take = 0)
        {
            if ((skip <= 0 && take <= 0) || (skip < 0 && take > 0) || (skip > 0 && take < 0))
            {
                return GetQuery(text).ToList();
            }

            return GetQuery(text).Skip(skip).Take(take).ToList();
        }

        public static KhachHang GetById(int id)
        {
            return dbContext.KhachHangs.Where(p => p.Id.Equals(id)).FirstOrDefault<KhachHang>();
        }

        public static KhachHang GetByMa(string ma)
        {
            return dbContext.KhachHangs.Where(p => p.Ma.Equals(ma)).FirstOrDefault<KhachHang>();
        }

        private static bool Insert(KhachHang data)
        {
            try
            {
                dbContext.KhachHangs.Add(data);
                dbContext.SaveChanges();
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
        /// <param name="ten"></param>
        /// <param name="ghiChu"></param>
        /// <returns>Return id of the new data if success</returns>
        public static int? Insert(User user, int idGroup, string ma, string ten, string gioiTinh = "Nam",
            DateTime? DOB = null, string CMND = "", string diaChi = "",
            string dienThoai = "",string email = "", string ghiChu = "")
        {
            int? res = null;

            try
            {
                KhachHang data = new KhachHang();
                data.Id = 1;
                data.IdGroup = idGroup;
                data.Ma = ma;
                data.Ten = ten;
                data.GioiTinh = gioiTinh;
                data.DOB = DOB == null ? DateTime.Now : DOB;
                data.CMND = CMND;
                data.DiaChi = diaChi;
                data.DienThoai = dienThoai;
                data.Email = email;
                data.GhiChu = ghiChu;

                data.CreateBy = data.UpdateBy = user.UserName;
                data.CreateDate = data.UpdateDate = DateTime.Now;

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

        public static bool Delete(KhachHang data, User user)
        {
            try
            {
                if (data != null)
                {
                    KhachHang objDb = GetById(data.Id);

                    if (objDb != null)
                    {
                        data.UpdateBy = user.UserName;
                        data.UpdateDate = DateTime.Now;

                        objDb.DeleteFlag = true;
                        dbContext.SaveChanges();

                        return true;
                    }
                }
            }
            catch
            {
                
            }

            //NewConnection();
            return false;
        }

        public static bool DeleteList(string ids, User user)
        {
            bool res = true;

            try
            {
                BeginTransaction();

                if (!string.IsNullOrEmpty(ids))
                {
                    string[] idArr = ids.Split(new string[] { CommonConstants.DELIMITER_STRING }, StringSplitOptions.RemoveEmptyEntries);
                    int result = 0;

                    foreach (string id in idArr)
                    {
                        if (int.TryParse(id, out result))
                        {
                            KhachHang data = GetById(result);

                            if (!Delete(data, user))
                            {
                                res = false;
                                break;
                            }
                        }
                        else
                        {
                            res = false;
                            break;
                        }
                    }
                }
                else
                {
                    res = false;
                }
            }
            catch
            {
                res = false;
            }
            finally
            {
                EndTransaction(res);
            }

            return res;
        }

        public static bool Update(KhachHang data, User user)
        {
            try
            {
                if (data != null)
                {
                    dbContext.SaveChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(User user, int id, object group, string ma, string ten, string gioiTinh = "Nam",
            DateTime? DOB = null, string CMND = "", string diaChi = "",
            string dienThoai = "", string email = "", string ghiChu = "")
        {
            bool res = false;

            try
            {
                KhachHang data = GetById(id);

                if (data != null)
                {
                    if (group is int)
                    {
                        data.KhachHangGroup = KhachHangGroupImp.GetById(ConvertUtil.ConvertToInt(group));
                    }
                    else
                    {
                        data.KhachHangGroup = (KhachHangGroup)group;
                    }

                    data.Ma = ma;
                    data.Ten = ten;
                    data.GioiTinh = gioiTinh;
                    data.DOB = DOB == null ? DateTime.Now : DOB;
                    data.CMND = CMND;
                    data.DiaChi = diaChi;
                    data.DienThoai = dienThoai;
                    data.Email = email;
                    data.GhiChu = ghiChu;

                    data.UpdateBy = user.UserName;
                    data.UpdateDate = DateTime.Now;

                    res = Update(data, user);
                }
            }
            catch
            {
                
            }

            return res;
        }
    }
}
