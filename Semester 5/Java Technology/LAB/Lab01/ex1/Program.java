public class Program {
    public static void main(String[] args) {
        if (args.length != 3) {
            System.out.print("Invalid expression");
            return;
        }

        double num1, num2;
        String op = args[1];
        double result;

        try {
            num1 = Double.parseDouble(args[0]);
        }
        catch (Exception e) {
            System.out.print("The num1 argument is not valid");
            return;
        }

        try {
            num2 = Double.parseDouble(args[2]);
        }
        catch (Exception e) {
            System.out.print("The num1 argument is not valid");
            return;
        }

        switch (op) {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "x":
                result = num1 * num2;
                break;
            case "/":
                if (num2 == 0) {
                    System.out.print("The num2 is zero");
                }
                result = num1 / num2;
                break;
            case "^":
                result = luythua(num1, num2);
                break;
            default:
                System.out.print("Unsupported operator");
                return;
        }
        System.out.println(result);;
    }
    public static double luythua(double num1, double num2) {
        double kq = 1;

        for (int i = 0; i < num2; i++) {
            kq *= num1;
        }
        return kq;
    }
}