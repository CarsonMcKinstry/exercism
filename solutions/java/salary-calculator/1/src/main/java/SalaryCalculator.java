public class SalaryCalculator {

    final double BASE_SALARY = 1000;
    final double MAX_SALARY = 2000;

    public double salaryMultiplier(int daysSkipped) {
        return daysSkipped >= 5 ? 0.85 : 1;
    }

    public int bonusMultiplier(int productsSold) {
        return productsSold >= 20 ? 13 : 10;
    }

    public double bonusForProductsSold(int productsSold) {
        return this.bonusMultiplier(productsSold) * productsSold;
    }

    public double finalSalary(int daysSkipped, int productsSold) {
        double salaryBeforeBonus = BASE_SALARY * salaryMultiplier(daysSkipped);
        double bonus = bonusForProductsSold(productsSold);

        double total = salaryBeforeBonus + bonus;

        if (total > MAX_SALARY) {
            return MAX_SALARY;
        } else {
            return total;
        }
    }
}
