﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.IO;
using System.Globalization;
using System.Diagnostics;
using Controller.Common;
using Model;

namespace Controller.Common
{
    public class ExportExcel
    {
        private static XLWorkbook workbook;
        private static IXLWorksheet ws;

        public static void SaveExcel(string path)
        {
            try
            {
                workbook.SaveAs(path);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void InitWorkBook()
        {
            workbook = new XLWorkbook();
        }

        public static void InitWorkBook(string sheetName)
        {
            try
            {
                workbook = new XLWorkbook();
                InitNewSheet(sheetName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void InitNewSheet(string sheetName)
        {
            try
            {
                if (workbook != null)
                {
                    ws = workbook.Worksheets.Add(sheetName);
                    ws.ShowGridLines = false;
                    ws.Style.Font.FontName = "Arial";
                    ws.Style.Alignment.WrapText = true;
                    ws.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Top);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CreateSummaryMasterChiPhi()
        {
            try
            {
                ws.Cell("A1").Value = "STT";
                ws.Cell("B1").Value = "NGÀY ORDER";
                ws.Cell("C1").Value = "CODE MER";
                ws.Cell("D1").Value = "TÊN NT";
                ws.Cell("E1").Value = "ĐỊA CHỈ";
                ws.Cell("F1").Value = "ĐƯỜNG";
                ws.Cell("G1").Value = "OTHER";
                ws.Cell("H1").Value = "PHƯỜNG";
                ws.Cell("I1").Value = "QUẬN";
                ws.Cell("J1").Value = "TỈNH/THÀNH";
                ws.Cell("K1").Value = "KHẢO SÁT";
                ws.Cell("L1").Value = "CHI PHÍ KHẢO SÁT";
                ws.Cell("M1").Value = "VẬN CHUYỂN";
                ws.Cell("N1").Value = "CHI PHÍ VẬN CHUYỂN";
                ws.Cell("O1").Value = "HẠNG MỤC THI CÔNG";
                ws.Cell("P1").Value = "Đơn vị tính";
                ws.Cell("Q1").Value = "Đơn giá sản xuất"; //17
                ws.Column(17).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Cell("R1").Value = "LẮP ĐẶT (Nếu có)";
                ws.Cell("S1").Value = "Đơn vị tính";
                ws.Cell("T1").Value = "Đơn giá lắp đặt (Nếu có)"; //20
                ws.Column(20).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Cell("U1").Value = "XIN PHÉP (Nếu có)";
                ws.Cell("V1").Value = "Đơn vị tính";
                ws.Cell("W1").Value = "Đơn giá xin phép (Nếu có)"; //23
                ws.Column(23).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Range(1, 24, 1, 27).Merge();
                ws.Cell("X1").Value = "Kích thước(m)"; //24, 25, 26, 27
                ws.Column(24).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Column(25).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Column(26).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Column(27).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Cell("AB1").Value = "Thành tiền sản xuất"; //28
                ws.Column(28).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Cell("AC1").Value = "Thành tiền lắp đặt (Nếu có)"; //29
                ws.Column(29).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Cell("AD1").Value = "Thành tiền xin phép (Nếu có)"; //30
                ws.Column(30).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Cell("AE1").Value = "HẠNG MỤC KHÁC ĐƠN VỊ TÍNH NGOÀI M2 (NẾU CÓ)";
                ws.Cell("AF1").Value = "Đơn vị tính";
                ws.Cell("AG1").Value = "Đơn giá Hạng mục khác đơn vị tính ngoài m2 (Nếu có)";
                ws.Cell("AH1").Value = "Đơn vị tính";
                ws.Cell("AI1").Value = "Thành tiền Hạng mục khác đơn vị tính ngoài m2 (Nếu có)"; //35
                ws.Column(35).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Cell("AJ1").Value = "Brand";
                ws.Cell("AK1").Value = "Tổng cộng"; //37
                ws.Column(37).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;

                ws.Cell("K2").Value = "Chọn hạng mục tương ứng";
                ws.Cell("L2").Value = "'(1)"; //12
                ws.Column(12).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Cell("M2").Value = "Chọn hạng mục tương ứng";
                ws.Cell("N2").Value = "'(2)"; //14
                ws.Column(14).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Cell("O2").Value = "Chọn hạng mục tương ứng";
                ws.Cell("R2").Value = "Chọn hạng mục tương ứng";
                ws.Cell("U2").Value = "Chọn hạng mục tương ứng";
                ws.Cell("X2").Value = "Ngang";
                ws.Cell("Y2").Value = "Rộng";
                ws.Cell("Z2").Value = "Qty";
                ws.Cell("AA2").Value = "M2";
                ws.Cell("AB2").Value = "'(3)"; //28
                ws.Column(28).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Cell("AC2").Value = "'(4)"; //29
                ws.Column(29).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Cell("AD2").Value = "'(5)"; //30
                ws.Column(30).Style.NumberFormat.Format = CommonConstants.EXCEL_DEFAULT_FORMAT_MONEY;
                ws.Cell("AE2").Value = "Chọn hạng mục tương ứng";
                ws.Cell("AI2").Value = "'(6)"; //34
                ws.Cell("AK2").Value = "'(1)+…(6)"; //36

                ws.Columns().AdjustToContents(1, 2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CreateDetailsTableMasterChiPhi(List<History> listHistory)
        {
            try
            {
                if (listHistory != null)
                {
                    int firstRow = 3;
                    int firstCol = 1;
                    int lastRow = firstRow + listHistory.Count;
                    int lastCol = 37;
                    int listCount = listHistory.Count;

                    ws.Cell(firstRow, 12).FormulaA1 = string.Format("=SUBTOTAL(9,L{0}:L{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 14).FormulaA1 = string.Format("=SUBTOTAL(9,N{0}:N{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 17).FormulaA1 = string.Format("=SUBTOTAL(9,Q{0}:Q{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 20).FormulaA1 = string.Format("=SUBTOTAL(9,T{0}:T{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 23).FormulaA1 = string.Format("=SUBTOTAL(9,W{0}:W{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 24).FormulaA1 = string.Format("=SUBTOTAL(9,X{0}:Y{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 25).FormulaA1 = string.Format("=SUBTOTAL(9,Y{0}:Y{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 26).FormulaA1 = string.Format("=SUBTOTAL(9,Z{0}:Z{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 27).FormulaA1 = string.Format("=SUBTOTAL(9,AA{0}:AA{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 28).FormulaA1 = string.Format("=SUBTOTAL(9,AB{0}:AB{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 29).FormulaA1 = string.Format("=SUBTOTAL(9,AC{0}:AC{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 30).FormulaA1 = string.Format("=SUBTOTAL(9,AD{0}:AD{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 33).FormulaA1 = string.Format("=SUBTOTAL(9,AG{0}:AG{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 34).FormulaA1 = string.Format("=SUBTOTAL(9,AH{0}:AH{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 35).FormulaA1 = string.Format("=SUBTOTAL(9,AI{0}:AI{1})", firstRow + 1, lastRow);
                    ws.Cell(firstRow, 37).FormulaA1 = string.Format("=SUBTOTAL(9,AK{0}:AK{1})", firstRow + 1, lastRow);

                    for (int rowNum = 0; rowNum < listCount; rowNum++)
                    {
                        int colNum = 1;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = (rowNum + 1).ToString();
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].NgayOrder == null ? String.Empty : listHistory[rowNum].NgayOrder.Value.ToShortDateString();
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].NhaThuoc.CodeMer;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].NhaThuoc.PharmacyName;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].NhaThuoc.Address;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].NhaThuoc.Street;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].NhaThuoc.Other == null ? String.Empty : listHistory[rowNum].NhaThuoc.Other;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].NhaThuoc.Ward;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].NhaThuoc.District;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].NhaThuoc.Province;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue.ItemDescription;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue.UnitPrice.ToString();
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue1 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue1.ItemDescription;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue1 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue1.UnitPrice.ToString();
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue2 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue2.ItemDescription;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue2 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue2.PartNumber == null ?
                            String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue2.PartNumber;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue2 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue2.UnitPrice.ToString();
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue3 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue3.ItemDescription;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue3 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue3.PartNumber;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue3 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue3.UnitPrice.ToString();
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue4 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue4.ItemDescription;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue4 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue4.PartNumber;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue4 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue4.UnitPrice.ToString();

                        double ngang = listHistory[rowNum].MasterChiPhi.Ngang == null ? 0 : listHistory[rowNum].MasterChiPhi.Ngang.Value;
                        double rong = listHistory[rowNum].MasterChiPhi.Rong == null ? 0 : listHistory[rowNum].MasterChiPhi.Rong.Value;
                        double dienTich = ngang * rong;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = ngang == 0 ? String.Empty : ngang.ToString();
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = rong == 0 ? String.Empty : rong.ToString();
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.SLHMTC == null ? String.Empty : listHistory[rowNum].MasterChiPhi.SLHMTC.ToString();
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = dienTich == 0 ? String.Empty : dienTich.ToString();
                        ws.Cell(firstRow + 1 + rowNum, colNum++).FormulaA1 = string.Format("=Q{0}*AA{0}", firstRow + 1 + rowNum);
                        ws.Cell(firstRow + 1 + rowNum, colNum++).FormulaA1 = string.Format("=T{0}*AA{0}", firstRow + 1 + rowNum);
                        ws.Cell(firstRow + 1 + rowNum, colNum++).FormulaA1 = string.Format("=W{0}*AA{0}", firstRow + 1 + rowNum);
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue5 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue5.ItemDescription;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue5 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue5.PartNumber;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Catalogue5 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Catalogue5.UnitPrice.ToString();
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.SLHMK == null ? String.Empty : listHistory[rowNum].MasterChiPhi.SLHMK.ToString();
                        ws.Cell(firstRow + 1 + rowNum, colNum++).FormulaA1 = string.Format("=AG{0}*AH{0}", firstRow + 1 + rowNum);
                        ws.Cell(firstRow + 1 + rowNum, colNum++).Value = listHistory[rowNum].MasterChiPhi.Brand2 == null ? String.Empty : listHistory[rowNum].MasterChiPhi.Brand2;
                        ws.Cell(firstRow + 1 + rowNum, colNum++).FormulaA1 = string.Format("=AI{0}+AC{0}+AD{0}+AB{0}+L{0}+N{0}", firstRow + 1 + rowNum);
                    }

                    // From worksheet
                    //var rngTableDetails = ws.Range(firstRow, firstCol, lastRow, lastCol);
                    //var rngHeadersDetails = rngTableDetails.Range(1, firstCol, 1, lastCol); // The address is relative to rngTable (NOT the worksheet)
                    //rngHeadersDetails.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                    //rngHeadersDetails.Style.Font.FontColor = XLColor.White;
                    var rngDataDetails = ws.Range(1, firstCol, lastRow, lastCol);
                    rngDataDetails.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    rngDataDetails.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    //var excelTableDetails = rngTableDetails.CreateTable();
                    //ws.Columns().AdjustToContents(1, lastRow + 1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
