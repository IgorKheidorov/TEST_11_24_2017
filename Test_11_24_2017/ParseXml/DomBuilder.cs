using System;
using System.Collections.Generic;
using System.Text;

namespace ParseXml
{
  /// <summary>
  /// 
  /// </summary>
  public class DomBuilder
  {
    public string[] File { get; set; }
    private int CurrentLineIndex { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputFile"></param>
    public DomBuilder(string[] inputFile)
    {
      File = inputFile;
      CurrentLineIndex = 0;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Element> BuildDomFromXml()
    {
      List<Element> domOject = new List<Element> {BindElem()};
      return domOject;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private Element BindElem()
    {
      string currentLine = File[CurrentLineIndex];
      Element element = new Element();

      int closeTagIndex = currentLine.IndexOf('>');
      element.Tag = BindTag(currentLine);

      string closingTag = element.Tag.Insert(1, "/");
      if (currentLine.EndsWith(closingTag))
      {
        element.Value = currentLine.Substring(closeTagIndex + 1,
          currentLine.IndexOf(closingTag, StringComparison.Ordinal) - closeTagIndex - 1);
        CurrentLineIndex++;
        return element;
      }
      CurrentLineIndex++;

      while (!BindTag(File[CurrentLineIndex]).Equals(closingTag))
      {
        element.ChildElements.Add(BindElem());
      }
      CurrentLineIndex++;

      return element;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="line"></param>
    /// <returns></returns>
    public string BindTag(string line)
    {
      int openTagIndex = line.IndexOf('<');
      int closeTagIndex = line.IndexOf('>');
      return new StringBuilder("<")
        .Append(line.Substring(openTagIndex + 1, closeTagIndex - openTagIndex - 1))
        .Append('>').ToString();
    }
  }
}
