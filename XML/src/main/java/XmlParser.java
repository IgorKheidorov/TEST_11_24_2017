import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by siarhey on 24.11.17.
 */
public class XmlParser {
  private static Logger log = Logger.getLogger(Main.class.getName());

  public Dom parseToDom(File xmlFile) {
    Dom dom = new Dom();
    StringBuffer content = getAsString(xmlFile);
    String tag;

    Pattern pattern = Pattern.compile("<[^> ]+>");



    return new Dom();
  }


  private StringBuffer getAsString(File XmlFile) {
    try {

      BufferedReader reader = new BufferedReader(new FileReader(XmlFile))
      StringBuffer stringBuffer = new StringBuffer();
      while (reader.ready()) {
        stringBuffer.append(reader.readLine());
      }
      return stringBuffer;
    } catch (IOException ex) {
      log.log(Level.SEVERE, "IOException: ", ex);
    }
  }
}
