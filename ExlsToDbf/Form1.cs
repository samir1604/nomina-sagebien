using Aspose.Zip;
using Aspose.Zip.Saving;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace ExlsToDbf
{
    public partial class Forma : Form
    {
        private static string dbFileName = "\\nomina.dbf";
        private static string zipFileName = "\\nomina.zip";
        private static string actualWorksheet = "Pago";        
        private static string numIdeper = "num_ideper";
        private static string ctaMnac = "cta_mnac";
        private static string ctaMlc = "cta_mlc";
        private static string importeD = "importe_d";
        private static string importeN = "importe_n";
        
        private DataTable? dt;        

        public Forma()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            openFileDialog();
        }

        private void openFileDialog() {

            using (var openDiaglog = new OpenFileDialog
            {
                FileName = "Select a xls file",
                Filter = "Excel file (*.xls, *.xlsm)|*.xls;*.xlsm",
                Title = "Open xls file"
            })
            {
                if (openDiaglog.ShowDialog() == DialogResult.OK)
                {
                    tBoxPath.Text = openDiaglog.FileName;
                }
            };

        }

        

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (dt == null || dt.Rows.Count <= 0) {
                MessageBox.Show("No hay datos para convertir", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string outputDir = Path.GetDirectoryName(tBoxPath.Text)!;
                string dbf = outputDir + dbFileName;
                string zip = outputDir + zipFileName;
                createDbf(outputDir);
                createZip(dbf, zip);
                MessageBox.Show("El archivo nomina se ha creado correctamente", "Ok", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err) {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createDbf(string filename) 
        {
            Dictionary<string, string> fields = new()
            {
                { numIdeper, "C(11)"  },
                { ctaMnac, "C(16)" },
                { ctaMlc, "C(1)" },
                { importeD, "C(1)" },
                { importeN, "N(8,2)" }
            };


            if (string.IsNullOrWhiteSpace(filename)) {              
                MessageBox.Show("No hay datos para convertir", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 

            if (File.Exists(filename)) File.Delete(filename);            
                                    
            string createSql = "CREATE TABLE nomina (";
            

            foreach (var (item, index) in fields.Select((item, index) => (item, index)))
            {
                createSql += $"{item.Key} {item.Value}{(index != fields.Count -1 ? ", " : ")")}";
            }                 
            
            using (var cnn = new OleDbConnection(GetCnn(filename)))
            {
                cnn.Open();
                var cmd = new OleDbCommand(createSql, cnn);
                cmd.ExecuteNonQuery();

                foreach (DataRow row in dt!.Rows)
                {
                    string insertSql = $"INSERT INTO nomina ({numIdeper}, {ctaMnac}, {importeN}) VALUES(";
                    string? num = row[0].ToString();
                    string? cta = row[1].ToString();
                    decimal? importe = Decimal.Parse(row[2].ToString()!);
                    insertSql += $"'{num}', '{cta}', {importe}";
                    insertSql += ")";

                    cmd = new OleDbCommand(insertSql, cnn);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static  string GetCnn(string filename)
        {            
            return "Provider=VFPOLEDB.1;Data Source=" + filename + ";Extended Properties=dBASE IV;";            
        }

        private void loadExcelData(string filename)
        {
            int totalPerson = 0;
            double totalSalary = 0;
            int indexCi = 0;
            int indexCtaMn = 0;
            int indexImporteMn = 0;

            if (filename == string.Empty) return;

            tBoxPath.Text = filename;
            dt = new DataTable();

            Cursor.Current = Cursors.WaitCursor;

            using (XLWorkbook workbook = new XLWorkbook(filename))
            {
                bool isFirstRow = true;
                var rows = workbook.Worksheet(actualWorksheet).RowsUsed();
                foreach (var row in rows)
                {
                    if (isFirstRow)
                    {
                        foreach (IXLCell cell in row.CellsUsed())
                        {
                            if (!String.IsNullOrEmpty(cell.Value.ToString()))
                                dt.Columns.Add(cell.Value.ToString());


                            if (cell.Value.ToString() == "CI")
                            {
                                indexCi = cell.Address.ColumnNumber;
                            }

                            if (cell.Value.ToString() == "CtaMN")
                            {
                                indexCtaMn = cell.Address.ColumnNumber;
                            }

                            if (cell.Value.ToString() == "ImporteMN")
                            {
                                indexImporteMn = cell.Address.ColumnNumber;
                            }
                        }
                        isFirstRow = false;
                    }
                    else
                    {
                        if (row.Cell(indexCi).Value.ToString() == String.Empty &&
                           row.Cell(indexCtaMn).Value.ToString() == String.Empty)
                        {
                            double total = 0;
                            double.TryParse(row.Cell(indexImporteMn).Value.ToString(), out total);


                            if (total <= 0) throw new Exception("Posible error comprando el total a pagar.");

                            //totalSalary = totalSalary / 2;
                            if (total.CompareTo(totalSalary) != 0)
                            {
                                throw new Exception("Error comparando el importe total con el importe total actual .");
                            }
                            break;
                        }
                        else
                        {
                            dt.Rows.Add();
                            int i = 0;
                            foreach (IXLCell cell in row.CellsUsed())
                            {
                                dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                            }

                            double importe = 0;
                            row.Cell(indexImporteMn).TryGetValue(out importe);
                            totalSalary += importe;
                        }
                    }

                    totalPerson++;
                }

                lblSumTotal.Text = (totalPerson -1).ToString();
                lblSumaMoney.Text = totalSalary.ToString();

                Grid.DataSource = dt.DefaultView;
                Cursor.Current = Cursors.Default;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tBoxPath.Text)) 
            {
                MessageBox.Show("Especique el archivo excel que contiene los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!File.Exists(tBoxPath.Text)) 
            {
                MessageBox.Show("El archivo excel no se encuentra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                loadExcelData(tBoxPath.Text.Trim());
                MessageBox.Show("Datos cargados correctamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err) {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void createZip(string dbFilename, string zipFilename)
        {

            using (FileStream zipFile = File.Open(zipFilename, FileMode.Create))
            {
                // Archivo que se agregará al archivo
                using (FileStream source1 = File.Open(dbFilename, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (var archive = new Archive(new ArchiveEntrySettings()))
                    {
                        // Agregar archivo al archivo
                        archive.CreateEntry("nomina.dbf", source1);
                        // archivo zip
                        archive.Save(zipFile, new ArchiveSaveOptions() { Encoding = System.Text.Encoding.ASCII });
                    }
                }
            }
        }
    }    
}