using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace OJTProjectFrom
{
    public partial class OJTProjectForm : Form
    {
        private readonly OJTProjectEntities _db;
        FileSystemWatcher watcher;
        private bool isWatching;
        public OJTProjectForm()
        {
            InitializeComponent();
            _db = new OJTProjectEntities();
            watcher = new FileSystemWatcher();
        }
        private void OJTProjectForm_Load(object sender, EventArgs e)
        {
            var OJTProjectList = _db.OJTProjects
                                  .Select(q => new
                                  {
                                      q.Id,
                                      q.FileName,
                                      q.Status
                                  }).ToList();
            gvOJTProjectList.DataSource = OJTProjectList;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            var newFilename = e.Name;
            var renameFileList = new OJTProject
            {
                FileName = newFilename,
                Status = "File Updated"
            };
            _db.OJTProjects.Add(renameFileList);
            _db.SaveChanges();
            MessageBox.Show("File Updated");
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            var newFilename = e.Name;
            var renameFileList = new OJTProject
            {
                FileName = newFilename,
                Status = "File Created"
            };
            _db.OJTProjects.Add(renameFileList);
            _db.SaveChanges();
            MessageBox.Show("File Created");
        }

        private void PopulateGrid()
        {
            var OJTProjectList = _db.OJTProjects
                                  .Select(q => new
                                  {
                                      q.Id,
                                      q.FileName,
                                      q.Status
                                  }).ToList();
            gvOJTProjectList.DataSource = OJTProjectList;
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            var newFilename = e.Name;
            var renameFileList = new OJTProject
            {
                FileName = newFilename,
                Status = "File Deleted"
            };
            _db.OJTProjects.Add(renameFileList);
            _db.SaveChanges();
            MessageBox.Show("File Deleted");
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            var newFilename = e.Name;
            var renameFileList = new OJTProject
            {
                FileName = newFilename,
                Status = "File Renamed"
            };
            _db.OJTProjects.Add(renameFileList);
            _db.SaveChanges();
            MessageBox.Show("File Renamed");
        }

        private void btnStartWatching_Click(object sender, EventArgs e)
        {
            if (btnStartWatching.Text == "Start Watching")
            {
                btnStartWatching.Text = "Stop Watching";
                isWatching = true;
                if (isWatching)
                {
                    watcher = new FileSystemWatcher();
                    watcher.Path = @"D:\CarRentalProject\Testing";
                    watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                       | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                    watcher.Filter = "*.";
                    watcher.EnableRaisingEvents = true;
                    watcher.Changed += new FileSystemEventHandler(fileSystemWatcher1_Changed);
                    watcher.Created += new FileSystemEventHandler(fileSystemWatcher1_Created);
                    watcher.Deleted += new FileSystemEventHandler(fileSystemWatcher1_Deleted);
                    watcher.Renamed += new RenamedEventHandler(fileSystemWatcher1_Renamed);
                    PopulateGrid();
                    isWatching = false;
                }
            }
            else if (btnStartWatching.Text == "Stop Watching")
            {
                btnStartWatching.Text = "Start Watching";
                watcher.EnableRaisingEvents = false;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var exportdata = _db.OJTProjects
               .Select(q => new
               {
                   id = q.Id,
                   name = q.FileName,
                   status = q.Status,
               }).ToList();
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("File Name", typeof(string));
            table.Columns.Add("File Status", typeof(string));
            //Row Data
            //data  
            foreach (var files in exportdata)
            {
                table.Rows.Add(files.id, files.name, files.status);
            }
            string filename = @"D:\CarRentalProject\Testing\data.csv";
            table.ToCSV(filename);
        }
        private void btnStartWatching_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

