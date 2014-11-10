using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdemServico.Forms.ClassesAuxiliares
{
    public static class MetodosExtencao
    {
        public static string ValorSelecionado(this ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                return ((ComboBoxItem)comboBox.SelectedItem).Value;
            }
            return null;
        }

        public static void AdcionarItens(this ComboBox comboBox, List<ComboBoxItem> itens)
        {
            var itemSelecione = new ComboBoxItem() { Value = "", Text = "Selecione..." };
            itens.Add(itemSelecione);
            comboBox.Items.AddRange(itens.ToArray());
            comboBox.SelectedItem = itemSelecione;
        }
    }
}
