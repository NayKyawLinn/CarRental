using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
namespace OJTProjectFrom
{
    class OperationsUtlity
    {
        
        public static DataTable createDataTable()
        {
           /* var exportdata = _db.OJTProjects
               .Select(q => new
               {
                   id = q.Id,
                   name = q.FileName,
                   status = q.Status,
               }).ToList();*/
            DataTable table = new DataTable();
            //columns  
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("File Name", typeof(string));
            table.Columns.Add("File Status", typeof(string));
            //Row Data
            //data  
           /* foreach (var files in exportdata)
            {
                table.Rows.Add(files.id, files.name, files.status);
            }*/
            return table;
        }
    }
}
