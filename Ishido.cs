using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using System.Data;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FruitIshido
{
    public partial class Ishido : Form
    {
        public Ishido()
        {
            InitializeComponent();
        }

        // Definition of variables
        
        // String arrays
        string[] sColumn = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };
        string[] sRow = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };
        string[] sFruitName = new string[] { "A", "B", "C", "D", "E", "F" };
        string[] sSteps = new string[72];          

        // Colors
        Color cBorder = Color.DarkGray;
        Color cTable = Color.LightGray;
        Color[] cStoneColor = new Color[] { Color.FromArgb(255, 185, 244), 
            Color.FromArgb(188, 255, 162), 
            Color.FromArgb(121, 252, 250), 
            Color.FromArgb(255, 253, 79), 
            Color.FromArgb(250, 250, 250), 
            Color.FromArgb(252, 191, 111) };

        // Lists of objects
        StoneList sel = new StoneList();
        StockList skl = new StockList();

        // Scores and other numbers
        Scores sc = new Scores();

        Control ThisStone;
        string sRef;

        private void FruitIshido_Load(object sender, EventArgs e)
        {
            BuildTable();
            StartGame();
        }

        private void BuildTable()
        {
            for (int i = 0; i < sRow.Length; ++i)
            {
                for (int j = 0; j < sColumn.Length; ++j)
                {
                    s = new Label();
                    s.Parent = panGame;
                    s.BorderStyle = BorderStyle.Fixed3D;
                    s.BackgroundImageLayout = ImageLayout.Stretch;
                    s.Width = panGame.Width / 12;
                    s.Height = panGame.Height / 8;
                    s.Left = j * s.Width;
                    s.Top = i * s.Height;
                    s.Name = sColumn[j] + sRow[i];                    
                    s.Text = "";
                    s.Click += new System.EventHandler(StoneClick);

                    Stone stone = new Stone(s.Name, s.Text, Color.Black);
                    sel.AddStone(stone);
                }
            }
        }

        //New Game function
        //==============================
        void StartGame()
        {
            ResetScores();
            ClearTable();
            StonesInOrder();
            MixingStones();
            DisplayFirstSixStone();
            NextStep();
            //EndOfGame(201); //Debug only
        }      

        private void ResetScores()
        {
            //Reset scores
            lblMessageDisplay.Text = "New game";
            sc = new Scores();
        }

        private void ClearTable()
        {
            //Table emptying
            for (int i = 0; i < sRow.Length; ++i)
            {
                for (int j = 0; j < sColumn.Length; ++j)
                {
                    ThisStone = this.Controls.Find(sColumn[j] + sRow[i], true).FirstOrDefault() as Control; 
                    ThisStone.Text = "";
                    ThisStone.BackgroundImage = null;

                    // Manage stone object as well
                    Stone s = sel.GetStone(sColumn[j] + sRow[i]);
                    s.Text = "";
                    s.StoneColor = Color.Black;

                    if (i == 0 || i == 7 || j == 0 || j == 11) 
                    {
                        ThisStone.BackColor = cBorder;
                        s.StoneColor = cBorder;
                    }
                    else 
                    {
                        ThisStone.BackColor = cTable;
                        s.StoneColor = cTable;
                    }                     
                }
            }
        }

        private void StonesInOrder()
        {
            skl = new StockList();

            //Stones set to stock on order 
            for (int k = 0; k < 2; ++k)
            {
                for (int i = 0; i < 6; ++i)
                {
                    for (int j = 0; j < 6; ++j)
                    {
                        Stock s = new Stock(k * 36 + (i) * 6 + j, sFruitName[i], cStoneColor[j]);
                        skl.AddStock(s);
                    }
                }
            }

            //// Debug Only
            //foreach (var stock in skl)
            //{
            //    Debug.Print("In Order: " + stock.ToString());
            //}
        }

        private void MixingStones()
        {
            //Stones mixing in store
            System.Random RandNum = new System.Random();

            for (int k = 0; k < 1000; ++k)
            {
                int randi = RandNum.Next(0, 71);
                int randj = RandNum.Next(0, 71);

                string refName = skl.Stocks.ElementAt(randi).Name;
                Color refCol = skl.Stocks.ElementAt(randi).Col;

                skl.Stocks.ElementAt(randi).Name = skl.Stocks.ElementAt(randj).Name;
                skl.Stocks.ElementAt(randi).Col = skl.Stocks.ElementAt(randj).Col;

                skl.Stocks.ElementAt(randj).Name = refName;
                skl.Stocks.ElementAt(randj).Col = refCol;
            }

            //// Debug Only
            //foreach (var stock in skl) {
            //    Debug.Print("Mixed Order: " + stock.ToString());
            //}
            
        }

        private void DisplayFirstSixStone()
        {
            //Display the first six stone, all must be different color and fruit
            string[] sStarterStones = new string[6];
            Color[] cStarterStones = new Color[6];

            string[] sStartingPositions = new string[] { "A1", "L1", "A8", "L8", "F4", "G5" };
            int iRef1, iRef2;

            Array.Copy(sFruitName, sStarterStones, 6);
            Array.Copy(cStoneColor, cStarterStones, 6);

            sc.UsedStoneNum = -1;

            for (int k = 0; k < 72; ++k)
            {
                if (sc.UsedStoneNum < 6)
                {
                    iRef1 = Array.IndexOf(sStarterStones, skl.Stocks.ElementAt(k).Name);
                    iRef2 = Array.IndexOf(cStarterStones, skl.Stocks.ElementAt(k).Col);
                    if (iRef1 > -1 && iRef2 > -1)
                    {
                        sc.UsedStoneNum = sc.UsedStoneNum + 1;                        
                        ThisStone = this.Controls.Find(sStartingPositions[sc.UsedStoneNum], true).FirstOrDefault() as Control;
                        ThisStone.Text = skl.Stocks.ElementAt(k).Name;
                        ThisStone.ForeColor = skl.Stocks.ElementAt(k).Col;
                        //ThisStone.Text = sStockName[k] + cStockColor[k]; //debug only

                        Stone s = sel.GetStone(sStartingPositions[sc.UsedStoneNum]);
                        s.Text = skl.Stocks.ElementAt(k).Name;
                        s.StoneColor = skl.Stocks.ElementAt(k).Col;

                        sRef = skl.Stocks.ElementAt(k).Name;
                        switch (sRef)
                        {
                            case "A":
                                ThisStone.BackgroundImage = Properties.Resources.A;
                                break;
                            case "B":
                                ThisStone.BackgroundImage = Properties.Resources.B;
                                break;
                            case "C":
                                ThisStone.BackgroundImage = Properties.Resources.C;
                                break;
                            case "D":
                                ThisStone.BackgroundImage = Properties.Resources.D;
                                break;
                            case "E":
                                ThisStone.BackgroundImage = Properties.Resources.E;
                                break;
                            case "F":
                                ThisStone.BackgroundImage = Properties.Resources.F;
                                break;
                        }

                        ThisStone.BackColor = skl.Stocks.ElementAt(k).Col;
                        sSteps[sc.UsedStoneNum] = sStartingPositions[sc.UsedStoneNum];
                        sStarterStones[iRef1] = "";
                        cStarterStones[iRef2] = cTable;   //point is that this is not among the properties
                        if (k != sc.UsedStoneNum)
                        {
                            //Change stones in stock as in use order
                            string refName = skl.Stocks.ElementAt(k).Name;
                            Color refCol = skl.Stocks.ElementAt(k).Col;

                            skl.Stocks.ElementAt(k).Name = skl.Stocks.ElementAt(sc.UsedStoneNum).Name;
                            skl.Stocks.ElementAt(k).Col = skl.Stocks.ElementAt(sc.UsedStoneNum).Col;

                            skl.Stocks.ElementAt(sc.UsedStoneNum).Name = refName;
                            skl.Stocks.ElementAt(sc.UsedStoneNum).Col = refCol;
                        }
                    }
                }
            }
        }


        //Next Step function
        //============================
        void NextStep()
        {
            string sRef;
            bool bEndOfGame = false;
            if (sc.UsedStoneNum < 71)
            {
                lblNextStone.Text = skl.Stocks.ElementAt(sc.UsedStoneNum + 1).Name;
                lblNextStone.ForeColor = skl.Stocks.ElementAt(sc.UsedStoneNum + 1).Col;
                sRef = skl.Stocks.ElementAt(sc.UsedStoneNum + 1).Name;
                switch (sRef)
                {
                    case "A":
                        lblNextStone.Image = Properties.Resources.A;
                        break;
                    case "B":
                        lblNextStone.Image = Properties.Resources.B;
                        break;
                    case "C":
                        lblNextStone.Image = Properties.Resources.C;
                        break;
                    case "D":
                        lblNextStone.Image = Properties.Resources.D;
                        break;
                    case "E":
                        lblNextStone.Image = Properties.Resources.E;
                        break;
                    case "F":
                        lblNextStone.Image = Properties.Resources.F;
                        break;
                }
                lblNextStone.BackColor = skl.Stocks.ElementAt(sc.UsedStoneNum + 1).Col;
                if (!Usable()) bEndOfGame = true;
            }
            else { bEndOfGame = true; }

            if (bEndOfGame)
            {
                lblMessageDisplay.Text = "End";
                if (sc.UsedStoneNum == 69) sc.EndScore = 100;
                if (sc.UsedStoneNum == 70) sc.EndScore = 500;
                if (sc.UsedStoneNum == 71) sc.EndScore = 1000;
            }

            //Score contest, the test must be carried before him, because here we have to end point
            lblUsedStoneDisplay.Text = Convert.ToString(sc.UsedStoneNum + 1);
            lblLeftStoneDisplay.Text = Convert.ToString(72 - sc.UsedStoneNum - 1); 
            sc.FinalScore = 0;
            sc.FinalScore = sc.Score + sc.FourWayScore + sc.EndScore;
            lblScoreDisplay.Text = Convert.ToString(sc.FinalScore);
            lblFourWayDisplay.Text = Convert.ToString(sc.FourWay);

            if (bEndOfGame)
            {
                EndOfGame(sc.FinalScore);  
            }
        }
        
        // Usable function
        bool Usable()
        {
            System.Windows.Forms.Control ThisStone;
            if (sc.UsedStoneNum >= 5)
            {
                for (int ii = 0; ii < sColumn.Length; ++ii)
                {
                    for (int jj = 0; jj < sRow.Length; ++jj)
                    {
                        ThisStone = this.Controls.Find(sColumn[ii] + sRow[jj], true).FirstOrDefault() as Control;
                        if (ThisStone.Text == "" && Landing(ThisStone))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            else { return true; }
        }

        string Neighbor(string FieldName, int v, int f)
        {
            if (FieldName == "") return "";
            int vv = Array.BinarySearch(sColumn, FieldName.Substring(0, 1)) + v;
            int ff = Array.BinarySearch(sRow, FieldName.Substring(1, 1)) + f;
            if (vv > -1 && ff > -1 && vv < 12 && ff < 8) return sColumn[vv] + sRow[ff];
            else return "x";
        }

        //Landing function
        bool Landing(Control NeighborStone) 
        {
            int iNeighborStoneNum = 0;     // Number of adjacent stones 
            int iMatchedFruitNum = 0;     // Number of properties matching fruit 
            int iMatchedColorNum = 0;     // Number of properties matching color 
            int iNeighborFruit = 0; 
            int iNeighborColor = 0;
            sc.RecentScore = -1;  //If that stay on this value not be held down 
            sc.RecentFourWay = 0;
            string[] sNeighborName = new string[4]; 
            System.Windows.Forms.Control NeighborField;

            // Order: left, right, top, bottom 
            sNeighborName[0] = Neighbor(NeighborStone.Name, -1, 0);
            sNeighborName[1] = Neighbor(NeighborStone.Name, 1, 0);
            sNeighborName[2] = Neighbor(NeighborStone.Name, 0, -1);
            sNeighborName[3] = Neighbor(NeighborStone.Name, 0, 1);

            for (int i = 0; i < 4; ++i)
            {
                iNeighborFruit = 0;
                iNeighborColor = 0;
                
                // This is a cube, and if so is there a stone frame, and if their properties match
                if (sNeighborName[i] != "x")
                {
                    NeighborField = this.Controls.Find(sNeighborName[i], true).FirstOrDefault() as Control;
                    if (NeighborField.Text != "")
                    {
                        iNeighborStoneNum = iNeighborStoneNum + 1;  //Add one to adjacent stones
                        if (NeighborField.Text == lblNextStone.Text)
                        {
                            iMatchedFruitNum = iMatchedFruitNum + 1;
                            iNeighborFruit = 1;
                        }
                        if (NeighborField.ForeColor == lblNextStone.ForeColor)
                        {
                            iMatchedColorNum = iMatchedColorNum + 1;
                            iNeighborColor = 1;
                        }
                        if (iNeighborFruit + iNeighborColor == 0)
                        {
                            return false;  // With this neighbor is not same property
                        }
                    }
                }
            }

            if (iNeighborStoneNum == 1) sc.RecentScore = 1;
            if ((iNeighborStoneNum == 2 || iNeighborStoneNum == 3) && iMatchedFruitNum * iMatchedColorNum > 0) sc.RecentScore = 1;
            if (iNeighborStoneNum == 4 && iMatchedFruitNum >= 2 && iMatchedColorNum >= 2)
            {
                sc.RecentScore = 1;
                sc.RecentFourWay = 1;
            }
            if (sc.RecentScore == 1) sc.RecentScore = Convert.ToInt32(Math.Pow(2, (iNeighborStoneNum - 1)) * Math.Pow(2, sc.FourWay));
            // On the border has not score
            if (sc.RecentScore > 0 && (sNeighborName[0] == "x" || sNeighborName[1] == "x" || sNeighborName[2] == "x" || sNeighborName[3] == "x"))
            {
                sc.RecentScore = 0;
            }
            if (sc.RecentScore > -1) return true;
            else return false;
        }

        // Bonus scores
        void BonusScores()
        {
            if (sc.FourWay == 1) sc.FourWayBonus = 25;
            if (sc.FourWay == 2) sc.FourWayBonus = 50;
            if (sc.FourWay == 3) sc.FourWayBonus = 100;
            if (sc.FourWay == 4) sc.FourWayBonus = 200;
            if (sc.FourWay == 5) sc.FourWayBonus = 400;
            if (sc.FourWay == 6) sc.FourWayBonus = 600;
            if (sc.FourWay == 7) sc.FourWayBonus = 800;
            if (sc.FourWay == 8) sc.FourWayBonus = 1000;
            if (sc.FourWay == 9) sc.FourWayBonus = 5000;
            if (sc.FourWay == 10) sc.FourWayBonus = 10000;
            if (sc.FourWay == 11) sc.FourWayBonus = 25000;
            if (sc.FourWay == 12) sc.FourWayBonus = 50000;
        }

        void EndOfGame(int piFinalScore)
        {
            // Declare data table object
            DataTable dTable = new DataTable();

            //Stored procedure
            string sStoredProc = "SP_Read_Top10";

            // a list of parameters for stored procedors only!
            List<string> sParams = new List<string>();
            sParams.Clear();

            Data da = new Data();

            SqlDataReader objDataReader = da.ExecuteReader(sStoredProc, sParams);

            dTable.Load(objDataReader);

            objDataReader.Close();    

            //get table length
            string[] sNickName = new string[10];
            string[] sScore = new string[10];
            int[] iScore = new int[10];


            //write data to local arrays
            for (int i = 0; i < 10; ++i) //get length
            {
                sNickName[i] = dTable.Rows[i]["NickName"].ToString();
                sScore[i] = dTable.Rows[i]["Score"].ToString();

                iScore[i] = Convert.ToInt32(sScore[i]);
            }

            // Check the scores
            int iRef = 0;
            for (int i = 0; i < 10; i++)
            {
                if (piFinalScore > iScore[i])
                {
                    lblMessageDisplay.Text = "IN TOP10";
                    iRef++;
                }
            }

            if (iRef > 0)
            {
                // Create form to add competitor
                Top10UpdateForm frm = new Top10UpdateForm();

                // Pass required competition id to new form
                frm.piFinalScore = piFinalScore;

                // Display form
                frm.ShowDialog();
            }

            if (MessageBox.Show("Enf of Game" + System.Environment.NewLine + "Do you want to start a new game?", "Fruit Ishido", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                StartGame();
            }

        }


        // Stone Click function
        void StoneClick(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Control ThisStone;
            ThisStone = (System.Windows.Forms.Label)sender;
            string sRef;
            
            if (ThisStone.Text == "" && sc.UsedStoneNum < 71)
            {
                
                if (Landing(ThisStone))
                {
                    // What is clicked and how many points
                    lblMessageDisplay.Text = ThisStone.Name + " / " + Convert.ToString(sc.RecentScore);  
                    sc.UsedStoneNum = sc.UsedStoneNum + 1;
                    ThisStone.Text = skl.Stocks.ElementAt(sc.UsedStoneNum).Name;
                    ThisStone.ForeColor = skl.Stocks.ElementAt(sc.UsedStoneNum).Col;

                    Stone s = sel.GetStone(ThisStone.Name);
                    s.Text = ThisStone.Text;
                    s.StoneColor = skl.Stocks.ElementAt(sc.UsedStoneNum).Col;
                    
                    // Fruit display statement
                    sRef = skl.Stocks.ElementAt(sc.UsedStoneNum).Name;
                        switch (sRef)
                        {
                            case "A":
                                ThisStone.BackgroundImage = Properties.Resources.A;
                                break;
                            case "B":
                                ThisStone.BackgroundImage = Properties.Resources.B;
                                break;
                            case "C":
                                ThisStone.BackgroundImage = Properties.Resources.C;
                                break;
                            case "D":
                                ThisStone.BackgroundImage = Properties.Resources.D;
                                break;
                            case "E":
                                ThisStone.BackgroundImage = Properties.Resources.E;
                                break;
                            case "F":
                                ThisStone.BackgroundImage = Properties.Resources.F;
                                break;

                        }

                    // Background color setting
                    ThisStone.BackColor = skl.Stocks.ElementAt(sc.UsedStoneNum).Col;

                    sSteps[sc.UsedStoneNum] = ThisStone.Name;
                    sc.FourWay = sc.FourWay + sc.RecentFourWay; // FourWay bonus calculation
                    sc.FourWayBonus = 0;
                    if (sc.RecentFourWay == 1)
                    {

                        ThisStone.BackColor = Color.DarkBlue;
                        ThisStone.ForeColor = Color.DarkBlue;
                        BonusScores();  // Bonus scores calculation
                    }
                    sc.Score = sc.Score + sc.RecentScore;
                    sc.FourWayScore = sc.FourWayScore + sc.FourWayBonus;
                    NextStep();
                }
            }
        }


        // Sotre display to debug only
        void StoreDisplay()   
        {
            System.Windows.Forms.Control ThisStone;
            string sRef;

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 6; ++j)
                {
                    ThisStone = this.Controls.Find(sColumn[i] + sRow[j], true).FirstOrDefault() as Control;
                    sRef = skl.Stocks.ElementAt((j) * 12 + i).Name;

                    // Fruit display statement
                    switch (sRef)
                    {
                        case "A":
                            ThisStone.BackgroundImage = Properties.Resources.A;
                            break;
                        case "B":
                            ThisStone.BackgroundImage = Properties.Resources.B;
                            break;
                        case "C":
                            ThisStone.BackgroundImage = Properties.Resources.C;
                            break;
                        case "D":
                            ThisStone.BackgroundImage = Properties.Resources.D;
                            break;
                        case "E":
                            ThisStone.BackgroundImage = Properties.Resources.E;
                            break;
                        case "F":
                            ThisStone.BackgroundImage = Properties.Resources.F;
                            break;

                    }

                    // Background color setting
                    ThisStone.BackColor = skl.Stocks.ElementAt((j) * 12 + i).Col;
                }
            }
        }       

        private void tOP10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the TOP 10 form
            TOP10Form aTOP10Form = new TOP10Form();
            aTOP10Form.ShowDialog();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new manual box and display it
            ManualForm aManualForm = new ManualForm();
            aManualForm.ShowDialog(); 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new AboutBox and Display it
            AboutBox1 aboutFrom = new AboutBox1();
            aboutFrom.ShowDialog();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you start a new game?", "Fruit Ishido", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                StartGame();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SerializeMyClass();
        }

        public void SerializeMyClass()  // Save to file
        {
            // Displays a SaveFileDialog so the user can save the game 
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "BIN|*.bin";
            saveFileDialog1.Title = "Save a game file";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                AllData ad = new AllData();
                ad.AddClass(sel);
                ad.AddClass(skl);
                ad.AddClass(sc);

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(saveFileDialog1.FileName,
                                         FileMode.Create,
                                         FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, ad);
                stream.Close();

                //Debug only
                ListClasses();

                MessageBox.Show("Game successfully saved");
            }           
        }        

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a game file 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "BIN|*.bin";
            openFileDialog1.Title = "Select a game bin file";

            // Show the Dialog  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ClearTable();

                AllData ad = new AllData();

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(openFileDialog1.FileName,
                                          FileMode.Open,
                                          FileAccess.Read,
                                          FileShare.Read);
                ad = (AllData)formatter.Deserialize(stream);
                stream.Close();

                foreach (var item in ad)
                {
                    string sType = item.GetType().Name;

                    if (sType == "StoneList")
                    {
                        sel = new StoneList();

                        foreach (var element in item as StoneList)
                        {
                            Debug.Print(element.ToString());
                            sel.AddStone(element);
                        }
                    }
                    else if (sType == "StockList")
                    {
                        skl = new StockList();

                        foreach (var element in item as StockList)
                        {
                            Debug.Print(element.ToString());
                            skl.AddStock(element);
                        }
                    }
                    else if (sType == "Scores")
                    {
                        sc = new Scores();
                        sc = item as Scores;
                    }
                }

                RestoreGame();

                // Debug only
                //ListClasses();
            }            
        }

        private void RestoreGame()
        {
            // Restore table
            foreach (var item in sel)
            {
                ThisStone = this.Controls.Find(item.Name, true).FirstOrDefault() as Control;
                ThisStone.Text = item.Text;
                ThisStone.ForeColor = item.StoneColor;
                ThisStone.BackColor = item.StoneColor;

                // Fruit display statement
                switch (item.Text)
                {
                    case "A":
                        ThisStone.BackgroundImage = Properties.Resources.A;
                        break;
                    case "B":
                        ThisStone.BackgroundImage = Properties.Resources.B;
                        break;
                    case "C":
                        ThisStone.BackgroundImage = Properties.Resources.C;
                        break;
                    case "D":
                        ThisStone.BackgroundImage = Properties.Resources.D;
                        break;
                    case "E":
                        ThisStone.BackgroundImage = Properties.Resources.E;
                        break;
                    case "F":
                        ThisStone.BackgroundImage = Properties.Resources.F;
                        break;
                }                 
            }
            
            // Display scores
            lblMessageDisplay.Text = "Game loaded";
            lblScoreDisplay.Text = Convert.ToString(sc.Score);
            lblUsedStoneDisplay.Text = Convert.ToString(sc.UsedStoneNum + 1);
            lblLeftStoneDisplay.Text = Convert.ToString(72 - sc.UsedStoneNum - 1);
            lblScoreDisplay.Text = Convert.ToString(sc.FinalScore);
            lblFourWayDisplay.Text = Convert.ToString(sc.FourWay);

            NextStep();
        }

        private void ListClasses()
        {
            foreach (var item in sel)
            {
                Debug.Print(item.ToString());
            }

            foreach (var item in skl)
            {
                Debug.Print(item.ToString());
            }

            Debug.Print(sc.ToString());
        }             
    }
}
