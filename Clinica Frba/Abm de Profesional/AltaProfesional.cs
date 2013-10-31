using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Utils;
using Logic;
using Persistance.Entities;

namespace Clinica_Frba.AbmProfesional
{
    public partial class frmAltaProfesional : Form
    {
        private ProfesionalLogic _logic;
        private Dictionary<int, TipoDocumento> _tipoDocumento;
        private Dictionary<int, Especialidad> _especialidad;

        public frmAltaProfesional()
        {
            InitializeComponent();

            Initialize();
        }

        public void Initialize()
        {
            _logic = new ProfesionalLogic();

            _tipoDocumento = Initializator.TipoDocumento(CmbTipo);
            _especialidad = Initializator.Especialidad(chkEspecialidades);

            CleanUI();
        }

        private void CleanUI()
        {
            throw new NotImplementedException();
        }

        private void frmAltaProfesional_Load(object sender, EventArgs e)
        {

        }
    }
}
