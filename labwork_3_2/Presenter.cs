using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_3_2
{
    class Presenter
    {
        private readonly MainWindow view;
        Model model;

        public Presenter(MainWindow window)
        {
            model = new Model();
            view = window;

            view.Add += View_Add;
            view.Subtract += View_Subtract;
            view.Multiply += View_Multiply;
            view.Divide += View_Divide;
            view.Clear += View_Clear;
        }

        private void View_Add(object sender, EventArgs e)
        {
                view.TextBoxResult.Text = model.Add(Convert.ToDouble(view.TextBoxFirstValue.Text), Convert.ToDouble(view.TextBoxSecondValue.Text));
                view.TextBlockSign.Text = model.sign;
        }
        private void View_Subtract(object sender, EventArgs e)
        {
            view.TextBoxResult.Text = model.Subtract(Convert.ToDouble(view.TextBoxFirstValue.Text), Convert.ToDouble(view.TextBoxSecondValue.Text));
            view.TextBlockSign.Text = model.sign;
        }
        private void View_Multiply(object sender, EventArgs e)
        {
            view.TextBoxResult.Text = model.Multiply(Convert.ToDouble(view.TextBoxFirstValue.Text), Convert.ToDouble(view.TextBoxSecondValue.Text));
            view.TextBlockSign.Text = model.sign;
        }
        private void View_Divide(object sender, EventArgs e)
        {
            view.TextBoxResult.Text = model.Divide(Convert.ToDouble(view.TextBoxFirstValue.Text), Convert.ToDouble(view.TextBoxSecondValue.Text));
            view.TextBlockSign.Text = model.sign;
        }
        private void View_Clear(object sender, EventArgs e)
        {
            model.Clear();
            view.TextBlockSign.Text = model.sign;
            view.TextBoxFirstValue.Text = model.sign;
            view.TextBoxSecondValue.Text = model.sign;
            view.TextBoxResult.Text = model.sign;
        }

    }
}
