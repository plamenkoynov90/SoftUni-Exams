import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

public class _02LogParser {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String command = scanner.nextLine();
        Map<String, HashMap<String, List<String>>> allData = new HashMap<>();
        while (!command.equals("END")) {
            Pattern pattern = Pattern.compile("(?<=\\[\\\")(.*?)(?=\\\"\\])");
            Matcher matcher = pattern.matcher(command);
            String projectName = "";
            String errorType = "";
            String errorMessage = "";
            if (matcher.find()) {
                projectName = matcher.group();
            }
            if (matcher.find()) {
                errorType = matcher.group();
            }
            if (matcher.find()) {
                errorMessage = matcher.group();
            }
            HashMap<String, List<String>> map;
            List<String> list;
            if (!allData.containsKey(projectName)) {
                map = new HashMap<>();
                map.put("Critical", new ArrayList<>());
                map.put("Warning", new ArrayList<>());
                allData.put(projectName, map);
            } else {
                map = allData.get(projectName);
            }
            list = map.get(errorType);
            list.add(errorMessage);
            command = scanner.nextLine();
        }

        List<Map.Entry<String, HashMap<String, List<String>>>> sorted = allData.entrySet().stream().collect(Collectors.toList());
        sorted.sort((o1, o2) -> {
            int totalO1 = o1.getValue().get("Critical").size()
                    + o1.getValue().get("Warning").size();
            int totalO2 = o2.getValue().get("Critical").size()
                    + o2.getValue().get("Warning").size();
            int cmp = Integer.compare(totalO2, totalO1);
            if (cmp == 0) {
                cmp = o1.getKey().compareTo(o2.getKey());
            }
            return cmp;
        });
        Comparator<String> listSorter = (o1, o2) -> {
            int lengthO1 = o1.length();
            int lengthO2 = o2.length();
            int cmp = Integer.compare(lengthO1, lengthO2);
            if (cmp == 0) {
                cmp = o1.compareTo(o2);
            }
            return cmp;
        };
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < sorted.size(); i++) {
            Map.Entry<String, HashMap<String, List<String>>> entry = sorted.get(i);
            List<String> criticalList = entry.getValue().get("Critical");
            List<String> warningList = entry.getValue().get("Warning");
            int criticalCount = entry.getValue().get("Critical").size();
            int warningCount = entry.getValue().get("Warning").size();
            criticalList.sort(listSorter);
            warningList.sort(listSorter);
            sb.append(String.format("%s:\n", entry.getKey()));
            sb.append(String.format("Total Errors: %d\n", criticalCount + warningCount));
            sb.append(String.format("Critical: %d\n", criticalCount));
            sb.append(String.format("Warnings: %d\n", warningCount));
            sb.append("Critical Messages:\n");
            if (criticalCount == 0) {
                sb.append("--->None\n");
            } else {
                for (int b = 0; b < criticalCount; b++) {
                    sb.append(String.format("--->%s\n", criticalList.get(b)));
                }
            }
            sb.append("Warning Messages:\n");
            if (warningCount == 0) {
                sb.append("--->None\n");
            } else {
                for (int b = 0; b < warningCount; b++) {
                    sb.append(String.format("--->%s\n", warningList.get(b)));
                }
            }
            if (i != sorted.size() - 1) {
                sb.append("\n");
            }
        }
        System.out.println(sb.toString());
    }
}