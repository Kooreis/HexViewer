```java
import java.io.FileInputStream;
import java.io.IOException;

public class HexViewer {
    public static void main(String[] args) {
        if (args.length < 1) {
            System.out.println("Usage: java HexViewer <file>");
            return;
        }

        try (FileInputStream fis = new FileInputStream(args[0])) {
            int value;
            int count = 0;
            while ((value = fis.read()) != -1) {
                System.out.printf("%02X ", value);
                if (++count % 16 == 0) {
                    System.out.println();
                }
            }
        } catch (IOException e) {
            System.out.println("Error reading file: " + e.getMessage());
        }
    }
}
```