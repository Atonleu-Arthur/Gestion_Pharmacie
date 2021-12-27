using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using ProjetPharmacie.BO;
using _Excel = Microsoft.Office.Interop.Excel;

namespace FormPharmacie
{
  public  class FicheMedocsExcel
    {
        string path = "";
        _Application excel = new  _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public FicheMedocsExcel (string path , int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }
        public String ReadCell(int i , int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
                return ws.Cells[i, j].Value2;
            else
                return "";
        }
        public string[,] ReadRange(int starti , int starty , int endi, int endy)
        {
            Range range = (Range)ws.Range[ws.Cells[starti, starty], ws.Cells[endi, endy]];
            object[,] holder = range.Value2;
            string[,] returnstring = new string[endi - starti, endy - starty];
            for(int p=1;p<= endi- starty;p++)
            {
                for(int q=1; q<= endy-starty; q++)
                {
                    returnstring[p - 1, q - 1] =holder[p, q].ToString() ;
                }
            }
            return returnstring; 
         }
    }
}
