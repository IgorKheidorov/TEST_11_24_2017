using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ParseXml
{
  /// <summary>
  /// 
  /// </summary>
  public class EntryPoint
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      using (StreamReader file = new StreamReader(@"c:/testXml.xml", Encoding.Default))
      {
        string line;
        List<String> inputLines = new List<string>();
        while ((line = file.ReadLine()) != null)
        {
          inputLines.Add(line);
        }
        List<Element> domObject = new DomBuilder(inputLines.ToArray()).BuildDomFromXml();
      }
    }
  }
}
