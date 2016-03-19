import java.util.*;

public class _01ArrangeIntegers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split("\\D+");
        String[] allNumbersWords = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        List<String> inputNumbers = new ArrayList<>();
        for (int i = 0; i < input.length; i++) {
            String[] currentNumber = new String[input[i].length()];
            for (int j = 0; j < input[i].length(); j++) {
                currentNumber[j] = allNumbersWords[Character.getNumericValue(input[i].charAt(j))];
            }
            inputNumbers.add(String.join("-", currentNumber));
        }
        Collections.sort(inputNumbers);
        List<String> finalNumbers = new ArrayList<>();
        for (String number : inputNumbers) {
            String[] currentNumberInWords = number.split("-");
            String currentNumber = "";
            for (String digit : currentNumberInWords) {
                currentNumber += Arrays.asList(allNumbersWords).indexOf(digit);
            }
            finalNumbers.add(currentNumber);
        }
        System.out.println(String.join(", ", finalNumbers));
    }
}

