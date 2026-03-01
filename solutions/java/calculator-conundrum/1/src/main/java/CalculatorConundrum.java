import java.util.Objects;

class CalculatorConundrum {
    public String calculate(int operand1, int operand2, String operation) {
        validateOperation(operation);

        return switch (operation) {
            case "+" -> add(operand1, operand2);
            case "*" -> multiply(operand1, operand2);
            case "/" -> divide(operand1, operand2);
            default -> throw new IllegalOperationException(String.format("Operation '%s' does not exist", operation));
        };
    }

    private String add(int a, int b) {
        int result = a + b;

        return buildResult(
                a, b, "+", result);
    }

    private String multiply(int a, int b) {
        int result = a * b;

        return buildResult(
                a, b, "*", result);
    }

    private String divide(int a, int b) {

        if (b == 0) {
            throw new IllegalOperationException("Division by zero is not allowed", new ArithmeticException());
        }

        int result = a / b;

        return buildResult(
                a, b, "/", result);
    }

    private void validateOperation(String operation) {
        if (Objects.isNull(operation)) {
            throw new IllegalArgumentException("Operation cannot be null");
        } else if (operation.isEmpty()) {
            throw new IllegalArgumentException("Operation cannot be empty");
        }
    }

    private String buildResult(int operand1, int operand2, String operation, int result) {
        return String.format(
                "%d %s %d = %d",
                operand1,
                operation,
                operand2,
                result);
    }
}
