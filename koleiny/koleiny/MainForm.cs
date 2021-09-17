using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeoJSON.Net.Feature;
using GeoJSON.Net.Geometry;
using GeoJSON.Net.Converters;
using Newtonsoft.Json;

namespace koleiny
{
    public partial class MainForm : Form
    {
        int _currentIndex;
        RutInformationDSN[] _rutInformations;
        RutMeasurment _currentRut;

        public MainForm()
        {
            InitializeComponent();
            EnableButtons(false);
        }

        private void fileBrowserButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;
                dialog.DefaultExt = ".xml";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filesListBox.Items.Clear();

                    string[] paths = dialog.FileNames;
                    _rutInformations = new RutInformationDSN[paths.Length];

                    for (int i = 0; i < paths.Length; i++)
                    {
                        RutMeasurment[] ruts = LcmsResultReader.GetRutMeasurments(paths[i]);
                        List<RutMeasurment> leftRuts = new List<RutMeasurment>();
                        List<RutMeasurment> rightRuts = new List<RutMeasurment>();
                        for (int j = 0; j < ruts.Length; j++)
                        {
                            if (ruts[j].LaneSide.Equals("Left"))
                                leftRuts.Add(ruts[j]);

                            if (ruts[j].LaneSide.Equals("Right"))
                                rightRuts.Add(ruts[j]);
                        }
                        _rutInformations[i] = new RutInformationDSN(leftRuts.ToArray(), rightRuts.ToArray());

                        filesListBox.Items.Add(new FileInfo(paths[i]).Name);
                    }
                    filesListBox.SelectedIndex = 0;
                    EnableButtons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                _currentIndex = filesListBox.IndexFromPoint(e.Location);
                if (_currentIndex != ListBox.NoMatches)
                {
                    _currentRut = GetRut(_currentIndex, 0);
                    UpdateJsonFile(_currentRut);
                    UpdateView(_currentIndex, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            int position = _currentRut.Position - 1;
            if (position >= 0)
            {
                _currentRut = GetRut(_currentIndex, position);
                UpdateView(_currentIndex, position);
            }
            else
            {
                int index = _currentIndex - 1;
                if (index >= 0)
                {
                    position = 9;
                    _currentRut = GetRut(index, position);
                    _currentIndex = index;
                    UpdateView(_currentIndex, position);
                }
            }
            UpdateJsonFile(_currentRut);
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            int position = _currentRut.Position + 1;
            if (position <= 9)
            {
                _currentRut = GetRut(_currentIndex, position);
                UpdateView(_currentIndex, position);
            }
            else
            {
                int index = _currentIndex + 1;
                if (index < _rutInformations.Length)
                {
                    position = 0;
                    _currentRut = GetRut(index, position);
                    _currentIndex = index;
                    UpdateView(_currentIndex, position);
                }
            }
            UpdateJsonFile(_currentRut);
        }

        private void leftRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentRut = GetRut(_currentIndex, _currentRut.Position);
            UpdateJsonFile(_currentRut);
        }

        private void scaleXTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRut = GetRut(_currentIndex, _currentRut.Position);
            UpdateJsonFile(_currentRut);
        }

        private void scaleYTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRut = GetRut(_currentIndex, _currentRut.Position);
            UpdateJsonFile(_currentRut);
        }


        private RutMeasurment GetRut(int index, int position)
        {
            if (leftRadioButton.Checked)
                return _rutInformations[index].LeftRuts[position];
            else
                return _rutInformations[index].RightRuts[position];
        }
        private void UpdateView(int index, int position)
        {
            filesListBox.SelectedIndex = index;
            positionLabel.Text = $"Position: {position}";
        }
        private void UpdateJsonFile(RutMeasurment rut)
        {
            double x, y;

            if (!double.TryParse(scaleXTextBox.Text, out x))
                if (!double.TryParse(scaleXTextBox.Text.Replace('.', ','), out x))
                    x = 1;

            if (!double.TryParse(scaleYTextBox.Text, out y))
                if (!double.TryParse(scaleYTextBox.Text.Replace('.', ','), out y))
                    y = 1;

            using (StreamWriter file = File.CreateText("RutMeasurment.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                writer.WriteRaw(rut.GetGeoJson(x, y));
            }
        }
        private void EnableButtons(bool enable = true)
        {
            upButton.Enabled = enable;
            DownButton.Enabled = enable;
            leftRadioButton.Enabled = enable;
            rightRadioButton.Enabled = enable;
            scaleXTextBox.Enabled = enable;
            scaleYTextBox.Enabled = enable;
        }

    }
}
