using CarlosAg.ExcelXmlWriter;
using NumSimpSonApp5.Simson.DataEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSimpSonApp5.Simson.Excel
{
    public class SimsonExcel
    {
        public void GenerateExcel(String OutputFileName, SimsonEntityIList simsonentityilist, List<SimsonEntity> lstSimsonEntity)
        {
            
            Workbook workbook = new Workbook();
            workbook.ExcelWorkbook.ActiveSheetIndex = (3);
            workbook.ExcelWorkbook.WindowTopX = (100);
            workbook.ExcelWorkbook.WindowTopY = (200);
            workbook.ExcelWorkbook.WindowHeight = (7000);
            workbook.ExcelWorkbook.WindowWidth = (10000);
            workbook.Properties.Author = ("CarlosAg");
            workbook.Properties.Title = "SimsonApp5";
            workbook.Properties.Created = (DateTime.Now);
            workbook.Styles.Add("HeaderStyle").Font.FontName = ("Cordia New");

            WorksheetStyle worksheetStyle1 = workbook.Styles.Add("Default");

            worksheetStyle1.Font.FontName = "Cordia New";
            worksheetStyle1.Font.Size = 14;
            worksheetStyle1.Font.Bold = (true);
            worksheetStyle1.Borders.Add(StylePosition.Bottom, LineStyleOption.Continuous, 1);
            worksheetStyle1.Borders.Add(StylePosition.Left, LineStyleOption.Continuous, 1);
            worksheetStyle1.Borders.Add(StylePosition.Right, LineStyleOption.Continuous, 1);
            worksheetStyle1.Borders.Add(StylePosition.Top, LineStyleOption.Continuous, 1);

            Worksheet worksheet1 = workbook.Worksheets.Add("SimsonAppSheet");
            worksheet1.Table.Columns.Add(new WorksheetColumn(40)); //1
            worksheet1.Table.Columns.Add(new WorksheetColumn(50));//2
            worksheet1.Table.Columns.Add(new WorksheetColumn(70));//3
            worksheet1.Table.Columns.Add(new WorksheetColumn(100));//4
            worksheet1.Table.Columns.Add(new WorksheetColumn(120));//5
            worksheet1.Table.Columns.Add(new WorksheetColumn(150));//6
            worksheet1.Table.Columns.Add(new WorksheetColumn(80));//7
            worksheet1.Table.Columns.Add(new WorksheetColumn(80));//8
            worksheet1.Table.Columns.Add(new WorksheetColumn(190));//9
            worksheet1.Table.Columns.Add(new WorksheetColumn(60));
            worksheet1.Table.Columns.Add(new WorksheetColumn(80));
            worksheet1.Table.Columns.Add(new WorksheetColumn(80));

            /// Header 
            /// 
            WorksheetRow worksheetRow1 = worksheet1.Table.Rows.Add();
            worksheetRow1.Cells.Add("");

            worksheetRow1 = worksheet1.Table.Rows.Add();
            worksheetRow1.Cells.Add("i");
            worksheetRow1.Cells.Add("xi");
            worksheetRow1.Cells.Add("1+((x^2)/dof)");
            worksheetRow1.Cells.Add("1+((x^2)/dof) ^((dof-1)/2)");
            worksheetRow1.Cells.Add("r((dof+1)/2)/(dof*Pi)^1/2*r(dof/2)");
            worksheetRow1.Cells.Add("F(x)");
            worksheetRow1.Cells.Add("Mutiplier");
            worksheetRow1.Cells.Add("Term (W/3)*Mutiplier * F(xi)");

            WorksheetStyle style33 = workbook.Styles.Add("s31");
            style33.Font.FontName = "Cordia New";
            style33.Font.Size = 14;
            style33.Font.Bold = false;
            style33.Interior.Pattern = StyleInteriorPattern.Solid;
            style33.Borders.Add(StylePosition.Bottom, LineStyleOption.Continuous, 1);
            style33.Borders.Add(StylePosition.Left, LineStyleOption.Continuous, 1);
            style33.Borders.Add(StylePosition.Right, LineStyleOption.Continuous, 1);
            style33.Borders.Add(StylePosition.Top, LineStyleOption.Continuous, 1);



            WorksheetStyle style = workbook.Styles.Add("s32");
            style.Font.FontName = "Cordia New";
            style.Font.Size = 14;
            style.Font.Bold = false;
            style.NumberFormat = "#,###,##0";

            WorksheetCell worksheetCell = null;
            foreach (SimsonEntity itemSimsonEntity in lstSimsonEntity)
            {
                
                worksheetRow1 = worksheet1.Table.Rows.Add();
                
                worksheetCell = new WorksheetCell(itemSimsonEntity.NumOfSegment.ToString(), DataType.Number, "s31");
                worksheetRow1.Cells.Add(worksheetCell);

                worksheetCell = new WorksheetCell(itemSimsonEntity.NumOfAvgSeg.ToString(), DataType.Number, "s31");
                worksheetRow1.Cells.Add(worksheetCell);


                worksheetCell = new WorksheetCell(itemSimsonEntity.NumOfAvgDofPowDof.ToString(), DataType.Number, "s31");
                worksheetRow1.Cells.Add(worksheetCell);

                worksheetCell = new WorksheetCell(itemSimsonEntity.NumOfAvgDofPowDofDividSecond.ToString(), DataType.Number, "s31");
                worksheetRow1.Cells.Add(worksheetCell);

                worksheetCell = new WorksheetCell(itemSimsonEntity.NumOfrDofMultiDofPi_radius.ToString(), DataType.Number, "s31");
                worksheetRow1.Cells.Add(worksheetCell);

                worksheetCell = new WorksheetCell(itemSimsonEntity.NumOfFX.ToString(), DataType.Number, "s31");
                worksheetRow1.Cells.Add(worksheetCell);

                worksheetCell = new WorksheetCell(itemSimsonEntity.NumOfmutiplier.ToString(), DataType.Number, "s31");
                worksheetRow1.Cells.Add(worksheetCell);

                worksheetCell = new WorksheetCell(itemSimsonEntity.NumOfTerm.ToString(), DataType.Number, "s31");
                worksheetRow1.Cells.Add(worksheetCell);
                
            }
            worksheetRow1 = worksheet1.Table.Rows.Add();
            double sumOfMultiple = simsonentityilist.SumTermOfMutiple;
            worksheetCell = new WorksheetCell("", DataType.String, "s31");
            worksheetRow1.Cells.Add(worksheetCell);
            worksheetRow1.Cells.Add(worksheetCell);
            worksheetRow1.Cells.Add(worksheetCell);
            worksheetRow1.Cells.Add(worksheetCell);
            worksheetRow1.Cells.Add(worksheetCell);
            worksheetRow1.Cells.Add(worksheetCell);
            worksheetCell = new WorksheetCell("Result Bias", DataType.String, "s31");
            worksheetRow1.Cells.Add(worksheetCell);
            worksheetCell = new WorksheetCell(sumOfMultiple.ToString(), DataType.Number, "s31");
            worksheetRow1.Cells.Add(worksheetCell);
            
            workbook.Save(OutputFileName);
        }
    }
}
