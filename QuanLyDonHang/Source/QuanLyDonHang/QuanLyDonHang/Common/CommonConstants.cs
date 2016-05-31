﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDonHang.Common
{
    public class CommonConstants
    {
        public const string DELIMITER_STRING = ", ";
        public const string ITEMGROUP_KHAOSAT = "Khảo sát";
        public const string ITEMGROUP_VANCHUYEN = "Vận chuyển";
        public const string ITEMGROUP_HANGMUCTHICONG = "Hạng mục thi công";
        public const string ITEMGROUP_LAPDAT = "Lắp đặt";
        public const string ITEMGROUP_XINPHEP = "Xin phép";
        public const string ITEMGROUP_HANGMUCKHAC = "Hạng mục khác";
        public const string ITEMDESCRIPTION = "ItemDescription";
        public enum DATATYPE { NhaThuoc, Catalogue, Master };

        public const string DEFAULT_MONEY_DELIMETER = ",";
        public const string DEFAULT_MONEY_FORMAT = "#" + DEFAULT_MONEY_DELIMETER + "###";
        public const string DEFAULT_USER_GROUP_ADMIN_NAME = "admin";
        public const string DEFAULT_USER_GROUP_QUANLY = "quản lý";
        public const string DEFAULT_USER_GROUP_NHANVIEN = "nhân viên";
        public const string MESSAGE_ERROR_VERIFY_OLD_PASS = "Mật khẩu cũ không chính xác!";
        public const string MESSAGE_ERROR_DO_NOT_HAVE_PERMISSION = "Tài khoản không có quyền!";
        public const string MESSAGE_ERROR_EDIT_PROFILE_ADMIN = "Không thể thay đổi thông tin Admin khác!";
        public const string MESSAGE_ERROR_SELF_DESTRUCTION = "Vui lòng sử dụng chức năng \"Hủy tài khoản\"!";
    }
}
