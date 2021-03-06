﻿using Commons;
using Structures;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace DetectModule
{
    /// <summary>
    /// Load file with test results, then create nonconformances that were founded.
    /// </summary>
    public class NCCreator
    {
        /// <summary>
        /// Constructor of NCCreator class.
        /// </summary>
        public NCCreator()
        {
        }

        public HashSet<Nonconformance> ListNonconformances()
        {
            return ListNonconformances(Constants.TEST_ERRORS);
        }

        /// <summary>
        /// Return a list of distinct nonconformances founded with tests.
        /// </summary>
        /// <returns>List of distinct nonconformances founded with tests.</returns>
        public HashSet<Nonconformance> ListNonconformances(string fileToLoad)
        {
            HashSet<Nonconformance> result = new HashSet<Nonconformance>();
            // Load test results.
            XmlDocument docXml = new XmlDocument();
            docXml.Load(fileToLoad);

            XmlNodeList nodes = docXml.GetElementsByTagName("UnitTestResult");

            IEnumerator ienum = nodes.GetEnumerator();
            while (ienum.MoveNext())
            {
                // Read from XML, the needed values.
                XmlNode unitTestResult = (XmlNode)ienum.Current;
                if (unitTestResult.HasChildNodes)
                {
                    XmlNode output = unitTestResult.FirstChild;
                    var errorInfoMatch = ((XmlElement)output).GetElementsByTagName("ErrorInfo");
                    if (errorInfoMatch.Count == 1)
                    {
                        XmlNode errorInfo = errorInfoMatch.Item(0);
                        XmlNode mess = errorInfo.FirstChild;
                        XmlNode stac = errorInfo.LastChild;
                        string message = mess.InnerText.ToString();
                        string stackTrace = stac.InnerText.ToString();

                        // Create the nonconformance.
                        Nonconformance n = new Nonconformance(message, stackTrace);
                        if (!result.Contains(n) && !n.IsMeaningless())
                            result.Add(new Nonconformance(message, stackTrace));
                    }
                }
            }

            return result;
        }

    }
}
