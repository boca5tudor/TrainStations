namespace TrainStationTest
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;


    class TrainStations
    {
        // public List<string> AllTrainStations { get; set; }

        //// public method that returns a shortlist of stations based on the first letter typed
        public List<string> getAllTrainStations(string first)
        {
            //char[] list1 = { 'a', 'b', 'c', 'd', 'e' };  //char[] list2 = { 'f', 'g', 'h', 'i', 'j' };
            //char[] list3 = { 'k', 'l', 'm', 'n', 'o' }; //char[] list4 = { 'p', 'q', 'r', 's', 't' };
            //char[] list5 = { 'u', 'v', 'w', 'x', 'y', 'z' };

            first = first.ToUpper();
            List<string> list = new List<string>();           
            List<string> shortlist = new List<string>();

            // for getting the path to the txt file remotely
            string pathFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"txtStations\StationsUK.txt");
            StreamReader file = new StreamReader(pathFolder);

            try
            {    // create list of stations without ","
                string station = string.Empty;
                while ((station = file.ReadLine()) != null)
                {
                    list = station.Split(',').ToList();
                }

                // loop through stations and find the ones that start with the first letter typed
                for (int i = 0; i <list.Count; i++)
                {
                    string stationTyped = list[i];
                   // strange occurence that needs checking, without the "or" statement this returns one or all-1
                   // the || returns all the items that match
                    if (stationTyped[0].ToString().ToUpper().Equals(first) || stationTyped[1].ToString().ToUpper().Equals(first))
                    {
                        shortlist.Add(stationTyped);
                    }
                }
            }
            catch (Exception)
            {
                shortlist = null;
                throw;               
            }

            return shortlist;
        }
    }
}
