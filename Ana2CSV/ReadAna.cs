using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Ana2CSV
{
    public class ReadAna
    {
        string foldername;
        string projectname;
        string line;
        string header = "\tSegments\tWords\tCharacters\tPlaceables\tTags\tRepairWords\tFullRecallWords\tPartialRecallWords\tEdits\tAdaptiveWords\tBaselineWords";

        public void ReadAndCreate2( string path)
        {
            XmlTextReader reader = new XmlTextReader(path);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "project")
                        {

                            while (reader.MoveToNextAttribute())
                            {
                                switch (reader.Name)
                                {
                                    case "name":
                                        projectname = reader.Value;
                                        SaveCSV("Project:\t" + projectname, path, projectname);
                                        break;
                                }

                            }
                        }
                        if (reader.Name == "settings")
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                switch (reader.Name)
                                {
                                    case "reportInternalFuzzyLeverage":
                                        SaveCSV("reportInternalFuzzyLeverage:\t" + reader.Value, path, projectname);
                                        break;
                                    case "reportLockedSegmentsSeparately":
                                        SaveCSV("reportInternalFuzzyLeverage:\t" + reader.Value, path, projectname);
                                        break;
                                    case "reportCrossFileRepetitions":
                                        SaveCSV("reportCrossFileRepetitions:\t" + reader.Value, path, projectname);
                                        break;
                                    case "minimumMatchScore":
                                        SaveCSV("minimumMatchScore:\t" + reader.Value, path, projectname);
                                        break;
                                    case "searchMode":
                                        SaveCSV("searchMode:\t" + reader.Value, path, projectname);
                                        break;
                                    case "missingFormattingPenalty":
                                        SaveCSV("missingFormattingPenalty:\t" + reader.Value, path, projectname);
                                        break;
                                    case "differentFormattingPenalty":
                                        SaveCSV("differentFormattingPenalty:\t" + reader.Value, path, projectname);
                                        break;
                                    case "multipleTranslationsPenalty":
                                        SaveCSV("multipleTranslationsPenalty:\t" + reader.Value, path, projectname);
                                        break;
                                    case "autoLocalizationPenalty":
                                        SaveCSV("autoLocalizationPenalty:\t" + reader.Value, path, projectname);
                                        break;
                                    case "textReplacementPenalty":
                                        SaveCSV("textReplacementPenalty:\t" + reader.Value, path, projectname);
                                        break;
                                    case "enableFuzzyMatchRepair":
                                        SaveCSV("enableFuzzyMatchRepair:\t" + reader.Value, path, projectname);
                                        break;
                                    case "enableMtFuzzyMatchRepair":
                                        SaveCSV("enableMtFuzzyMatchRepair:\t" + reader.Value, path, projectname);
                                        break;
                                    case "fullRecallMatchedWords":
                                        SaveCSV("fullRecallMatchedWords:\t" + reader.Value, path, projectname);
                                        break;
                                    case "partialRecallMatchedWords":
                                        SaveCSV("partialRecallMatchedWords:\t" + reader.Value, path, projectname);
                                        break;
                                    case "partialRecallSignificantWords":
                                        SaveCSV("partialRecallSignificantWords:\t" + reader.Value, path, projectname);
                                        SaveCSV("\n", path, projectname);
                                        break;
                                }

                            }
                        }
                        if (reader.Name == "file")
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                switch (reader.Name)
                                {
                                    case "name":
                                        SaveCSV("\n", path, projectname);
                                        SaveCSV("Filename:\t" + reader.Value, path, projectname);
                                        SaveCSV(header, path, projectname);

                                        break;
                                }

                            }
                            
                        }
                        if (reader.Name == "batchTotal")
                        {
                            SaveCSV("\n", path, projectname);
                            SaveCSV("=========Total:============", path, projectname);
                            SaveCSV(header, path, projectname);
                        }
                        if (reader.Name == "perfect")
                        {
                            line = "Perfect Match:\t";
                            while (reader.MoveToNextAttribute())
                            {
                                line += reader.Value+ "\t";
                            }
                            SaveCSV(line, path, projectname);
                        }
                        if (reader.Name == "inContextExact")
                        {
                            line = "Context Match:\t";
                            while (reader.MoveToNextAttribute())
                            {
                                line += reader.Value + "\t";
                            }
                            SaveCSV(line, path, projectname);
                        }
                        if (reader.Name == "exact")
                        {
                            line = "100%:\t";
                            while (reader.MoveToNextAttribute())
                            {
                                line += reader.Value + "\t";
                            }
                            SaveCSV(line, path, projectname);
                        }
                        if (reader.Name == "locked")
                        {
                            line = "Locked:\t";
                            while (reader.MoveToNextAttribute())
                            {
                                line += reader.Value + "\t";
                            }
                            SaveCSV(line, path, projectname);
                        }
                        if (reader.Name == "crossFileRepeated")
                        {
                            line = "Cross-file repetitions:\t";
                            while (reader.MoveToNextAttribute())
                            {
                                line += reader.Value + "\t";
                            }
                            SaveCSV(line, path, projectname);
                        }
                        if (reader.Name == "repeated")
                        {
                            line = "Repetitions:\t";
                            while (reader.MoveToNextAttribute())
                            {
                                line += reader.Value + "\t";
                            }
                            SaveCSV(line, path, projectname);
                        }
                        if (reader.Name == "total")
                        {
                            line = "Total:\t";
                            while (reader.MoveToNextAttribute())
                            {
                                line += reader.Value + "\t";
                            }
                            SaveCSV(line, path, projectname);
                        }
                        if (reader.Name == "new")
                        {
                            line = "New:\t";
                            while (reader.MoveToNextAttribute())
                            {
                                line += reader.Value + "\t";
                            }
                            SaveCSV(line, path, projectname);
                        }
                        if (reader.Name == "fuzzy")
                        {
                            line = "Fuzzy ";
                            while (reader.MoveToNextAttribute())
                            {
                                switch (reader.Name)
                                {
                                    case "min":
                                        line += reader.Value + "-";
                                        break;
                                    case "max":
                                        line += reader.Value + "\t";
                                        break;
                                    default:
                                        line += reader.Value + "\t";
                                        break;
                                }
                                
                            }
                            SaveCSV(line, path, projectname);
                        }
                        break;

                        
                }//switch
            }//while (reader.Read()) 
            MessageBox.Show(foldername + "\\" + projectname + ".csv");
        }

        
        private void SaveCSV(string text, string path, string projectname)
        {
            this.foldername = Path.GetDirectoryName(path);
            using (System.IO.StreamWriter logfile = new System.IO.StreamWriter(foldername+ "\\"+projectname+".csv", true))
                {
                
                    logfile.WriteLine(text);
                }

        }


    }
}
