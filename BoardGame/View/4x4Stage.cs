using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zh.Modell;

namespace Zh
{
    public partial class Form1 : Form
    {

        static int gamesize = 4;
        static Map myMap = new Map(gamesize);
        Game game = new Game();
        List<int> temps = new List<int>();
        int turnIndex = 1;
        bool isgameinprocess = true;


        public Button[,] buttons = new Button[myMap.Size, myMap.Size];

        List<String> P1StepOrder = new List<String> { "1", "2", "3", "4" };
        List<String> P2StepOrder = new List<String> { "1", "2", "3", "4" };




        public Form1()
        {
            ResetOcuptaion();
            InitializeComponent();
            createBoard();
            setCharacters();
            game.isPlayer1turn = true;
            HighLightNext();
        }
        public void GameLoop()
        {

            switch (turnIndex)
            {
                case -1: game.turn = "Game over"; isgameinprocess = false; break;

            }


        }

        public void createBoard()
        {
            int buttonsize = panel1.Width / myMap.Size;
            panel1.Height = panel1.Width;

            for (int i = 0; i < myMap.Size; i++)
            {
                for (int j = 0; j < myMap.Size; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = buttonsize;
                    buttons[i, j].Width = buttonsize;
                    buttons[i, j].BackColor = Color.Empty;
                    buttons[i, j].Click += ButtonMove;
                    panel1.Controls.Add(buttons[i, j]);
                    buttons[i, j].Location = new Point(i * buttonsize, j * buttonsize);
                    buttons[i, j].Tag = new Point(i, j);
                }
            }


        }

        public void setCharacters()
        {

            //player1

            buttons[0, myMap.Size - 1].BackColor = Color.LightBlue;
            buttons[0, myMap.Size - 1].Text = "4";
            myMap.CellGrid[0, myMap.Size - 1].isOcupiedbyP1 = true;

            buttons[1, myMap.Size - 1].BackColor = Color.LightBlue;
            buttons[1, myMap.Size - 1].Text = "3";
            myMap.CellGrid[1, myMap.Size - 1].isOcupiedbyP1 = true;

            buttons[1, myMap.Size - 2].BackColor = Color.LightBlue;
            buttons[1, myMap.Size - 2].Text = "2";
            myMap.CellGrid[1, myMap.Size - 2].isOcupiedbyP1 = true;

            buttons[0, myMap.Size - 2].BackColor = Color.LightBlue;
            buttons[0, myMap.Size - 2].Text = "1";
            myMap.CellGrid[0, myMap.Size - 2].isOcupiedbyP1 = true;


            //player2


            buttons[myMap.Size - 1, 0].BackColor = Color.LightCoral;
            buttons[myMap.Size - 1, 0].Text = "4";
            myMap.CellGrid[myMap.Size - 1, 0].isOcupiedbyP2 = true;

            buttons[myMap.Size - 1, 1].BackColor = Color.LightCoral;
            buttons[myMap.Size - 1, 1].Text = "1";
            myMap.CellGrid[myMap.Size - 1, 1].isOcupiedbyP2 = true;

            buttons[myMap.Size - 2, 1].BackColor = Color.LightCoral;
            buttons[myMap.Size - 2, 1].Text = "2";
            myMap.CellGrid[myMap.Size - 2, 1].isOcupiedbyP2 = true;

            buttons[myMap.Size - 2, 0].BackColor = Color.LightCoral;
            buttons[myMap.Size - 2, 0].Text = "3";
            myMap.CellGrid[myMap.Size - 2, 0].isOcupiedbyP2 = true;




        }


        private void ButtonMove(object sender, EventArgs e)
        {


            GameLoop();
            //számolja a köröket, egy turnIndex nevű változó adja hozzá +ba

           

            //hozzáadjuk a clickedbuttont 
            Button clickedButton = (Button)sender;
            Point Location = (Point)clickedButton.Tag;


            //elmentjük int-be a koordinátákat
            int x = Location.X;
            int y = Location.Y;


            //save old location
            temps.Add(x);
            temps.Add(y);

            if (isgameinprocess) { 

            //switch P1 vagy P2 köre
            switch (game.isPlayer1turn)
            {

                //player1 step
                case true:

                    //kijelölés legal move
                    if (clickedButton.Text == P1StepOrder[0] && myMap.CellGrid[x, y].isOcupiedbyP1)
                    {


                        Cell currentCell = myMap.CellGrid[x, y];
                        clickedButton.BackColor = Color.GhostWhite;
                        myMap.IsLegalMethod(currentCell);


                        //highlight legal cells to step
                        myMap.MarkNextLegalMoves(currentCell);

                        for (int i = 0; i < myMap.Size; i++)
                        {
                            for (int j = 0; j < myMap.Size; j++)
                            {

                                if (myMap.CellGrid[i, j].isLegal)
                                {
                                    //mark posiblities
                                    buttons[i, j].BackColor = Color.CadetBlue;
                                };

                            }


                        }


                    }
                    //ha már meg van jelölve akkor ..
                    else if (clickedButton.BackColor == Color.CadetBlue)
                    {
                        MoveButton(x, y);

                        //ujratervezzük mi a foglalt kocka
                        resetButtonColors();


                        game.isPlayer1turn = false;
                        whoseturnLabel.Text = "Player2's move";
                        whoseturnLabel.ForeColor = Color.Red;

                        HighLightNext();
                        GameLoop();
                    }
                    else
                    {
                        temps.Clear();

                    }
                    break;

                //-----------------------------player2 step------------------------------------------------------------
                case false:

                    if (clickedButton.Text == P2StepOrder[0] && myMap.CellGrid[x, y].isOcupiedbyP2)
                    {
                        //kijelöli a válaszott gombot
                        Cell currentCell = myMap.CellGrid[x, y];
                        clickedButton.BackColor = Color.Coral;
                        myMap.IsLegalMethod(currentCell);


                        //highlight legal cells to step
                        myMap.MarkNextLegalMoves(currentCell);

                        for (int i = 0; i < myMap.Size; i++)
                        {
                            for (int j = 0; j < myMap.Size; j++)
                            {

                                if (myMap.CellGrid[i, j].isLegal)
                                {
                                    //mark posiblities
                                    buttons[i, j].BackColor = Color.PaleVioletRed;
                                };

                            }


                        }



                        //ha már meg van jelölve akkor ..
                    }
                    else if (clickedButton.BackColor == Color.PaleVioletRed)
                    {

                        MoveButton(x, y);


                        //ujratervezzük mi a foglalt kocka
                        resetButtonColors();
                        game.isPlayer1turn = true;
                        whoseturnLabel.Text = "Player1's move";
                        whoseturnLabel.ForeColor = Color.Blue;


                        turnIndex++;
                        turnLabel.Text = turnIndex.ToString();


                        if (P2StepOrder.Count != 0) { HighLightNext(); }






                    }
                    else
                    {
                        temps.Clear();



                    }
                    break;
            }

            }

        }


        public void resetButtonColors()
        {
            for (int i = 0; i < myMap.Size; i++)
            {
                for (int j = 0; j < myMap.Size; j++)
                {
                    if (myMap.CellGrid[i, j].isOcupiedbyP1)
                    {
                        buttons[i, j].BackColor = Color.LightBlue;
                    }
                    else if (myMap.CellGrid[i, j].isOcupiedbyP2)
                    {
                        buttons[i, j].BackColor = Color.LightCoral;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.Empty;
                    }

                }
            }

        }

        public void MoveButton(int x, int y)
        {
            int xold = temps[0];
            int yold = temps[1];
            temps.Clear();


            ///átcseréljük a kiválaszott kijelöl kockát a lépővel
            String text = buttons[xold, yold].Text;
            buttons[xold, yold].Text = String.Empty;



            if (myMap.CellGrid[x, y].isOcupiedbyP1) { P1StepOrder.Remove(buttons[x, y].Text.ToString()); }
            if (myMap.CellGrid[x, y].isOcupiedbyP2) { P2StepOrder.Remove(buttons[x, y].Text.ToString()); }


            //a régi mezőket neutrálisnak állítjuk.
            // A karakterek lépési sorrendjét modosítjuk azzal, h kivesszük és hátratesszük a végére
            // majd az új mezőt a kellő játékos tulajonára tesszük

            if (game.isPlayer1turn)
            {
                myMap.CellGrid[xold, yold].isOcupiedbyP1 = false;

                string temp4 = P1StepOrder[0];
                P1StepOrder.RemoveAt(0);
                P1StepOrder.Add(temp4);

                myMap.CellGrid[x, y].isOcupiedbyP1 = true;
                myMap.CellGrid[x, y].isOcupiedbyP2 = false;
            }
            else
            {
                myMap.CellGrid[xold, yold].isOcupiedbyP2 = false;

                string temp4 = P2StepOrder[0];
                P2StepOrder.RemoveAt(0);
                P2StepOrder.Add(temp4);

                myMap.CellGrid[x, y].isOcupiedbyP2 = true;
                myMap.CellGrid[x, y].isOcupiedbyP1 = false;

            }


            buttons[x, y].Text = text;


            if (IsThereaWinner() != String.Empty)
            {
                turnIndex = -1;
            }

        }


        public string IsThereaWinner()
        {
            int P1occupied = 0;
            int P2occupied = 0;

            for (int i = 0; i < myMap.Size; i++)
            {
                for (int j = 0; j < myMap.Size; j++)
                {

                    if (myMap.CellGrid[i, 0].isOcupiedbyP1)
                    {
                        WinnerLabel.Text = "Player 1 WON"; turnLabel.Text = "Game over"; return "P1";
                    }
                    if (myMap.CellGrid[i, myMap.Size - 1].isOcupiedbyP2)
                    {
                        WinnerLabel.Text = "Player 2 WON"; turnLabel.Text = "Game over"; return "P2";
                    }
                }
            }

            if (P1StepOrder.Count == 0)
            {
                turnLabel.Text = "Game over"; WinnerLabel.Text = "Player 2 WON"; return "P2";
            }
            if (P2StepOrder.Count == 0)
            {
                turnLabel.Text = "Game over"; WinnerLabel.Text = "Player 1 WON"; return "P1";
            }


            return String.Empty;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (isgameinprocess)
            {
                if (game.isPlayer1turn)
                {
                    game.isPlayer1turn = false;
                    whoseturnLabel.Text = "Player2's move";
                    turnLabel.Text = turnIndex.ToString();
                    whoseturnLabel.ForeColor = Color.Red;

                    string tempstr = P1StepOrder[0];
                    P1StepOrder.Remove(P1StepOrder[0]);
                    P1StepOrder.Add(tempstr);

                    resetButtonColors();
                    HighLightNext();
                }
                else
                {
                    game.isPlayer1turn = true;
                    turnIndex++;
                    whoseturnLabel.Text = "Player1's move";
                    turnLabel.Text = turnIndex.ToString();
                    whoseturnLabel.ForeColor = Color.Blue;

                    string tempstr = P2StepOrder[0];
                    P2StepOrder.Remove(P2StepOrder[0]);
                    P2StepOrder.Add(tempstr);

                    resetButtonColors();
                    HighLightNext();

                }
            }
        }

        public void ResetOcuptaion() {
            for (int i = 0; i < myMap.Size; i++) {
                for (int j = 0; j < myMap.Size; j++) {
                    myMap.CellGrid[i, j].isOcupiedbyP1 = false;
                    myMap.CellGrid[i, j].isOcupiedbyP2 = false;


                }
            }
        
        }


        public void HighLightNext()
        {
            for (int i = 0; i < myMap.Size; i++)
            {
                for (int j = 0; j < myMap.Size; j++)
                {
                    if (P1StepOrder.Count > 0)
                    {
                        if (game.isPlayer1turn && buttons[i, j].Text == P1StepOrder[0] && myMap.CellGrid[i, j].isOcupiedbyP1)
                        {
                            buttons[i, j].BackColor = Color.LightCyan;
                        }
                    }
                    if (P2StepOrder.Count > 0)
                    {

                        if (!game.isPlayer1turn && buttons[i, j].Text == P2StepOrder[0] && myMap.CellGrid[i, j].isOcupiedbyP2)
                        {

                            buttons[i, j].BackColor = Color.PaleVioletRed;
                        }
                    }


                }

            }


        }










        private void GameSizeMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string choosedSize = combo.Text;


            switch (choosedSize)
            {


                case "4x4":
                    Form1 form1 = new Form1(); form1.Show(); this.Close();

                    break;
                case "6x6":Form3 form3 = new Form3(); form3.Show(); this.Close();
                    break;
                case "8x8": Form2 form2 = new Form2(); form2.Show(); this.Close();
                    break;


            }





        }








    }
}

