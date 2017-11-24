using System.Collections.Generic;

namespace ParseXml
{
  /// <summary>
  /// 
  /// </summary>
  public class Element
  {
    public string Tag { get; set; }
    public string Value { get; set; }

    public List<Element> ChildElements { get; set; }

    public Element()
    {
      ChildElements = new List<Element>();
    }
  }
}
