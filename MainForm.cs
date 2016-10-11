#region Using Statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace Assignment3
{
    public partial class MainForm : Form
    {
        private FuelCalculator carMileage = new FuelCalculator();
        private BodyMassIndexCalculator bmiCalc = new BodyMassIndexCalculator();

        private string name = String.Empty;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            //Set all labels to default value or empty depending on suitability
        }

      
        private void UpdateGUIFuel()
        {

        }

        private void UpdateGUIBRM()
        {

        }
    }
}
