using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace labwork_3_1
{
    class Presenter
    {

        private readonly MainWindow view;
        Model model;

        public DispatcherTimer timer = new DispatcherTimer();

        public Presenter(MainWindow window)
        {
            model = new Model();
            view = window;

            timer.Interval = new TimeSpan(0, 0, 1);
            view.Start += View_Start;
            view.Stop += View_Stop;
            view.Reset += View_Reset;
            timer.Tick += timerTick;
            timer.Start();

            timer.IsEnabled = false;
        }

        private void timerTick(object sender, EventArgs e)
        {
            view.TextBoxTime.Text = model.Time();
        }

        private void View_Reset(object sender, EventArgs e)
        {
            model.ValuesEqualZero();
            timer.Stop();
            view.TextBoxTime.Text = "00:00:00";
        }

        private void View_Stop(object sender, EventArgs e)
        {
            timer.Stop();
            timer.IsEnabled = false;
        }

        private void View_Start(object sender, EventArgs e)
        {
            
            timer.Start();
            timer.IsEnabled = true;
        }
    }
}

