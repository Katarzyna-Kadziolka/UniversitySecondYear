using ArchotekturaLabTwo;
using ArchotekturaLabTwo.Builders;

public class Program {
    static void Main(string[] args) {
        ComputerShop computerShop = new ComputerShop();

        ComputerBuilder computerBuilder = new OfficeComputerBuilder();
        computerShop.ConstructComputer(computerBuilder);

        computerBuilder.Computer.DisplayConfiguration();
    }
}