import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 * Created by siarhey on 24.11.17.
 */
public class Main {

  private static Logger log = Logger.getLogger(Main.class.getName());

  public static void main(String[] args) {
    System.out.println("print path to xml");
    Scanner in = new Scanner(System.in);
    String path = in.nextLine();
    File xmlFile = new File(path);
    XmlParser xmlParser = new XmlParser();
    xmlParser.parseToDom(xmlFile);
  }

}
