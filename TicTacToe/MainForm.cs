namespace TicTacToe
{
    public partial class MainForm : Form
    {
        readonly private PlayButton[] playButtons = [];
        readonly private List<int[]> matches = [];
        readonly private Cursor xCursor;
        readonly private Cursor oCursor;
        private int gameClicks = 0;

        public MainForm()
        {
            InitializeComponent();
            InitializeMatches();
            xCursor = new Cursor("XIcon.ico");
            oCursor = new Cursor("OIcon.ico");

            playButtons = [pButton1, pButton2, pButton3, pButton4, pButton5, pButton6, pButton7, pButton8, pButton9];
            
            foreach (PlayButton button in playButtons)
            {
                button.Click += this.CheckMatchEvent;
            }

            SyncTurn();
        }

        private void ResetAll(object? sender, EventArgs e)
        {
            foreach (PlayButton button in playButtons)
            {
                button.Reset();
            }
            winnerText.Clear();
            gameClicks = 0;
            SyncTurn();
        }

        private void CheckMatchEvent(object? sender, EventArgs e)
        {
            if (++gameClicks >= 5)
            {
                foreach (int[] triple in matches)
                {
                    if (TripleWins(triple))
                    {
                        foreach (int idx in triple)
                        {
                            PlayButton button = playButtons[idx];
                            button.MarkAsWin();
                        }

                        foreach (PlayButton button in playButtons)
                        {
                            button.Enabled = false;
                        }

                        PlayButton sample = playButtons[triple[1]];
                        winnerText.Text = ButtonStateToString(sample.State) + " Wins";
                        turnText.Text = "";
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }
            }

            if (gameClicks == 9)
            {
                winnerText.Text = "No one wins";
                turnText.Text = "";
                this.Cursor = Cursors.Default;
                return;
            }

            SyncTurn();
        }

        private void InitializeMatches()
        {
            for (int x = 0; x < 3; ++x)
            {
                int baseHorizontal = x * 3;
                int baseVertical = x;
                int[] rowIndexes = new int[3];
                int[] colIndexes = new int[3];
                for (int y = 0; y < 3; ++y)
                {
                    int rowIndex = baseHorizontal + y;
                    int colIndex = baseVertical + y * 3;
                    rowIndexes[y] = rowIndex;
                    colIndexes[y] = colIndex;
                }
                matches.Add(rowIndexes);
                matches.Add(colIndexes);
            }
            matches.Add([0, 4, 8]);
            matches.Add([2, 4, 6]);
        }

        private bool TripleWins(int[] selection)
        {
            PlayButton.StateEnum expectedState = PlayButton.StateEnum.Unclicked;
            for (int item = 0; item < 3; ++item)
            {
                PlayButton button = playButtons[selection[item]];

                if (button.State == PlayButton.StateEnum.Unclicked)
                    return false;

                if (item == 0)
                    expectedState = button.State;
                else if (button.State != expectedState)
                    return false;
            }
            return true;
        }

        private static String ButtonStateToString(PlayButton.StateEnum state)
        {
            return state == PlayButton.StateEnum.X ? "X" : "O";
        }

        private void SyncTurn()
        {
            turnText.Text = ButtonStateToString(PlayButton.GlobalTurn()) + "'s turn";
            this.Cursor = PlayButton.GlobalTurn() == PlayButton.StateEnum.X ? xCursor : oCursor;
        }
    }
}
