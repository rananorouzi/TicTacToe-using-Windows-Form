using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public partial class PlayButton : Button
    {
        public enum StateEnum { Unclicked, X, O}

        public StateEnum State = StateEnum.Unclicked;
        private static StateEnum globalTurn = StateEnum.X;

        public PlayButton()
        {
            InitializeComponent();
        }

        public PlayButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Click += PButton_Click;
            Text = "";
            BackColor = Color.White;
            Font = new Font(this.Font.FontFamily, 25);
            SetStyle(ControlStyles.Selectable, false);
        }

        public static StateEnum GlobalTurn() {
            return globalTurn;
        }

        private void PButton_Click(object? sender, EventArgs e)
        {
            Play();
        }

        public void Play()
        {
            State = globalTurn;
            globalTurn = globalTurn == StateEnum.X ? StateEnum.O : StateEnum.X;
            Text = State == StateEnum.X ? "X" : "O";
            Enabled = false;
        }

        public void Reset()
        {
            State = StateEnum.Unclicked;
            Text = "";
            BackColor = Color.White;
            Enabled = true;
        }

        public void MarkAsWin()
        {
            BackColor = Color.Green;
        }
    }
}
