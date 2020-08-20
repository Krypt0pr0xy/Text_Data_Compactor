using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace text_data_compactor
{
    public partial class Form1 : Form
    {
        string Output_File = "";
        string Data;
        public Form1()
        {
            InitializeComponent();
            InputFiles_lb.Sorted = true;
        }
        //__________________________________________________________________________________________________________________________________________
        //Fügt Text im log Block an
        private void appendLogTextBox(String input)
        {
            //*****************************************************
            //Zeitstempel Hinzufügen
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();
            log_tb.Text += ("[" + dtn + "] " + input + "\r\n");
            //*****************************************************
            //Automatisches Scrollen
            log_tb.SelectionStart = log_tb.Text.Length;
            log_tb.ScrollToCaret();

        }
        //__________________________________________________________________________________________________________________________________________
        //Automatische Datei Pfad erkennung bei Drag and Drop
        private void InputFiles_lb_DragDrop(object sender, DragEventArgs e)
        {
            //*****************************************************
            //File namen in String Array Speichern
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            //*****************************************************
            //Schleiffe für jedes File im String Array
            foreach (string file in files)
            {
                //*****************************************************
                //Abfrage für gleichen Datei Pfad 
                if (!InputFiles_lb.Items.Contains(file))
                {
                    InputFiles_lb.Items.Add(file);
                    appendLogTextBox("File added: " + file);
                }
                //*****************************************************
                //Feheler ausgabe das File bereits hinzugefügt wurde
                else
                {
                    appendLogTextBox("File already exists" + file);
                }

            }
        
        }
        //*****************************************************
        //Übernimmt werde von Drag wenn datei hineingezogen wird
        private void InputFiles_lb_DragEnter(object sender, DragEventArgs e)
        {
            //*****************************************************
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
        //__________________________________________________________________________________________________________________________________________
        //Haput Funktion Verbindet die Jeweiligen Dateien
        private void convert_bt_Click(object sender, EventArgs e)
        {
            //*****************************************************
            //Prüft die Input und Output Files
            if (!(InputFiles_lb.Items.Count == 0) && !(Output_File == ""))
            {
                appendLogTextBox("Convertion Started");

                //*****************************************************
                //Fügt den Inhalt von den Dateien in die Output Datei ein
                foreach (string file in InputFiles_lb.Items)
                {
                    try {Data = File.ReadAllText(file); }
                    catch (Exception ex) { appendLogTextBox("Error: " + ex); }
                    using (StreamWriter w = File.AppendText(Output_File))
                    {
                        w.Write(Data);
                    }
                }
                //*****************************************************
                //String löschen damit der Ram nicht überfüllt
                Data = "";
                appendLogTextBox("Convertion Finished");

                //*****************************************************
                //Zusatzfunktion für entfernen von bestimmten Daten sätze und Neuen HEader gebung 
                if (excluding_Yes_rb.Checked || adHeader_Yes_rd.Checked)
                {
                    try {Data = File.ReadAllText(Output_File);}
                    catch (Exception ex){appendLogTextBox("Error: " + ex);}
                    

                    //*****************************************************
                    //Excluding Funktion entfernt ungewünschte Datensätze
                    if (excluding_Yes_rb.Checked)
                    {
                        appendLogTextBox("Excluding Started");
                        //*****************************************************
                        //Überprüffen des inhaltes von der excluding TextBox
                        if (excluding_tb.Text == "")
                        {
                            appendLogTextBox("Error no Excluding Text found");
                        }
                        //*****************************************************
                        //Wenn inhalt exsistiert dieser im Ganzen Output FIle durch suchen und mit nichts ersetzen
                        else
                        {
                            Data = Data.Replace(excluding_tb.Text, "");
                        }
                        appendLogTextBox("Excluding Finished");
                    }

                    //*****************************************************
                    //FUnktion Für header anfügung
                    if (adHeader_Yes_rd.Checked)
                    {
                        appendLogTextBox("Ad Header Started");
                        //*****************************************************
                        //Überprüffen des inhaltes von der adHeader TextBox
                        if (adHeader_tb.Text == "")
                        {
                            appendLogTextBox("Error no Header Text found");
                        }
                        //*****************************************************
                        //Wenn inhalt exsistiert am anfang des Dokumentes Hinzufügen
                        else
                        {
                            Data = adHeader_tb.Text + Data;
                        }
                        appendLogTextBox("Ad Header Finished");
                    }
                    //*****************************************************
                    //Inhalt des Output File Löschen und bearbeiteter STring Neu Hinzufügen
                    try { File.WriteAllText(Output_File, string.Empty);}
                    catch (Exception ex) { appendLogTextBox("Error: " + ex); }

                    using (StreamWriter w = File.AppendText(Output_File))
                    {
                        w.Write(Data);
                    }
                    appendLogTextBox("File recreated");
                }
            }
            //*****************************************************
            //Fehler ausgabe kein/e InputFiles Gefunden oder kein Output File gefunden
            else if (InputFiles_lb.Items.Count == 0)
            { appendLogTextBox("Error: No  Input Items"); }
   
            else if (Output_File == "")
            { appendLogTextBox("Error: No Output Items"); }

            //String löschen damit der Ram nicht überfüllt
            Data = "";

        }
        //__________________________________________________________________________________________________________________________________________
        //lösch funktion der ausgewählten objekte
        private void Delete_bt_Click(object sender, EventArgs e)
        {
            //*****************************************************
            ///Überprüfung des selectierten Objekt
            if (InputFiles_lb.SelectedIndex == -1)
            {
                appendLogTextBox("No Item is selected");
            }
            //*****************************************************
            //entfernen des ausgewählten Objekt
            else
            {
                string curItem = InputFiles_lb.SelectedItem.ToString();
                appendLogTextBox("Removed selected Item: " + curItem);
                InputFiles_lb.Items.Remove(curItem);
            }  
        }
        //__________________________________________________________________________________________________________________________________________
        //Daten Hinzufügen ohne Drag and Drop
        private void add_bt_Click(object sender, EventArgs e)
        {
            //*****************************************************
            //Dialog feld öffen für hinzufügung der Daten
            OpenFileDialog Open_file = new OpenFileDialog();
            Open_file.Filter = "TXT(*.txt)|*.txt";
            if(Open_file.ShowDialog() == DialogResult.OK)
            {
                //*****************************************************
                //Wenn FIles noch nicht exsistieren in Liste Hinzufügen
                if (!InputFiles_lb.Items.Contains(Open_file.FileName))
                {
                    InputFiles_lb.Items.Add(Open_file.FileName);
                    appendLogTextBox("File has been added: " + Open_file.FileName);
                }
                //*****************************************************
                //Error Nachricht das ,dass File bereits exsistiert
                else
                {
                    appendLogTextBox("File already exists" + Open_file.FileName);
                }
                
            }
        }
        //__________________________________________________________________________________________________________________________________________

        private void Create_bt_Click(object sender, EventArgs e)
        {
            //*****************************************************
            //Dialog feld öffen für abspeicherungen der Daten
            SaveFileDialog Save_file = new SaveFileDialog();
            Save_file.Filter = "TXT(*.txt)|*.txt";
            if(Save_file.ShowDialog() == DialogResult.OK)
            {
                Output_tb.Text = Save_file.FileName;
                appendLogTextBox("Output Files has been selected:  " + Save_file.FileName);
            }
            Output_File = Save_file.FileName;
            //*****************************************************
            //Auto scroll
            Output_tb.Focus();
            Output_tb.Select(Output_tb.Text.Length, 0);
        }


        //__________________________________________________________________________________________________________________________________________
        //Sichtbarkeit der Tesxtboxen steuern 
        private void excluding_No_rb_CheckedChanged(object sender, EventArgs e)
        {
            excluding_tb.Visible = false;
        }

        private void adHeader_No_rd_CheckedChanged(object sender, EventArgs e)
        {
            adHeader_tb.Visible = false;
        }

        private void excluding_Yes_rb_CheckedChanged(object sender, EventArgs e)
        {
            excluding_tb.Visible = true;
        }

        private void adHeader_Yes_rd_CheckedChanged(object sender, EventArgs e)
        {
            adHeader_tb.Visible = true;
        }

        private void autosort_No_rb_CheckedChanged(object sender, EventArgs e)
        {
            //*****************************************************
            //Nicht sortiert nach Name 
            InputFiles_lb.Sorted = false;
        }

        private void autosort_Yes_rb_CheckedChanged(object sender, EventArgs e)
        {
            //*****************************************************
            //Sortiert nach Name
            InputFiles_lb.Sorted = true;
        }
    }
}
