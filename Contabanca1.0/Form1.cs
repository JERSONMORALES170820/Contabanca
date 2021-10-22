using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contabanca1._0
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void xtraScrollableControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'contabancaDataSet.tbl_detalle_venta' Puede moverla o quitarla según sea necesario.
            this.tbl_detalle_ventaTableAdapter.Fill(this.contabancaDataSet.tbl_detalle_venta);
            // TODO: esta línea de código carga datos en la tabla 'contabancaDataSet.Tbl_Clientes__credito' Puede moverla o quitarla según sea necesario.
            this.tbl_Clientes__creditoTableAdapter.Fill(this.contabancaDataSet.Tbl_Clientes__credito);
            // TODO: esta línea de código carga datos en la tabla 'contabancaDataSet.tbl_categoria' Puede moverla o quitarla según sea necesario.
            this.tbl_categoriaTableAdapter.Fill(this.contabancaDataSet.tbl_categoria);
            // TODO: esta línea de código carga datos en la tabla 'contabancaDataSet.tbl_producto' Puede moverla o quitarla según sea necesario.
            this.tbl_productoTableAdapter.Fill(this.contabancaDataSet.tbl_producto);

        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl23_Click(object sender, EventArgs e)
        {

        }

        private void labelControl36_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
