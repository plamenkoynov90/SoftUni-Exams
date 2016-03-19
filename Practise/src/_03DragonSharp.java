import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _03DragonSharp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int linesCount = scanner.nextInt();
        scanner.nextLine();
        String[] allLines = new String[linesCount];
        String condition = "";
        boolean conditionIsTrue = false;
        int firstNumber = 0;
        int secondNumber = 0;
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < linesCount; i++) {
            String line = scanner.nextLine();
            if (!line.contains("\"") | !line.contains(";")) {
                System.out.printf("Compile time error @ line %d", i + 1);
                return;
            }
            if (line.contains("if ")) {
                Pattern conditionPattern = Pattern.compile("(==)|(<)|(>)");
                Matcher conditionMatcher = conditionPattern.matcher(line);
                if (conditionMatcher.find()) {
                    condition = conditionMatcher.group();
                }
                Pattern numbersPattern = Pattern.compile("(?<=\\()(.*)(?=\\))");
                Matcher numbersMatcher = numbersPattern.matcher(line);
                if (numbersMatcher.find()) {
                    String[] allNumbers = numbersMatcher.group().split("\\W+");
                    firstNumber = Integer.parseInt(allNumbers[0]);
                    secondNumber = Integer.parseInt(allNumbers[1]);
                }
            }
            if (condition.equals("==")) {
                conditionIsTrue = firstNumber == secondNumber;
            } else if (condition.equals("<")) {
                conditionIsTrue = firstNumber < secondNumber;
            } else {
                conditionIsTrue = firstNumber > secondNumber;
            }
            int printCount = -1;
            if (line.contains("loop")) {
                Pattern printCountPattern = Pattern.compile("(?<=\\s)(\\d+)(?=\\s)");
                Matcher printCountMatcher = printCountPattern.matcher(line);
                if (printCountMatcher.find()) {
                    printCount = Integer.parseInt(printCountMatcher.group());
                }
            }
            Pattern printTextPattern = Pattern.compile("(?<=\")(.*)(?=\")");
            Matcher printTextMatcher = printTextPattern.matcher(line);
            String printText = "";
            if (printTextMatcher.find()) {
                printText = printTextMatcher.group();
            }
            if(conditionIsTrue && line.contains("if ")){
                if(line.contains("loop")){
                    for (int j = 0; j < printCount ; j++) {
                        output.append(printText).append(System.lineSeparator());
                    }
                }else{
                    output.append(printText).append(System.lineSeparator());
                }
            }else if(!conditionIsTrue && line.contains("else")){
                if(line.contains("loop")){
                    for (int j = 0; j < printCount ; j++) {
                        output.append(printText).append(System.lineSeparator());
                    }
                }else{
                    output.append(printText).append(System.lineSeparator());
                }
            }
        }
        System.out.println(output);
    }
}
