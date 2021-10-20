using ArchotekturaLabTwo.Builders;

namespace ArchotekturaLabTwo {
    public class ComputerShop {
        public void ConstructComputer(ComputerBuilder computerBuilder) {
            computerBuilder.BuildScreen();
            computerBuilder.BuildMotherboard();
            computerBuilder.BuildProcessor();
            computerBuilder.BuildDrive();
        }
    }
}