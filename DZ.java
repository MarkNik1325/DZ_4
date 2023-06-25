import java.util.LinkedList;
import java.util.Scanner;

public class DZ {
    public static void main(String[] args) {

        LinkedList <String> Str = new LinkedList<>();
        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.println("Введите строку (print/revert/exit для выполнения команд):");
            String command = scanner.nextLine();
             if ("exit".equals(command)) {
                break;
             }
             
             if (command.equals("print")) {
                System.out.println("Строки в обратном порядке:");
                while (!Str.isEmpty()) {
                    System.out.println(Str.removeLast());
                }
            } else if (command.equals("revert")) {
                if (!Str.isEmpty()) {
                    Str.removeLast();
                    System.out.println("Последняя введенная строка удалена из памяти.");
                } else {
                    System.out.println("Нет сохраненных строк для удаления.");
                }
            } else {
                Str.addLast(command);

        }
        
    }
   
System.out.println("Программа завершена");

}
}

