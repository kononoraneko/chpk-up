using System.Runtime.CompilerServices;

namespace chpk_up;

class Arithmetic
{
    public int sum(int n1, int n2) { // Сумма первого и второго чисел
        Console.WriteLine($"\nСумма {n1} и {n2} = {n1+n2}");
        return n1+n2;
    }

    public int diff(int n1, int n2) { // Разность первого и второго чисел
        Console.WriteLine($"\nРазность {n1} и {n2} = {n1-n2}");
        return n1-n2;
    }
}


class SimpleInputOutput {

    public SimpleInputOutput(){

    }

    public void start() {
        Arithmetic arith = new Arithmetic();
        while (true){
            int key = readSelectMenu();

            if (key == 0){
                return;
            }
            if (key == 1){
                int[] res = readNums(2);
                arith.sum(res[0], res[1]);
            }
            if (key == 2){
                int[] res = readNums(2);
                arith.diff(res[0], res[1]);
            }
        }
    }

    private int[] readNums(int count){
        int[] res = new int[count];

        for (int i = 0; i < count; i++){
            Console.Write("Введите число: ");
            int parsedInt;
            while (!int.TryParse(Console.ReadLine(), out parsedInt)){
                Console.WriteLine("Ошибка ввода! Попробйте заново!\nВведите число: ");
            }
            res[i] = parsedInt;
        }

        return res;
    }

    int readSelectMenu(){
        Console.WriteLine(
    @"
    Выберите операцию:
    1. Сложение
    2. Вычитание
    0. Выход
    ");
        int key;
        while (!int.TryParse(Console.ReadLine(), out key)){
            Console.WriteLine("Ошибка ввода!");
        }
        return key;
    }

}


class Program
{
    static void Main(string[] args)
    {
        SimpleInputOutput io = new SimpleInputOutput();
        
        io.start();
    }


    


    private int maxInt(int[] nArr){   // Нахождение максимального числа в массиве
        //return nArr.Max();

        if (nArr.Length == 0){
            Console.WriteLine("Ошибк, пустой массив!");
            return 0;
        }


        int lastMax = nArr[0];
        foreach (int n in nArr){
            if (n > lastMax){
                lastMax = n;
            }
        }
        return lastMax;
    }


}
