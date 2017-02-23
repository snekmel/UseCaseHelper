using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC_Helper.Models;

namespace UC_Helper
{
    public partial class UsecaseScherm : Form
    {
        private UseCase _uc;
        private MainScreen _m;

        public UsecaseScherm(UseCase uc, MainScreen m)
        {
            InitializeComponent();
            this._uc = uc;
            this._m = m;

            FillFields();
        }

        public void FillFields()
        {
            ucNaamTb.Text = _uc.Naam;
            ucSamenvattingTb.Text = _uc.Samenvatting;
            actorenNaamTb.Text = _uc.Actoren;
            ucAannamentb.Text = _uc.Aannamen;
            ucBeschrijvingTb.Text = _uc.Beschrijving;
            ucUitzonderingTb.Text = _uc.Uitzondering;
            ucResultTb.Text = _uc.Resultaat;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (UseCase uc in _m.UseCaseLijst)
            {
                if (_uc.Pointer == uc.Pointer)
                {
                    _uc.Naam = ucNaamTb.Text;
                    _uc.Samenvatting = ucSamenvattingTb.Text;
                    _uc.Actoren = actorenNaamTb.Text;
                    _uc.Aannamen = ucAannamentb.Text;
                    _uc.Beschrijving = ucBeschrijvingTb.Text;
                    _uc.Uitzondering = ucUitzonderingTb.Text;
                    _uc.Resultaat = ucResultTb.Text;
                }
            }

            _m.Repaint();
        }
    }
}