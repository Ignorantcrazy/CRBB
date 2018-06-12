using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib
{
    public class ChartJson
    {
        public string charttype = "";
        public bool chart = true;
        public List<xAxisItemJson> xAxis = new List<xAxisItemJson>();
        public List<SeriesItemJson> series = new List<SeriesItemJson>();
        public ChartJson()
        {

        }
        public string ConvertToJson()
        {
            return "";
        }
    }

    public class xAxisItemJson
    {
        public List<string> categories = new List<string>();
        public bool crosshair = true;
        public xAxisItemJson()
        {

        }
        public void Add(string item)
        {
            categories.Add(item);
        }
        public string ConvertToJson()
        {
            return "";
        }
    }


    public class SeriesItemJson
    {
        public List<int> data = new List<int>();
        public List<double> data_f = new List<double>();
        public string name = "";
        public SeriesItemJson()
        {
        }
        public SeriesItemJson(string _name = "")
        {
            data = new List<int>();
            name = _name;
            data_f = new List<double>();
        }
        public SeriesItemJson(List<int> _data, string _name, List<double> _data_f)
        {
            data = _data;
            name = _name;
            data_f = _data_f;
        }
        public void Add(int item)
        {
            data.Add(item);
        }
        public void Add(double item)
        {
            data_f.Add(item);
        }
        public void Add(double item_f, int item_n)
        {
            data_f.Add(item_f);
            data.Add(item_n);
        }
        public string ConvertToJson()
        {
            return "";
        }
    }


}
