namespace TrainStationTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;


    public partial class TestUI : Form
    {
        public TestUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nostationlbl.Text = "";
            liststations.Clear();
            keylistview.Clear();

            string lookUp = searchTxtBox.Text.ToString();
            string first = lookUp[0].ToString().ToUpper();
            List<string> searchStation = new List<string>();
            List<string> allStations = new TrainStations().getAllTrainStations(first);

            if (allStations.Count() == 0)
            {
                nostationlbl.Text = "No such station found";
            }
            else
            {
                foreach (var station in allStations)
                {
                    lookUp = lookUp.First().ToString().ToUpper() + lookUp.Substring(1);
                    if (station.Contains(lookUp))
                    {
                        searchStation.Add(station);
                        liststations.Items.Add(station);
                    }
                    else if (searchStation.Count == 0)
                    {
                        nostationlbl.Text = "No station with this name";
                    }
                }

                List<char> nextKeysLook = new List<char>();
                for (int i = 0; i < searchStation.Count(); i++)               
                {
                    if (searchStation[i].Length > lookUp.Length)
                    {
                        char nextKey;
                        nextKey = searchStation[i][lookUp.Length + 1];
                        nextKeysLook.Add(nextKey);

                        if (nextKeysLook.Count() == 1)
                        {
                            keylistview.Items.Add(nextKey.ToString().ToUpper());
                        }
                        else if(nextKeysLook[i] != nextKeysLook[i-1])
                        {
                            keylistview.Items.Add(nextKey.ToString().ToUpper());
                        }
                    }
                }              
            }
        }
    }
}
