using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Persistance.Entities;

namespace Clinica_Frba.Busquedas
{
    public partial class FormSearchOwner : Form
    {
        public FormSearchOwner()
        {
            InitializeComponent();
        }

        public virtual void SelectedPareja(Afiliado pareja)
        {
        }

        public virtual void SelectedFamiliar(Afiliado familiar)
        {
        }

    }
}
