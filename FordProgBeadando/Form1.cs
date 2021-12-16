using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FordProgBeadando
{
    public partial class Form1 : Form
    {


        string inputFile;
        string outputFile = "";
        string inputFileName = "input.txt";
        string outputFileName = "export.txt";
        string[] inputSplit;
        string[] inputSplitrow;    

        string input;
        string allapot;
        string szamok = "";       

        public Form1()
        {
            InitializeComponent();
            Read(inputFileName);
            ReadTxt();
            testrtb.Visible = false;      
        }

        
        private void ClearTable()
        {
            dGV1.Columns.Clear();
            dGV1.Rows.Clear();
        }

        private void WriteTxt()
        {
            for (int i = 0; i < dGV1.RowCount; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < dGV1.ColumnCount; j++)
                    {
                        outputFile += dGV1.Columns[j].HeaderText;
                        if (j < dGV1.ColumnCount - 1)
                            outputFile += ';';
                    }
                    outputFile += "\n";
                }
                for (int j = 0; j < dGV1.ColumnCount; j++)
                {
                    if (j == 0)
                    {
                        outputFile += dGV1.Rows[i].HeaderCell.Value + ";";
                    }
                    outputFile += dGV1[j, i].Value;
                    if (j < dGV1.ColumnCount - 1)
                        outputFile += ";";
                    else
                        outputFile += "\n";
                }
            }
        }

        private void ReadTxt()
        {
            inputSplit = inputFile.Split('\n');
            for (int i = 0; i < inputSplit.Length; i++)
            {
                inputSplitrow = inputSplit[i].Split(';');
                if (i == 0)
                {
                    for (int j = 0; j < inputSplitrow.Length; j++)
                    {
                        dGV1.Columns.Add(inputSplitrow[j], inputSplitrow[j]);
                    }
                }
                dGV1.Rows.Add();
                for (int j = 0; j < inputSplitrow.Length; j++)
                {
                    if (j == 0)
                    {
                        if (i > 0)
                        {
                            dGV1.Rows[i].HeaderCell.Value = inputSplitrow[j];
                        }
                    }
                    else
                    {
                        dGV1[j - 1, i].Value = inputSplitrow[j];
                    }
                }

            }
            dGV1.Rows.RemoveAt(0);
        }

        public void Read(string fname)
        {
            StreamReader sr = new StreamReader(File.OpenRead(@fname));
            inputFile = sr.ReadToEnd();
            sr.Close();
        }

        public void Write()
        {
            StreamWriter sw = new StreamWriter(File.OpenWrite(@outputFileName));
            sw.Write(outputFile);
            sw.Flush();
            sw.Close();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            szamok = "";
            rTB.Text = "";
            int rowindex = -1;
            int columnindex = -1;          

            allapot = dGV1.Rows[0].HeaderCell.Value.ToString() + "#";
            input = tBInput.Text;
            input = Regex.Replace(input, "[0-9]", "i");
            input = Regex.Replace(input, " ", "");

            if (input[input.Length - 1] != '#')
            {
                input = input + "#";
                tBInput.Text = input;

            }
                
            string actstate = allapot[0].ToString();
            
            rTB.AppendText(input + "," + allapot + "," + szamok);
            while (true)
            {
                columnindex = -1;
                rowindex = -1;
                if (allapot[1].ToString() == "'") { actstate = allapot[0].ToString() + allapot[1].ToString(); }
                else { actstate = allapot[0].ToString(); }
                for (int i = 0; i < dGV1.Rows.Count - 1; i++)
                {
                    if (actstate == dGV1.Rows[i].HeaderCell.Value.ToString())
                    {
                        rowindex = i;
#region debug 
                        //teszteles
                        testrtb.AppendText("1" + "\n ");
                        testrtb.AppendText( "allapot: " + allapot + ", actallitas :" + actstate +", bemenet: "+ input + "\n ");
                        #endregion
                    }
                }

                if (rowindex == -1)
                {
                   rTB.Text += string.Format("\nHiba a bemeneti állapot `{0}´ karakternél", actstate);
#region debug 
                    //teszteles
                    testrtb.AppendText("2" + "\n ");
                    testrtb.AppendText("allapot: " + allapot + ", actallitas :" + actstate + "bemenet: " + input + "\n ");
                    #endregion
                    break;                
                }

                for (int i = 0; i < dGV1.ColumnCount; i++)
                {
                    if (input[0].ToString() == dGV1.Columns[i].Name.ToString())
                    {
                        columnindex = 0;
#region debug 
                        //teszteles
                        testrtb.AppendText("3" + "\n ");
                        testrtb.AppendText("allapot: " + allapot + ", actallitas :" + actstate + "bemenet: " + input + "\n ");
                        testrtb.AppendText(input[0].ToString() + "==???=="+ dGV1.Columns[i].Name.ToString() + "column index= "+columnindex+"\n ");
                        #endregion
                    }
                }
                if (columnindex == -1)
                {
                   rTB.Text += string.Format("\nHiba a bemenetben a `{0}´ karakternél", input[0]);
#region debug 
                             //teszteles
                             testrtb.AppendText("4" + "\n ");
                            testrtb.AppendText("allapot: " + allapot + ", actallitas :" + actstate + "bemenet: " + input + "\n ");
                    #endregion
                    break;                
                 }

                string command = dGV1[input[0].ToString(), rowindex].Value.ToString();
                switch (command)
                {
                    case "pop":
                    {
                        input = input.Substring(1);
                        allapot = allapot.Substring(1);
                        rTB.AppendText("\n" + input + "," + allapot + "," + szamok);
#region debug 
                            //teszteles
                            testrtb.AppendText("5" + "\n ");
                            testrtb.AppendText("comman: "+command+", allapot: " + allapot + ", actallitas :" + actstate + "bemenet: " + input + "\n ");
                            #endregion
                        break;
                    }

                    case "error":
                    {
                        rTB.AppendText("\n" + input + "," + allapot + "," + szamok);
                        rTB.AppendText(String.Format(" Hiba a bemenetben a `{0}´ karakternél", input[0]));
# region debug 
                            //teszteles
                            testrtb.AppendText("6" + "\n ");
                            testrtb.AppendText("comman: " + command + ", allapot: " + allapot + ", actallitas :" + actstate + "bemenet: " + input + "\n ");
#endregion 
                        break;
                     }
                    default:
                     {
                         try
                         {
                             szamok += command.Split(',')[1].Substring(0, 1);
                             if ((command.Split(',')[0])[1] == '$')
                             {
                                 if (allapot[1].ToString() == "'") { allapot = allapot.Substring(2); }
                                 else { allapot = allapot.Substring(1); }
                                 rTB.AppendText("\n" + input + "," + allapot + "," + szamok);
#region debug 
                                    //teszteles
                                    testrtb.AppendText("7" + "\n ");
                                    testrtb.AppendText("comman: " + command + ", allapot: " + allapot + ", actallitas :" + actstate + "bemenet: " + input + "\n ");
                                    #endregion
                             }
                             else
                             {
                                 if (allapot[1].ToString() == "'") { allapot = command.Split(',')[0].Substring(1) + allapot.Substring(2); }
                                 else { allapot = command.Split(',')[0].Substring(1) + allapot.Substring(1); }
                                 rTB.AppendText("\n" + input + "," + allapot + "," + szamok);
#region debug 
                                    //teszteles
                                    testrtb.AppendText("8" + "\n ");
                                    testrtb.AppendText("comman: " + command + ", allapot: " + allapot + ", actallitas :" + actstate + "bemenet: " + input + "\n ");
                                    #endregion
                             }
                         }
                         catch
                         {
                             rTB.AppendText(String.Format("A {0} oszlop, {1}. sorának utasítása hibás", input[0].ToString(), rowindex));
#region debug 
                                //teszteles
                                testrtb.AppendText("9" + "\n ");
                                testrtb.AppendText("comman: " + command + ", allapot: " + allapot + ", actallitas :" + actstate + "bemenet: " + input + "\n ");
                                #endregion
                         }
                      break;
                     }
                }
                if (input == allapot && allapot == "#")
                {
                    rTB.AppendText("\n" + input + "," + allapot + "," + szamok + " elfogadva");
#region debug 
                    //teszteles
                    testrtb.AppendText("10" + "\n ");
                    testrtb.AppendText("comman: " + command + ", allapot: " + allapot + ", actallitas :" + actstate + "bemenet: " + input + "\n ");
                    #endregion
                      break;
                }
                if (command == "error")
                {
#region debug 
                    //teszteles
                    testrtb.AppendText("11" + "\n ");
                    testrtb.AppendText("comman: " + command + ", allapot: " + allapot + ", actallitas :" + actstate + "bemenet: " + input + "\n ");
                    #endregion
                     break;
                }
                if (sw.Elapsed > TimeSpan.FromMilliseconds(500))
                    break;
            }

               
        }

        private void BtnTablazatBetolt_Click(object sender, EventArgs e)
        {
            ofp.Filter = "Text|*.txt*.*";
            ofp.ShowDialog();
            StreamReader sr = new StreamReader(File.OpenRead(ofp.FileName));
            inputFile = sr.ReadToEnd();
            ClearTable();
            ReadTxt();
        }

        private void BTNTablaTorol_Click(object sender, EventArgs e)
        {
            ClearTable();
        }

        private void btnSaveOutput_Click(object sender, EventArgs e)
        {

            StreamWriter writer = File.AppendText(outputFileName);
            writer.Write(rTB.Text);
            writer.Close();
        }

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Text|*.txt*.*";
            sfd.ShowDialog();
            StreamWriter sw = new StreamWriter(File.OpenWrite(@sfd.FileName));
            WriteTxt();
            sw.Write(outputFile);
            sw.Flush();
            sw.Close();
        }
    }
}
