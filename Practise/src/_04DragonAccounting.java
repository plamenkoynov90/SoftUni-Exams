import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.*;

public class _04DragonAccounting {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Queue<BigDecimal[]> employees = new LinkedList<>();
        BigDecimal capital = scanner.nextBigDecimal();
        scanner.nextLine();
        BigDecimal dayCounter = BigDecimal.ZERO;
        boolean hadBankrupted = false;
        String[] line;
        while (!(line = scanner.nextLine().split("\\;"))[0].equals("END")) {
            dayCounter =  dayCounter.add(BigDecimal.ONE);
            Long hired = Long.parseLong(line[0]);
            Long fired = Long.parseLong(line[1]);
            BigDecimal salary = new BigDecimal(line[2]);
            BigDecimal[] currentDayEmployees = new BigDecimal[]{new BigDecimal(1), dayCounter, salary, new BigDecimal(hired)};
            employees.add(currentDayEmployees);
            if (dayCounter.compareTo(new BigDecimal(30)) == 0) {
                dayCounter = BigDecimal.ZERO;
                BigDecimal employeeSalary;
                for (BigDecimal[] employee : employees) {
                    if (employee[0].compareTo(new BigDecimal(365)) >= 0) {
                        employee[2] = employee[2].multiply(new BigDecimal(1.006));
                        employee[0] = employee[0].subtract(new BigDecimal(365));
                    }
                    employeeSalary = (employee[2].divide(new BigDecimal(30), 9, RoundingMode.UP).setScale(7, RoundingMode.DOWN));
                    employeeSalary = employeeSalary.multiply(new BigDecimal(31).subtract(employee[1]));
                    employee[0] = employee[0].add(BigDecimal.ONE);
                    employee[1] = BigDecimal.ONE;
                    employeeSalary = employeeSalary.multiply(employee[3]);
                    capital = capital.subtract(employeeSalary);
                }
            } else {
                for (BigDecimal[] employee : employees) {
                    employee[0] = employee[0].add(BigDecimal.ONE);
                }
            }
            for (int i = 0; i < fired; i++) {
                if (employees.peek()[3].equals(BigDecimal.ZERO)) {
                    employees.remove();
                }
                employees.peek()[3] = employees.peek()[3].subtract(BigDecimal.ONE);
                if (employees.peek()[3].equals(BigDecimal.ZERO)) {
                    employees.remove();
                }
            }
            for (int i = 3; i < line.length; i++) {
                String[] dailyActivitiesString = line[i].split(":");
                String additionalEvent = dailyActivitiesString[0];
                BigDecimal additionalEventMoney = new BigDecimal(dailyActivitiesString[1]);
                if (additionalEvent.equals("Product development") || additionalEvent.equals("Unconditional funding")) {
                    capital = capital.add(additionalEventMoney);
                } else {
                    capital = capital.subtract(additionalEventMoney);
                }
            }
            if (capital.compareTo(BigDecimal.ZERO) <= 0) {
                hadBankrupted = true;
                break;
            }
        }
        String result = capital.abs().setScale(4,RoundingMode.DOWN).toPlainString();

        if(hadBankrupted){
            System.out.printf("BANKRUPTCY: %s" , result);
        }else {
            long employeesLeft = 0L;
            for (BigDecimal[] hiredAndSalaries : employees) {
                employeesLeft += hiredAndSalaries[3].longValueExact();
            }
            System.out.printf("%d %s",employeesLeft , result);
        }
    }
}
