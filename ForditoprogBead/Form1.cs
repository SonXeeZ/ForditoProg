using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ForditoprogBead
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();

        bool debugmode = false;
        bool stepByStep = false;
        int steps = 0;

        //input variables
        string inputFile;
        string inputFileName = "bemenet.txt";

        string input;
        string stack;
        string numbers;

        string[] splitInputColumn;
        string[] splitInputRow;
        int inputIndex;

        // output variables
        string outputFile = "";
        string outputFileName = @"C:\Users\sonxe\source\repos\ForditoprogBead\ForditoprogBead\bin\Debug\kimenet.txt";
        


        public Form1()
        {
            InitializeComponent();
            ReadFromFile("bemenet.txt");
            Read();
        }

        void ReadFromFile(string fileName)
        {
            StreamReader sr = new StreamReader(File.OpenRead(@fileName));
            inputFile = sr.ReadToEnd();
            sr.Close();
        }

        void Read()
        {
            splitInputColumn = inputFile.Split('\n');

            // terminális jelek hozzáadása az első sorhoz.
            for (int i = 0; i < splitInputColumn.Length; i++)
            {
                splitInputRow = splitInputColumn[i].Split(';');
                if(i == 0)
                {
                    for (int j = 0; j < splitInputRow.Length; j++)
                    {
                        table_DGW.Columns.Add(splitInputRow[j], splitInputRow[j]);
                        if (debugmode)
                            MessageBox.Show("Hozzáadott érték: " + splitInputRow[j]);
                    }
                }
                    

                table_DGW.Rows.Add();

                // nem terminális jelek az első oszlopba.
                for (int j = 0; j < splitInputRow.Length; j++)
                {
                    if (j == 0)
                    {
                        if (0 < i )
                            table_DGW.Rows[i].HeaderCell.Value = splitInputRow[j];
                            if (debugmode)
                            MessageBox.Show("Hozzáadott érték: " + splitInputRow[j]);
                    }else
                    {
                        //Beolvasott táblázat elemei.
                        table_DGW[j - 1, i].Value = splitInputRow[j];
                        if(debugmode)
                        MessageBox.Show("i értéke: " + i + " j értéke: " + j + " Hozzáadott érték: " + splitInputRow[j]);
                    }
                } 

            }
            table_DGW.Rows.RemoveAt(0);
        }

        void clearTable()
        {
            table_DGW.Rows.Clear();
            table_DGW.Columns.Clear();
        }

        void Write()
        {
            StreamWriter sw = new StreamWriter(File.OpenWrite(outputFileName));
            sw.Write(outputFile);
            sw.Flush();
            sw.Close();
        }


        public void ok_BT_Click(object sender, EventArgs e)
        {
            int rowIndex = -1;
            int columnIndex = -1;
            outputWindow.Text = "";
            numbers = "";

            stack = table_DGW.Rows[0].HeaderCell.Value.ToString() + "#";
            input = convertedInputText_TB.Text;
            

            if (input[input.Length - 1] != '#')
            {
                input = input + "#";
                convertedInputText_TB.Text = input;
            
            }

            string actStack = stack[0].ToString();
            WriteFormattedOutputWindow(outputWindow, input, stack, numbers);

            if (debugmode)
            {
                MessageBox.Show("stack: " + stack);
                MessageBox.Show("input: " + input);
                MessageBox.Show("Actual stack:" + actStack);
            }

            bool isCorrect = false;
            bool isError = false;
            
           while (!isCorrect || !isError )
           {
               columnIndex = -1;
               rowIndex = -1;
       
               if(stack[1].ToString() == "'")
               {
                   actStack = stack[0].ToString() + stack[1].ToString();
                   if (debugmode)
       
                       MessageBox.Show("Actual stack: " + actStack);
               }
               else
               {
                   actStack = stack[0].ToString();
               }
       
               for (int i = 0; i < table_DGW.Rows.Count-1; i++)
               {
                   if(actStack == table_DGW.Rows[i].HeaderCell.Value.ToString())
                   {
                       rowIndex = i;
                       if (debugmode)
                           MessageBox.Show(table_DGW.Rows[i].HeaderCell.Value.ToString() + " =  " + actStack + " Megvan. -> Sor:[" + i + "]");
                   }
               }
       
               if(rowIndex == -1)
               {
                    WriteFormattedOutputWindow(outputWindow,input, actStack);
                    break;
               }
               
               // 1. sorban keresünk fent a terminális jelek között.
       
               for (int i = 0; i < table_DGW.ColumnCount; i++)
               {
                   if (input[0].ToString() == table_DGW.Columns[i].Name.ToString())
                   {
                       columnIndex = 0;
                       if (debugmode)
                           MessageBox.Show(table_DGW.Columns[i].Name.ToString() + " =  " + input[0].ToString() + " Megvan. -> OSZLOP:["+i+"]");
                   }
               }
       
               // ha nem találtuk meg a terminális jelet.
               if(columnIndex == -1)
               {
                   WriteFormattedOutputWindow(outputWindow, input, 0);
                   break;
               }
       
               string rule = table_DGW[input[0].ToString(), rowIndex].Value.ToString();
       
               if (debugmode)
               {
                   MessageBox.Show("Input: " + input); // i
                   MessageBox.Show("" + table_DGW[input[0].ToString(), rowIndex].Value.ToString());
                   MessageBox.Show(rule);
               }

                switch (rule)
                {
                    case "-":
                        {
                            WriteFormattedOutputWindow(outputWindow, input,stack,numbers);
                            WriteFormattedOutputWindow(outputWindow, input, 0);
                            break;
                        }
               
                    case "pop":
                        {
                            input = input.Substring(1);
                            stack = stack.Substring(1);
                            WriteFormattedOutputWindow(outputWindow, input, stack, numbers);
                            break;
                        }
               
                        default:
                        {
                            try
                            {
                                numbers += rule.Split(',')[1].Substring(0, 1);
                                if((rule.Split(',')[0])[1] == '$')
                                {
                                    if(stack[1].ToString() == "'")
                                    {
                                        stack = stack.Substring(2);
                                    }
                                    else
                                    {
                                        stack = stack.Substring(1);
                                    }
                                    WriteFormattedOutputWindow(outputWindow, input, stack, numbers);
                                }
                                else
                                {
                                    if(stack[1].ToString() == "'")
                                    {
                                        stack = rule.Split(',')[0].Substring(1) + stack.Substring(2);
                                    }
                                    else
                                    {
                                        stack = rule.Split(',')[0].Substring(1) + stack.Substring(1);
                                    }
                                    WriteFormattedOutputWindow(outputWindow, input, stack, numbers);
                                }
               
                            }
                            catch
                            {
                                WriteFormattedOutputWindow(outputWindow, input, 0 , rowIndex);
                            }
                            break;
                        }
                }
                if (stack == "#" && input == stack)
                {
                    WriteFormattedOutputWindow(outputWindow, input, stack, numbers);
                    outputWindow.AppendText("\nELFOGADVA.");
                    isCorrect = true;
                    break;
                }
               
                if(rule == "-")
                {
                    isError = true;
                    MessageBox.Show("A program hibára futott.");
                    break;
                }

                if (stepByStep)
                {
                    steps++;
                    MessageBox.Show(steps + ".lépés");
                }


            }

            if (debugmode)
                MessageBox.Show("A program lefutott..");

            stepByStep = false;
            steps = 0;
        }

        void ClearTable()
        {
            table_DGW.Columns.Clear();
            table_DGW.Rows.Clear();
        }

        private void convert_BT_Click(object sender, EventArgs e)
        {
            convertedInputText_TB.Text = Regex.Replace(InputText_TB.Text, "[0-9]+", "i") + "#";
        }
        
        void WriteFormattedOutputWindow(RichTextBox window, string input, int i)
        {
            window.Text += string.Format("\nHiba a(z) {0} karakternél.", input[i]);

        }
        void WriteFormattedOutputWindow(RichTextBox window, string input, string i)
        {
            int c = i[0];
            window.Text += string.Format("\nHiba a(z) {0} karakternél.", input[c]);

        }
        void WriteFormattedOutputWindow(RichTextBox window, string input, int i, int rowIndex)
        {
            window.Text += string.Format("\nA {0} oszlop, {1}. sorának utasítása hibás", input[i].ToString(), rowIndex);
        }
        void WriteFormattedOutputWindow(RichTextBox window, string input, int i, string numbers)
        {
            outputWindow.Text += string.Format("\nHiba a(z) {0} karakternél.", input[i]);
        }
        void WriteFormattedOutputWindow(RichTextBox window, string input, string stack, string numbers)
        {
            window.AppendText(input + "," + stack + "," + numbers + "\n");
        }
        void WriteFormattedOutputWindow(RichTextBox window, string input, string stack, int numbers)
        {
            window.AppendText(input + "," + stack + "," + numbers + "\n");
        }

        private void okStepByStep_BT_Click(object sender, EventArgs e)
        {
            stepByStep = true;
            ok_BT_Click(sender,e);
        }

        private void importTbl_BT_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Text|*.txt*.*";
            ofd.ShowDialog();
            StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
            inputFile = sr.ReadToEnd();
            ClearTable();
            Read();
        }

        private void deleteTbl_BT_Click(object sender, EventArgs e)
        {
            ClearTable();
        }

        private void saveOutput_BT_Click(object sender, EventArgs e)
        {
            File.WriteAllText(outputFileName, String.Empty);
            StreamWriter writer = File.AppendText(outputFileName);
            writer.Write(outputWindow.Text);
            writer.Close();
            MessageBox.Show("Output fájl mentve " + outputFileName + " helyre/néven." );
        }
    }
}
