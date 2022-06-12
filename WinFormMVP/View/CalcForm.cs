using System;
using System.Windows.Forms;
using WinFormMVP.Presenter;
using WinFormMVP.Views.Interface;

namespace WinFormMVP
{
    public partial class CalcForm : Form, ICalcView
    {
        private readonly CalcPresenter _presenter;

        public Label LblArea { get => this.lblArea; }
        public TextBox TxtRadio { get => this.txtRaio; }

        public CalcForm()
        {
            InitializeComponent();
            _presenter = new CalcPresenter(this);
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.CalcularAreaCirculo();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
