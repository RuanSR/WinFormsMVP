using WinFormMVP.Model;
using WinFormMVP.Views.Interface;

namespace WinFormMVP.Presenter
{
    public class CalcPresenter
    {
        private readonly ICalcView _iCalcView;

        public CalcPresenter(ICalcView view)
        {
            this._iCalcView = view;
        }

        public void CalcularAreaCirculo()
        {
            CirculoModel model = new CirculoModel();

            _iCalcView.LblArea.Text += model.GetArea(double.Parse(_iCalcView.TxtRadio.Text)).ToString();
        }
    }
}
