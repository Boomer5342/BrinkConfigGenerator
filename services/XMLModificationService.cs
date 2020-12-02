/*
 * Brink Config Generator program is written and copyrighted by David Conrad 2020.
 * This program is designed with the intent on making Brink register.cfg and kitchen.cfg generation easier and faster.
 * 
 * XMLModificationService.cs contains all of the XML Modification methods. 2 of the methods will take in 5 parameters and the other one will take in 4.
 * These parameters are the text within each TextBox, file path, file name, and station/kitchen number.
 * 
 */

using System;
using System.Windows.Forms;
using System.Xml;

namespace BrinkConfigGenerator.services
{
    class XMLModificationService
    {

        private static String[] _xmlPaths = new String[]
        {
            Application.StartupPath + @"\XMLConfigs\Station1\Register.cfg",
            Application.StartupPath + @"\XMLConfigs\Station2Plus\Register.cfg",
            Application.StartupPath + @"\XMLConfigs\Kitchen\Kitchen.cfg"
        };


        public static void RegisterOneXMLModifier(String[,] configChanges, String fullPath, String fileName, int index)
        {
            String[] elements = new String[]
            {
                "//Register",
                "//Register//EndPoint",
                "//Register//ServerEndPoint"
            };

            XmlDocument xmlLoader = new XmlDocument();
            xmlLoader.Load(_xmlPaths[index]);
            for (int i = 1; i <= elements.Length; i++)
            {
                XmlElement elementLoader = (XmlElement)xmlLoader.SelectSingleNode(elements[i - 1]);
                // STATION 1 CONFIG GENERATION
                if (i == 1)
                {
                    elementLoader.SetAttribute("LocationUid", configChanges[0,0]); // Set to Location Value.
                    elementLoader.SetAttribute("TerminalNumber", i.ToString()); // Set to the value of i.
                }
                else if (i == 2)
                {
                    elementLoader.SetAttribute("Address", configChanges[3,0]); // Set to Server Endpoint Value.
                }
                else if (i == 3)
                {
                    elementLoader.SetAttribute("Address", configChanges[3,0]); // Set to Server Endpoint Value.
                }
                // END STATION 1 CONFIG GENERATION

            }
            xmlLoader.Save(fullPath + fileName);
        }
        public static void RegisterTwoPlusXMLModifier(String[,] configChanges, String fullPath, String fileName, int index, int statNum)
        {

            String[] elements = new String[]
            {
                "//Register",
                "//Register//EndPoint",
                "//Register//ServerEndPoint",
                "//Register//BackupEndPoint"
            };

            XmlDocument xmlLoader = new XmlDocument();
            xmlLoader.Load(_xmlPaths[index]);
            for (int i = 0; i < elements.Length; i++)
            {
                XmlElement elementLoader = (XmlElement)xmlLoader.SelectSingleNode(elements[i]);
                // STATION 2 PLUS CONFIG GENERATION
                if (i == 0)
                {
                    elementLoader.SetAttribute("LocationUid", configChanges[0,0]); // Set to Location Value.
                    elementLoader.SetAttribute("TerminalNumber", statNum.ToString()); // Set to the value of i.
                }
                else if (i == 1)
                {
                    elementLoader.SetAttribute("Address", configChanges[2,0]); // Set to Server Endpoint Value.
                }
                else if (i == 2)
                {
                    elementLoader.SetAttribute("Address", configChanges[3,0]); // Set to Backup Endpoint Value.
                }
                else if (i == 3)
                {
                    elementLoader.SetAttribute("Address", configChanges[1,0]); // Set to Endpoint Value.
                }
                // END STATION 2 PLUS CONFIG GENERATION

            }
            xmlLoader.Save(fullPath + fileName);
        }
        public static void KitchenXMLModifier(String[,] configChanges, String fullPath, String fileName, int index, String videoNum)
        {
            String[] elements = new String[]
            {
                "//Kitchen",
                "//Kitchen//EndPoint",
                "//Kitchen//BackupEndPoint"
            };

            XmlDocument xmlLoader = new XmlDocument();
            xmlLoader.Load(_xmlPaths[index]);
            for (int i = 0; i < elements.Length; i++)
            {
                XmlElement elementLoader = (XmlElement)xmlLoader.SelectSingleNode(elements[i]);
                // KITCHEN VIDEO CONFIG GENERATION
                if (i == 0)
                {
                    elementLoader.SetAttribute("LocationUid", configChanges[0,0]); // Set to Location Value.
                    elementLoader.SetAttribute("TerminalNumber", videoNum); // Set to the value of i.
                }
                else if (i == 1)
                {
                    elementLoader.SetAttribute("Address", configChanges[2,0]); // Set to Backup Endpoint Value.
                }
                else if (i == 2)
                {
                    elementLoader.SetAttribute("Address", configChanges[1,0]); // Set to Endpoint Value.
                }
                // KITCHEN VIDEO CONFIG GENERATION
                xmlLoader.Save(fullPath + fileName);

            }

        }

    }
}
