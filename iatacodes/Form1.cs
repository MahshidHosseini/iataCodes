using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Configuration;

using Newtonsoft.Json;
using iatacodes.Models;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace iatacodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAirportInfo_Click(object sender, EventArgs e)
        {
            string api = ConfigurationManager.AppSettings["apikey"];
            WebClient web = new WebClient();
            string address = string.Empty;

            if (txtAirportCode.Text.Trim() != string.Empty)
            {
                string airportCode = (txtAirportCode.Text.Trim());
      
                 address = "https://iatacodes.org/api/v6/airports.xml?api_key=" + api + "&code=" + airportCode;

            }
            else
            {
                 address = "https://iatacodes.org/api/v6/airports.xml?api_key=" + api;
            }
            List<AirportModel> airportList = new List<AirportModel>();
            string res = web.DownloadString(address);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(res);
            var nodes = doc.SelectNodes("//response");

        foreach (XmlNode item in nodes)
            {
                if(item.ChildNodes.Count == 2)
                {
                    AirportModel airport = new AirportModel
                    {
                        Code = item.SelectSingleNode("code").InnerText,
                        Name = item.SelectSingleNode("name").InnerText

                    };
                    airportList.Add(airport);
                }
               
            }

            //var airport = ConvertXMToObject<AirPortResponse>(res);

        }
        //private AirPortResponse ConvertXMToObject<T>(string xml)
        //{
        //    XmlSerializer xsSubmit = new XmlSerializer(typeof(T));
        //    using (StringReader rdr = new StringReader(xml))
        //    {
        //        var xmlResult = (AirPortResponse)xsSubmit.Deserialize(rdr);
        //        return xmlResult;
        //    }
        //}

    }
}
