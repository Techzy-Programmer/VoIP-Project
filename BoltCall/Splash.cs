using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoltCall
{
    public partial class Splash : Form
    {
        private int Dir = 1;
        private int Acc = 1, AnimVal;
        private readonly Timer TmrAnimator;

        public Splash()
        {
            InitializeComponent();
            TmrAnimator = new Timer { Interval = 40 };
            TmrAnimator.Tick += TmrAnimator_Tick;
            TmrAnimator.Start();
        }

        private void TmrAnimator_Tick(object _, EventArgs E)
        {   
            if (Math.Abs(AnimVal) < 20) AnimVal += Dir * 4;
            else AnimVal += Acc++ * Dir;
            
            if (Math.Abs(AnimVal) >= 125)
            {
                Acc = 1;
                Dir = -1;
                AnimVal = 125;
            }
            else if (AnimVal <= 0)
            {                
                Dir = -1;
                var TempAV = AnimVal * -1;
                if (TempAV > 125) { TempAV = 125; Acc = 1; }
                AnimVal = TempAV * -1;
            }

            LAnims.Text = new string('.', Math.Abs(AnimVal));
        }

        private void StatusUpdate(string NewStatus)
        {
            if (IsHandleCreated)
                if (InvokeRequired) Invoke(new MethodInvoker
                    (() => StatusUpdate(NewStatus)));
                else LStatus.Text = NewStatus;
        }
    }
}
