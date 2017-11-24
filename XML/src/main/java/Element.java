import java.util.ArrayList;

/**
 * Created by siarhey on 24.11.17.
 */
public class Element {
  String tag;
  ArrayList<Element> children = new ArrayList<>();

  Element(String tag) {
    this.tag = tag;
  }

  public void addChildren(Element child) {
    this.children.add(child);
  }
}
